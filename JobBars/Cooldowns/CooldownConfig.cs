﻿using ImGuiNET;
using JobBars.Data;
using System.Numerics;

namespace JobBars.Cooldowns {
    public struct CooldownProps {
        public ActionIds Icon;
        public Item[] Triggers;
        public float Duration;
        public float CD;
    }

    public class CooldownConfig {
        public readonly string Name;
        public readonly ActionIds Icon;
        public readonly Item[] Triggers;
        public readonly float Duration;
        public readonly float CD;

        public bool Enabled { get; private set; }
        public int Order { get; private set; }
        public bool ShowBorderWhenActive { get; private set; }
        public bool ShowBorderWhenOffCD { get; private set; }

        public CooldownConfig(string name, CooldownProps props) {
            Name = name;
            Icon = props.Icon;
            Triggers = props.Triggers;
            Duration = props.Duration;
            CD = props.CD;
            Enabled = JobBars.Config.CooldownEnabled.Get(Name);
            Order = JobBars.Config.CooldownOrder.Get(Name);
            ShowBorderWhenActive = JobBars.Config.CooldownShowBorderWhenActive.Get(Name);
            ShowBorderWhenOffCD = JobBars.Config.CooldownShowBorderWhenOffCD.Get(Name);
        }

        public void Draw(string _id, ref bool reset) {
            ImGui.TextColored(Enabled ? new Vector4(0, 1, 0, 1) : new Vector4(1, 0, 0, 1), $"{Name}");

            if (JobBars.Config.CooldownEnabled.Draw($"Enabled{_id}{Name}", Name, Enabled, out var newEnabled)) {
                Enabled = newEnabled;
                reset = true;
            }

            if (JobBars.Config.CooldownOrder.Draw($"Order{_id}{Name}", Name, Order, out var newOrder)) {
                Order = newOrder;
                reset = true;
            }

            if (JobBars.Config.CooldownShowBorderWhenActive.Draw($"Show border when active{_id}{Name}", Name, ShowBorderWhenActive, out var newShowBorderWhenActive)) {
                ShowBorderWhenActive = newShowBorderWhenActive;
            }

            if (JobBars.Config.CooldownShowBorderWhenOffCD.Draw($"Show border when off CD{_id}{Name}", Name, ShowBorderWhenOffCD, out var newShowBorderWhenOffCD)) {
                ShowBorderWhenOffCD = newShowBorderWhenOffCD;
            }

            ImGui.SetCursorPosY(ImGui.GetCursorPosY() + 5);
        }
    }
}
