using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200007B RID: 123
	public class TetraPnPMsg
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000E770 File Offset: 0x0000C970
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000E778 File Offset: 0x0000C978
		public string PhysicalLocation
		{
			get
			{
				return this._physicalLocation;
			}
			set
			{
				this._physicalLocation = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000E781 File Offset: 0x0000C981
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000E789 File Offset: 0x0000C989
		public string PortNumber
		{
			get
			{
				return this._portNumber;
			}
			set
			{
				this._portNumber = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000E792 File Offset: 0x0000C992
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000E79A File Offset: 0x0000C99A
		public global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction PnPType
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000E7A3 File Offset: 0x0000C9A3
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000E7AB File Offset: 0x0000C9AB
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DevMode
		{
			get
			{
				return this._devMode;
			}
			set
			{
				this._devMode = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public string RadioId
		{
			get
			{
				return this._radioID;
			}
			set
			{
				this._radioID = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000E7C5 File Offset: 0x0000C9C5
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000E7CD File Offset: 0x0000C9CD
		public global::Motorola.Common.Communication.CommonUtil.TetraRadioType RadioType
		{
			get
			{
				return this._radioType;
			}
			set
			{
				this._radioType = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		public bool IsOriginalPnP
		{
			get
			{
				return this._isOriginalPnP;
			}
			set
			{
				this._isOriginalPnP = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000E7E7 File Offset: 0x0000C9E7
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0000E7EF File Offset: 0x0000C9EF
		public string PID
		{
			get
			{
				return this._pid;
			}
			set
			{
				this._pid = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0000E800 File Offset: 0x0000CA00
		public string UniqueLocation
		{
			get
			{
				return this._uniqueLocation;
			}
			set
			{
				this._uniqueLocation = value;
			}
		}

		// Token: 0x040003D0 RID: 976
		private string _physicalLocation = string.Empty;

		// Token: 0x040003D1 RID: 977
		private string _portNumber = string.Empty;

		// Token: 0x040003D2 RID: 978
		private global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg.DevPnPAction _action;

		// Token: 0x040003D3 RID: 979
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x040003D4 RID: 980
		private string _radioID = string.Empty;

		// Token: 0x040003D5 RID: 981
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType _radioType;

		// Token: 0x040003D6 RID: 982
		private bool _isOriginalPnP;

		// Token: 0x040003D7 RID: 983
		private string _pid = string.Empty;

		// Token: 0x040003D8 RID: 984
		private string _uniqueLocation = string.Empty;

		// Token: 0x0200007C RID: 124
		public enum DevPnPAction
		{
			// Token: 0x040003DA RID: 986
			DeviceStatusUnknow,
			// Token: 0x040003DB RID: 987
			DeviceAttached,
			// Token: 0x040003DC RID: 988
			DeviceDetached
		}
	}
}
