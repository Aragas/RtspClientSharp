using System;

namespace RtspClientSharp.RawFrames.Metadata
{
    public class RawMetadataFrame : RawFrame
    {
        public override FrameType Type => FrameType.Metadata;

        public RawMetadataFrame(DateTime timestamp, ArraySegment<byte> frameSegment) : base(timestamp, frameSegment) { }
    }
}