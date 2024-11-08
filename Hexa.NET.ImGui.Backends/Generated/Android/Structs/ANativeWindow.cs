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

namespace Hexa.NET.ImGui.Backends.Android
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ANativeWindow
	{


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ANativeWindowPtr : IEquatable<ANativeWindowPtr>
	{
		public ANativeWindowPtr(ANativeWindow* handle) { Handle = handle; }

		public ANativeWindow* Handle;

		public bool IsNull => Handle == null;

		public static ANativeWindowPtr Null => new ANativeWindowPtr(null);

		public ANativeWindow this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ANativeWindowPtr(ANativeWindow* handle) => new ANativeWindowPtr(handle);

		public static implicit operator ANativeWindow*(ANativeWindowPtr handle) => handle.Handle;

		public static bool operator ==(ANativeWindowPtr left, ANativeWindowPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ANativeWindowPtr left, ANativeWindowPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ANativeWindowPtr left, ANativeWindow* right) => left.Handle == right;

		public static bool operator !=(ANativeWindowPtr left, ANativeWindow* right) => left.Handle != right;

		public bool Equals(ANativeWindowPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ANativeWindowPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ANativeWindowPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
