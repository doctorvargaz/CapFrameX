﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapFrameX.Contracts.Overlay
{
    public interface IOverlayEntryCore
    {
        Dictionary<string, IOverlayEntry> OverlayEntryDict { get; }

        TaskCompletionSource<bool> OverlayEntryCoreCompletionSource { get; }
    }
}
