using System;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000003 RID: 3
	internal interface IOperationAsyncResult : global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		string InterfaceName { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		// (set) Token: 0x06000003 RID: 3
		object Output { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4
		// (set) Token: 0x06000005 RID: 5
		global::System.Exception Error { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		string OperationId { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7
		global::Motorola.Common.Communication.Service.AsyncStatus AsyncStatus { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000008 RID: 8
		// (remove) Token: 0x06000009 RID: 9
		event global::System.EventHandler Canceled;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000A RID: 10
		// (remove) Token: 0x0600000B RID: 11
		event global::System.EventHandler CancelReading;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600000C RID: 12
		// (remove) Token: 0x0600000D RID: 13
		event global::System.EventHandler Started;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600000E RID: 14
		// (remove) Token: 0x0600000F RID: 15
		event global::System.EventHandler Queued;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000010 RID: 16
		// (remove) Token: 0x06000011 RID: 17
		event global::System.EventHandler Operation;

		// Token: 0x06000012 RID: 18
		void OnQueued();

		// Token: 0x06000013 RID: 19
		void OnStarted();

		// Token: 0x06000014 RID: 20
		void OnCanceled();

		// Token: 0x06000015 RID: 21
		void OnOperation();

		// Token: 0x06000016 RID: 22
		void OnCompleted();

		// Token: 0x06000017 RID: 23
		void OnCancelReading();
	}
}
