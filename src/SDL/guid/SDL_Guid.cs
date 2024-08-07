﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// A 128-bit identifier for an input device that identifies that device across runs of SDL programs on the same platform.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUID">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Guid
{
	public fixed byte Data[16];
}