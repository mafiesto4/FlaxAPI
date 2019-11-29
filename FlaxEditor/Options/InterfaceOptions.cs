// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.

using System.ComponentModel;
using FlaxEngine;

namespace FlaxEditor.Options
{
    /// <summary>
    /// Editor interface options data container.
    /// </summary>
    [CustomEditor(typeof(Editor<InterfaceOptions>))]
    public class InterfaceOptions
    {
        /// <summary>
        /// The log timestamp modes.
        /// </summary>
        public enum TimestampsFormats
        {
            /// <summary>
            /// No prefix.
            /// </summary>
            None,

            /// <summary>
            /// The UTC time format.
            /// </summary>
            Utc,

            /// <summary>
            /// The local time format.
            /// </summary>
            LocalTime,

            /// <summary>
            /// The time since startup (in seconds).
            /// </summary>
            TimeSinceStartup,
        }

        /// <summary>
        /// Gets or sets a value indicating whether show selected camera preview in the editor window.
        /// </summary>
        [DefaultValue(true)]
        [EditorDisplay("Interface"), EditorOrder(80), Tooltip("Determines whether show selected camera preview in the edit window.")]
        public bool ShowSelectedCameraPreview { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether center mouse position on window focus in play mode. Helps when working with games that lock mouse cursor.
        /// </summary>
        [DefaultValue(false)]
        [EditorDisplay("Interface", "Center Mouse On Game Window Focus"), EditorOrder(100), Tooltip("Determines whether center mouse position on window focus in play mode. Helps when working with games that lock mouse cursor.")]
        public bool CenterMouseOnGameWinFocus { get; set; } = false;

        /// <summary>
        /// Gets or sets the timestamps prefix mode for debug log messages.
        /// </summary>
        [DefaultValue(TimestampsFormats.None)]
        [EditorDisplay("Interface"), EditorOrder(210), Tooltip("The timestamps prefix mode for debug log messages.")]
        public TimestampsFormats DebugLogTimestampsFormat { get; set; } = TimestampsFormats.None;

        /// <summary>
        /// Gets or sets a value indicating whether auto-focus game window on play mode start.
        /// </summary>
        [DefaultValue(true)]
        [EditorDisplay("Play In-Editor", "Focus Game Window On Play"), EditorOrder(200), Tooltip("Determines whether auto-focus game window on play mode start.")]
        public bool FocusGameWinOnPlay { get; set; } = true;

        private static FontAsset DefaultFont => FlaxEngine.Content.LoadInternal<FontAsset>(EditorAssets.PrimaryFont);

        /// <summary>
        /// Gets or sets the title font for editor UI.
        /// </summary>
        [EditorDisplay("Fonts"), EditorOrder(500), Tooltip("The title font for editor UI.")]
        public FontReference TitleFont { get; set; } = new FontReference(DefaultFont, 18);

        /// <summary>
        /// Gets or sets the large font for editor UI.
        /// </summary>
        [EditorDisplay("Fonts"), EditorOrder(510), Tooltip("The large font for editor UI.")]
        public FontReference LargeFont { get; set; } = new FontReference(DefaultFont, 14);

        /// <summary>
        /// Gets or sets the medium font for editor UI.
        /// </summary>
        [EditorDisplay("Fonts"), EditorOrder(520), Tooltip("The medium font for editor UI.")]
        public FontReference MediumFont { get; set; } = new FontReference(DefaultFont, 9);

        /// <summary>
        /// Gets or sets the small font for editor UI.
        /// </summary>
        [EditorDisplay("Fonts"), EditorOrder(530), Tooltip("The small font for editor UI.")]
        public FontReference SmallFont { get; set; } = new FontReference(DefaultFont, 9);
    }
}
