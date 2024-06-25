﻿using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_init.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_init.h.
unsafe partial class SDL
{
	/// <summary>
	/// Initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Init">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags"> Subsystem initialization flags. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int Init(SDL_InitFlags flags)
	{
		return SDL_Init(flags);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int SDL_Init(SDL_InitFlags flags);
	}

	/// <summary>
	/// Compatibility function to initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_InitSubSystem">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int InitSubSystem(SDL_InitFlags flags)
	{
		return SDL_InitSubSystem(flags);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int SDL_InitSubSystem(SDL_InitFlags flags);
	}

	/// <summary>
	/// Shut down specific SDL subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_QuitSubSystem">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	public static void QuitSubSystem(SDL_InitFlags flags)
	{
		SDL_QuitSubSystem(flags);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void SDL_QuitSubSystem(SDL_InitFlags flags);
	}

	/// <summary>
	/// Get a mask of the specified subsystems which are currently initialized.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WasInit">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	/// <returns> A mask of all initialized subsystems if <paramref name="flags"/> is 0, otherwise it returns the initialization status of the specified subsystems. </returns>
	public static SDL_InitFlags WasInit(SDL_InitFlags flags)
	{
		return SDL_WasInit(flags);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_InitFlags SDL_WasInit(SDL_InitFlags flags);
	}

	/// <summary>
	/// Clean up all initialized subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Quit">documentation</see> for more details.
	/// </remarks>
	public static void Quit()
	{
		SDL_Quit();

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void SDL_Quit();
	}
}