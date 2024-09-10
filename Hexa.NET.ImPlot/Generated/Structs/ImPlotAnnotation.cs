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
using Hexa.NET.ImGui;

namespace Hexa.NET.ImPlot
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAnnotation
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector2 Pos;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector2 Offset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ColorBg;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ColorFg;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int TextOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Clamp;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotAnnotation(Vector2 pos = default, Vector2 offset = default, uint colorBg = default, uint colorFg = default, int textOffset = default, bool clamp = default)
		{
			Pos = pos;
			Offset = offset;
			ColorBg = colorBg;
			ColorFg = colorFg;
			TextOffset = textOffset;
			Clamp = clamp ? (byte)1 : (byte)0;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImPlotAnnotationPtr : IEquatable<ImPlotAnnotationPtr>
	{
		public ImPlotAnnotationPtr(ImPlotAnnotation* handle) { Handle = handle; }

		public ImPlotAnnotation* Handle;

		public bool IsNull => Handle == null;

		public static ImPlotAnnotationPtr Null => new ImPlotAnnotationPtr(null);

		public ImPlotAnnotation this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImPlotAnnotationPtr(ImPlotAnnotation* handle) => new ImPlotAnnotationPtr(handle);

		public static implicit operator ImPlotAnnotation*(ImPlotAnnotationPtr handle) => handle.Handle;

		public static bool operator ==(ImPlotAnnotationPtr left, ImPlotAnnotationPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImPlotAnnotationPtr left, ImPlotAnnotationPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImPlotAnnotationPtr left, ImPlotAnnotation* right) => left.Handle == right;

		public static bool operator !=(ImPlotAnnotationPtr left, ImPlotAnnotation* right) => left.Handle != right;

		public bool Equals(ImPlotAnnotationPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImPlotAnnotationPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImPlotAnnotationPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&Handle->Pos);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref Vector2 Offset => ref Unsafe.AsRef<Vector2>(&Handle->Offset);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint ColorBg => ref Unsafe.AsRef<uint>(&Handle->ColorBg);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint ColorFg => ref Unsafe.AsRef<uint>(&Handle->ColorFg);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int TextOffset => ref Unsafe.AsRef<int>(&Handle->TextOffset);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool Clamp => ref Unsafe.AsRef<bool>(&Handle->Clamp);
	}

}