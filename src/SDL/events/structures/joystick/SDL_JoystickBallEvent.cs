﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Joystick trackball motion event structure (<see cref="SDL_Event.JoystickBall"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyBallEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickBallEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickBallMotion"/>.
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
	/// The joystick trackball index.
	/// </summary>
	public byte Ball;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;

	/// <summary>
	/// The relative motion in the X direction.
	/// </summary>
	public int XRel;

	/// <summary>
	/// The relative motion in the Y direction.
	/// </summary>
	public int YRel;
}