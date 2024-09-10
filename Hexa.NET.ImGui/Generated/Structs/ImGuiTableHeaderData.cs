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
	public partial struct ImGuiTableHeaderData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte Index;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint TextColor;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BgColor0;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BgColor1;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiTableHeaderData(sbyte index = default, uint textColor = default, uint bgColor0 = default, uint bgColor1 = default)
		{
			Index = index;
			TextColor = textColor;
			BgColor0 = bgColor0;
			BgColor1 = bgColor1;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiTableHeaderDataPtr : IEquatable<ImGuiTableHeaderDataPtr>
	{
		public ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* handle) { Handle = handle; }

		public ImGuiTableHeaderData* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiTableHeaderDataPtr Null => new ImGuiTableHeaderDataPtr(null);

		public ImGuiTableHeaderData this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* handle) => new ImGuiTableHeaderDataPtr(handle);

		public static implicit operator ImGuiTableHeaderData*(ImGuiTableHeaderDataPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiTableHeaderDataPtr left, ImGuiTableHeaderDataPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiTableHeaderDataPtr left, ImGuiTableHeaderDataPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiTableHeaderDataPtr left, ImGuiTableHeaderData* right) => left.Handle == right;

		public static bool operator !=(ImGuiTableHeaderDataPtr left, ImGuiTableHeaderData* right) => left.Handle != right;

		public bool Equals(ImGuiTableHeaderDataPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiTableHeaderDataPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiTableHeaderDataPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte Index => ref Unsafe.AsRef<sbyte>(&Handle->Index);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint TextColor => ref Unsafe.AsRef<uint>(&Handle->TextColor);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint BgColor0 => ref Unsafe.AsRef<uint>(&Handle->BgColor0);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint BgColor1 => ref Unsafe.AsRef<uint>(&Handle->BgColor1);
	}

}