// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Environment Probe can capture space around the objects to provide reflections.
	/// </summary>
	[Serializable]
	public sealed partial class EnvironmentProbe : Actor
	{
		/// <summary>
		/// Creates new <see cref="EnvironmentProbe"/> object.
		/// </summary>
		private EnvironmentProbe() : base()
		{
		}

		/// <summary>
		/// Creates new instance of <see cref="EnvironmentProbe"/> object.
		/// </summary>
		/// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public static EnvironmentProbe New() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			return Internal_Create(typeof(EnvironmentProbe)) as EnvironmentProbe;
#endif
		}

		/// <summary>
		/// Gets or sets probe brightness parameter.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(10), Limit(0, 1000, 0.01f), EditorDisplay("Probe"), Tooltip("Reflections brightness")]
		public float Brightness
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetBrightness(unmanagedPtr); }
			set { Internal_SetBrightness(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets probe radius.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(20), Limit(0), EditorDisplay("Probe"), Tooltip("Probe radius")]
		public float Radius
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetRadius(unmanagedPtr); }
			set { Internal_SetRadius(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets value indicating if probe should be updated automaticlly on change.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(30), EditorDisplay("Probe"), Tooltip("Enable auto probe update on transform changed")]
		public bool AutoUpdate
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetAutoUpdate(unmanagedPtr); }
			set { Internal_SetAutoUpdate(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the probe capture camera near plane distance..
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(30), Limit(0, float.MaxValue, 0.01f), EditorDisplay("Probe"), Tooltip("The probe capture camera near plane distance.")]
		public float CaptureNearPlane
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetCaptureNearPlane(unmanagedPtr); }
			set { Internal_SetCaptureNearPlane(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the custom probe texture to be used during reflections pass rendering. Use null if disable custom probe feature.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(40), EditorDisplay("Probe"), Tooltip("Custom probe to override baked probe")]
		public CubeTexture CustomProbe
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetCustomProbe(unmanagedPtr); }
			set { Internal_SetCustomProbe(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
		}

		/// <summary>
		/// Gets the probe texture used during rendering (baked or custom one).
		/// </summary>
		[UnmanagedCall]
		public CubeTexture Probe
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetProbe(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Requests probe texture baking. It won't be performed now but on async graphics rendering task.
		/// </summary>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public void Bake() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			Internal_Bake(unmanagedPtr);
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetBrightness(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetBrightness(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetRadius(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetRadius(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetAutoUpdate(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetAutoUpdate(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetCaptureNearPlane(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetCaptureNearPlane(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern CubeTexture Internal_GetCustomProbe(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetCustomProbe(IntPtr obj, IntPtr val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern CubeTexture Internal_GetProbe(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Bake(IntPtr obj);
#endif
#endregion
	}
}

