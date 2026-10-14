using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000038 RID: 56
	internal class DeviceInfoDependency
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00010826 File Offset: 0x0000EA26
		public DeviceInfoDependency(string codeplugVersion, global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType)
		{
			this.CodeplugVersion = codeplugVersion;
			this.Model = deviceType;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00010844 File Offset: 0x0000EA44
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0001085B File Offset: 0x0000EA5B
		private string CodeplugVersion { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00010864 File Offset: 0x0000EA64
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0001087B File Offset: 0x0000EA7B
		private global::Motorola.Common.Communication.SequenceManager.DeviceType Model { get; set; }

		// Token: 0x060001CF RID: 463 RVA: 0x00010884 File Offset: 0x0000EA84
		public bool Match(global::Motorola.Common.Communication.SequenceManager.DeviceInfoDependency other)
		{
			bool result;
			if (other == null)
			{
				result = false;
			}
			else if ((other.Model & this.Model) != this.Model)
			{
				result = false;
			}
			else
			{
				if (!string.IsNullOrEmpty(this.CodeplugVersion) && !string.IsNullOrEmpty(other.CodeplugVersion))
				{
					if (string.Compare(this.CodeplugVersion, other.CodeplugVersion, global::System.StringComparison.Ordinal) < 0)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}
	}
}
