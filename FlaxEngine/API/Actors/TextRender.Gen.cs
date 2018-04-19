// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Text rendering object.
	/// </summary>
	[Serializable]
	public sealed partial class TextRender : Actor
	{
		/// <summary>
		/// Creates new <see cref="TextRender"/> object.
		/// </summary>
		private TextRender() : base()
		{
		}

		/// <summary>
		/// Creates new instance of <see cref="TextRender"/> object.
		/// </summary>
		/// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public static TextRender New() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			return Internal_Create(typeof(TextRender)) as TextRender;
#endif
		}

		/// <summary>
		/// Gets or sets text to render.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(0), MultilineText, EditorDisplay("Text"), Tooltip("Text to render")]
		public string Text
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetText(unmanagedPtr); }
			set { Internal_SetText(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets text color.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(10), EditorDisplay("Text"), Tooltip("Color of the text")]
		public Color Color
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { Color resultAsRef; Internal_GetColor(unmanagedPtr, out resultAsRef); return resultAsRef; }
			set { Internal_SetColor(unmanagedPtr, ref value); }
#endif
		}

		/// <summary>
		/// Gets or sets the material used for the text rendering.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(20), AssetReference(true), EditorDisplay("Text"), Tooltip("Material to use for rendering")]
		public MaterialBase Material
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetMaterial(unmanagedPtr); }
			set { Internal_SetMaterial(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
		}

		/// <summary>
		/// Gets or sets the font asset used as a text characters source.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(30), AssetReference(true), EditorDisplay("Text"), Tooltip("Font to use for rendering")]
		public FontAsset Font
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetFont(unmanagedPtr); }
			set { Internal_SetFont(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
		}

		/// <summary>
		/// Gets or sets the font characters size.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(40), Limit(1, 1000), EditorDisplay("Text"), Tooltip("Size of the font characters")]
		public int FontSize
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetFontSize(unmanagedPtr); }
			set { Internal_SetFontSize(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the shadows casting mode by this visual element.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(80), EditorDisplay("Text"), Tooltip("Shadows casting mode by this visual element")]
		public ShadowsCastingMode ShadowsMode
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetShadowsMode(unmanagedPtr); }
			set { Internal_SetShadowsMode(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the text layout area rectangle.
		/// </summary>
		/// <remarks>
		/// Layout is defined in local space of the object (on XY plane).
		/// </remarks>
		[UnmanagedCall]
		[EditorOrder(100), EditorDisplay("Layout"), Tooltip("Layout area rectangle in local space of the object (on XY plane)")]
		public Rectangle Bounds
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { Rectangle resultAsRef; Internal_GetBounds(unmanagedPtr, out resultAsRef); return resultAsRef; }
			set { Internal_SetBounds(unmanagedPtr, ref value); }
#endif
		}

		/// <summary>
		/// Gets or sets the text horizontal alignment inside the layout rectangle.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(130), EditorDisplay("Layout"), Tooltip("Text horizontal alignment inside the layout rectangle")]
		public TextAlignment HorizontalAlignment
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetHorizontalAlignment(unmanagedPtr); }
			set { Internal_SetHorizontalAlignment(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the text vertical alignment inside the layout rectangle.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(130), EditorDisplay("Layout"), Tooltip("Text vertical alignment inside the layout rectangle")]
		public TextAlignment VerticalAlignment
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetVerticalAlignment(unmanagedPtr); }
			set { Internal_SetVerticalAlignment(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the text wrapping mode inside the layout bounds.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(130), EditorDisplay("Layout"), Tooltip("Text wrapping mode inside the layout bounds")]
		public TextWrapping TextWrapping
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetTextWrapping(unmanagedPtr); }
			set { Internal_SetTextWrapping(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the scale parameter for lines gap size
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(140), Limit(-1000, 1000, 0.01f), EditorDisplay("Layout"), Tooltip("Scale parameter for the lines gap")]
		public float BaseLinesGapScale
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetBaseLinesGapScale(unmanagedPtr); }
			set { Internal_SetBaseLinesGapScale(unmanagedPtr, value); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetText(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetText(IntPtr obj, string val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetColor(IntPtr obj, out Color resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetColor(IntPtr obj, ref Color val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MaterialBase Internal_GetMaterial(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetMaterial(IntPtr obj, IntPtr val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FontAsset Internal_GetFont(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetFont(IntPtr obj, IntPtr val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetFontSize(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetFontSize(IntPtr obj, int val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern ShadowsCastingMode Internal_GetShadowsMode(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetShadowsMode(IntPtr obj, ShadowsCastingMode val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetBounds(IntPtr obj, out Rectangle resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetBounds(IntPtr obj, ref Rectangle val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern TextAlignment Internal_GetHorizontalAlignment(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetHorizontalAlignment(IntPtr obj, TextAlignment val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern TextAlignment Internal_GetVerticalAlignment(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetVerticalAlignment(IntPtr obj, TextAlignment val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern TextWrapping Internal_GetTextWrapping(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetTextWrapping(IntPtr obj, TextWrapping val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetBaseLinesGapScale(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetBaseLinesGapScale(IntPtr obj, float val);
#endif
#endregion
	}
}

