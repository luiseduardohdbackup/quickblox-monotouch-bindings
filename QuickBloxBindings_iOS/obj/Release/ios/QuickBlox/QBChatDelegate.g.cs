//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace QuickBlox {
	[Protocol (Name = "QBChatDelegate", WrapperType = typeof (QBChatDelegateWrapper))]
	public interface IQBChatDelegate : INativeObject, IDisposable
	{
	}
	
	public static class QBChatDelegate_Extensions {
		[CompilerGenerated]
		public static void ChatDidLogin (this IQBChatDelegate This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("chatDidLogin"));
		}
		
		[CompilerGenerated]
		public static void ChatDidNotLogin (this IQBChatDelegate This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("chatDidNotLogin"));
		}
		
		[CompilerGenerated]
		public static void ChatDidNotSendMessage (this IQBChatDelegate This, QBChatMessage message, NSError error)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotSendMessage:error:"), message.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveMessage (this IQBChatDelegate This, QBChatMessage message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceiveMessage:"), message.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidFailWithError (this IQBChatDelegate This, int code)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("chatDidFailWithError:"), code);
		}
		
		[CompilerGenerated]
		public static void ChatDidReceivePresenceOfUser (this IQBChatDelegate This, global::System.UInt32 userID, string type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			var nstype = NSString.CreateNative (type);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceivePresenceOfUser:type:"), userID, nstype);
			NSString.ReleaseNative (nstype);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveContactAddRequestFromUser (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatDidReceiveContactAddRequestFromUser:"), userID);
		}
		
		[CompilerGenerated]
		public static void ChatContactListDidChange (this IQBChatDelegate This, QBContactList contactList)
		{
			if (contactList == null)
				throw new ArgumentNullException ("contactList");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatContactListDidChange:"), contactList.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveContactItemActivity (this IQBChatDelegate This, global::System.UInt32 userID, bool isOnline, string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			ApiDefinition.Messaging.void_objc_msgSend_UInt32_bool_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceiveContactItemActivity:isOnline:status:"), userID, isOnline, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveListOfRooms (this IQBChatDelegate This, NSObject[] rooms)
		{
			if (rooms == null)
				throw new ArgumentNullException ("rooms");
			var nsa_rooms = NSArray.FromNSObjects (rooms);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceiveListOfRooms:"), nsa_rooms.Handle);
			nsa_rooms.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveMessage (this IQBChatDelegate This, QBChatMessage message, string roomName)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveMessage:fromRoom:"), message.Handle, nsroomName);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveMessageFromRoomJID (this IQBChatDelegate This, QBChatMessage message, string roomJID)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveMessage:fromRoomJID:"), message.Handle, nsroomJID);
			NSString.ReleaseNative (nsroomJID);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveInformation (this IQBChatDelegate This, NSDictionary information, string roomName)
		{
			if (information == null)
				throw new ArgumentNullException ("information");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveInformation:room:"), information.Handle, nsroomName);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidCreate (this IQBChatDelegate This, string roomName)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidCreate:"), nsroomName);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidEnter (this IQBChatDelegate This, QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidEnter:"), room.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidNotEnter (this IQBChatDelegate This, string roomName, NSError error)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidNotEnter:error:"), nsroomName, error.Handle);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidNotEnterRoomWithJID (this IQBChatDelegate This, string roomJID, NSError error)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidNotEnterRoomWithJID:error:"), nsroomJID, error.Handle);
			NSString.ReleaseNative (nsroomJID);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidLeave (this IQBChatDelegate This, string roomName)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidLeave:"), nsroomName);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidLeaveRoomWithJID (this IQBChatDelegate This, string roomJID)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidLeaveRoomWithJID:"), nsroomJID);
			NSString.ReleaseNative (nsroomJID);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidDestroy (this IQBChatDelegate This, string roomName)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidDestroy:"), nsroomName);
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidChangeOnlineUsers (this IQBChatDelegate This, NSObject[] onlineUsers, string roomName)
		{
			if (onlineUsers == null)
				throw new ArgumentNullException ("onlineUsers");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsa_onlineUsers = NSArray.FromNSObjects (onlineUsers);
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidChangeOnlineUsers:room:"), nsa_onlineUsers.Handle, nsroomName);
			nsa_onlineUsers.Dispose ();
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidChangeOnlineUsersFromRoomJID (this IQBChatDelegate This, NSObject[] onlineUsers, string roomJID)
		{
			if (onlineUsers == null)
				throw new ArgumentNullException ("onlineUsers");
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsa_onlineUsers = NSArray.FromNSObjects (onlineUsers);
			var nsroomJID = NSString.CreateNative (roomJID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidChangeOnlineUsers:roomJID:"), nsa_onlineUsers.Handle, nsroomJID);
			nsa_onlineUsers.Dispose ();
			NSString.ReleaseNative (nsroomJID);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveListOfUsers (this IQBChatDelegate This, NSObject[] users, string roomName)
		{
			if (users == null)
				throw new ArgumentNullException ("users");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsa_users = NSArray.FromNSObjects (users);
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveListOfUsers:room:"), nsa_users.Handle, nsroomName);
			nsa_users.Dispose ();
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveListOfOnlineUsers (this IQBChatDelegate This, NSObject[] users, string roomName)
		{
			if (users == null)
				throw new ArgumentNullException ("users");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsa_users = NSArray.FromNSObjects (users);
			var nsroomName = NSString.CreateNative (roomName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveListOfOnlineUsers:room:"), nsa_users.Handle, nsroomName);
			nsa_users.Dispose ();
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[CompilerGenerated]
		public static void ChatRoomDidReceiveListOfOnlineUsersFromRoomJID (this IQBChatDelegate This, NSObject[] users, string roomJID)
		{
			if (users == null)
				throw new ArgumentNullException ("users");
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsa_users = NSArray.FromNSObjects (users);
			var nsroomJID = NSString.CreateNative (roomJID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatRoomDidReceiveListOfOnlineUsers:roomJID:"), nsa_users.Handle, nsroomJID);
			nsa_users.Dispose ();
			NSString.ReleaseNative (nsroomJID);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveCallRequestFromUser (this IQBChatDelegate This, global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType)
		{
			if (sessionID == null)
				throw new ArgumentNullException ("sessionID");
			var nssessionID = NSString.CreateNative (sessionID);
			
			ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:"), userID, nssessionID, (UInt32)conferenceType);
			NSString.ReleaseNative (nssessionID);
			
		}
		
		[CompilerGenerated]
		public static void chatDidReceiveCallRequestFromUserWithParameters (this IQBChatDelegate This, global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters)
		{
			if (sessionID == null)
				throw new ArgumentNullException ("sessionID");
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			var nssessionID = NSString.CreateNative (sessionID);
			
			ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_UInt32_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:"), userID, nssessionID, (UInt32)conferenceType, customParameters.Handle);
			NSString.ReleaseNative (nssessionID);
			
		}
		
		[CompilerGenerated]
		public static void CallUserDidNotAnswer (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatCallUserDidNotAnswer:"), userID);
		}
		
		[CompilerGenerated]
		public static void CallDidAcceptByUser (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatCallDidAcceptByUser:"), userID);
		}
		
		[CompilerGenerated]
		public static void CallDidAcceptByUserWithCustomParameters (this IQBChatDelegate This, global::System.UInt32 userID, NSDictionary customParameters)
		{
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("chatCallDidAcceptByUser:customParameters:"), userID, customParameters.Handle);
		}
		
		[CompilerGenerated]
		public static void CallDidRejectByUser (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatCallDidRejectByUser:"), userID);
		}
		
		[CompilerGenerated]
		public static void CallDidStopByUser (this IQBChatDelegate This, global::System.UInt32 userID, string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("chatCallDidStopByUser:status:"), userID, nsstatus);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[CompilerGenerated]
		public static void CallDidStopByUserWithCustomParameters (this IQBChatDelegate This, global::System.UInt32 userID, string status, NSDictionary customParameters)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			var nsstatus = NSString.CreateNative (status);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatCallDidStopByUser:status:customParameters:"), userID, nsstatus, customParameters.Handle);
			NSString.ReleaseNative (nsstatus);
			
		}
		
		[CompilerGenerated]
		public static void CallDidStartWithUser (this IQBChatDelegate This, global::System.UInt32 userID, string sessionID)
		{
			if (sessionID == null)
				throw new ArgumentNullException ("sessionID");
			var nssessionID = NSString.CreateNative (sessionID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("chatCallDidStartWithUser:sessionID:"), userID, nssessionID);
			NSString.ReleaseNative (nssessionID);
			
		}
		
		[CompilerGenerated]
		public static void DidStartUseTURNForVideoChat (this IQBChatDelegate This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didStartUseTURNForVideoChat"));
		}
		
		[CompilerGenerated]
		public static void DidReceiveAudioBuffe (this IQBChatDelegate This, global::MonoTouch.AudioToolbox.AudioBuffer buffer)
		{
			ApiDefinition.Messaging.void_objc_msgSend_AudioBuffer (This.Handle, Selector.GetHandle ("didReceiveAudioBuffer:"), buffer);
		}
		
		[CompilerGenerated]
		public static void ChatDidReceivePrivacyListNames (this IQBChatDelegate This, NSObject[] listNames)
		{
			if (listNames == null)
				throw new ArgumentNullException ("listNames");
			var nsa_listNames = NSArray.FromNSObjects (listNames);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceivePrivacyListNames:"), nsa_listNames.Handle);
			nsa_listNames.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void ChatDidReceivePrivacyList (this IQBChatDelegate This, QBPrivacyList privacyList)
		{
			if (privacyList == null)
				throw new ArgumentNullException ("privacyList");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidReceivePrivacyList:"), privacyList.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidNotReceivePrivacyListNames (this IQBChatDelegate This, NSObject error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotReceivePrivacyListNamesDueToError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidNotReceivePrivacyListWithName (this IQBChatDelegate This, string name, NSObject error)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotReceivePrivacyListWithName:error:"), nsname, error.Handle);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidSetPrivacyListWithName (this IQBChatDelegate This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidSetPrivacyListWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidSetActivePrivacyListWithName (this IQBChatDelegate This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidSetActivePrivacyListWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidSetDefaultPrivacyListWithNam (this IQBChatDelegate This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidSetDefaultPrivacyListWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidNotSetPrivacyListWithName (this IQBChatDelegate This, string name, NSObject error)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotSetPrivacyListWithName:error:"), nsname, error.Handle);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidNotSetActivePrivacyListWithName (this IQBChatDelegate This, string name, NSObject error)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotSetActivePrivacyListWithName:error:"), nsname, error.Handle);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidNotSetDefaultPrivacyListWithName (this IQBChatDelegate This, string name, NSObject error)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatDidNotSetDefaultPrivacyListWithName:error:"), nsname, error.Handle);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidRemovedPrivacyListWithName (this IQBChatDelegate This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidRemovedPrivacyListWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveUserIsTypingFromUserWithID (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatDidReceiveUserIsTypingFromUserWithID:"), userID);
		}
		
		[CompilerGenerated]
		public static void ChatDidReceiveUserStopTypingFromUserWithID (this IQBChatDelegate This, global::System.UInt32 userID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatDidReceiveUserStopTypingFromUserWithID:"), userID);
		}
		
		[CompilerGenerated]
		public static void ChatDidDeliverMessageWithPacketID (this IQBChatDelegate This, string packetID)
		{
			if (packetID == null)
				throw new ArgumentNullException ("packetID");
			var nspacketID = NSString.CreateNative (packetID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatDidDeliverMessageWithPacketID:"), nspacketID);
			NSString.ReleaseNative (nspacketID);
			
		}
		
		[CompilerGenerated]
		public static void ChatTURNServerDidDisconnect (this IQBChatDelegate This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("chatTURNServerDidDisconnect"));
		}
		
		[CompilerGenerated]
		public static void ChatTURNServerdidFailWithError (this IQBChatDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("chatTURNServerdidFailWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatDidPassConnectionStep (this IQBChatDelegate This, global::System.UInt32 step, global::System.UInt32 totalSteps)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (This.Handle, Selector.GetHandle ("chatDidPassConnectionStep:totalSteps:"), step, totalSteps);
		}
		
		[CompilerGenerated]
		public static void ChatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount (this IQBChatDelegate This, global::System.UInt32 operationsInQueue)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount:"), operationsInQueue);
		}
		
		[CompilerGenerated]
		public static void ChatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount (this IQBChatDelegate This, global::System.UInt32 operationsInQueue)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("chatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount:"), operationsInQueue);
		}
		
	}
	
	internal sealed class QBChatDelegateWrapper : IQBChatDelegate {
		public IntPtr Handle { get; set; }
		
		public QBChatDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public QBChatDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    global::MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~QBChatDelegateWrapper ()
		{
			Dispose ();
		}
		
		public void Dispose ()
		{
			if (Handle != IntPtr.Zero) {
				global::MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("release"));
				Handle = IntPtr.Zero;
			}
			GC.SuppressFinalize (this);
		}
		
	}
}
namespace QuickBlox {
	[Protocol]
	[Register("QBChatDelegate", true)]
	[Model]
	public unsafe partial class QBChatDelegate : NSObject, IQBChatDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatDelegate () : base (NSObjectFlag.Empty)
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
		public QBChatDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("chatCallDidAcceptByUser:")]
		[CompilerGenerated]
		public virtual void CallDidAcceptByUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidAcceptByUser:customParameters:")]
		[CompilerGenerated]
		public virtual void CallDidAcceptByUserWithCustomParameters (global::System.UInt32 userID, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidRejectByUser:")]
		[CompilerGenerated]
		public virtual void CallDidRejectByUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStartWithUser:sessionID:")]
		[CompilerGenerated]
		public virtual void CallDidStartWithUser (global::System.UInt32 userID, string sessionID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStopByUser:status:")]
		[CompilerGenerated]
		public virtual void CallDidStopByUser (global::System.UInt32 userID, string status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStopByUser:status:customParameters:")]
		[CompilerGenerated]
		public virtual void CallDidStopByUserWithCustomParameters (global::System.UInt32 userID, string status, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallUserDidNotAnswer:")]
		[CompilerGenerated]
		public virtual void CallUserDidNotAnswer (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatContactListDidChange:")]
		[CompilerGenerated]
		public virtual void ChatContactListDidChange (QBContactList contactList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidDeliverMessageWithPacketID:")]
		[CompilerGenerated]
		public virtual void ChatDidDeliverMessageWithPacketID (string packetID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount:")]
		[CompilerGenerated]
		public virtual void ChatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount (global::System.UInt32 operationsInQueue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		[CompilerGenerated]
		public virtual void ChatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount (global::System.UInt32 operationsInQueue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidFailWithError:")]
		[CompilerGenerated]
		public virtual void ChatDidFailWithError (int code)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidLogin")]
		[CompilerGenerated]
		public virtual void ChatDidLogin ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotLogin")]
		[CompilerGenerated]
		public virtual void ChatDidNotLogin ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotReceivePrivacyListNamesDueToError:")]
		[CompilerGenerated]
		public virtual void ChatDidNotReceivePrivacyListNames (NSObject error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotReceivePrivacyListWithName:error:")]
		[CompilerGenerated]
		public virtual void ChatDidNotReceivePrivacyListWithName (string name, NSObject error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotSendMessage:error:")]
		[CompilerGenerated]
		public virtual void ChatDidNotSendMessage (QBChatMessage message, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotSetActivePrivacyListWithName:error:")]
		[CompilerGenerated]
		public virtual void ChatDidNotSetActivePrivacyListWithName (string name, NSObject error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotSetDefaultPrivacyListWithName:error:")]
		[CompilerGenerated]
		public virtual void ChatDidNotSetDefaultPrivacyListWithName (string name, NSObject error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotSetPrivacyListWithName:error:")]
		[CompilerGenerated]
		public virtual void ChatDidNotSetPrivacyListWithName (string name, NSObject error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidPassConnectionStep:totalSteps:")]
		[CompilerGenerated]
		public virtual void ChatDidPassConnectionStep (global::System.UInt32 step, global::System.UInt32 totalSteps)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveCallRequestFromUser (global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		[CompilerGenerated]
		public virtual void chatDidReceiveCallRequestFromUserWithParameters (global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveContactAddRequestFromUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveContactItemActivity (global::System.UInt32 userID, bool isOnline, string status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveListOfRooms:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveListOfRooms (NSObject[] rooms)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveMessage:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveMessage (QBChatMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceivePresenceOfUser:type:")]
		[CompilerGenerated]
		public virtual void ChatDidReceivePresenceOfUser (global::System.UInt32 userID, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceivePrivacyList:")]
		[CompilerGenerated]
		public virtual void ChatDidReceivePrivacyList (QBPrivacyList privacyList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceivePrivacyListNames:")]
		[CompilerGenerated]
		public virtual void ChatDidReceivePrivacyListNames (NSObject[] listNames)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveUserIsTypingFromUserWithID:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveUserIsTypingFromUserWithID (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveUserStopTypingFromUserWithID:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveUserStopTypingFromUserWithID (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidRemovedPrivacyListWithName:")]
		[CompilerGenerated]
		public virtual void ChatDidRemovedPrivacyListWithName (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidSetActivePrivacyListWithName:")]
		[CompilerGenerated]
		public virtual void ChatDidSetActivePrivacyListWithName (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidSetDefaultPrivacyListWithName:")]
		[CompilerGenerated]
		public virtual void ChatDidSetDefaultPrivacyListWithNam (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidSetPrivacyListWithName:")]
		[CompilerGenerated]
		public virtual void ChatDidSetPrivacyListWithName (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidChangeOnlineUsers (NSObject[] onlineUsers, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidChangeOnlineUsers:roomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidChangeOnlineUsersFromRoomJID (NSObject[] onlineUsers, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidCreate:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidCreate (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidDestroy:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidDestroy (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidEnter:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidEnter (QBChatRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidLeave:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidLeave (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidLeaveRoomWithJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidLeaveRoomWithJID (string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidNotEnter:error:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidNotEnter (string roomName, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidNotEnterRoomWithJID:error:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidNotEnterRoomWithJID (string roomJID, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveInformation:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveInformation (NSDictionary information, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfOnlineUsers (NSObject[] users, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfOnlineUsers:roomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfOnlineUsersFromRoomJID (NSObject[] users, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfUsers (NSObject[] users, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveMessage (QBChatMessage message, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveMessage:fromRoomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveMessageFromRoomJID (QBChatMessage message, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatTURNServerDidDisconnect")]
		[CompilerGenerated]
		public virtual void ChatTURNServerDidDisconnect ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatTURNServerdidFailWithError:")]
		[CompilerGenerated]
		public virtual void ChatTURNServerdidFailWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didReceiveAudioBuffer:")]
		[CompilerGenerated]
		public virtual void DidReceiveAudioBuffe (global::MonoTouch.AudioToolbox.AudioBuffer buffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didStartUseTURNForVideoChat")]
		[CompilerGenerated]
		public virtual void DidStartUseTURNForVideoChat ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class QBChatDelegate */
}
