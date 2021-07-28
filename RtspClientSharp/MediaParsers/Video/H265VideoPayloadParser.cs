using System;
using System.IO;
using RtspClientSharp.Codecs.Video;

namespace RtspClientSharp.MediaParsers
{
    class H265VideoPayloadParser : MediaPayloadParser
    {
        private readonly H265Parser _h265Parser;
        private readonly MemoryStream _nalStream;

        public H265VideoPayloadParser(H265CodecInfo codecInfo)
        {
            if (codecInfo == null)
                throw new ArgumentNullException(nameof(codecInfo));
            if (codecInfo.SpsBytes == null)
                throw new ArgumentException($"{nameof(codecInfo.SpsBytes)} is null", nameof(codecInfo));
            if (codecInfo.PpsBytes == null)
                throw new ArgumentException($"{nameof(codecInfo.PpsBytes)} is null", nameof(codecInfo));
            if (codecInfo.VpsBytes == null)
                throw new ArgumentException($"{nameof(codecInfo.VpsBytes)} is null", nameof(codecInfo));
        }

        public override void Parse(TimeSpan timeOffset, ArraySegment<byte> byteSegment, bool markerBit)
        {
            throw new NotImplementedException();
        }

        public override void ResetState()
        {
            throw new NotImplementedException();
        }
    }
}