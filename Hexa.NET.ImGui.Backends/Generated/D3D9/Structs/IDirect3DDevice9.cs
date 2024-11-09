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

namespace Hexa.NET.ImGui.Backends.D3D9
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct IDirect3DDevice9
	{


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct IDirect3DDevice9Ptr : IEquatable<IDirect3DDevice9Ptr>
	{
		public IDirect3DDevice9Ptr(IDirect3DDevice9* handle) { Handle = handle; }

		public IDirect3DDevice9* Handle;

		public bool IsNull => Handle == null;

		public static IDirect3DDevice9Ptr Null => new IDirect3DDevice9Ptr(null);

		public IDirect3DDevice9 this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator IDirect3DDevice9Ptr(IDirect3DDevice9* handle) => new IDirect3DDevice9Ptr(handle);

		public static implicit operator IDirect3DDevice9*(IDirect3DDevice9Ptr handle) => handle.Handle;

		public static bool operator ==(IDirect3DDevice9Ptr left, IDirect3DDevice9Ptr right) => left.Handle == right.Handle;

		public static bool operator !=(IDirect3DDevice9Ptr left, IDirect3DDevice9Ptr right) => left.Handle != right.Handle;

		public static bool operator ==(IDirect3DDevice9Ptr left, IDirect3DDevice9* right) => left.Handle == right;

		public static bool operator !=(IDirect3DDevice9Ptr left, IDirect3DDevice9* right) => left.Handle != right;

		public bool Equals(IDirect3DDevice9Ptr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is IDirect3DDevice9Ptr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("IDirect3DDevice9Ptr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
