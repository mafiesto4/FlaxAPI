// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

namespace FlaxEngine.GUI.Docking
{
    /// <summary>
    /// Floating Window Dock Panel control.
    /// </summary>
    /// <seealso cref="FlaxEngine.GUI.Docking.DockPanel" />
    public class FloatWindowDockPanel : DockPanel
    {
        private MasterDockPanel _masterPanel;
        private Window _window;

        /// <summary>
        /// Gets the master panel.
        /// </summary>
        public MasterDockPanel MasterPanel => _masterPanel;

        /// <summary>
        /// Gets the window.
        /// </summary>
        public Window Window => _window;

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatWindowDockPanel"/> class.
        /// </summary>
        /// <param name="masterPanel">The master panel.</param>
        /// <param name="window">The window.</param>
        public FloatWindowDockPanel(MasterDockPanel masterPanel, Window window)
            : base(null)
        {
            _masterPanel = masterPanel;
            _window = window;

            // Link
            _masterPanel.FloatingPanels.Add(this);
            Parent = window;
            window.NativeWindow.OnClosing += onClosing;
            window.NativeWindow.OnLButtonHit += onLButtonHit;
        }

        /// <summary>
        /// Begin drag operation on the window
        /// </summary>
        public void BeginDrag()
        {
            // Filter invalid events
            if (_window == null)
                return;

            // Check if window is maximized
            if (_window.IsMaximized)
                return;

            // Create docking hint window
            DockHintWindow.Create(this);
        }

        /// <summary>
        /// Creates a floating window.
        /// </summary>
        /// <param name="parent">Parent window handle.</param>
        /// <param name="location">Client area location.</param>
        /// <param name="size">Window client area size.</param>
        /// <param name="startPosition">Window start position.</param>
        /// <param name="title">Initial window title.</param>
        internal static FlaxEngine.Window CreateFloatWindow(Window parent, Vector2 location, Vector2 size, WindowStartPosition startPosition, string title)
        {
            // Setup initial window settings
            var settings = CreateWindowSettings.Default;
            settings.Parent = parent?.NativeWindow;
            settings.Title = title;
            settings.Size = size;
            settings.Position = location;
            settings.MinimumSize = new Vector2(1);
            settings.MaximumSize = new Vector2(2000);
            settings.Fullscreen = false;
            settings.HasBorder = true;
            settings.SupportsTransparency = false;
            settings.ActivateWhenFirstShown = true;
            settings.AllowInput = true;
            settings.AllowMinimize = true;
            settings.AllowMaximize = true;
            settings.AllowDragAndDrop = true;
            settings.IsTopmost = false;
            settings.IsRegularWindow = true;
            settings.HasSizingFrame = true;
            settings.ShowAfterFirstPaint = false;
            settings.ShowInTaskbar = false;
            settings.StartPosition = startPosition;

            // Create window
            return FlaxEngine.Window.Create(settings);
        }

        private bool onLButtonHit(WindowHitCodes hitTest)
        {
            if (hitTest == WindowHitCodes.Caption)
            {
                BeginDrag();
                return true;
            }

            return false;
        }

        private void onClosing(ClosingReason reason, ref bool cancel)
        {
            // Close all docked windows
            while (Tabs.Count > 0)
            {
                if (Tabs[0].Close(reason))
                {
                    // Cancel
                    cancel = true;
                    return;
                }
            }

            // Unlink
            _window.NativeWindow.OnClosing -= onClosing;
            _window.NativeWindow.OnLButtonHit = null;
            _window = null;

            // Remove object
            Assertions.Assert.IsTrue(TabsCount == 0 && ChildPanelsCount == 0);
            Dispose();
        }

        /// <inheritdoc />
        public override bool IsFloating => true;

        /// <inheritdoc />
        public override DockState TryGetDockState(out float splitterValue)
        {
            splitterValue = 0.5f;
            return DockState.Float;
        }

        /// <inheritdoc />
        protected override void OnLastTabRemoved()
        {
            // Close window
            _window?.Close();
        }

        /// <inheritdoc />
        protected override void OnSelectedTabChanged()
        {
            base.OnSelectedTabChanged();

            if (_window != null && SelectedTab != null)
                _window.Title = SelectedTab.Title;
        }

        /// <inheritdoc />
        public override void OnDestroy()
        {
            _masterPanel?.FloatingPanels.Remove(this);

            base.OnDestroy();
        }
    }
}
