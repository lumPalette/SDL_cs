﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The structure that defines a point (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FPoint">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate.</param>
/// <param name="y">The y coordinate.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FPoint(float x, float y)
{
	/// <summary>
	/// The x coordinate of this point.
	/// </summary>
	public float X = x;

	/// <summary>
	/// The y coordinate of this point.
	/// </summary>
	public float Y = y;
}