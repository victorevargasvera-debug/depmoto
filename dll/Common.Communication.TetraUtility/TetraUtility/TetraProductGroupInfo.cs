using System;
using System.Reflection;
using System.Xml;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000037 RID: 55
	public class TetraProductGroupInfo : global::System.ICloneable
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0000B768 File Offset: 0x00009968
		public TetraProductGroupInfo(global::System.Xml.XmlElement xmlEle)
		{
			global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo.SetPropertyFromXmlAttri(this, xmlEle);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000B777 File Offset: 0x00009977
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000B77F File Offset: 0x0000997F
		public string GroupName { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000B788 File Offset: 0x00009988
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000B790 File Offset: 0x00009990
		public string ModelList { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000B799 File Offset: 0x00009999
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000B7A1 File Offset: 0x000099A1
		public string ProductLine { get; set; }

		// Token: 0x060001CF RID: 463 RVA: 0x0000B7AA File Offset: 0x000099AA
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B7B4 File Offset: 0x000099B4
		internal static void SetPropertyFromXmlAttri(object obj, global::System.Xml.XmlElement xmlEle)
		{
			if (xmlEle == null)
			{
				return;
			}
			global::System.Reflection.PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				global::System.Xml.XmlAttribute xmlAttribute = xmlEle.Attributes[propertyInfo.Name];
				if (xmlAttribute != null)
				{
					object value = global::System.Convert.ChangeType(xmlAttribute.Value, propertyInfo.PropertyType);
					propertyInfo.SetValue(obj, value, null);
				}
			}
		}
	}
}
