// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// UIComponent.cs
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

namespace Urho
{
	/// <summary>
	/// Construct.
	/// </summary>
	public unsafe partial class UIComponent : Component
	{
		unsafe partial void OnUIComponentCreated ();

		[Preserve]
		public UIComponent (IntPtr handle) : base (handle)
		{
			OnUIComponentCreated ();
		}

		[Preserve]
		protected UIComponent (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnUIComponentCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int UIComponent_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (UIComponent_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (UIComponent_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int UIComponent_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(UIComponent));
			return new StringHash (UIComponent_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(UIComponent));
			return Marshal.PtrToStringAnsi (UIComponent_GetTypeNameStatic ());
		}

		[Preserve]
		public UIComponent () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_UIComponent (IntPtr context);

		[Preserve]
		public UIComponent (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(UIComponent));
			handle = UIComponent_UIComponent ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnUIComponentCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void UIComponent_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(UIComponent));
			UIComponent_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_GetRoot (IntPtr handle);

		/// <summary>
		/// Return UIElement.
		/// </summary>
		private UIElement GetRoot ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<UIElement> (UIComponent_GetRoot (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_GetMaterial (IntPtr handle);

		/// <summary>
		/// Return material which will be used for rendering UI texture.
		/// </summary>
		private Material GetMaterial ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Material> (UIComponent_GetMaterial (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UIComponent_GetTexture (IntPtr handle);

		/// <summary>
		/// Return texture which will be used for rendering UI to.
		/// </summary>
		private Texture2D GetTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture2D> (UIComponent_GetTexture (handle));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return UIElement.
		/// </summary>
		public UIElement Root {
			get {
				return GetRoot ();
			}
		}

		/// <summary>
		/// Return material which will be used for rendering UI texture.
		/// </summary>
		public Material Material {
			get {
				return GetMaterial ();
			}
		}

		/// <summary>
		/// Return texture which will be used for rendering UI to.
		/// </summary>
		public Texture2D Texture {
			get {
				return GetTexture ();
			}
		}
	}
}
