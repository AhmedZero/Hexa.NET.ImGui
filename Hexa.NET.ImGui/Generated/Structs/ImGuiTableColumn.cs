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
	public partial struct ImGuiTableColumn
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiTableColumnFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float WidthGiven;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float MinX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float MaxX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float WidthRequest;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float WidthAuto;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float StretchWeight;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float InitStretchWeightOrWidth;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImRect ClipRect;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint UserID;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float WorkMinX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float WorkMaxX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ItemWidth;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ContentMaxXFrozen;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ContentMaxXUnfrozen;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ContentMaxXHeadersUsed;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ContentMaxXHeadersIdeal;

		/// <summary>
		/// To be documented.
		/// </summary>
		public short NameOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte DisplayOrder;

		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte IndexWithinEnabledSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte PrevEnabledColumn;

		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte NextEnabledColumn;

		/// <summary>
		/// To be documented.
		/// </summary>
		public sbyte SortOrder;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte DrawChannelCurrent;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte DrawChannelFrozen;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte DrawChannelUnfrozen;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsEnabled;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsUserEnabled;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsUserEnabledNextFrame;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsVisibleX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsVisibleY;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsRequestOutput;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsSkipItems;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsPreserveWidthAuto;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte NavLayerCurrent;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte AutoFitQueue;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte CannotSkipItemsQueue;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SortDirection;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SortDirectionsAvailCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SortDirectionsAvailMask;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SortDirectionsAvailList;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiTableColumn(ImGuiTableColumnFlags flags = default, float widthGiven = default, float minX = default, float maxX = default, float widthRequest = default, float widthAuto = default, float stretchWeight = default, float initStretchWeightOrWidth = default, ImRect clipRect = default, uint userId = default, float workMinX = default, float workMaxX = default, float itemWidth = default, float contentMaxXFrozen = default, float contentMaxXUnfrozen = default, float contentMaxXHeadersUsed = default, float contentMaxXHeadersIdeal = default, short nameOffset = default, sbyte displayOrder = default, sbyte indexWithinEnabledSet = default, sbyte prevEnabledColumn = default, sbyte nextEnabledColumn = default, sbyte sortOrder = default, byte drawChannelCurrent = default, byte drawChannelFrozen = default, byte drawChannelUnfrozen = default, bool isEnabled = default, bool isUserEnabled = default, bool isUserEnabledNextFrame = default, bool isVisibleX = default, bool isVisibleY = default, bool isRequestOutput = default, bool isSkipItems = default, bool isPreserveWidthAuto = default, byte navLayerCurrent = default, byte autoFitQueue = default, byte cannotSkipItemsQueue = default, byte sortDirection = default, byte sortDirectionsAvailCount = default, byte sortDirectionsAvailMask = default, byte sortDirectionsAvailList = default)
		{
			Flags = flags;
			WidthGiven = widthGiven;
			MinX = minX;
			MaxX = maxX;
			WidthRequest = widthRequest;
			WidthAuto = widthAuto;
			StretchWeight = stretchWeight;
			InitStretchWeightOrWidth = initStretchWeightOrWidth;
			ClipRect = clipRect;
			UserID = userId;
			WorkMinX = workMinX;
			WorkMaxX = workMaxX;
			ItemWidth = itemWidth;
			ContentMaxXFrozen = contentMaxXFrozen;
			ContentMaxXUnfrozen = contentMaxXUnfrozen;
			ContentMaxXHeadersUsed = contentMaxXHeadersUsed;
			ContentMaxXHeadersIdeal = contentMaxXHeadersIdeal;
			NameOffset = nameOffset;
			DisplayOrder = displayOrder;
			IndexWithinEnabledSet = indexWithinEnabledSet;
			PrevEnabledColumn = prevEnabledColumn;
			NextEnabledColumn = nextEnabledColumn;
			SortOrder = sortOrder;
			DrawChannelCurrent = drawChannelCurrent;
			DrawChannelFrozen = drawChannelFrozen;
			DrawChannelUnfrozen = drawChannelUnfrozen;
			IsEnabled = isEnabled ? (byte)1 : (byte)0;
			IsUserEnabled = isUserEnabled ? (byte)1 : (byte)0;
			IsUserEnabledNextFrame = isUserEnabledNextFrame ? (byte)1 : (byte)0;
			IsVisibleX = isVisibleX ? (byte)1 : (byte)0;
			IsVisibleY = isVisibleY ? (byte)1 : (byte)0;
			IsRequestOutput = isRequestOutput ? (byte)1 : (byte)0;
			IsSkipItems = isSkipItems ? (byte)1 : (byte)0;
			IsPreserveWidthAuto = isPreserveWidthAuto ? (byte)1 : (byte)0;
			NavLayerCurrent = navLayerCurrent;
			AutoFitQueue = autoFitQueue;
			CannotSkipItemsQueue = cannotSkipItemsQueue;
			SortDirection = sortDirection;
			SortDirectionsAvailCount = sortDirectionsAvailCount;
			SortDirectionsAvailMask = sortDirectionsAvailMask;
			SortDirectionsAvailList = sortDirectionsAvailList;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiTableColumnPtr : IEquatable<ImGuiTableColumnPtr>
	{
		public ImGuiTableColumnPtr(ImGuiTableColumn* handle) { Handle = handle; }

		public ImGuiTableColumn* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiTableColumnPtr Null => new ImGuiTableColumnPtr(null);

		public ImGuiTableColumn this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiTableColumnPtr(ImGuiTableColumn* handle) => new ImGuiTableColumnPtr(handle);

		public static implicit operator ImGuiTableColumn*(ImGuiTableColumnPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiTableColumnPtr left, ImGuiTableColumnPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiTableColumnPtr left, ImGuiTableColumnPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiTableColumnPtr left, ImGuiTableColumn* right) => left.Handle == right;

		public static bool operator !=(ImGuiTableColumnPtr left, ImGuiTableColumn* right) => left.Handle != right;

		public bool Equals(ImGuiTableColumnPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiTableColumnPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiTableColumnPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiTableColumnFlags Flags => ref Unsafe.AsRef<ImGuiTableColumnFlags>(&Handle->Flags);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float WidthGiven => ref Unsafe.AsRef<float>(&Handle->WidthGiven);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float MinX => ref Unsafe.AsRef<float>(&Handle->MinX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float MaxX => ref Unsafe.AsRef<float>(&Handle->MaxX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float WidthRequest => ref Unsafe.AsRef<float>(&Handle->WidthRequest);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float WidthAuto => ref Unsafe.AsRef<float>(&Handle->WidthAuto);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float StretchWeight => ref Unsafe.AsRef<float>(&Handle->StretchWeight);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float InitStretchWeightOrWidth => ref Unsafe.AsRef<float>(&Handle->InitStretchWeightOrWidth);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&Handle->ClipRect);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint UserID => ref Unsafe.AsRef<uint>(&Handle->UserID);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float WorkMinX => ref Unsafe.AsRef<float>(&Handle->WorkMinX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float WorkMaxX => ref Unsafe.AsRef<float>(&Handle->WorkMaxX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ItemWidth => ref Unsafe.AsRef<float>(&Handle->ItemWidth);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ContentMaxXFrozen => ref Unsafe.AsRef<float>(&Handle->ContentMaxXFrozen);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ContentMaxXUnfrozen => ref Unsafe.AsRef<float>(&Handle->ContentMaxXUnfrozen);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ContentMaxXHeadersUsed => ref Unsafe.AsRef<float>(&Handle->ContentMaxXHeadersUsed);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ContentMaxXHeadersIdeal => ref Unsafe.AsRef<float>(&Handle->ContentMaxXHeadersIdeal);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref short NameOffset => ref Unsafe.AsRef<short>(&Handle->NameOffset);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte DisplayOrder => ref Unsafe.AsRef<sbyte>(&Handle->DisplayOrder);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte IndexWithinEnabledSet => ref Unsafe.AsRef<sbyte>(&Handle->IndexWithinEnabledSet);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte PrevEnabledColumn => ref Unsafe.AsRef<sbyte>(&Handle->PrevEnabledColumn);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte NextEnabledColumn => ref Unsafe.AsRef<sbyte>(&Handle->NextEnabledColumn);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref sbyte SortOrder => ref Unsafe.AsRef<sbyte>(&Handle->SortOrder);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte DrawChannelCurrent => ref Unsafe.AsRef<byte>(&Handle->DrawChannelCurrent);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte DrawChannelFrozen => ref Unsafe.AsRef<byte>(&Handle->DrawChannelFrozen);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte DrawChannelUnfrozen => ref Unsafe.AsRef<byte>(&Handle->DrawChannelUnfrozen);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsEnabled => ref Unsafe.AsRef<bool>(&Handle->IsEnabled);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsUserEnabled => ref Unsafe.AsRef<bool>(&Handle->IsUserEnabled);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsUserEnabledNextFrame => ref Unsafe.AsRef<bool>(&Handle->IsUserEnabledNextFrame);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsVisibleX => ref Unsafe.AsRef<bool>(&Handle->IsVisibleX);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsVisibleY => ref Unsafe.AsRef<bool>(&Handle->IsVisibleY);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsRequestOutput => ref Unsafe.AsRef<bool>(&Handle->IsRequestOutput);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsSkipItems => ref Unsafe.AsRef<bool>(&Handle->IsSkipItems);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsPreserveWidthAuto => ref Unsafe.AsRef<bool>(&Handle->IsPreserveWidthAuto);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte NavLayerCurrent => ref Unsafe.AsRef<byte>(&Handle->NavLayerCurrent);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte AutoFitQueue => ref Unsafe.AsRef<byte>(&Handle->AutoFitQueue);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte CannotSkipItemsQueue => ref Unsafe.AsRef<byte>(&Handle->CannotSkipItemsQueue);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte SortDirection => ref Unsafe.AsRef<byte>(&Handle->SortDirection);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte SortDirectionsAvailCount => ref Unsafe.AsRef<byte>(&Handle->SortDirectionsAvailCount);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte SortDirectionsAvailMask => ref Unsafe.AsRef<byte>(&Handle->SortDirectionsAvailMask);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte SortDirectionsAvailList => ref Unsafe.AsRef<byte>(&Handle->SortDirectionsAvailList);
	}

}