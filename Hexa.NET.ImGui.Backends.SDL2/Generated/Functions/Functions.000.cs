// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.ImGui;

namespace Hexa.NET.ImGui.Backends.SDL2
{
	public unsafe partial class ImGuiImplSDL2
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetCurrentContextNative(ImGuiContext* ctx)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiContext*, void>)funcTable[0])(ctx);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[0])((nint)ctx);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetCurrentContext(ImGuiContextPtr ctx)
		{
			SetCurrentContextNative(ctx);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetCurrentContext(ref ImGuiContext ctx)
		{
			fixed (ImGuiContext* pctx = &ctx)
			{
				SetCurrentContextNative((ImGuiContext*)pctx);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiContext* GetCurrentContextNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiContext*>)funcTable[1])();
			#else
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<nint>)funcTable[1])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiContextPtr GetCurrentContext()
		{
			ImGuiContextPtr ret = GetCurrentContextNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForOpenGLNative(SDLWindow* window, void* sdlGlContext)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, void*, byte>)funcTable[2])(window, sdlGlContext);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, nint, byte>)funcTable[2])((nint)window, (nint)sdlGlContext);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOpenGL(SDLWindowPtr window, void* sdlGlContext)
		{
			byte ret = InitForOpenGLNative(window, sdlGlContext);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOpenGL(ref SDLWindow window, void* sdlGlContext)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForOpenGLNative((SDLWindow*)pwindow, sdlGlContext);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForVulkanNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[3])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[3])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForVulkan(SDLWindowPtr window)
		{
			byte ret = InitForVulkanNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForVulkan(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForVulkanNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForD3DNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[4])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[4])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForD3D(SDLWindowPtr window)
		{
			byte ret = InitForD3DNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForD3D(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForD3DNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForMetalNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[5])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[5])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForMetal(SDLWindowPtr window)
		{
			byte ret = InitForMetalNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForMetal(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForMetalNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForSDLRendererNative(SDLWindow* window, SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, SDLRenderer*, byte>)funcTable[6])(window, renderer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, nint, byte>)funcTable[6])((nint)window, (nint)renderer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(SDLWindowPtr window, SDLRendererPtr renderer)
		{
			byte ret = InitForSDLRendererNative(window, renderer);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(ref SDLWindow window, SDLRendererPtr renderer)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForSDLRendererNative((SDLWindow*)pwindow, renderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(SDLWindowPtr window, ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				byte ret = InitForSDLRendererNative(window, (SDLRenderer*)prenderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(ref SDLWindow window, ref SDLRenderer renderer)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (SDLRenderer* prenderer = &renderer)
				{
					byte ret = InitForSDLRendererNative((SDLWindow*)pwindow, (SDLRenderer*)prenderer);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForOtherNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[7])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[7])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOther(SDLWindowPtr window)
		{
			byte ret = InitForOtherNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOther(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForOtherNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[8])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[8])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Shutdown()
		{
			ShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NewFrameNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[9])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[9])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void NewFrame()
		{
			NewFrameNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte ProcessEventNative(SDLEvent* evnt)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLEvent*, byte>)funcTable[10])(evnt);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[10])((nint)evnt);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool ProcessEvent(SDLEventPtr evnt)
		{
			byte ret = ProcessEventNative(evnt);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool ProcessEvent(ref SDLEvent evnt)
		{
			fixed (SDLEvent* pevnt = &evnt)
			{
				byte ret = ProcessEventNative((SDLEvent*)pevnt);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetGamepadModeNative(ImGuiImplSDL2GamepadMode mode, SDLGameController** manualGamepadsArray, int manualGamepadsCount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiImplSDL2GamepadMode, SDLGameController**, int, void>)funcTable[11])(mode, manualGamepadsArray, manualGamepadsCount);
			#else
			((delegate* unmanaged[Cdecl]<ImGuiImplSDL2GamepadMode, nint, int, void>)funcTable[11])(mode, (nint)manualGamepadsArray, manualGamepadsCount);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetGamepadMode(ImGuiImplSDL2GamepadMode mode, SDLGameControllerPtrPtr manualGamepadsArray, int manualGamepadsCount)
		{
			SetGamepadModeNative(mode, manualGamepadsArray, manualGamepadsCount);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetGamepadMode(ImGuiImplSDL2GamepadMode mode, ref SDLGameController* manualGamepadsArray, int manualGamepadsCount)
		{
			fixed (SDLGameController** pmanualGamepadsArray = &manualGamepadsArray)
			{
				SetGamepadModeNative(mode, (SDLGameController**)pmanualGamepadsArray, manualGamepadsCount);
			}
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2InitNative(SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLRenderer*, byte>)funcTable[12])(renderer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[12])((nint)renderer);
			#endif
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool SDLRenderer2Init(SDLRendererPtr renderer)
		{
			byte ret = SDLRenderer2InitNative(renderer);
			return ret != 0;
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool SDLRenderer2Init(ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				byte ret = SDLRenderer2InitNative((SDLRenderer*)prenderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2ShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[13])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[13])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2Shutdown()
		{
			SDLRenderer2ShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2NewFrameNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[14])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[14])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2NewFrame()
		{
			SDLRenderer2NewFrameNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2RenderDrawDataNative(ImDrawData* drawData, SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImDrawData*, SDLRenderer*, void>)funcTable[15])(drawData, renderer);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[15])((nint)drawData, (nint)renderer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ImDrawDataPtr drawData, SDLRendererPtr renderer)
		{
			SDLRenderer2RenderDrawDataNative(drawData, renderer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ref ImDrawData drawData, SDLRendererPtr renderer)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				SDLRenderer2RenderDrawDataNative((ImDrawData*)pdrawData, renderer);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ImDrawDataPtr drawData, ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				SDLRenderer2RenderDrawDataNative(drawData, (SDLRenderer*)prenderer);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ref ImDrawData drawData, ref SDLRenderer renderer)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (SDLRenderer* prenderer = &renderer)
				{
					SDLRenderer2RenderDrawDataNative((ImDrawData*)pdrawData, (SDLRenderer*)prenderer);
				}
			}
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2CreateFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<byte>)funcTable[16])();
			#else
			return (byte)((delegate* unmanaged[Cdecl]<byte>)funcTable[16])();
			#endif
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool SDLRenderer2CreateFontsTexture()
		{
			byte ret = SDLRenderer2CreateFontsTextureNative();
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2DestroyFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[17])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[17])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2DestroyFontsTexture()
		{
			SDLRenderer2DestroyFontsTextureNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2CreateDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<byte>)funcTable[18])();
			#else
			return (byte)((delegate* unmanaged[Cdecl]<byte>)funcTable[18])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool SDLRenderer2CreateDeviceObjects()
		{
			byte ret = SDLRenderer2CreateDeviceObjectsNative();
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2DestroyDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[19])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[19])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2DestroyDeviceObjects()
		{
			SDLRenderer2DestroyDeviceObjectsNative();
		}

	}
}
