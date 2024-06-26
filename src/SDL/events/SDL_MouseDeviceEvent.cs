﻿using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Mouse device event structure (<see cref="SDL_Event.MouseDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MouseDeviceEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseDeviceEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.MouseAdded"/> or <see cref="SDL_EventType.MouseRemoved"/>.
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