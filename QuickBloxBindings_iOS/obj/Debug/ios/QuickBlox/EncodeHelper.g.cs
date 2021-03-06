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
	[Register("EncodeHelper", true)]
	public unsafe partial class EncodeHelper : NSObject {
		[CompilerGenerated]
		const string selUrlencode_ = "urlencode:";
		static readonly IntPtr selUrlencode_Handle = Selector.GetHandle ("urlencode:");
		[CompilerGenerated]
		const string selUrldecode_ = "urldecode:";
		static readonly IntPtr selUrldecode_Handle = Selector.GetHandle ("urldecode:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EncodeHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EncodeHelper () : base (NSObjectFlag.Empty)
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
		public EncodeHelper (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public EncodeHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public EncodeHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("urlencode:")]
		[CompilerGenerated]
		public static string Urlencode (string unencodedString)
		{
			if (unencodedString == null)
				throw new ArgumentNullException ("unencodedString");
			var nsunencodedString = NSString.CreateNative (unencodedString);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selUrlencode_Handle, nsunencodedString));
			NSString.ReleaseNative (nsunencodedString);
			
			return ret;
		}
		
		[Export ("urldecode:")]
		[CompilerGenerated]
		public static string Urldecode (string encodedString)
		{
			if (encodedString == null)
				throw new ArgumentNullException ("encodedString");
			var nsencodedString = NSString.CreateNative (encodedString);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selUrldecode_Handle, nsencodedString));
			NSString.ReleaseNative (nsencodedString);
			
			return ret;
		}
		
	} /* class EncodeHelper */
}
