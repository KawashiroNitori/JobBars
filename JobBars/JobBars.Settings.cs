﻿using Dalamud.Interface;
using Dalamud.Plugin;
using ImGuiNET;
using System.Numerics;

namespace JobBars {
    public unsafe partial class JobBars {
        public bool Visible = false;

        private void BuildSettingsUI() {
            if (!PlayerExists || !Initialized) return;
            if (!Visible) return;

            string _ID = "##JobBars_Settings";
            ImGui.SetNextWindowSize(new Vector2(500, 800), ImGuiCond.FirstUseEver);
            if (ImGui.Begin("JobBars Settings", ref Visible)) {
                ImGui.BeginTabBar("Tabs" + _ID);
                if (ImGui.BeginTabItem("Gauges" + _ID)) {
                    GManager?.Draw();
                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Buffs" + _ID)) {
                    BManager?.Draw();
                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Cooldowns" + _ID)) {
                    CDManager?.Draw();
                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Utilities" + _ID)) {
                    UtilManager?.Draw();
                    ImGui.EndTabItem();
                }

                ImGui.EndTabBar();
            }
            ImGui.End();

            GManager?.DrawPositionBox();
            BManager?.DrawPositionBox();
        }

        public static void SetWindowPosition(string Id, Vector2 position) {
            var minPosition = ImGuiHelpers.MainViewport.Pos;
            ImGui.SetWindowPos(Id, position + minPosition);
        }

        public static bool DrawPositionView(string Id, Vector2 position, out Vector2 newPosition) {
            ImGuiHelpers.ForceNextWindowMainViewport();
            var minPosition = ImGuiHelpers.MainViewport.Pos;
            ImGui.SetNextWindowPos(position + minPosition, ImGuiCond.FirstUseEver);
            ImGui.SetNextWindowSize(new Vector2(200, 200));
            ImGui.PushStyleVar(ImGuiStyleVar.Alpha, 0.7f);
            ImGui.Begin(Id, ImGuiWindowFlags.NoNav | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoDocking | ImGuiWindowFlags.NoResize);
            newPosition = ImGui.GetWindowPos() - minPosition;
            ImGui.PopStyleVar(1);
            ImGui.End();
            return newPosition != position;
        }

        public static void Separator() {
            ImGui.SetCursorPosY(ImGui.GetCursorPosY() + 2);
            ImGui.Separator();
            ImGui.SetCursorPosY(ImGui.GetCursorPosY() + 2);
        }
    }
}
