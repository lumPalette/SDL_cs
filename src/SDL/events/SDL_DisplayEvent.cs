﻿using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Display state change event data (<see cref="SDL_Event.Display"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_DisplayEvent
{
	/// <summary>
	/// An <see cref="SDL_EventType"/> that has <c>Display</c> as prefix.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated display.
	/// </summary>
	public SDL_DisplayId DisplayId;

	/// <summary>
	/// Event dependent data.
	/// </summary>
	public int Data1;
}