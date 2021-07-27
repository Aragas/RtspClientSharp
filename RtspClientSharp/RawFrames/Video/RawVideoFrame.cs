using System;

namespace RtspClientSharp.RawFrames.Video
{
    public abstract class RawVideoFrame : RawFrame
    {
        public override FrameType Type => FrameType.Video;

        protected RawVideoFrame(DateTime timestamp, ArraySegment<byte> frameSegment)
            : base(timestamp, frameSegment)
        {
        }
    }

    public class RawMetadataFrame : RawFrame
    {
        public override FrameType Type => FrameType.Metadata;

        public RawMetadataFrame(DateTime timestamp, ArraySegment<byte> frameSegment)
            : base(timestamp, frameSegment)
        {
        }
    }
}