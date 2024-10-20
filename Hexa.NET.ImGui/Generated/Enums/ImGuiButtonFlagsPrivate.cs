// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum ImGuiButtonFlagsPrivate : int
	{
		/// <summary>
		/// return true on click (mouse down event)<br/>
		/// </summary>
		PressedOnClick = unchecked(16),

		/// <summary>
		/// [Default] return true on click + release on same item &lt;-- this is what the majority of Button are using<br/>
		/// </summary>
		PressedOnClickRelease = unchecked(32),

		/// <summary>
		/// return true on click + release even if the release event is not done while hovering the item<br/>
		/// </summary>
		PressedOnClickReleaseAnywhere = unchecked(64),

		/// <summary>
		/// return true on release (default requires click+release)<br/>
		/// </summary>
		PressedOnRelease = unchecked(128),

		/// <summary>
		/// return true on double-click (default requires click+release)<br/>
		/// </summary>
		PressedOnDoubleClick = unchecked(256),

		/// <summary>
		/// return true when held into while we are drag and dropping another item (used by e.g. tree nodes, collapsing headers)<br/>
		/// </summary>
		PressedOnDragDropHold = unchecked(512),

		/// <summary>
		/// allow interactions even if a child window is overlapping<br/>
		/// </summary>
		FlattenChildren = unchecked(2048),

		/// <summary>
		/// require previous frame HoveredId to either match id or be null before being usable.<br/>
		/// </summary>
		AllowOverlap = unchecked(4096),

		/// <summary>
		/// vertically align button to match text baseline - ButtonEx() only  FIXME: Should be removed and handled by SmallButton(), not possible currently because of DC.CursorPosPrevLine<br/>
		/// </summary>
		AlignTextBaseLine = unchecked(32768),

		/// <summary>
		/// disable mouse interaction if a key modifier is held<br/>
		/// </summary>
		NoKeyModsAllowed = unchecked(65536),

		/// <summary>
		/// don't set ActiveId while holding the mouse (ImGuiButtonFlags_PressedOnClick only)<br/>
		/// </summary>
		NoHoldingActiveId = unchecked(131072),

		/// <summary>
		/// don't override navigation focus when activated (FIXME: this is essentially used every time an item uses ImGuiItemFlags_NoNav, but because legacy specs don't requires LastItemData to be set ButtonBehavior(), we can't poll g.LastItemData.ItemFlags)<br/>
		/// </summary>
		NoNavFocus = unchecked(262144),

		/// <summary>
		/// don't report as hovered when nav focus is on this item<br/>
		/// </summary>
		NoHoveredOnFocus = unchecked(524288),

		/// <summary>
		/// don't set keyinput owner on the initial click (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)<br/>
		/// </summary>
		NoSetKeyOwner = unchecked(1048576),

		/// <summary>
		/// don't test keyinput owner when polling the key (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)<br/>
		/// </summary>
		NoTestKeyOwner = unchecked(2097152),

		/// <summary>
		/// To be documented.
		/// </summary>
		PressedOnMask = unchecked(1008),

		/// <summary>
		/// To be documented.
		/// </summary>
		PressedOnDefault = PressedOnClickRelease,
	}
}
