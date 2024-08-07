﻿namespace SDL3;

/// <summary>
/// Window flash operation.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlashOperation">documentation</see> for more details.
/// </remarks>
public enum SDL_FlashOperation
{
	/// <summary>
	/// Cancel any window flash state.
	/// </summary>
	Cancel,

	/// <summary>
	/// Flash the window briefly to get attention
	/// </summary>
	Briefly,

	/// <summary>
	/// Flash the window until it gets focus
	/// </summary>
	UntilFocused
}