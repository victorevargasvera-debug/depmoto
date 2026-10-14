using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200006A RID: 106
	public class RS232DevCreateUtility
	{
		// Token: 0x06000311 RID: 785 RVA: 0x00007DCB File Offset: 0x00005FCB
		private RS232DevCreateUtility()
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00007DE9 File Offset: 0x00005FE9
		public static global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility Instance
		{
			get
			{
				if (global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility._instance == null)
				{
					global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility._instance = new global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility();
				}
				return global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility._instance;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00007E04 File Offset: 0x00006004
		public bool CloseOpeningRS232Port(string portName)
		{
			if (string.IsNullOrEmpty(portName))
			{
				return false;
			}
			bool result = false;
			global::System.IO.Ports.SerialPort serialPort = null;
			lock (this._openingRS232PortDic)
			{
				this._openingRS232PortDic.TryGetValue(portName, out serialPort);
			}
			if (serialPort != null)
			{
				try
				{
					serialPort.Close();
					result = true;
				}
				catch (global::System.Exception)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00007E7C File Offset: 0x0000607C
		public void AddOpeningRS232Port(string portName, global::System.IO.Ports.SerialPort portInstance)
		{
			if (string.IsNullOrEmpty(portName) || portInstance == null)
			{
				return;
			}
			lock (this._openingRS232PortDic)
			{
				if (!this._openingRS232PortDic.ContainsKey(portName))
				{
					this._openingRS232PortDic.Add(portName, portInstance);
				}
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00007EE0 File Offset: 0x000060E0
		public void RemoveOpeningRS232Port(string portName)
		{
			if (string.IsNullOrEmpty(portName))
			{
				return;
			}
			lock (this._openingRS232PortDic)
			{
				if (this._openingRS232PortDic.ContainsKey(portName))
				{
					this._openingRS232PortDic.Remove(portName);
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00007F40 File Offset: 0x00006140
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus> RS232DevCreateStatusDic
		{
			get
			{
				return this._rs232DevCreateStatusDic;
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00007F48 File Offset: 0x00006148
		public void UpdateRS232DevCreateStatus(string portPlusTimeStamp, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus status)
		{
			if (string.IsNullOrEmpty(portPlusTimeStamp))
			{
				return;
			}
			if (this._rs232DevCreateStatusDic.ContainsKey(portPlusTimeStamp))
			{
				this._rs232DevCreateStatusDic[portPlusTimeStamp] = status;
				return;
			}
			this._rs232DevCreateStatusDic.Add(portPlusTimeStamp, status);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00007F7C File Offset: 0x0000617C
		public global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus GetRS232DevCreateStatus(string portPlusTimeStamp)
		{
			global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus result = global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.UN_DEFINED;
			if (string.IsNullOrEmpty(portPlusTimeStamp))
			{
				return result;
			}
			if (this._rs232DevCreateStatusDic.ContainsKey(portPlusTimeStamp))
			{
				result = this._rs232DevCreateStatusDic[portPlusTimeStamp];
			}
			return result;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00007FB1 File Offset: 0x000061B1
		public void RemoveRS232DevCreateStatus(string portPlusTimeStamp)
		{
			if (string.IsNullOrEmpty(portPlusTimeStamp))
			{
				return;
			}
			if (this._rs232DevCreateStatusDic.ContainsKey(portPlusTimeStamp))
			{
				this._rs232DevCreateStatusDic.Remove(portPlusTimeStamp);
			}
		}

		// Token: 0x0400036D RID: 877
		private global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort> _openingRS232PortDic = new global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort>();

		// Token: 0x0400036E RID: 878
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus> _rs232DevCreateStatusDic = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus>();

		// Token: 0x0400036F RID: 879
		private static global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility _instance;
	}
}
