﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// A structure that represents a color as RGBA floating-point components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FColor">documentation</see> for more details.
/// </remarks>
/// <param name="r">The red component.</param>
/// <param name="g">The green component.</param>
/// <param name="b">The blue component.</param>
/// <param name="a">The alpha component.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FColor(float r, float g, float b, float a)
{
	/// <summary>
	/// The red component, as a floating-point number.
	/// </summary>
	public float R = r;

	/// <summary>
	/// The green component, as a floating-point number.
	/// </summary>
	public float G = g;

	/// <summary>
	/// The blue component, as a floating-point number.
	/// </summary>
	public float B = b;

	/// <summary>
	/// The alpha component, as a floating-point number.
	/// </summary>
	public float A = a;
}