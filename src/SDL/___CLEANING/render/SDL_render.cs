﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_render.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_render.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Get the number of 2D rendering drivers available for the current display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>A number &gt;= 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumRenderDrivers();

	/// <summary>
	/// Use this function to get the name of a built in 2D rendering driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the rendering driver; the value ranges from 0 to <see cref="GetNumRenderDrivers"/> - 1.</param>
	/// <returns>The name of the rendering driver at the requested index, or <see langword="null"/> if an invalid index was specified.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDriver", StringMarshallingCustomType = typeof(GetStringRuleStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetRenderDriver(int index);

	/// <summary>
	/// Create a window and default renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowAndRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="title">The title of the window.</param>
	/// <param name="width">The width of the window.</param>
	/// <param name="height">The height of the window.</param>
	/// <param name="windowFlags">The flags used to create the window (see <see cref="CreateWindow(string, int, int, SDL_WindowFlags)"/> for details).</param>
	/// <param name="window">A pointer filled with the window, or <see langword="null"/> on error.</param>
	/// <param name="renderer">A pointer filled with the renderer, or <see langword="null"/> on error.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int CreateWindowAndRenderer(string title, int width, int height, SDL_WindowFlags windowFlags, out SDL_Window* window, out SDL_Renderer* renderer);

	/// <summary>
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">documentation</see> for more details.
	/// </remarks>
	public const string SoftwareRenderer = "software";
}