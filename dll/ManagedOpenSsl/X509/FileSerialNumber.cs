using System;
using System.IO;
using System.Threading;

namespace OpenSSL.X509
{
	// Token: 0x0200007D RID: 125
	public class FileSerialNumber : global::OpenSSL.X509.ISequenceNumber
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x0000992A File Offset: 0x00007B2A
		public FileSerialNumber(string path)
		{
			this.serialFile = new global::System.IO.FileInfo(path);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00009940 File Offset: 0x00007B40
		public int Next()
		{
			string name = this.serialFile.FullName.Replace('\\', '/');
			int result;
			using (global::System.Threading.Mutex mutex = new global::System.Threading.Mutex(true, name))
			{
				mutex.WaitOne();
				int num = 1;
				if (this.serialFile.Exists)
				{
					using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(this.serialFile.FullName))
					{
						string value = streamReader.ReadToEnd();
						num = global::System.Convert.ToInt32(value);
						num++;
					}
				}
				using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(this.serialFile.FullName))
				{
					streamWriter.Write(num.ToString());
				}
				result = num;
			}
			return result;
		}

		// Token: 0x040003E7 RID: 999
		private global::System.IO.FileInfo serialFile;
	}
}
