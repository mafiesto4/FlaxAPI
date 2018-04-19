// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Audio clip stores audio data in a compressed or uncompressed format using a binary asset. Clips can be provided to audio sources or other audio methods to be played.
	/// </summary>
	public sealed partial class AudioClip : BinaryAsset
	{
		/// <summary>
		/// Creates new <see cref="AudioClip"/> object.
		/// </summary>
		private AudioClip() : base()
		{
		}

		/// <summary>
		/// Gets the audio data format.
		/// </summary>
		[UnmanagedCall]
		public AudioFormat Format
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetFormat(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Gets the audio data info metadata.
		/// </summary>
		/// <param name="info">The output audio data header from the asset. May be invalid if asset is not loaded.</param>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public void GetInfo(out AudioDataInfo info) 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			Internal_GetInfo(unmanagedPtr, out info);
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern AudioFormat Internal_GetFormat(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetInfo(IntPtr obj, out AudioDataInfo info);
#endif
#endregion
	}
}

