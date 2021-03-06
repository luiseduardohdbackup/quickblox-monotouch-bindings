//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace QuickBlox {
	[Register("QBUUserDeleteByExternalIDQuery", true)]
	public unsafe partial class QBUUserDeleteByExternalIDQuery : NSObject {
		[CompilerGenerated]
		const string selExternalUserID = "externalUserID";
		static readonly IntPtr selExternalUserIDHandle = Selector.GetHandle ("externalUserID");
		[CompilerGenerated]
		const string selSetExternalUserID_ = "setExternalUserID:";
		static readonly IntPtr selSetExternalUserID_Handle = Selector.GetHandle ("setExternalUserID:");
		[CompilerGenerated]
		const string selInitWithExternalUserID_ = "initWithExternalUserID:";
		static readonly IntPtr selInitWithExternalUserID_Handle = Selector.GetHandle ("initWithExternalUserID:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUserDeleteByExternalIDQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUserDeleteByExternalIDQuery () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public QBUUserDeleteByExternalIDQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserDeleteByExternalIDQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserDeleteByExternalIDQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithExternalUserID:")]
		[CompilerGenerated]
		public QBUUserDeleteByExternalIDQuery (global::System.UInt32 externalUserID)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithExternalUserID_Handle, externalUserID), "initWithExternalUserID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithExternalUserID_Handle, externalUserID), "initWithExternalUserID:");
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ExternalUserID {
			[Export ("externalUserID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selExternalUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selExternalUserIDHandle);
				}
			}
			
			[Export ("setExternalUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetExternalUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetExternalUserID_Handle, value);
				}
			}
		}
		
	} /* class QBUUserDeleteByExternalIDQuery */
}
