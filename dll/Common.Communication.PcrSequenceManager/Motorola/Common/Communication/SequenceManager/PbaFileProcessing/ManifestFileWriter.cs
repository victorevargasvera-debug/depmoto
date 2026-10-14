using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001B RID: 27
	public sealed class ManifestFileWriter : global::System.IDisposable
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00004604 File Offset: 0x00002804
		internal byte[] GetBytes()
		{
			return this.ms.ToArray();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004624 File Offset: 0x00002824
		internal void BeginWrite()
		{
			if (this.bufStream != null)
			{
				throw new global::System.Exception("");
			}
			this.bufStream = new global::System.IO.MemoryStream();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004658 File Offset: 0x00002858
		internal byte[] EndWrite()
		{
			this.bufStream.WriteTo(this.ms);
			byte[] result = this.bufStream.ToArray();
			this.bufStream = null;
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004690 File Offset: 0x00002890
		internal void Write(string name, byte obj)
		{
			if (this.bufStream != null)
			{
				this.bufStream.WriteByte(obj);
			}
			else
			{
				this.ms.WriteByte(obj);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000046CC File Offset: 0x000028CC
		internal void Write(string name, string obj)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(obj.ToString());
			if (this.bufStream != null)
			{
				this.bufStream.Write(bytes, 0, bytes.Length);
			}
			else
			{
				this.ms.Write(bytes, 0, bytes.Length);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004720 File Offset: 0x00002920
		internal void Write(string name, byte[] obj)
		{
			if (this.bufStream != null)
			{
				this.bufStream.Write(obj, 0, obj.Length);
			}
			else
			{
				this.ms.Write(obj, 0, obj.Length);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004764 File Offset: 0x00002964
		internal void Write(string name, char[] obj)
		{
			foreach (char c in obj)
			{
				if (this.bufStream != null)
				{
					this.bufStream.WriteByte((byte)c);
				}
				else
				{
					this.ms.WriteByte((byte)c);
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000047BC File Offset: 0x000029BC
		internal void Write(string name, uint obj)
		{
			if (this.bufStream != null)
			{
				this.bufStream.WriteByte((byte)(obj >> 24 & 255U));
				this.bufStream.WriteByte((byte)(obj >> 16 & 255U));
				this.bufStream.WriteByte((byte)(obj >> 8 & 255U));
				this.bufStream.WriteByte((byte)(obj & 255U));
			}
			else
			{
				this.ms.WriteByte((byte)(obj >> 24 & 255U));
				this.ms.WriteByte((byte)(obj >> 16 & 255U));
				this.ms.WriteByte((byte)(obj >> 8 & 255U));
				this.ms.WriteByte((byte)(obj & 255U));
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004890 File Offset: 0x00002A90
		internal void Write(string name, ushort obj)
		{
			this.bufStream.WriteByte((byte)(obj >> 8 & 255));
			this.bufStream.WriteByte((byte)(obj & 255));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000048CC File Offset: 0x00002ACC
		public void Dispose()
		{
			if (this.bufStream != null)
			{
				this.bufStream.Dispose();
			}
			this.ms.Dispose();
		}

		// Token: 0x04000081 RID: 129
		private global::System.IO.MemoryStream ms = new global::System.IO.MemoryStream();

		// Token: 0x04000082 RID: 130
		private global::System.Xml.Linq.XDocument doc = new global::System.Xml.Linq.XDocument();

		// Token: 0x04000083 RID: 131
		private global::System.IO.MemoryStream bufStream = null;
	}
}
