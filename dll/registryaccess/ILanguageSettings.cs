using System;
using System.Collections;

namespace RegistryAccess
{
	// Token: 0x02000008 RID: 8
	public interface ILanguageSettings
	{
		// Token: 0x06000012 RID: 18
		void GetGUIResourceFile(string strLanguageID, ref string strGUIPathAndName);

		// Token: 0x06000013 RID: 19
		void GetHelpFile(string strLanguageID, ref string strHelpFilePathAndName);

		// Token: 0x06000014 RID: 20
		void GetXMLHelpFile(string LanguageID, ref string XMLHelpFilePathAndName);

		// Token: 0x06000015 RID: 21
		void GetImageResourceFile(ref string sImageResFileName);

		// Token: 0x06000016 RID: 22
		void IsRightToLeftLayout(string strLanguageID, ref bool strRightToLeft);

		// Token: 0x06000017 RID: 23
		void GetLanguageChoices(ref global::System.Collections.ArrayList alLanguagesID, ref global::System.Collections.ArrayList alLanguageName);

		// Token: 0x06000018 RID: 24
		void SetLanguageSelection(string strLanguage);

		// Token: 0x06000019 RID: 25
		void GetLanguageSelection(ref string strLanguage);

		// Token: 0x0600001A RID: 26
		void GetDealerInfo(string strLangID, ref string DealerInfoLeft, ref string DealerInfoMiddle, ref string DealerInfoRight);

		// Token: 0x0600001B RID: 27
		void SetDealerInfo(string strLangID, string DealerInfoLeft, string DealerInfoMiddle, string DealerInfoRight);
	}
}
