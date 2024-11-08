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
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, automatically called. Do not call manually, only after <see cref="FreeApi"/>.
		/// </summary>
		public static void InitApi()
		{
			funcTable = new FunctionTable(LibraryLoader.LoadLibrary(GetLibraryName, null), 20);
			funcTable.Load(0, "igSetCurrentContext");
			funcTable.Load(1, "igGetCurrentContext");
			funcTable.Load(2, "CImGui_ImplSDL2_InitForOpenGL");
			funcTable.Load(3, "CImGui_ImplSDL2_InitForVulkan");
			funcTable.Load(4, "CImGui_ImplSDL2_InitForD3D");
			funcTable.Load(5, "CImGui_ImplSDL2_InitForMetal");
			funcTable.Load(6, "CImGui_ImplSDL2_InitForSDLRenderer");
			funcTable.Load(7, "CImGui_ImplSDL2_InitForOther");
			funcTable.Load(8, "CImGui_ImplSDL2_Shutdown");
			funcTable.Load(9, "CImGui_ImplSDL2_NewFrame");
			funcTable.Load(10, "CImGui_ImplSDL2_ProcessEvent");
			funcTable.Load(11, "CImGui_ImplSDL2_SetGamepadMode");
			funcTable.Load(12, "CImGui_ImplSDLRenderer2_Init");
			funcTable.Load(13, "CImGui_ImplSDLRenderer2_Shutdown");
			funcTable.Load(14, "CImGui_ImplSDLRenderer2_NewFrame");
			funcTable.Load(15, "CImGui_ImplSDLRenderer2_RenderDrawData");
			funcTable.Load(16, "CImGui_ImplSDLRenderer2_CreateFontsTexture");
			funcTable.Load(17, "CImGui_ImplSDLRenderer2_DestroyFontsTexture");
			funcTable.Load(18, "CImGui_ImplSDLRenderer2_CreateDeviceObjects");
			funcTable.Load(19, "CImGui_ImplSDLRenderer2_DestroyDeviceObjects");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
