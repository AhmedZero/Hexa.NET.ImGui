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
	/// See ImFontAtlas::AddCustomRectXXX functions.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlasCustomRect
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort X;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort Y;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint GlyphID;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint GlyphColored;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float GlyphAdvanceX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector2 GlyphOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImFont* Font;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImFontAtlasCustomRect(ushort width = default, ushort height = default, ushort x = default, ushort y = default, uint glyphId = default, uint glyphColored = default, float glyphAdvanceX = default, Vector2 glyphOffset = default, ImFontPtr font = default)
		{
			Width = width;
			Height = height;
			X = x;
			Y = y;
			GlyphID = glyphId;
			GlyphColored = glyphColored;
			GlyphAdvanceX = glyphAdvanceX;
			GlyphOffset = glyphOffset;
			Font = font;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImFontAtlasCustomRect* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe bool IsPacked()
		{
			fixed (ImFontAtlasCustomRect* @this = &this)
			{
				byte ret = ImGui.IsPackedNative(@this);
				return ret != 0;
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImFontAtlasCustomRectPtr : IEquatable<ImFontAtlasCustomRectPtr>
	{
		public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* handle) { Handle = handle; }

		public ImFontAtlasCustomRect* Handle;

		public bool IsNull => Handle == null;

		public static ImFontAtlasCustomRectPtr Null => new ImFontAtlasCustomRectPtr(null);

		public ImFontAtlasCustomRect this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* handle) => new ImFontAtlasCustomRectPtr(handle);

		public static implicit operator ImFontAtlasCustomRect*(ImFontAtlasCustomRectPtr handle) => handle.Handle;

		public static bool operator ==(ImFontAtlasCustomRectPtr left, ImFontAtlasCustomRectPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImFontAtlasCustomRectPtr left, ImFontAtlasCustomRectPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImFontAtlasCustomRectPtr left, ImFontAtlasCustomRect* right) => left.Handle == right;

		public static bool operator !=(ImFontAtlasCustomRectPtr left, ImFontAtlasCustomRect* right) => left.Handle != right;

		public bool Equals(ImFontAtlasCustomRectPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImFontAtlasCustomRectPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImFontAtlasCustomRectPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ushort Width => ref Unsafe.AsRef<ushort>(&Handle->Width);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ushort Height => ref Unsafe.AsRef<ushort>(&Handle->Height);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ushort X => ref Unsafe.AsRef<ushort>(&Handle->X);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ushort Y => ref Unsafe.AsRef<ushort>(&Handle->Y);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint GlyphID => ref Unsafe.AsRef<uint>(&Handle->GlyphID);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint GlyphColored => ref Unsafe.AsRef<uint>(&Handle->GlyphColored);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float GlyphAdvanceX => ref Unsafe.AsRef<float>(&Handle->GlyphAdvanceX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&Handle->GlyphOffset);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImFontPtr Font => ref Unsafe.AsRef<ImFontPtr>(&Handle->Font);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImGui.DestroyNative(Handle);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe bool IsPacked()
		{
			byte ret = ImGui.IsPackedNative(Handle);
			return ret != 0;
		}

	}

}
