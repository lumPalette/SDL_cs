﻿using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A user-defined event type (<see cref="SDL_Event.User"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UserEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_UserEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.User"/> through <see cref="SDL_EventType.Last"/> - 1.
	/// </summary>
	/// <remarks>
	/// This is a <see cref="uint"/> because these are not in the <see cref="SDL_EventType"/> enumeration.
	/// </remarks>
	public uint Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated window, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// User defined event code.
	/// </summary>
	public int Code;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public void* Data1;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public void* Data2;
}