using System;
using System.Collections.Generic;
using RtspClientSharp.RawFrames.Video;

namespace RtspClientSharp.MediaParsers
{
    class OnvifMetadataPayloadParser : MediaPayloadParser
    {
        RawMetadataFrame frame;
        List<byte[]> data = new List<byte[]>();
        public OnvifMetadataPayloadParser()
        {

        }

        public override void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            if (frame == null) {
                frame = new RawMetadataFrame(GetFrameTimestamp(timeOffset), byteSegment);
            }
            if (markerBit && data.Count == 0) {
                OnFrameGenerated(frame);
                frame = null;
                return;
            }
            var a = new byte[byteSegment.Count];
            Array.Copy(byteSegment.Array, byteSegment.Offset, a, 0, byteSegment.Count);
            data.Add(a);

            if (markerBit) {
                int len = 0;
                foreach (var d in data) len += d.Length;
                a = new byte[len];
                len = 0;
                foreach (var d in data) {
                    Array.Copy(d, 0, a, len, d.Length);
                    len += d.Length;
                }
                OnFrameGenerated(new RawMetadataFrame(frame.Timestamp, new ArraySegment<byte>(a)));
                frame = null;
                data.Clear();
            }
        }

        public override void ResetState()
        {
            frame = null;
        }

    }
}