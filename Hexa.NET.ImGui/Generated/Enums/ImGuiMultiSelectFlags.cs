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
	public enum ImGuiMultiSelectFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// Disable selecting more than one item. This is available to allow single-selection code to share same codelogic if desired. It essentially disables the main purpose of BeginMultiSelect() tho!<br/>
		/// </summary>
		SingleSelect = unchecked(1),

		/// <summary>
		/// Disable CTRL+A shortcut to select all.<br/>
		/// </summary>
		NoSelectAll = unchecked(2),

		/// <summary>
		/// Disable Shift+selection mousekeyboard support (useful for unordered 2D selection). With BoxSelect is also ensure contiguous SetRange requests are not combined into one. This allows not handling interpolation in SetRange requests.<br/>
		/// </summary>
		NoRangeSelect = unchecked(4),

		/// <summary>
		/// Disable selecting items when navigating (useful for e.g. supporting range-select in a list of checkboxes).<br/>
		/// </summary>
		NoAutoSelect = unchecked(8),

		/// <summary>
		/// Disable clearing selection when navigating or selecting another one (generally used with ImGuiMultiSelectFlags_NoAutoSelect. useful for e.g. supporting range-select in a list of checkboxes).<br/>
		/// </summary>
		NoAutoClear = unchecked(16),

		/// <summary>
		/// Disable clearing selection when clickingselecting an already selected item.<br/>
		/// </summary>
		NoAutoClearOnReselect = unchecked(32),

		/// <summary>
		/// Enable box-selection with same width and same x pos items (e.g. full row Selectable()). Box-selection works better with little bit of spacing between items hit-box in order to be able to aim at empty space.<br/>
		/// </summary>
		BoxSelect1D = unchecked(64),

		/// <summary>
		/// Enable box-selection with varying width or varying x pos items support (e.g. different width labels, or 2D layoutgrid). This is slower: alters clipping logic so that e.g. horizontal movements will update selection of normally clipped items.<br/>
		/// </summary>
		BoxSelect2D = unchecked(128),

		/// <summary>
		/// Disable scrolling when box-selecting near edges of scope.<br/>
		/// </summary>
		BoxSelectNoScroll = unchecked(256),

		/// <summary>
		/// Clear selection when pressing Escape while scope is focused.<br/>
		/// </summary>
		ClearOnEscape = unchecked(512),

		/// <summary>
		/// Clear selection when clicking on empty location within scope.<br/>
		/// </summary>
		ClearOnClickVoid = unchecked(1024),

		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is whole window (Default). Use if BeginMultiSelect() covers a whole window or used a single time in same window.<br/>
		/// </summary>
		ScopeWindow = unchecked(2048),

		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is rectangle encompassing BeginMultiSelect()EndMultiSelect(). Use if BeginMultiSelect() is called multiple times in same window.<br/>
		/// </summary>
		ScopeRect = unchecked(4096),

		/// <summary>
		/// Apply selection on mouse down when clicking on unselected item. (Default)<br/>
		/// </summary>
		OnClick = unchecked(8192),

		/// <summary>
		/// Apply selection on mouse release when clicking an unselected item. Allow dragging an unselected item without altering selection.<br/>
		/// </summary>
		OnClickRelease = unchecked(16384),

		/// <summary>
		/// [Temporary] Enable navigation wrapping on X axis. Provided as a convenience because we don't have a design for the general Nav API for this yet. When the more general feature be public we may obsolete this flag in favor of new one.<br/>
		/// </summary>
		NavWrapX = unchecked(65536),
	}
}