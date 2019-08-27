// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.

using System;
using System.IO;
using FlaxEngine;
using Object = FlaxEngine.Object;

namespace FlaxEditor.GUI.Timeline.Tracks
{
    /// <summary>
    /// The timeline track for animating <see cref="FlaxEngine.Script"/> objects.
    /// </summary>
    /// <seealso cref="ObjectTrack" />
    public sealed class ScriptTrack : ObjectTrack
    {
        /// <summary>
        /// Gets the archetype.
        /// </summary>
        /// <returns>The archetype.</returns>
        public static TrackArchetype GetArchetype()
        {
            return new TrackArchetype
            {
                TypeId = 8,
                Name = "Script",
                DisableSpawnViaGUI = true,
                Create = options => new ScriptTrack(ref options),
                Load = LoadTrack,
                Save = SaveTrack,
            };
        }

        private static void LoadTrack(int version, Track track, BinaryReader stream)
        {
            var e = (ScriptTrack)track;
            e.ScriptID = new Guid(stream.ReadBytes(16));
        }

        private static void SaveTrack(Track track, BinaryWriter stream)
        {
            var e = (ScriptTrack)track;
            stream.Write(e.ScriptID.ToByteArray());
        }

        /// <summary>
        /// The object ID.
        /// </summary>
        public Guid ScriptID;

        /// <summary>
        /// Gets the object instance (it might be missing).
        /// </summary>
        public Script Script
        {
            get => Object.TryFind<Script>(ref ScriptID);
            set => ScriptID = value?.ID ?? Guid.Empty;
        }

        /// <inheritdoc />
        public ScriptTrack(ref TrackCreateOptions options)
        : base(ref options)
        {
        }

        /// <inheritdoc />
        public override Object Object => Script;

        /// <inheritdoc />
        protected override void OnShowAddContextMenu(ContextMenu.ContextMenu menu)
        {
            base.OnShowAddContextMenu(menu);

            var script = Script;
            if (script == null)
            {
                menu.AddButton("Missing script");
                return;
            }

            var type = script.GetType();
            AddObjectProperties(menu, type);
        }
    }
}