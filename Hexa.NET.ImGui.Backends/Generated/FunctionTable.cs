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

namespace Hexa.NET.ImGui.Backends
{
	public unsafe partial class ImGuiBackends
	{
		internal static FunctionTable funcTable;

		public static void InitApi()
		{
			funcTable = new FunctionTable(LibraryLoader.LoadLibrary(GetLibraryName, null), 51);
			funcTable.Load(0, "ImGui_ImplGlfw_InitForOpenGL");
			funcTable.Load(1, "ImGui_ImplGlfw_InitForVulkan");
			funcTable.Load(2, "ImGui_ImplGlfw_InitForOther");
			funcTable.Load(3, "ImGui_ImplGlfw_Shutdown");
			funcTable.Load(4, "ImGui_ImplGlfw_NewFrame");
			funcTable.Load(5, "ImGui_ImplGlfw_InstallCallbacks");
			funcTable.Load(6, "ImGui_ImplGlfw_RestoreCallbacks");
			funcTable.Load(7, "ImGui_ImplGlfw_SetCallbacksChainForAllWindows");
			funcTable.Load(8, "ImGui_ImplGlfw_WindowFocusCallback");
			funcTable.Load(9, "ImGui_ImplGlfw_CursorEnterCallback");
			funcTable.Load(10, "ImGui_ImplGlfw_CursorPosCallback");
			funcTable.Load(11, "ImGui_ImplGlfw_MouseButtonCallback");
			funcTable.Load(12, "ImGui_ImplGlfw_ScrollCallback");
			funcTable.Load(13, "ImGui_ImplGlfw_KeyCallback");
			funcTable.Load(14, "ImGui_ImplGlfw_CharCallback");
			funcTable.Load(15, "ImGui_ImplGlfw_MonitorCallback");
			funcTable.Load(16, "ImGui_ImplGlfw_Sleep");
			funcTable.Load(17, "ImGui_ImplOpenGL3_Init");
			funcTable.Load(18, "ImGui_ImplOpenGL3_Shutdown");
			funcTable.Load(19, "ImGui_ImplOpenGL3_NewFrame");
			funcTable.Load(20, "ImGui_ImplOpenGL3_RenderDrawData");
			funcTable.Load(21, "ImGui_ImplOpenGL3_CreateFontsTexture");
			funcTable.Load(22, "ImGui_ImplOpenGL3_DestroyFontsTexture");
			funcTable.Load(23, "ImGui_ImplOpenGL3_CreateDeviceObjects");
			funcTable.Load(24, "ImGui_ImplOpenGL3_DestroyDeviceObjects");
			funcTable.Load(25, "ImGui_ImplOpenGL2_Init");
			funcTable.Load(26, "ImGui_ImplOpenGL2_Shutdown");
			funcTable.Load(27, "ImGui_ImplOpenGL2_NewFrame");
			funcTable.Load(28, "ImGui_ImplOpenGL2_RenderDrawData");
			funcTable.Load(29, "ImGui_ImplOpenGL2_CreateFontsTexture");
			funcTable.Load(30, "ImGui_ImplOpenGL2_DestroyFontsTexture");
			funcTable.Load(31, "ImGui_ImplOpenGL2_CreateDeviceObjects");
			funcTable.Load(32, "ImGui_ImplOpenGL2_DestroyDeviceObjects");
			funcTable.Load(33, "ImGui_ImplSDL2_InitForOpenGL");
			funcTable.Load(34, "ImGui_ImplSDL2_InitForVulkan");
			funcTable.Load(35, "ImGui_ImplSDL2_InitForD3D");
			funcTable.Load(36, "ImGui_ImplSDL2_InitForMetal");
			funcTable.Load(37, "ImGui_ImplSDL2_InitForSDLRenderer");
			funcTable.Load(38, "ImGui_ImplSDL2_InitForOther");
			funcTable.Load(39, "ImGui_ImplSDL2_Shutdown");
			funcTable.Load(40, "ImGui_ImplSDL2_NewFrame");
			funcTable.Load(41, "ImGui_ImplSDL2_ProcessEvent");
			funcTable.Load(42, "ImGui_ImplSDL2_SetGamepadMode");
			funcTable.Load(43, "ImGui_ImplDX11_Init");
			funcTable.Load(44, "ImGui_ImplDX11_Shutdown");
			funcTable.Load(45, "ImGui_ImplDX11_NewFrame");
			funcTable.Load(46, "ImGui_ImplDX11_RenderDrawData");
			funcTable.Load(47, "ImGui_ImplDX11_InvalidateDeviceObjects");
			funcTable.Load(48, "ImGui_ImplDX11_CreateDeviceObjects");
			funcTable.Load(49, "igSetCurrentContext");
			funcTable.Load(50, "igGetCurrentContext");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
