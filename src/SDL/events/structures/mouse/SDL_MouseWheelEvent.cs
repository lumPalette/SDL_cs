﻿using System.Runtime.InteropServices;

namespace SDL3
{
	/// <summary>
	/// Mouse wheel event structure (<see cref="SDL_Event.MouseWheel"/>).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseWheelEvent">documentation</see> for more details.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_MouseWheelEvent
	{
		/// <summary>
		/// Set to <see cref="SDL_EventType.MouseWheel"/>.
		/// </summary>
		public SDL_EventType Type;

		private readonly uint _reserved;

		/// <summary>
		/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The window with mouse focus, if any.
		/// </summary>
		public SDL_WindowId WindowId;

		/// <summary>
		/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>, or <see cref="FIXME:SDL_PEN_MOUSEID"/>.
		/// </summary>
		public SDL_MouseId Which;

		/// <summary>
		/// The amount scrolled horizontally, positive to the right and negative to the left.
		/// </summary>
		public float X;

		/// <summary>
		/// The amount scrolled vertically, positive away from the user and negative toward the user.
		/// </summary>
		public float Y;

		/// <summary>
		/// Set to one of the <see cref="SDL_MouseWheelDirection"/> values.
		/// </summary>
		/// <remarks>
		/// When <see cref="SDL_MouseWheelDirection.Flipped"/> the values in X and Y will be opposite. Multiply by -1 to change
		/// them back.
		/// </remarks>
		public SDL_MouseWheelDirection Direction;

		/// <summary>
		/// X coordinate, relative to window.
		/// </summary>
		public float MouseX;

		/// <summary>
		/// Y coordinate, relative to window.
		/// </summary>
		public float MouseY;
	}
}