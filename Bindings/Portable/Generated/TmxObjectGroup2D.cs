// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// TmxObjectGroup2D.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Urho2D
{
	/// <summary>
	/// Tmx objects layer.
	/// </summary>
	public unsafe partial class TmxObjectGroup2D : TmxLayer2D
	{
		unsafe partial void OnTmxObjectGroup2DCreated ();

		[Preserve]
		public TmxObjectGroup2D (IntPtr handle) : base (handle)
		{
			OnTmxObjectGroup2DCreated ();
		}

		[Preserve]
		protected TmxObjectGroup2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnTmxObjectGroup2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxObjectGroup2D_TmxObjectGroup2D (IntPtr tmxFile);

		[Preserve]
		public TmxObjectGroup2D (TmxFile2D tmxFile) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(TmxObjectGroup2D));
			handle = TmxObjectGroup2D_TmxObjectGroup2D ((object)tmxFile == null ? IntPtr.Zero : tmxFile.Handle);
			Runtime.RegisterObject (this);
			OnTmxObjectGroup2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxObjectGroup2D_Load (IntPtr handle, IntPtr element, ref Urho.Urho2D.TileMapInfo2D info);

		/// <summary>
		/// Load from XML element.
		/// </summary>
		public bool Load (XmlElement element, Urho.Urho2D.TileMapInfo2D info)
		{
			Runtime.ValidateRefCounted (this);
			return TmxObjectGroup2D_Load (handle, (object)element == null ? IntPtr.Zero : element.Handle, ref info);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint TmxObjectGroup2D_GetNumObjects (IntPtr handle);

		/// <summary>
		/// Return number of objects.
		/// </summary>
		private uint GetNumObjects ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxObjectGroup2D_GetNumObjects (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxObjectGroup2D_GetObject (IntPtr handle, uint index);

		/// <summary>
		/// Return tile map object at index.
		/// </summary>
		public TileMapObject2D GetObject (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<TileMapObject2D> (TmxObjectGroup2D_GetObject (handle, index));
		}

		/// <summary>
		/// Return number of objects.
		/// </summary>
		public uint NumObjects {
			get {
				return GetNumObjects ();
			}
		}
	}
}
