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
	/// Helper: Growable text buffer for loggingaccumulating text<br/>
	/// (this could be called 'ImGuiTextBuilder'  'ImGuiStringBuilder')<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextBuffer
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<byte> Buf;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiTextBuffer(ImVector<byte> buf = default)
		{
			Buf = buf;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, byte* strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.appendNative(@this, str, strEnd);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.appendNative(@this, str, (byte*)(default));
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, byte* strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = &str)
				{
					ImGui.appendNative(@this, (byte*)pstr, strEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = &str)
				{
					ImGui.appendNative(@this, (byte*)pstr, (byte*)(default));
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, byte* strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = str)
				{
					ImGui.appendNative(@this, (byte*)pstr, strEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = str)
				{
					ImGui.appendNative(@this, (byte*)pstr, (byte*)(default));
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, byte* strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (str != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(str);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendNative(@this, pStr0, strEnd);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (str != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(str);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendNative(@this, pStr0, (byte*)(default));
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, ref byte strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstrEnd = &strEnd)
				{
					ImGui.appendNative(@this, str, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, ReadOnlySpan<byte> strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstrEnd = strEnd)
				{
					ImGui.appendNative(@this, str, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, string strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (strEnd != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(strEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendNative(@this, str, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, ref byte strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = &str)
				{
					fixed (byte* pstrEnd = &strEnd)
					{
						ImGui.appendNative(@this, (byte*)pstr, (byte*)pstrEnd);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, ReadOnlySpan<byte> strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = str)
				{
					fixed (byte* pstrEnd = strEnd)
					{
						ImGui.appendNative(@this, (byte*)pstr, (byte*)pstrEnd);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, string strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (str != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(str);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				byte* pStr1 = null;
				int pStrSize1 = 0;
				if (strEnd != null)
				{
					pStrSize1 = Utils.GetByteCountUTF8(strEnd);
					if (pStrSize1 >= Utils.MaxStackallocSize)
					{
						pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
					}
					else
					{
						byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
						pStr1 = pStrStack1;
					}
					int pStrOffset1 = Utils.EncodeStringUTF8(strEnd, pStr1, pStrSize1);
					pStr1[pStrOffset1] = 0;
				}
				ImGui.appendNative(@this, pStr0, pStr1);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr1);
				}
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, ReadOnlySpan<byte> strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = &str)
				{
					fixed (byte* pstrEnd = strEnd)
					{
						ImGui.appendNative(@this, (byte*)pstr, (byte*)pstrEnd);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, string strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = &str)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (strEnd != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(strEnd);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					ImGui.appendNative(@this, (byte*)pstr, pStr0);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						Utils.Free(pStr0);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, ref byte strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = str)
				{
					fixed (byte* pstrEnd = &strEnd)
					{
						ImGui.appendNative(@this, (byte*)pstr, (byte*)pstrEnd);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, string strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pstr = str)
				{
					byte* pStr0 = null;
					int pStrSize0 = 0;
					if (strEnd != null)
					{
						pStrSize0 = Utils.GetByteCountUTF8(strEnd);
						if (pStrSize0 >= Utils.MaxStackallocSize)
						{
							pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
						}
						else
						{
							byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
							pStr0 = pStrStack0;
						}
						int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
						pStr0[pStrOffset0] = 0;
					}
					ImGui.appendNative(@this, (byte*)pstr, pStr0);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						Utils.Free(pStr0);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, ref byte strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (str != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(str);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				fixed (byte* pstrEnd = &strEnd)
				{
					ImGui.appendNative(@this, pStr0, (byte*)pstrEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						Utils.Free(pStr0);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, ReadOnlySpan<byte> strEnd)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (str != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(str);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				fixed (byte* pstrEnd = strEnd)
				{
					ImGui.appendNative(@this, pStr0, (byte*)pstrEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						Utils.Free(pStr0);
					}
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(byte* fmt)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.appendfNative(@this, fmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(ref byte fmt)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pfmt = &fmt)
				{
					ImGui.appendfNative(@this, (byte*)pfmt);
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(ReadOnlySpan<byte> fmt)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pfmt = fmt)
				{
					ImGui.appendfNative(@this, (byte*)pfmt);
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(string fmt)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (fmt != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(fmt);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendfNative(@this, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(byte* fmt, nuint args)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.appendfvNative(@this, fmt, args);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(ref byte fmt, nuint args)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pfmt = &fmt)
				{
					ImGui.appendfvNative(@this, (byte*)pfmt, args);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(ReadOnlySpan<byte> fmt, nuint args)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				fixed (byte* pfmt = fmt)
				{
					ImGui.appendfvNative(@this, (byte*)pfmt, args);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(string fmt, nuint args)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (fmt != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(fmt);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendfvNative(@this, pStr0, args);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* begin()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* ret = ImGui.beginNative(@this);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe string beginS()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				string ret = Utils.DecodeStringUTF8(ImGui.beginNative(@this));
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* c_str()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* ret = ImGui.c_strNative(@this);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe string c_strS()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				string ret = Utils.DecodeStringUTF8(ImGui.c_strNative(@this));
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void clear()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.clearNative(@this);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe bool empty()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte ret = ImGui.emptyNative(@this);
				return ret != 0;
			}
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public unsafe byte* end()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				byte* ret = ImGui.endNative(@this);
				return ret;
			}
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public unsafe string endS()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				string ret = Utils.DecodeStringUTF8(ImGui.endNative(@this));
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void reserve(int capacity)
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				ImGui.reserveNative(@this, capacity);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe int size()
		{
			fixed (ImGuiTextBuffer* @this = &this)
			{
				int ret = ImGui.sizeNative(@this);
				return ret;
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiTextBufferPtr : IEquatable<ImGuiTextBufferPtr>
	{
		public ImGuiTextBufferPtr(ImGuiTextBuffer* handle) { Handle = handle; }

		public ImGuiTextBuffer* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiTextBufferPtr Null => new ImGuiTextBufferPtr(null);

		public ImGuiTextBuffer this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* handle) => new ImGuiTextBufferPtr(handle);

		public static implicit operator ImGuiTextBuffer*(ImGuiTextBufferPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiTextBufferPtr left, ImGuiTextBufferPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiTextBufferPtr left, ImGuiTextBufferPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiTextBufferPtr left, ImGuiTextBuffer* right) => left.Handle == right;

		public static bool operator !=(ImGuiTextBufferPtr left, ImGuiTextBuffer* right) => left.Handle != right;

		public bool Equals(ImGuiTextBufferPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiTextBufferPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiTextBufferPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<byte> Buf => ref Unsafe.AsRef<ImVector<byte>>(&Handle->Buf);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, byte* strEnd)
		{
			ImGui.appendNative(Handle, str, strEnd);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str)
		{
			ImGui.appendNative(Handle, str, (byte*)(default));
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, byte* strEnd)
		{
			fixed (byte* pstr = &str)
			{
				ImGui.appendNative(Handle, (byte*)pstr, strEnd);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str)
		{
			fixed (byte* pstr = &str)
			{
				ImGui.appendNative(Handle, (byte*)pstr, (byte*)(default));
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, byte* strEnd)
		{
			fixed (byte* pstr = str)
			{
				ImGui.appendNative(Handle, (byte*)pstr, strEnd);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str)
		{
			fixed (byte* pstr = str)
			{
				ImGui.appendNative(Handle, (byte*)pstr, (byte*)(default));
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, byte* strEnd)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ImGui.appendNative(Handle, pStr0, strEnd);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ImGui.appendNative(Handle, pStr0, (byte*)(default));
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, ref byte strEnd)
		{
			fixed (byte* pstrEnd = &strEnd)
			{
				ImGui.appendNative(Handle, str, (byte*)pstrEnd);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* pstrEnd = strEnd)
			{
				ImGui.appendNative(Handle, str, (byte*)pstrEnd);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(byte* str, string strEnd)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (strEnd != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(strEnd);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ImGui.appendNative(Handle, str, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, ref byte strEnd)
		{
			fixed (byte* pstr = &str)
			{
				fixed (byte* pstrEnd = &strEnd)
				{
					ImGui.appendNative(Handle, (byte*)pstr, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* pstr = str)
			{
				fixed (byte* pstrEnd = strEnd)
				{
					ImGui.appendNative(Handle, (byte*)pstr, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, string strEnd)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (strEnd != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(strEnd);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(strEnd, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			ImGui.appendNative(Handle, pStr0, pStr1);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* pstr = &str)
			{
				fixed (byte* pstrEnd = strEnd)
				{
					ImGui.appendNative(Handle, (byte*)pstr, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ref byte str, string strEnd)
		{
			fixed (byte* pstr = &str)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (strEnd != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(strEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendNative(Handle, (byte*)pstr, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, ref byte strEnd)
		{
			fixed (byte* pstr = str)
			{
				fixed (byte* pstrEnd = &strEnd)
				{
					ImGui.appendNative(Handle, (byte*)pstr, (byte*)pstrEnd);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(ReadOnlySpan<byte> str, string strEnd)
		{
			fixed (byte* pstr = str)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (strEnd != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(strEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(strEnd, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.appendNative(Handle, (byte*)pstr, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, ref byte strEnd)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			fixed (byte* pstrEnd = &strEnd)
			{
				ImGui.appendNative(Handle, pStr0, (byte*)pstrEnd);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void append(string str, ReadOnlySpan<byte> strEnd)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			fixed (byte* pstrEnd = strEnd)
			{
				ImGui.appendNative(Handle, pStr0, (byte*)pstrEnd);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(byte* fmt)
		{
			ImGui.appendfNative(Handle, fmt);
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(ref byte fmt)
		{
			fixed (byte* pfmt = &fmt)
			{
				ImGui.appendfNative(Handle, (byte*)pfmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* pfmt = fmt)
			{
				ImGui.appendfNative(Handle, (byte*)pfmt);
			}
		}

		/// <summary>
		/// no appendfV<br/>
		/// </summary>
		public unsafe void appendf(string fmt)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (fmt != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(fmt);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ImGui.appendfNative(Handle, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(byte* fmt, nuint args)
		{
			ImGui.appendfvNative(Handle, fmt, args);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(ref byte fmt, nuint args)
		{
			fixed (byte* pfmt = &fmt)
			{
				ImGui.appendfvNative(Handle, (byte*)pfmt, args);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(ReadOnlySpan<byte> fmt, nuint args)
		{
			fixed (byte* pfmt = fmt)
			{
				ImGui.appendfvNative(Handle, (byte*)pfmt, args);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void appendfv(string fmt, nuint args)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (fmt != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(fmt);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(fmt, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ImGui.appendfvNative(Handle, pStr0, args);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* begin()
		{
			byte* ret = ImGui.beginNative(Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe string beginS()
		{
			string ret = Utils.DecodeStringUTF8(ImGui.beginNative(Handle));
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* c_str()
		{
			byte* ret = ImGui.c_strNative(Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe string c_strS()
		{
			string ret = Utils.DecodeStringUTF8(ImGui.c_strNative(Handle));
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void clear()
		{
			ImGui.clearNative(Handle);
		}

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
		public unsafe bool empty()
		{
			byte ret = ImGui.emptyNative(Handle);
			return ret != 0;
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public unsafe byte* end()
		{
			byte* ret = ImGui.endNative(Handle);
			return ret;
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public unsafe string endS()
		{
			string ret = Utils.DecodeStringUTF8(ImGui.endNative(Handle));
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void reserve(int capacity)
		{
			ImGui.reserveNative(Handle, capacity);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe int size()
		{
			int ret = ImGui.sizeNative(Handle);
			return ret;
		}

	}

}
