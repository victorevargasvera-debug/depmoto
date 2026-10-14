using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000043 RID: 67
	[global::System.Runtime.InteropServices.Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
	[global::System.Runtime.InteropServices.CoClass(typeof(global::SHDocVw.WebBrowserClass))]
	[global::System.Runtime.InteropServices.ComImport]
	public interface WebBrowser : global::SHDocVw.IWebBrowser2, global::SHDocVw.DWebBrowserEvents2_Event
	{
	}
}
