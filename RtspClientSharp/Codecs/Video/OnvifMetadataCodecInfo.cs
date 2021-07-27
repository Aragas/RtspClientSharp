using System;

namespace RtspClientSharp.Codecs.Video
{
    class OnvifMetadataCodecInfo : VideoCodecInfo
    {
        public byte[] SpsPpsBytes { get; set; } = Array.Empty<byte>();
    }
}