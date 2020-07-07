using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='message']/class[@name='MyMessage']"
	[global::Android.Runtime.Register ("message/MyMessage", DoNotGenerateAcw=true)]
	public partial class MyMessage : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("message/MyMessage", typeof (MyMessage));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MyMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='message']/class[@name='MyMessage']/constructor[@name='MyMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MyMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_byeMessage;
#pragma warning disable 0169
		static Delegate GetByeMessageHandler ()
		{
			if (cb_byeMessage == null)
				cb_byeMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ByeMessage);
			return cb_byeMessage;
		}

		static IntPtr n_ByeMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Message.MyMessage __this = global::Java.Lang.Object.GetObject<global::Message.MyMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ByeMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='message']/class[@name='MyMessage']/method[@name='byeMessage' and count(parameter)=0]"
		[Register ("byeMessage", "()Ljava/lang/String;", "GetByeMessageHandler")]
		public virtual unsafe string ByeMessage ()
		{
			const string __id = "byeMessage.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_helloMessage;
#pragma warning disable 0169
		static Delegate GetHelloMessageHandler ()
		{
			if (cb_helloMessage == null)
				cb_helloMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HelloMessage);
			return cb_helloMessage;
		}

		static IntPtr n_HelloMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Message.MyMessage __this = global::Java.Lang.Object.GetObject<global::Message.MyMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HelloMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='message']/class[@name='MyMessage']/method[@name='helloMessage' and count(parameter)=0]"
		[Register ("helloMessage", "()Ljava/lang/String;", "GetHelloMessageHandler")]
		public virtual unsafe string HelloMessage ()
		{
			const string __id = "helloMessage.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
