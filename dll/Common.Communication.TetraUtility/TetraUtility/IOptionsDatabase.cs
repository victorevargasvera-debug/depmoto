using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006A RID: 106
	public interface IOptionsDatabase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600026D RID: 621
		// (remove) Token: 0x0600026E RID: 622
		event global::System.EventHandler<global::Motorola.Common.Communication.TetraUtility.OptionValueEventArgs> OptionValueChanged;

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026F RID: 623
		// (set) Token: 0x06000270 RID: 624
		string DatabasePath { get; set; }

		// Token: 0x06000271 RID: 625
		void Load(bool force_load);

		// Token: 0x06000272 RID: 626
		string GetValue(string section_name, string value_name);

		// Token: 0x06000273 RID: 627
		string GetValue(string section_name, string value_name, object defaultValue);

		// Token: 0x06000274 RID: 628
		void SetValue(string section_name, string value_name, object value);

		// Token: 0x06000275 RID: 629
		void Save();

		// Token: 0x06000276 RID: 630
		bool GetValue2Bool(string section_name, string value_name, bool fallbackValue);
	}
}
