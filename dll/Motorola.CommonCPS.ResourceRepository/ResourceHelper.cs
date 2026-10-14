using System;
using System.Globalization;
using System.Reflection;

namespace Motorola.CommonCPS.ResourceRepository
{
	// Token: 0x02000002 RID: 2
	public class ResourceHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static string GetCommonErrorMessageByID(string errorID, string[] args = null)
		{
			string result;
			try
			{
				global::System.Reflection.PropertyInfo property = typeof(global::Motorola.CommonCPS.ResourceRepository.Resources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				if (args == null || args.Length == 0)
				{
					result = property.GetValue(null, null).ToString();
				}
				else
				{
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
				}
			}
			catch
			{
				result = errorID;
			}
			return result;
		}
	}
}
