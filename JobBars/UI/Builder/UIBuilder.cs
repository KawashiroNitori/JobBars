﻿using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Component.GUI;
using JobBars.Helper;

namespace JobBars.UI {
    public unsafe partial class UIBuilder {
        private static readonly uint NODE_IDX_START = 89990001;
        private static uint NodeIdx = NODE_IDX_START;

        public UIBuilder() {
            NodeIdx = NODE_IDX_START;
            InitGauges();
            InitBuffs();
            InitCooldowns();
            InitCursor();

            UIHelper.Link(GaugeRoot, BuffRoot);
            UIHelper.Link(BuffRoot, CursorRoot);
        }

        public void Dispose() {
            UIHelper.Detach(GaugeRoot);
            UIHelper.Detach(CooldownRoot);

            DisposeCooldowns();
            DisposeGauges();
            DisposeBuffs();
            DisposeCursor();

            var attachAddon = UIHelper.BuffGaugeAttachAddon;
            if (attachAddon != null) attachAddon->UldManager.UpdateDrawNodeList();

            var cooldownAddon = UIHelper.CooldownAttachAddon;
            if (cooldownAddon != null) cooldownAddon->UldManager.UpdateDrawNodeList();

            var partyListAddon = UIHelper.PartyListAddon;
            if (partyListAddon != null) partyListAddon->AtkUnitBase.UldManager.UpdateDrawNodeList();
        }

        public void Attach() {
            var buffGaugeAddon = UIHelper.BuffGaugeAttachAddon;
            var cooldownAddon = UIHelper.CooldownAttachAddon;
            var partyListAddon = UIHelper.PartyListAddon;

            PluginLog.Log($"Gauges={buffGaugeAddon != null} PartyList={partyListAddon != null} Cooldowns={cooldownAddon != null}");

            // ===== CONTAINERS =========

            GaugeRoot->ParentNode = buffGaugeAddon->RootNode;
            BuffRoot->ParentNode = buffGaugeAddon->RootNode;
            CursorRoot->ParentNode = buffGaugeAddon->RootNode;

            UIHelper.Attach(buffGaugeAddon, GaugeRoot);

            PluginLog.Log("Attached Gauges");

            // ===== BUFF PARTYLIST ======

            for(var i = 0; i < PartyListBuffs.Count; i++) {
                var partyMember = partyListAddon->PartyMember[i];
                PartyListBuffs[i].AttachTo(partyMember.TargetGlowContainer, partyMember.IconBottomLeftText);
                partyMember.PartyMemberComponent->UldManager.UpdateDrawNodeList();
            }

            PluginLog.Log("Attached PartyList");

            // ===== COOLDOWNS =========

            CooldownRoot->ParentNode = cooldownAddon->RootNode;

            UIHelper.Attach(cooldownAddon, CooldownRoot);

            PluginLog.Log("Attached Cooldowns");

            // ======================

            buffGaugeAddon->UldManager.UpdateDrawNodeList();

            PluginLog.Log("Updated Gauges");

            cooldownAddon->UldManager.UpdateDrawNodeList();

            PluginLog.Log("Updated PartyList");

            partyListAddon->AtkUnitBase.UldManager.UpdateDrawNodeList();

            PluginLog.Log("Updated Cooldowns");
        }

        public void Tick(float percent) {
            Arrows.ForEach(x => x.Tick(percent));
            Diamonds.ForEach(x => x.Tick(percent));
        }

        // ==== HELPER FUNCTIONS ============

        private void SetPosition(AtkResNode* node, float X, float Y) {
            var addon = UIHelper.BuffGaugeAttachAddon;
            if (addon == null) return;
            var p = UIHelper.GetNodePosition(addon->RootNode);
            var pScale = UIHelper.GetNodeScale(addon->RootNode);
            UIHelper.SetPosition(node, (X - p.X) / pScale.X, (Y - p.Y) / pScale.Y);
        }

        private void SetScale(AtkResNode* node, float X, float Y) {
            var addon = UIHelper.BuffGaugeAttachAddon;
            if (addon == null) return;
            var p = UIHelper.GetNodeScale(addon->RootNode);
            UIHelper.SetScale(node, X / p.X, Y / p.Y);
        }
    }
}
