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

namespace Hexa.NET.ImGui
{
	public unsafe partial class ImGui
	{

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, byte* format)
		{
			int ret = DataTypeFormatStringNative(buf, bufSize, dataType, pData, format);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(ref byte buf, int bufSize, ImGuiDataType dataType, void* pData, byte* format)
		{
			fixed (byte* pbuf = &buf)
			{
				int ret = DataTypeFormatStringNative((byte*)pbuf, bufSize, dataType, pData, format);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(ref string buf, int bufSize, ImGuiDataType dataType, void* pData, byte* format)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = DataTypeFormatStringNative(pStr0, bufSize, dataType, pData, format);
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, ref byte format)
		{
			fixed (byte* pformat = &format)
			{
				int ret = DataTypeFormatStringNative(buf, bufSize, dataType, pData, (byte*)pformat);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, ReadOnlySpan<byte> format)
		{
			fixed (byte* pformat = format)
			{
				int ret = DataTypeFormatStringNative(buf, bufSize, dataType, pData, (byte*)pformat);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, string format)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (format != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(format);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(format, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = DataTypeFormatStringNative(buf, bufSize, dataType, pData, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(ref byte buf, int bufSize, ImGuiDataType dataType, void* pData, ref byte format)
		{
			fixed (byte* pbuf = &buf)
			{
				fixed (byte* pformat = &format)
				{
					int ret = DataTypeFormatStringNative((byte*)pbuf, bufSize, dataType, pData, (byte*)pformat);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(ref byte buf, int bufSize, ImGuiDataType dataType, void* pData, ReadOnlySpan<byte> format)
		{
			fixed (byte* pbuf = &buf)
			{
				fixed (byte* pformat = format)
				{
					int ret = DataTypeFormatStringNative((byte*)pbuf, bufSize, dataType, pData, (byte*)pformat);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static int DataTypeFormatString(ref string buf, int bufSize, ImGuiDataType dataType, void* pData, string format)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (format != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(format);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(format, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			int ret = DataTypeFormatStringNative(pStr0, bufSize, dataType, pData, pStr1);
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		internal static byte InputTextExNative(byte* label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<byte*, byte*, byte*, int, Vector2, ImGuiInputTextFlags, delegate*<ImGuiInputTextCallbackData*, int>, void*, byte>)vt[1433])(label, hint, buf, bufSize, sizeArg, flags, (delegate*<ImGuiInputTextCallbackData*, int>)Utils.GetFunctionPointerForDelegate(callback), userData);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, nint, nint, int, Vector2, ImGuiInputTextFlags, nint, nint, byte>)vt[1433])((nint)label, (nint)hint, (nint)buf, bufSize, sizeArg, flags, (nint)Utils.GetFunctionPointerForDelegate(callback), (nint)userData);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte ret = InputTextExNative(label, hint, buf, bufSize, sizeArg, flags, callback, userData);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ref byte label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = &label)
			{
				byte ret = InputTextExNative((byte*)plabel, hint, buf, bufSize, sizeArg, flags, callback, userData);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ReadOnlySpan<byte> label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = label)
			{
				byte ret = InputTextExNative((byte*)plabel, hint, buf, bufSize, sizeArg, flags, callback, userData);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(string label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = InputTextExNative(pStr0, hint, buf, bufSize, sizeArg, flags, callback, userData);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, ref byte hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* phint = &hint)
			{
				byte ret = InputTextExNative(label, (byte*)phint, buf, bufSize, sizeArg, flags, callback, userData);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, ReadOnlySpan<byte> hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* phint = hint)
			{
				byte ret = InputTextExNative(label, (byte*)phint, buf, bufSize, sizeArg, flags, callback, userData);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, string hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (hint != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(hint);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(hint, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = InputTextExNative(label, pStr0, buf, bufSize, sizeArg, flags, callback, userData);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ref byte label, ref byte hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = &label)
			{
				fixed (byte* phint = &hint)
				{
					byte ret = InputTextExNative((byte*)plabel, (byte*)phint, buf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = label)
			{
				fixed (byte* phint = hint)
				{
					byte ret = InputTextExNative((byte*)plabel, (byte*)phint, buf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(string label, string hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (hint != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(hint);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(hint, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			byte ret = InputTextExNative(pStr0, pStr1, buf, bufSize, sizeArg, flags, callback, userData);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, byte* hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* pbuf = &buf)
			{
				byte ret = InputTextExNative(label, hint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, byte* hint, ref string buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = InputTextExNative(label, hint, pStr0, bufSize, sizeArg, flags, callback, userData);
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ref byte label, byte* hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = &label)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = InputTextExNative((byte*)plabel, hint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ReadOnlySpan<byte> label, byte* hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = label)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = InputTextExNative((byte*)plabel, hint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(string label, byte* hint, ref string buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (buf != null)
			{
				pStrSize1 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(buf, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			byte ret = InputTextExNative(pStr0, hint, pStr1, bufSize, sizeArg, flags, callback, userData);
			buf = Utils.DecodeStringUTF8(pStr1);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, ref byte hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* phint = &hint)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = InputTextExNative(label, (byte*)phint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, ReadOnlySpan<byte> hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* phint = hint)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = InputTextExNative(label, (byte*)phint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(byte* label, string hint, ref string buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (hint != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(hint);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(hint, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (buf != null)
			{
				pStrSize1 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(buf, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			byte ret = InputTextExNative(label, pStr0, pStr1, bufSize, sizeArg, flags, callback, userData);
			buf = Utils.DecodeStringUTF8(pStr1);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ref byte label, ref byte hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = &label)
			{
				fixed (byte* phint = &hint)
				{
					fixed (byte* pbuf = &buf)
					{
						byte ret = InputTextExNative((byte*)plabel, (byte*)phint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
						return ret != 0;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, ref byte buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			fixed (byte* plabel = label)
			{
				fixed (byte* phint = hint)
				{
					fixed (byte* pbuf = &buf)
					{
						byte ret = InputTextExNative((byte*)plabel, (byte*)phint, (byte*)pbuf, bufSize, sizeArg, flags, callback, userData);
						return ret != 0;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InputTextEx(string label, string hint, ref string buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (hint != null)
			{
				pStrSize1 = Utils.GetByteCountUTF8(hint);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(hint, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			byte* pStr2 = null;
			int pStrSize2 = 0;
			if (buf != null)
			{
				pStrSize2 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize2 >= Utils.MaxStackallocSize)
				{
					pStr2 = Utils.Alloc<byte>(pStrSize2 + 1);
				}
				else
				{
					byte* pStrStack2 = stackalloc byte[pStrSize2 + 1];
					pStr2 = pStrStack2;
				}
				int pStrOffset2 = Utils.EncodeStringUTF8(buf, pStr2, pStrSize2);
				pStr2[pStrOffset2] = 0;
			}
			byte ret = InputTextExNative(pStr0, pStr1, pStr2, bufSize, sizeArg, flags, callback, userData);
			buf = Utils.DecodeStringUTF8(pStr2);
			if (pStrSize2 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr2);
			}
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		internal static byte TempInputTextNative(ImRect bb, uint id, byte* label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, byte*, byte*, int, ImGuiInputTextFlags, byte>)vt[1434])(bb, id, label, buf, bufSize, flags);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<ImRect, uint, nint, nint, int, ImGuiInputTextFlags, byte>)vt[1434])(bb, id, (nint)label, (nint)buf, bufSize, flags);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, byte* label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			byte ret = TempInputTextNative(bb, id, label, buf, bufSize, flags);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, ref byte label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* plabel = &label)
			{
				byte ret = TempInputTextNative(bb, id, (byte*)plabel, buf, bufSize, flags);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, ReadOnlySpan<byte> label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* plabel = label)
			{
				byte ret = TempInputTextNative(bb, id, (byte*)plabel, buf, bufSize, flags);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, string label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = TempInputTextNative(bb, id, pStr0, buf, bufSize, flags);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, byte* label, ref byte buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* pbuf = &buf)
			{
				byte ret = TempInputTextNative(bb, id, label, (byte*)pbuf, bufSize, flags);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, byte* label, ref string buf, int bufSize, ImGuiInputTextFlags flags)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte ret = TempInputTextNative(bb, id, label, pStr0, bufSize, flags);
			buf = Utils.DecodeStringUTF8(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, ref byte label, ref byte buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* plabel = &label)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = TempInputTextNative(bb, id, (byte*)plabel, (byte*)pbuf, bufSize, flags);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, ReadOnlySpan<byte> label, ref byte buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* plabel = label)
			{
				fixed (byte* pbuf = &buf)
				{
					byte ret = TempInputTextNative(bb, id, (byte*)plabel, (byte*)pbuf, bufSize, flags);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool TempInputText(ImRect bb, uint id, string label, ref string buf, int bufSize, ImGuiInputTextFlags flags)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			byte* pStr1 = null;
			int pStrSize1 = 0;
			if (buf != null)
			{
				pStrSize1 = Math.Max(Utils.GetByteCountUTF8(buf), (int)bufSize);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
				}
				else
				{
					byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
					pStr1 = pStrStack1;
				}
				int pStrOffset1 = Utils.EncodeStringUTF8(buf, pStr1, pStrSize1);
				pStr1[pStrOffset1] = 0;
			}
			byte ret = TempInputTextNative(bb, id, pStr0, pStr1, bufSize, flags);
			buf = Utils.DecodeStringUTF8(pStr1);
			if (pStrSize1 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr1);
			}
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret != 0;
		}

	}
}
