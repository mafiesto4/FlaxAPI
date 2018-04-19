// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Represents a physics mesh that can be used with a MeshCollider. Physics mesh can be a generic triangle mesh or a convex mesh.
	/// </summary>
	public partial class CollisionData : BinaryAsset
	{
		/// <summary>
		/// Creates new <see cref="CollisionData"/> object.
		/// </summary>
		private CollisionData() : base()
		{
		}

		/// <summary>
		/// Gets the type of the collision data.
		/// </summary>
		[UnmanagedCall]
		public CollisionDataType Type
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetType(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Gets the model asset used to generate a collision data.
		/// </summary>
		[UnmanagedCall]
		public Model Model
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetModel(unmanagedPtr); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern CollisionDataType Internal_GetType(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Model Internal_GetModel(IntPtr obj);
#endif
#endregion
	}
}

