// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Sky actor renders atmosphere around the scene with fog and sky
	/// </summary>
	[Serializable]
	public sealed partial class Sky : Actor
	{
		/// <summary>
		/// Creates new <see cref="Sky"/> object.
		/// </summary>
		private Sky() : base()
		{
		}

		/// <summary>
		/// Creates new instance of <see cref="Sky"/> object.
		/// </summary>
		/// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public static Sky New() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			return Internal_Create(typeof(Sky)) as Sky;
#endif
		}

		/// <summary>
		/// Gets or sets linked directional light actor that is used to simulate the sun.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(10), EditorDisplay("Sun"), Tooltip("Directional light used to simulate the sun")]
		public DirectionalLight SunLight
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetSunLight(unmanagedPtr); }
			set { Internal_SetSunLight(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
		}

		/// <summary>
		/// Gets or sets the sun disc scale.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(20), EditorDisplay("Sun"), Tooltip("Sun disc scale"), Limit(0, 100, 0.01f)]
		public float SunDiscScale
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetSunDiscScale(unmanagedPtr); }
			set { Internal_SetSunDiscScale(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the sun power.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(30), EditorDisplay("Sun"), Tooltip("Sun light power"), Limit(0, 1000, 0.01f)]
		public float SunPower
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetSunPower(unmanagedPtr); }
			set { Internal_SetSunPower(unmanagedPtr, value); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern DirectionalLight Internal_GetSunLight(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetSunLight(IntPtr obj, IntPtr val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetSunDiscScale(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetSunDiscScale(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetSunPower(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetSunPower(IntPtr obj, float val);
#endif
#endregion
	}
}

