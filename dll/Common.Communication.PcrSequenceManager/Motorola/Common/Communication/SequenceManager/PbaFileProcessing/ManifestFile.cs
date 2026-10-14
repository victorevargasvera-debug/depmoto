using System;
using System.Collections.Generic;
using System.Linq;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x02000019 RID: 25
	public class ManifestFile : global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.IManifestItem
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00004248 File Offset: 0x00002448
		internal ManifestFile(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileHeader header)
		{
			this.fileHeader = header;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000426C File Offset: 0x0000246C
		public byte[] GenereateFileContent()
		{
			byte[] bytes;
			using (global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter manifestFileWriter = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter())
			{
				this.WriteToStream(manifestFileWriter);
				bytes = manifestFileWriter.GetBytes();
			}
			return bytes;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000042B4 File Offset: 0x000024B4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> MOList
		{
			get
			{
				return this.objectList;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000042CC File Offset: 0x000024CC
		public void WriteToStream(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter writer)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> nonEmptyMOList = this.GetNonEmptyMOList();
			this.fileHeader.ObjectNum = (uint)nonEmptyMOList.Count<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
			this.fileHeader.WriteToStream(writer);
			foreach (global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject in nonEmptyMOList)
			{
				if (!manifestObject.IsEmpty())
				{
					manifestObject.WriteToStream(writer);
				}
			}
			this.WriteSignature(writer);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000438C File Offset: 0x0000258C
		public void AddManifestObject(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject obj)
		{
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject = this.objectList.Find((global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject s) => s.ObjectID == obj.ObjectID);
			if (manifestObject == null)
			{
				this.objectList.Add(obj);
			}
			else
			{
				foreach (string item in obj.LocalPaths)
				{
					if (!manifestObject.LocalPaths.Contains(item))
					{
						manifestObject.LocalPaths.Add(item);
					}
				}
			}
			this.fileHeader.ObjectNum = (uint)this.objectList.Count<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004494 File Offset: 0x00002694
		public void RemoveManifestObject(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject obj)
		{
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject = this.objectList.Find((global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject s) => s.ObjectID == obj.ObjectID);
			if (manifestObject != null)
			{
				this.objectList.Remove(obj);
			}
			this.fileHeader.ObjectNum = (uint)this.objectList.Count<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000044FC File Offset: 0x000026FC
		private void WriteSignature(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter writer)
		{
			byte[] hashSha = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiUtility.getHashSha256(writer.GetBytes());
			char[] array = new char[32];
			global::System.Array.Copy(hashSha, array, hashSha.Length);
			writer.Write("Signature", array);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004538 File Offset: 0x00002738
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> GetNonEmptyMOList()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
			foreach (global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject in this.objectList)
			{
				if (!manifestObject.IsEmpty())
				{
					list.Add(manifestObject);
				}
			}
			return list;
		}

		// Token: 0x0400007D RID: 125
		private global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileHeader fileHeader = null;

		// Token: 0x0400007E RID: 126
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> objectList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
	}
}
