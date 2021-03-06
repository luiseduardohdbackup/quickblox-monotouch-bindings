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
	[Register("QBRatings", true)]
	public unsafe partial class QBRatings : QBBaseModule {
		[CompilerGenerated]
		const string selCreateGameModeWithTitleDelegate_ = "createGameModeWithTitle:delegate:";
		static readonly IntPtr selCreateGameModeWithTitleDelegate_Handle = Selector.GetHandle ("createGameModeWithTitle:delegate:");
		[CompilerGenerated]
		const string selCreateGameModeWithTitleDelegateContext_ = "createGameModeWithTitle:delegate:context:";
		static readonly IntPtr selCreateGameModeWithTitleDelegateContext_Handle = Selector.GetHandle ("createGameModeWithTitle:delegate:context:");
		[CompilerGenerated]
		const string selGameModeWithIDDelegate_ = "gameModeWithID:delegate:";
		static readonly IntPtr selGameModeWithIDDelegate_Handle = Selector.GetHandle ("gameModeWithID:delegate:");
		[CompilerGenerated]
		const string selGameModeWithIDDelegateContext_ = "gameModeWithID:delegate:context:";
		static readonly IntPtr selGameModeWithIDDelegateContext_Handle = Selector.GetHandle ("gameModeWithID:delegate:context:");
		[CompilerGenerated]
		const string selGameModesWithDelegate_ = "gameModesWithDelegate:";
		static readonly IntPtr selGameModesWithDelegate_Handle = Selector.GetHandle ("gameModesWithDelegate:");
		[CompilerGenerated]
		const string selGameModesWithDelegateContext_ = "gameModesWithDelegate:context:";
		static readonly IntPtr selGameModesWithDelegateContext_Handle = Selector.GetHandle ("gameModesWithDelegate:context:");
		[CompilerGenerated]
		const string selUpdateGameModeDelegate_ = "updateGameMode:delegate:";
		static readonly IntPtr selUpdateGameModeDelegate_Handle = Selector.GetHandle ("updateGameMode:delegate:");
		[CompilerGenerated]
		const string selUpdateGameModeDelegateContext_ = "updateGameMode:delegate:context:";
		static readonly IntPtr selUpdateGameModeDelegateContext_Handle = Selector.GetHandle ("updateGameMode:delegate:context:");
		[CompilerGenerated]
		const string selDeleteGameModeWithIDDelegate_ = "deleteGameModeWithID:delegate:";
		static readonly IntPtr selDeleteGameModeWithIDDelegate_Handle = Selector.GetHandle ("deleteGameModeWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteGameModeWithIDDelegateContext_ = "deleteGameModeWithID:delegate:context:";
		static readonly IntPtr selDeleteGameModeWithIDDelegateContext_Handle = Selector.GetHandle ("deleteGameModeWithID:delegate:context:");
		[CompilerGenerated]
		const string selCreateScoreDelegate_ = "createScore:delegate:";
		static readonly IntPtr selCreateScoreDelegate_Handle = Selector.GetHandle ("createScore:delegate:");
		[CompilerGenerated]
		const string selCreateScoreDelegateContext_ = "createScore:delegate:context:";
		static readonly IntPtr selCreateScoreDelegateContext_Handle = Selector.GetHandle ("createScore:delegate:context:");
		[CompilerGenerated]
		const string selUpdateScoreDelegate_ = "updateScore:delegate:";
		static readonly IntPtr selUpdateScoreDelegate_Handle = Selector.GetHandle ("updateScore:delegate:");
		[CompilerGenerated]
		const string selUpdateScoreDelegateContext_ = "updateScore:delegate:context:";
		static readonly IntPtr selUpdateScoreDelegateContext_Handle = Selector.GetHandle ("updateScore:delegate:context:");
		[CompilerGenerated]
		const string selScoreWithIDDelegate_ = "scoreWithID:delegate:";
		static readonly IntPtr selScoreWithIDDelegate_Handle = Selector.GetHandle ("scoreWithID:delegate:");
		[CompilerGenerated]
		const string selScoreWithIDDelegateContext_ = "scoreWithID:delegate:context:";
		static readonly IntPtr selScoreWithIDDelegateContext_Handle = Selector.GetHandle ("scoreWithID:delegate:context:");
		[CompilerGenerated]
		const string selDeleteScoreWithIDDelegate_ = "deleteScoreWithID:delegate:";
		static readonly IntPtr selDeleteScoreWithIDDelegate_Handle = Selector.GetHandle ("deleteScoreWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteScoreWithIDDelegateContext_ = "deleteScoreWithID:delegate:context:";
		static readonly IntPtr selDeleteScoreWithIDDelegateContext_Handle = Selector.GetHandle ("deleteScoreWithID:delegate:context:");
		[CompilerGenerated]
		const string selTopNScoresGameModeIDDelegate_ = "topNScores:gameModeID:delegate:";
		static readonly IntPtr selTopNScoresGameModeIDDelegate_Handle = Selector.GetHandle ("topNScores:gameModeID:delegate:");
		[CompilerGenerated]
		const string selTopNScoresGameModeIDDelegateContext_ = "topNScores:gameModeID:delegate:context:";
		static readonly IntPtr selTopNScoresGameModeIDDelegateContext_Handle = Selector.GetHandle ("topNScores:gameModeID:delegate:context:");
		[CompilerGenerated]
		const string selTopNScoresGameModeIDExtendedRequestDelegate_ = "topNScores:gameModeID:extendedRequest:delegate:";
		static readonly IntPtr selTopNScoresGameModeIDExtendedRequestDelegate_Handle = Selector.GetHandle ("topNScores:gameModeID:extendedRequest:delegate:");
		[CompilerGenerated]
		const string selTopNScoresGameModeIDExtendedRequestDelegateContext_ = "topNScores:gameModeID:extendedRequest:delegate:context:";
		static readonly IntPtr selTopNScoresGameModeIDExtendedRequestDelegateContext_Handle = Selector.GetHandle ("topNScores:gameModeID:extendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selScoresWithUserIDDelegate_ = "scoresWithUserID:delegate:";
		static readonly IntPtr selScoresWithUserIDDelegate_Handle = Selector.GetHandle ("scoresWithUserID:delegate:");
		[CompilerGenerated]
		const string selScoresWithUserIDDelegateContext_ = "scoresWithUserID:delegate:context:";
		static readonly IntPtr selScoresWithUserIDDelegateContext_Handle = Selector.GetHandle ("scoresWithUserID:delegate:context:");
		[CompilerGenerated]
		const string selScoresWithUserIDExtendedRequestDelegate_ = "scoresWithUserID:extendedRequest:delegate:";
		static readonly IntPtr selScoresWithUserIDExtendedRequestDelegate_Handle = Selector.GetHandle ("scoresWithUserID:extendedRequest:delegate:");
		[CompilerGenerated]
		const string selScoresWithUserIDExtendedRequestDelegateContext_ = "scoresWithUserID:extendedRequest:delegate:context:";
		static readonly IntPtr selScoresWithUserIDExtendedRequestDelegateContext_Handle = Selector.GetHandle ("scoresWithUserID:extendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selAverageWithGameModeIDDelegate_ = "averageWithGameModeID:delegate:";
		static readonly IntPtr selAverageWithGameModeIDDelegate_Handle = Selector.GetHandle ("averageWithGameModeID:delegate:");
		[CompilerGenerated]
		const string selAverageWithGameModeIDDelegateContext_ = "averageWithGameModeID:delegate:context:";
		static readonly IntPtr selAverageWithGameModeIDDelegateContext_Handle = Selector.GetHandle ("averageWithGameModeID:delegate:context:");
		[CompilerGenerated]
		const string selAveragesForApplicationWithDelegate_ = "averagesForApplicationWithDelegate:";
		static readonly IntPtr selAveragesForApplicationWithDelegate_Handle = Selector.GetHandle ("averagesForApplicationWithDelegate:");
		[CompilerGenerated]
		const string selAveragesForApplicationWithDelegateContext_ = "averagesForApplicationWithDelegate:context:";
		static readonly IntPtr selAveragesForApplicationWithDelegateContext_Handle = Selector.GetHandle ("averagesForApplicationWithDelegate:context:");
		[CompilerGenerated]
		const string selCreateGameModeParameterValueDelegate_ = "createGameModeParameterValue:delegate:";
		static readonly IntPtr selCreateGameModeParameterValueDelegate_Handle = Selector.GetHandle ("createGameModeParameterValue:delegate:");
		[CompilerGenerated]
		const string selCreateGameModeParameterValueDelegateContext_ = "createGameModeParameterValue:delegate:context:";
		static readonly IntPtr selCreateGameModeParameterValueDelegateContext_Handle = Selector.GetHandle ("createGameModeParameterValue:delegate:context:");
		[CompilerGenerated]
		const string selGameModeParameterValueWithIDDelegate_ = "gameModeParameterValueWithID:delegate:";
		static readonly IntPtr selGameModeParameterValueWithIDDelegate_Handle = Selector.GetHandle ("gameModeParameterValueWithID:delegate:");
		[CompilerGenerated]
		const string selGameModeParameterValueWithIDDelegateContext_ = "gameModeParameterValueWithID:delegate:context:";
		static readonly IntPtr selGameModeParameterValueWithIDDelegateContext_Handle = Selector.GetHandle ("gameModeParameterValueWithID:delegate:context:");
		[CompilerGenerated]
		const string selUpdateGameModeParameterValueDelegate_ = "updateGameModeParameterValue:delegate:";
		static readonly IntPtr selUpdateGameModeParameterValueDelegate_Handle = Selector.GetHandle ("updateGameModeParameterValue:delegate:");
		[CompilerGenerated]
		const string selUpdateGameModeParameterValueDelegateContext_ = "updateGameModeParameterValue:delegate:context:";
		static readonly IntPtr selUpdateGameModeParameterValueDelegateContext_Handle = Selector.GetHandle ("updateGameModeParameterValue:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRatings");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRatings () : base (NSObjectFlag.Empty)
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
		public QBRatings (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRatings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRatings (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createGameModeWithTitle:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateGameModeWithTitle (string title, NSObject del)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nstitle = NSString.CreateNative (title);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateGameModeWithTitleDelegate_Handle, nstitle, del.Handle));
			NSString.ReleaseNative (nstitle);
			
			return ret;
		}
		
		[Export ("createGameModeWithTitle:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateGameModeWithTitle (string title, NSObject del, NSObject context)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nstitle = NSString.CreateNative (title);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateGameModeWithTitleDelegateContext_Handle, nstitle, del.Handle, context.Handle));
			NSString.ReleaseNative (nstitle);
			
			return ret;
		}
		
		[Export ("gameModeWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject GameModeWithID (global::System.UInt32 gameModeId, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selGameModeWithIDDelegate_Handle, gameModeId, del.Handle));
		}
		
		[Export ("gameModeWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GameModeWithID (global::System.UInt32 gameModeId, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selGameModeWithIDDelegateContext_Handle, gameModeId, del.Handle, context.Handle));
		}
		
		[Export ("gameModesWithDelegate:")]
		[CompilerGenerated]
		public static NSObject GameModesWithDelegate (NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selGameModesWithDelegate_Handle, del.Handle));
		}
		
		[Export ("gameModesWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject GameModesWithDelegate (NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selGameModesWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateGameMode:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateGameMode (QBRGameMode gameMode, NSObject del)
		{
			if (gameMode == null)
				throw new ArgumentNullException ("gameMode");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateGameModeDelegate_Handle, gameMode.Handle, del.Handle));
		}
		
		[Export ("updateGameMode:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateGameMode (QBRGameMode gameMode, NSObject del, NSObject context)
		{
			if (gameMode == null)
				throw new ArgumentNullException ("gameMode");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateGameModeDelegateContext_Handle, gameMode.Handle, del.Handle, context.Handle));
		}
		
		[Export ("deleteGameModeWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteGameModeWithID (global::System.UInt32 gameModeId, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteGameModeWithIDDelegate_Handle, gameModeId, del.Handle));
		}
		
		[Export ("deleteGameModeWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteGameModeWithID (global::System.UInt32 gameModeId, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteGameModeWithIDDelegateContext_Handle, gameModeId, del.Handle, context.Handle));
		}
		
		[Export ("createScore:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateScore (QBRScore score, NSObject del)
		{
			if (score == null)
				throw new ArgumentNullException ("score");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateScoreDelegate_Handle, score.Handle, del.Handle));
		}
		
		[Export ("createScore:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateScore (QBRScore score, NSObject del, NSObject context)
		{
			if (score == null)
				throw new ArgumentNullException ("score");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateScoreDelegateContext_Handle, score.Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateScore:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateScore (QBRScore score, NSObject del)
		{
			if (score == null)
				throw new ArgumentNullException ("score");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateScoreDelegate_Handle, score.Handle, del.Handle));
		}
		
		[Export ("updateScore:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateScore (QBRScore score, NSObject del, NSObject context)
		{
			if (score == null)
				throw new ArgumentNullException ("score");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateScoreDelegateContext_Handle, score.Handle, del.Handle, context.Handle));
		}
		
		[Export ("scoreWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject ScoreWithID (global::System.UInt32 scoreId, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selScoreWithIDDelegate_Handle, scoreId, del.Handle));
		}
		
		[Export ("scoreWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ScoreWithID (global::System.UInt32 scoreId, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selScoreWithIDDelegateContext_Handle, scoreId, del.Handle, context.Handle));
		}
		
		[Export ("deleteScoreWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteScoreWithID (global::System.UInt32 scoreId, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteScoreWithIDDelegate_Handle, scoreId, del.Handle));
		}
		
		[Export ("deleteScoreWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteScoreWithID (global::System.UInt32 scoreId, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteScoreWithIDDelegateContext_Handle, scoreId, del.Handle, context.Handle));
		}
		
		[Export ("topNScores:gameModeID:delegate:")]
		[CompilerGenerated]
		public static NSObject TopNScores (int topN, global::System.UInt32 gameModeID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_IntPtr (class_ptr, selTopNScoresGameModeIDDelegate_Handle, topN, gameModeID, del.Handle));
		}
		
		[Export ("topNScores:gameModeID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TopNScores (int topN, global::System.UInt32 gameModeID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_IntPtr_IntPtr (class_ptr, selTopNScoresGameModeIDDelegateContext_Handle, topN, gameModeID, del.Handle, context.Handle));
		}
		
		[Export ("topNScores:gameModeID:extendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject TopNScores (int topN, global::System.UInt32 gameModeID, QBRScoreGetRequest extendedRequest, NSObject del)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_IntPtr_IntPtr (class_ptr, selTopNScoresGameModeIDExtendedRequestDelegate_Handle, topN, gameModeID, extendedRequest.Handle, del.Handle));
		}
		
		[Export ("topNScores:gameModeID:extendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TopNScores (int topN, global::System.UInt32 gameModeID, QBRScoreGetRequest extendedRequest, NSObject del, NSObject context)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_IntPtr_IntPtr_IntPtr (class_ptr, selTopNScoresGameModeIDExtendedRequestDelegateContext_Handle, topN, gameModeID, extendedRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("scoresWithUserID:delegate:")]
		[CompilerGenerated]
		public static NSObject ScoresWithUserID (global::System.UInt32 userID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selScoresWithUserIDDelegate_Handle, userID, del.Handle));
		}
		
		[Export ("scoresWithUserID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ScoresWithUserID (global::System.UInt32 userID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selScoresWithUserIDDelegateContext_Handle, userID, del.Handle, context.Handle));
		}
		
		[Export ("scoresWithUserID:extendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject ScoresWithUserID (global::System.UInt32 userID, QBRScoreGetRequest extendedRequest, NSObject del)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selScoresWithUserIDExtendedRequestDelegate_Handle, userID, extendedRequest.Handle, del.Handle));
		}
		
		[Export ("scoresWithUserID:extendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ScoresWithUserID (global::System.UInt32 userID, QBRScoreGetRequest extendedRequest, NSObject del, NSObject context)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr (class_ptr, selScoresWithUserIDExtendedRequestDelegateContext_Handle, userID, extendedRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("averageWithGameModeID:delegate:")]
		[CompilerGenerated]
		public static NSObject AverageWithGameModeID (global::System.UInt32 gameModeId, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selAverageWithGameModeIDDelegate_Handle, gameModeId, del.Handle));
		}
		
		[Export ("averageWithGameModeID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject AverageWithGameModeID (global::System.UInt32 gameModeId, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selAverageWithGameModeIDDelegateContext_Handle, gameModeId, del.Handle, context.Handle));
		}
		
		[Export ("averagesForApplicationWithDelegate:")]
		[CompilerGenerated]
		public static NSObject AveragesForApplicationWithDelegate (NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selAveragesForApplicationWithDelegate_Handle, del.Handle));
		}
		
		[Export ("averagesForApplicationWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject AveragesForApplicationWithDelegate (NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selAveragesForApplicationWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("createGameModeParameterValue:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject del)
		{
			if (gameModeParameterValue == null)
				throw new ArgumentNullException ("gameModeParameterValue");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateGameModeParameterValueDelegate_Handle, gameModeParameterValue.Handle, del.Handle));
		}
		
		[Export ("createGameModeParameterValue:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject del, NSObject context)
		{
			if (gameModeParameterValue == null)
				throw new ArgumentNullException ("gameModeParameterValue");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateGameModeParameterValueDelegateContext_Handle, gameModeParameterValue.Handle, del.Handle, context.Handle));
		}
		
		[Export ("gameModeParameterValueWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject GameModeParameterValueWithID (global::System.UInt32 gameModeParameterValueID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selGameModeParameterValueWithIDDelegate_Handle, gameModeParameterValueID, del.Handle));
		}
		
		[Export ("gameModeParameterValueWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GameModeParameterValueWithID (global::System.UInt32 gameModeParameterValueID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selGameModeParameterValueWithIDDelegateContext_Handle, gameModeParameterValueID, del.Handle, context.Handle));
		}
		
		[Export ("updateGameModeParameterValue:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject del)
		{
			if (gameModeParameterValue == null)
				throw new ArgumentNullException ("gameModeParameterValue");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateGameModeParameterValueDelegate_Handle, gameModeParameterValue.Handle, del.Handle));
		}
		
		[Export ("updateGameModeParameterValue:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject del, NSObject context)
		{
			if (gameModeParameterValue == null)
				throw new ArgumentNullException ("gameModeParameterValue");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateGameModeParameterValueDelegateContext_Handle, gameModeParameterValue.Handle, del.Handle, context.Handle));
		}
		
	} /* class QBRatings */
}
