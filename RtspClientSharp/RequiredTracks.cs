﻿using System;

namespace RtspClientSharp
{
    [Flags]
    public enum RequiredTracks
    {
        Video = 1,
        Audio = 2,
        Metadata = 4,
        All = Video | Audio
    }
}