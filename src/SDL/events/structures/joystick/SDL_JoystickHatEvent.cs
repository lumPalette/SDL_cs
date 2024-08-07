﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyHatEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickHatEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickHatMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick hat index.
	/// </summary>
	public byte Hat;

	/// <summary>
	/// The hat position value.
	/// </summary>
	public SDL_JoystickHatPosition Value;

	private readonly byte _padding1;

	private readonly byte _padding2;
}