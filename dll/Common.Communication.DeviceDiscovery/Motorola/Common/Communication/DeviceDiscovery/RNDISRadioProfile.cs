using System;
using System.Text;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001A RID: 26
	public class RNDISRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RadioProfileBase
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005867 File Offset: 0x00003A67
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000586F File Offset: 0x00003A6F
		internal string DeviceName { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005878 File Offset: 0x00003A78
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005880 File Offset: 0x00003A80
		public string PortName { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005889 File Offset: 0x00003A89
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00005891 File Offset: 0x00003A91
		internal string DeviceDescription { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000589A File Offset: 0x00003A9A
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000058A2 File Offset: 0x00003AA2
		public string IPAddress { get; internal set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000058AB File Offset: 0x00003AAB
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000058B3 File Offset: 0x00003AB3
		internal string MacAddress { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000058BC File Offset: 0x00003ABC
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000058C4 File Offset: 0x00003AC4
		public string NetCfgInstanceId { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000058CD File Offset: 0x00003ACD
		public override byte[] RadioId
		{
			get
			{
				return global::System.Text.Encoding.ASCII.GetBytes(this.DeviceInstanceID);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000058DF File Offset: 0x00003ADF
		public override string RadioIdString
		{
			get
			{
				return base.PID + "_" + base.UniqueLocation;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000058F7 File Offset: 0x00003AF7
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000058FF File Offset: 0x00003AFF
		public uint InstanceId
		{
			get
			{
				return this._instanceId;
			}
			internal set
			{
				this._instanceId = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00005908 File Offset: 0x00003B08
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00005910 File Offset: 0x00003B10
		public string RadioModelNumber
		{
			get
			{
				return this.ModelNumber;
			}
			set
			{
				this.ModelNumber = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00005919 File Offset: 0x00003B19
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00005921 File Offset: 0x00003B21
		public string RadioSerialNumber
		{
			get
			{
				return this.SerialNumber;
			}
			set
			{
				this.SerialNumber = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000592A File Offset: 0x00003B2A
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00005932 File Offset: 0x00003B32
		internal string ParentDeviceInstanceID { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000593B File Offset: 0x00003B3B
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00005943 File Offset: 0x00003B43
		public string DeviceInstanceID { get; internal set; }

		// Token: 0x0400006C RID: 108
		private string SerialNumber;

		// Token: 0x0400006D RID: 109
		private string ModelNumber;

		// Token: 0x0400006E RID: 110
		private uint _instanceId;
	}
}
