﻿using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Mouse device event structure (<see cref="SDL_Event.MouseDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.MouseAdded"/> or <see cref="SDL_EventType.MouseRemoved"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The mouse instance ID.
	/// </summary>
	public SDL_MouseId Which;
}