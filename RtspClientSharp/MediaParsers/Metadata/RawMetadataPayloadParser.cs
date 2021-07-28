using RtspClientSharp.RawFrames.Metadata;
using System;

namespace RtspClientSharp.MediaParsers
{
    class RawMetadataPayloadParser : MediaPayloadParser
    {
        public override void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            var frame = new RawMetadataFrame(DateTime.UtcNow, byteSegment);
            FrameGenerated?.Invoke(frame);
        }

        public override void ResetState()
        {
            //Console.WriteLine("------------- OnvifMetaDataPayloadParser: RESET -------------");
        }
    }
}