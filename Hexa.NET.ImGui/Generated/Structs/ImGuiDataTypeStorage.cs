// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeStorage
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Data_0;
		public byte Data_1;
		public byte Data_2;
		public byte Data_3;
		public byte Data_4;
		public byte Data_5;
		public byte Data_6;
		public byte Data_7;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiDataTypeStorage(byte* data = default)
		{
			if (data != default(byte*))
			{
				Data_0 = data[0];
				Data_1 = data[1];
				Data_2 = data[2];
				Data_3 = data[3];
				Data_4 = data[4];
				Data_5 = data[5];
				Data_6 = data[6];
				Data_7 = data[7];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiDataTypeStorage(Span<byte> data = default)
		{
			if (data != default(Span<byte>))
			{
				Data_0 = data[0];
				Data_1 = data[1];
				Data_2 = data[2];
				Data_3 = data[3];
				Data_4 = data[4];
				Data_5 = data[5];
				Data_6 = data[6];
				Data_7 = data[7];
			}
		}


	}

}