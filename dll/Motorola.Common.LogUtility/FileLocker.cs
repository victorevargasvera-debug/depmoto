using System;
using System.Globalization;
using System.Threading;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000D RID: 13
	public class FileLocker : global::System.IDisposable
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00003D00 File Offset: 0x00001F00
		public FileLocker(string fileName)
		{
			fileName = fileName.Replace("\\", "_");
			fileName = fileName.Replace(":", "_");
			this.mtxName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Global\\{0}", new object[]
			{
				fileName
			});
			this.mtx = new global::System.Threading.Mutex(false, this.mtxName);
			this.mtx.WaitOne();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003D81 File Offset: 0x00001F81
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003D90 File Offset: 0x00001F90
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.mtx != null)
			{
				this.mtx.ReleaseMutex();
				this.mtx.Close();
				this.mtx = null;
			}
		}

		// Token: 0x0400003D RID: 61
		private global::System.Threading.Mutex mtx;

		// Token: 0x0400003E RID: 62
		private string mtxName = string.Empty;
	}
}
