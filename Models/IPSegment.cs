using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXLightningDodger.Models
{
    public class IPSegment
    {
        public required string SegmentName { get; set; }

        public int PreDelay { get; set; }
        public int PressDuration { get; set; }
        public int PostDelay { get; set; }

        public required InputSignal InputSignal { get; set; }

        public Color DetectionColour { get; set; }
        public int ColourTolerance { get; set; }

        public required string MonitorName { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int SampleSize { get; set; }
    }
}
