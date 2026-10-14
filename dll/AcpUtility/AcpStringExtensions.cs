using System;

namespace AcpUtility
{
	// Token: 0x02000002 RID: 2
	public static class AcpStringExtensions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static string AcpStringFormat(this string fmt, params object[] args)
		{
			string result = string.Empty;
			try
			{
				result = string.Format(fmt, args);
			}
			catch (global::System.ArgumentNullException)
			{
				result = ">> String not found! <<";
			}
			catch (global::System.FormatException)
			{
				result = ">> String not found! <<";
			}
			catch (global::System.Exception)
			{
				throw;
			}
			return result;
		}
	}
}
