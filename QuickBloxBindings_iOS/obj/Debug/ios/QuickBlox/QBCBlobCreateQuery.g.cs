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
	[Register("QBCBlobCreateQuery", true)]
	public unsafe partial class QBCBlobCreateQuery : NSObject {
		[CompilerGenerated]
		const string selBlob = "blob";
		static readonly IntPtr selBlobHandle = Selector.GetHandle ("blob");
		[CompilerGenerated]
		const string selInitWithBlob_ = "initWithBlob:";
		static readonly IntPtr selInitWithBlob_Handle = Selector.GetHandle ("initWithBlob:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBCBlobCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithBlob:")]
		[CompilerGenerated]
		public QBCBlobCreateQuery (QBCBlob blob)
			: base (NSObjectFlag.Empty)
		{
			if (blob == null)
				throw new ArgumentNullException ("blob");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithBlob_Handle, blob.Handle), "initWithBlob:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithBlob_Handle, blob.Handle), "initWithBlob:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Blob_var;
		[CompilerGenerated]
		public virtual QBCBlob Blob {
			[Export ("blob")]
			get {
				QBCBlob ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobHandle));
				}
				MarkDirty ();
				__mt_Blob_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Blob_var = null;
			}
		}
	} /* class QBCBlobCreateQuery */
}
