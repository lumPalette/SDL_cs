﻿namespace SDL3;

/// <summary>
/// Array component order, low byte -> high byte.
/// </summary>
public enum SDL_ArrayOrder
{
	None,
	RGB,
	RGBA,
	ARGB,
	BGR,
	BGRA,
	ABGR
}