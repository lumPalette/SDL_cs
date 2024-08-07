﻿namespace SDL3;

/// <summary>
/// Possible connection states for a joystick device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickConnectionState">documentation</see> for more details.
/// </remarks>
public enum SDL_JoystickConnectionState
{
	Invalid = -1,
	Unknown,
	Wired,
	Wireless
}