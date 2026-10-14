using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000080 RID: 128
	public class ThreadSafeEventHandlerBag
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0000F880 File Offset: 0x0000DA80
		public ThreadSafeEventHandlerBag()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000F8A5 File Offset: 0x0000DAA5
		public ThreadSafeEventHandlerBag(bool isWeakEvent, bool dispatchAsyncMsg)
		{
			this.isWeakEvent = isWeakEvent;
			this.dispatchAsyncMsg = dispatchAsyncMsg;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0000F8EB File Offset: 0x0000DAEB
		public static int MainManagedThreadId { get; set; } = int.MinValue;

		// Token: 0x06000316 RID: 790 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
		public void Add(string eventName, global::System.Delegate del)
		{
			if (string.IsNullOrEmpty(eventName) || del == null)
			{
				return;
			}
			lock (this.padLock)
			{
				if (this.dispatchAsyncMsg && global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag.MainManagedThreadId != -2147483648 && global::System.Threading.SynchronizationContext.Current != null && global::System.Threading.Thread.CurrentThread.ManagedThreadId != global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag.MainManagedThreadId)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger("SafeEventHandler_Logger").Debug("==== None main thread has gui control ====");
				}
				if (!this.map.ContainsKey(eventName))
				{
					this.map[eventName] = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair>();
				}
				global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair delegateThrdCtxPair = this.SearchDelegate(this.map[eventName], del);
				if (delegateThrdCtxPair == null)
				{
					global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair delegateThrdCtxPair2 = new global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair();
					if (this.isWeakEvent)
					{
						delegateThrdCtxPair2.WeakDelegate = new global::Motorola.Common.Communication.TetraUtility.WeakDelegate(del);
					}
					else
					{
						delegateThrdCtxPair2.Delegate = del;
					}
					if (this.dispatchAsyncMsg)
					{
						delegateThrdCtxPair2.Context = ((global::System.Threading.SynchronizationContext.Current != null) ? global::System.Threading.SynchronizationContext.Current : new global::System.Threading.SynchronizationContext());
					}
					this.map[eventName].Add(delegateThrdCtxPair2);
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000FA08 File Offset: 0x0000DC08
		public void Remove(string eventName, global::System.Delegate del)
		{
			if (string.IsNullOrEmpty(eventName) || del == null)
			{
				return;
			}
			lock (this.padLock)
			{
				if (this.map.ContainsKey(eventName))
				{
					global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair delegateThrdCtxPair = this.SearchDelegate(this.map[eventName], del);
					if (delegateThrdCtxPair != null)
					{
						this.map[eventName].Remove(delegateThrdCtxPair);
					}
				}
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000FA88 File Offset: 0x0000DC88
		public void Invoke(string eventName, params object[] args)
		{
			if (string.IsNullOrEmpty(eventName))
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair[] array = new global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair[0];
			lock (this.padLock)
			{
				if (!this.map.ContainsKey(eventName))
				{
					return;
				}
				array = this.map[eventName].ToArray();
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair>();
			foreach (global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair delegateThrdCtxPair in array)
			{
				object firstArgument = (delegateThrdCtxPair.WeakDelegate == null) ? null : delegateThrdCtxPair.WeakDelegate.Target;
				if (this.isWeakEvent && !delegateThrdCtxPair.WeakDelegate.IsValid)
				{
					list.Add(delegateThrdCtxPair);
				}
				else
				{
					global::System.Delegate @delegate = delegateThrdCtxPair.Delegate;
					if (this.isWeakEvent)
					{
						@delegate = global::System.Delegate.CreateDelegate(delegateThrdCtxPair.WeakDelegate.DelegateType, firstArgument, delegateThrdCtxPair.WeakDelegate.Method);
					}
					object[] array3 = new object[args.Length + 1];
					array3[0] = @delegate;
					global::System.Array.Copy(args, 0, array3, 1, args.Length);
					if (this.dispatchAsyncMsg)
					{
						delegateThrdCtxPair.Context.Post(new global::System.Threading.SendOrPostCallback(this.Callback), array3);
					}
					else
					{
						@delegate.DynamicInvoke(args);
					}
				}
			}
			lock (this.padLock)
			{
				foreach (global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair item in list)
				{
					this.map[eventName].Remove(item);
				}
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000FC4C File Offset: 0x0000DE4C
		public void Clear()
		{
			lock (this.padLock)
			{
				this.map.Clear();
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000FC94 File Offset: 0x0000DE94
		private global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair SearchDelegate(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair> pairList, global::System.Delegate del)
		{
			foreach (global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair delegateThrdCtxPair in pairList)
			{
				if (this.isWeakEvent)
				{
					if (delegateThrdCtxPair.WeakDelegate == null)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger("SafeEventHandler_Logger").Error("this.isWeakEvent is true but WeakDelegate == null");
					}
					else if (delegateThrdCtxPair.WeakDelegate.Equals(new global::Motorola.Common.Communication.TetraUtility.WeakDelegate(del)))
					{
						return delegateThrdCtxPair;
					}
				}
				else if (delegateThrdCtxPair.Delegate == null)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger("SafeEventHandler_Logger").Error("this.isWeakEvent is false but nextPair.Delegate == null");
				}
				else if (delegateThrdCtxPair.Delegate.Equals(del))
				{
					return delegateThrdCtxPair;
				}
			}
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000FD4C File Offset: 0x0000DF4C
		private void Callback(object state)
		{
			global::System.Threading.Thread.CurrentThread.CurrentCulture = global::System.Globalization.CultureInfo.InvariantCulture;
			object[] array = state as object[];
			if (array == null || array.Length == 0)
			{
				return;
			}
			global::System.Delegate @delegate = array[0] as global::System.Delegate;
			if (@delegate == null)
			{
				return;
			}
			object[] array2 = null;
			if (array.Length - 1 >= 1)
			{
				array2 = new object[array.Length - 1];
				global::System.Array.Copy(array, 1, array2, 0, array.Length - 1);
			}
			@delegate.DynamicInvoke(array2);
		}

		// Token: 0x040003E6 RID: 998
		private const string MyLoggerName = "SafeEventHandler_Logger";

		// Token: 0x040003E7 RID: 999
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair>> map = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.DelegateThrdCtxPair>>();

		// Token: 0x040003E8 RID: 1000
		private object padLock = new object();

		// Token: 0x040003E9 RID: 1001
		private bool isWeakEvent;

		// Token: 0x040003EA RID: 1002
		private bool dispatchAsyncMsg = true;
	}
}
