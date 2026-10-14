using System;
using System.Collections.Generic;
using System.Threading;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000024 RID: 36
	public class MassStorageSwitchInfo : global::System.IDisposable
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00009858 File Offset: 0x00007A58
		public void AddRadioForMassStorageSwitch(global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem info)
		{
			lock (this.accessLock)
			{
				if (this._itemList.ContainsKey(info.TEI))
				{
					this._itemList.Remove(info.TEI);
				}
				this._itemList.Add(info.TEI, info);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000098CC File Offset: 0x00007ACC
		public void RemoveRadioForMassStorageSwitch(string tei)
		{
			lock (this.accessLock)
			{
				if (this._itemList.ContainsKey(tei))
				{
					this._itemList.Remove(tei);
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009924 File Offset: 0x00007B24
		public global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem FindMassStorageSwitchInfo(string tei)
		{
			global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem result;
			lock (this.accessLock)
			{
				if (this._itemList.ContainsKey(tei))
				{
					result = this._itemList[tei];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00009980 File Offset: 0x00007B80
		public global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem FindMassStorageSwitchInfoByCpuID(string cpuID)
		{
			global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem result;
			lock (this.accessLock)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem> keyValuePair in this._itemList)
				{
					if (keyValuePair.Value != null && keyValuePair.Value.CpuID == cpuID)
					{
						return keyValuePair.Value;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00009A20 File Offset: 0x00007C20
		public global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem FindMassStorageSwitchInfoByDiskName(string diskName)
		{
			global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem result;
			lock (this.accessLock)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem> keyValuePair in this._itemList)
				{
					if (keyValuePair.Value != null && keyValuePair.Value.DiskName == diskName)
					{
						return keyValuePair.Value;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00009AC0 File Offset: 0x00007CC0
		public void WaitForMassStorageSwitchTimer()
		{
			lock (this.waitLock)
			{
				this._timerEvent.WaitOne();
				new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.ResetEvent))
				{
					IsBackground = false
				}.Start();
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00009B28 File Offset: 0x00007D28
		private void ResetEvent()
		{
			global::System.Threading.Thread.Sleep(5000);
			this._timerEvent.Set();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00009B40 File Offset: 0x00007D40
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00009B50 File Offset: 0x00007D50
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				if (disposing && this._timerEvent != null)
				{
					this._timerEvent.Close();
				}
			}
			finally
			{
				this._disposed = true;
			}
		}

		// Token: 0x04000080 RID: 128
		private const int SwitchInterval = 5000;

		// Token: 0x04000081 RID: 129
		private global::System.Threading.AutoResetEvent _timerEvent = new global::System.Threading.AutoResetEvent(true);

		// Token: 0x04000082 RID: 130
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem> _itemList = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem>();

		// Token: 0x04000083 RID: 131
		private object accessLock = new object();

		// Token: 0x04000084 RID: 132
		private object waitLock = new object();

		// Token: 0x04000085 RID: 133
		private bool _disposed;
	}
}
