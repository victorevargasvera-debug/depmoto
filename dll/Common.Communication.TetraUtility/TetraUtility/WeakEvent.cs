using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000087 RID: 135
	public class WeakEvent<T> where T : global::System.EventArgs
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00011BD8 File Offset: 0x0000FDD8
		public void Invok(object sender, T args)
		{
			this.bag.Invoke("NO_Name", new object[]
			{
				sender,
				args
			});
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00011C0A File Offset: 0x0000FE0A
		public void Add(global::System.EventHandler<T> handler)
		{
			this.bag.Add("NO_Name", handler);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00011C1D File Offset: 0x0000FE1D
		public void Remove(global::System.EventHandler<T> handler)
		{
			this.bag.Remove("NO_Name", handler);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00011C30 File Offset: 0x0000FE30
		public void RemoveAll()
		{
			this.bag.Clear();
		}

		// Token: 0x04000422 RID: 1058
		private const string MyEventName = "NO_Name";

		// Token: 0x04000423 RID: 1059
		private global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag bag = new global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag(true, true);
	}
}
