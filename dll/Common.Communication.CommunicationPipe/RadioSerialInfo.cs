using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000013 RID: 19
	internal class RadioSerialInfo
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000051A9 File Offset: 0x000033A9
		private int RadioType
		{
			get
			{
				return this.radioType;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000051B1 File Offset: 0x000033B1
		private int ConnectorPosition
		{
			get
			{
				return this.connectorPosition;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000051B9 File Offset: 0x000033B9
		private global::Motorola.Common.Communication.CommunicationPipe.FlowControls FlowControl
		{
			get
			{
				return this.flowControl;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000051C1 File Offset: 0x000033C1
		private int BaudRate
		{
			get
			{
				return this.baudRate;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000051C9 File Offset: 0x000033C9
		private string RadioIPAddress
		{
			get
			{
				return this.radioIPAddress;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000051D1 File Offset: 0x000033D1
		public RadioSerialInfo(int radioType, int connectorPosition, global::Motorola.Common.Communication.CommunicationPipe.FlowControls flowControl, int baudRate, string radioIPAddress)
		{
			this.radioType = radioType;
			this.connectorPosition = connectorPosition;
			this.flowControl = flowControl;
			this.baudRate = baudRate;
			this.radioIPAddress = radioIPAddress;
		}

		// Token: 0x0400007D RID: 125
		private int radioType;

		// Token: 0x0400007E RID: 126
		private int connectorPosition;

		// Token: 0x0400007F RID: 127
		private global::Motorola.Common.Communication.CommunicationPipe.FlowControls flowControl;

		// Token: 0x04000080 RID: 128
		private int baudRate;

		// Token: 0x04000081 RID: 129
		private string radioIPAddress = string.Empty;
	}
}
