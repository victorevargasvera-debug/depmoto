using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200001F RID: 31
	internal static class SbepParser
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00009084 File Offset: 0x00007284
		static SbepParser()
		{
			try
			{
				using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("TetraUtility.Log.SbepCmdSchema.dat")))
				{
					string name = "Unkown SBEP Command";
					global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						if (!string.IsNullOrEmpty(text.Trim()))
						{
							if (text.StartsWith("[SBEP]", global::System.StringComparison.Ordinal))
							{
								if (list.Count > 0)
								{
									global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList.Add(new global::Motorola.Common.Communication.TetraUtility.SbepSchemItem(name, list.ToArray()));
									list.Clear();
								}
								string[] array = text.Split(new char[]
								{
									':'
								}, global::System.StringSplitOptions.RemoveEmptyEntries);
								name = "Unkown SBEP Command";
								if (array.Length > 1)
								{
									name = array[1].Trim();
								}
							}
							else
							{
								list.Add(text);
							}
						}
					}
					if (list.Count > 0)
					{
						global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList.Add(new global::Motorola.Common.Communication.TetraUtility.SbepSchemItem(name, list.ToArray()));
						list.Clear();
					}
					global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList.Sort(new global::Motorola.Common.Communication.TetraUtility.SchemItemComparer());
				}
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger("").Error(e, "SbepParser error");
				global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList.Clear();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000091D0 File Offset: 0x000073D0
		public static string GetSbepName(byte[] buffer)
		{
			lock (global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList)
			{
				foreach (global::Motorola.Common.Communication.TetraUtility.SbepSchemItem sbepSchemItem in global::Motorola.Common.Communication.TetraUtility.SbepParser.SbepSchemaList)
				{
					if (sbepSchemItem.IsMatch(buffer))
					{
						return sbepSchemItem.Name;
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x04000072 RID: 114
		private static global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SbepSchemItem> SbepSchemaList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SbepSchemItem>();
	}
}
