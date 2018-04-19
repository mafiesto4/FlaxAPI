// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using FlaxEditor.SceneGraph.Actors;
using FlaxEngine;

namespace FlaxEditor.SceneGraph.GUI
{
    /// <summary>
    /// A <see cref="ActorTreeNode"/> custom implementation for <see cref="SceneNode"/>.
    /// </summary>
    /// <seealso cref="FlaxEditor.SceneGraph.GUI.ActorTreeNode" />
    public sealed class SceneTreeNode : ActorTreeNode
    {
        /// <inheritdoc />
        public override void UpdateText()
        {
            base.UpdateText();

            // Append star character to modified scenes
            if (ActorNode is SceneNode node && node.IsEdited)
                Text += "*";
        }

        /// <inheritdoc />
        protected override Color CacheTextColor()
        {
            return Color.White;
        }
    }
}
