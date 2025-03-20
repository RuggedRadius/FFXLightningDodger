using FFXLightningDodger.Models;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXLightningDodger
{
    public static class Extensions
    {
        public static Xbox360Button ToButton(this InputSignal signal)
        {
            switch (signal)
            {
                case InputSignal.A: return Xbox360Button.A;
                case InputSignal.B: return Xbox360Button.B;
                case InputSignal.X: return Xbox360Button.X;
                case InputSignal.Y: return Xbox360Button.Y;
                case InputSignal.LB: return Xbox360Button.LeftShoulder;
                case InputSignal.RB: return Xbox360Button.RightShoulder;
                case InputSignal.Select: return Xbox360Button.Guide;
                case InputSignal.Start: return Xbox360Button.Start;
                case InputSignal.DUp: return Xbox360Button.Up;
                case InputSignal.DDown: return Xbox360Button.Down;
                case InputSignal.DLeft: return Xbox360Button.Left;
                case InputSignal.DRight: return Xbox360Button.Right;
                default: return null;
            }
        }
    }
}
