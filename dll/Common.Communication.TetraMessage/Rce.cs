using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public class Rce
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000042BA File Offset: 0x000024BA
		public bool OpenTransport()
		{
			if (this._transport == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.Open: The transport is null");
				return false;
			}
			return (this._transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).OpenPort();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000042EA File Offset: 0x000024EA
		public bool CloseTransport()
		{
			if (this._transport == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.Close: The transport is null");
				return false;
			}
			this._transport.ClosePort();
			return true;
		}

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00004316 File Offset: 0x00002516
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Transport
		{
			set
			{
				this._transport = value;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004320 File Offset: 0x00002520
		public bool DownloadImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			if (image == null || image.Count == 0 || image[0].GetType() != typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.DownloadImage: the input image is illegal");
				return false;
			}
			if (this._transport == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.DownloadImage: The transport is null");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = this._transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			tetraCommPipe.PurgeInputBuffer();
			tetraCommPipe.PurgeOutputBuffer();
			tetraCommPipe.WriteTimeout = (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DEFAULT_TIMEOUT;
			tetraCommPipe.ReadTimeout = (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DEFAULT_TIMEOUT;
			uint num = global::System.Convert.ToUInt32(image[0].Address);
			uint num2 = global::System.Convert.ToUInt32(image[image.Count - 1].Address) + image[image.Count - 1].Size - 1U;
			uint num3 = num2 - num + 1U;
			bool flag = num3 > 65535U;
			uint num4 = flag ? 14U : 12U;
			byte[] array = new byte[num4];
			if (flag)
			{
				array[0] = 170;
				array[1] = 85;
				array[2] = 85;
				array[3] = 170;
				array[4] = (byte)(num >> 24 & 255U);
				array[5] = (byte)(num >> 16 & 255U);
				array[6] = (byte)(num >> 8 & 255U);
				array[7] = (byte)(num & 255U);
				array[8] = (byte)(num3 >> 24 & 255U);
				array[9] = (byte)(num3 >> 16 & 255U);
				array[10] = (byte)(num3 >> 8 & 255U);
				array[11] = (byte)(num3 & 255U);
				array[12] = 0;
				array[13] = 0;
			}
			else
			{
				array[0] = 85;
				array[1] = 85;
				array[2] = 85;
				array[3] = 170;
				array[4] = (byte)(num >> 24 & 255U);
				array[5] = (byte)(num >> 16 & 255U);
				array[6] = (byte)(num >> 8 & 255U);
				array[7] = (byte)(num & 255U);
				array[8] = (byte)(num3 >> 8 & 255U);
				array[9] = (byte)(num3 & 255U);
				array[10] = 0;
				array[11] = 0;
			}
			byte[] array2 = new byte[num3 + 1U];
			int num5 = 0;
			while ((long)num5 < (long)((ulong)(num3 + 1U)))
			{
				array2[num5] = 0;
				num5++;
			}
			for (int i = 0; i < image.Count; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = image[i];
				uint num6 = global::System.Convert.ToUInt32(memoryUnit.Address) - num;
				global::System.Array.Copy(memoryUnit.Data, 0L, array2, (long)((ulong)num6), (long)((ulong)memoryUnit.Size));
			}
			byte b = 0;
			int num7 = 4;
			while ((long)num7 < (long)((ulong)num4))
			{
				b += array[num7];
				num7++;
			}
			int num8 = 0;
			while ((long)num8 < (long)((ulong)num3))
			{
				b += array2[num8];
				num8++;
			}
			b = byte.MaxValue - b;
			array2[(int)((global::System.UIntPtr)num3)] = b;
			int num9 = tetraCommPipe.SendData(array, 0, array.Length);
			if (num9 != array.Length)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.DownloadImage: Send RCE header error dataSent={0}", new object[]
				{
					num9
				});
				return false;
			}
			num9 = tetraCommPipe.SendData(array2, 0, array2.Length);
			if (num9 != array2.Length)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.DownloadImage: Send RCE body error dataSent={0}", new object[]
				{
					num9
				});
				return false;
			}
			return true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004688 File Offset: 0x00002888
		public bool DownloadUartMiniKernelImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			bool result;
			if (this.IsAutoBaudRate(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_KERNEL))
			{
				result = this.DownloadImage(image);
			}
			else
			{
				result = this.DownloadImage(image);
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000046B8 File Offset: 0x000028B8
		public bool DownloadUartPatriotKernelImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			bool flag = true;
			bool flag2 = this.IsAutoBaudRate(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_SBEP);
			if (!flag2)
			{
				flag2 = this.IsAutoBaudRate(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_57600);
			}
			if (!flag2)
			{
				flag2 = this.IsAutoBaudRate(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_KERNEL);
			}
			if (!flag2)
			{
				flag = false;
			}
			if (flag)
			{
				flag = this.DownloadImage(image);
			}
			return flag;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004704 File Offset: 0x00002904
		public bool GetAcknowledge()
		{
			if (this._transport == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.GetAcknowledge: The transport is null");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = this._transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (!tetraCommPipe.OpenPort())
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.GetAcknowledge: Can't open transport");
				return false;
			}
			byte[] array = new byte[1];
			tetraCommPipe.SupressTriggerUSBAnalyzer = true;
			int num = tetraCommPipe.ReceiveData(array, 0, 1);
			tetraCommPipe.SupressTriggerUSBAnalyzer = false;
			if (num != 1)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.GetAcknowledge: No ACK received dataRcv={0}", new object[]
				{
					num
				});
				return false;
			}
			if (array[0] != 80)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Rce.GetAcknowledge: ACK received but the content is not expected ACK={0}", new object[]
				{
					array[0]
				});
				return false;
			}
			return true;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000047D8 File Offset: 0x000029D8
		private bool IsAutoBaudRate(int baudRate)
		{
			bool result = false;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = this._transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			tetraCommPipe.BaudRate = baudRate;
			bool flag = true;
			byte[] array = new byte[2];
			byte[] array2 = new byte[1];
			array[0] = 97;
			array[1] = 65;
			int i = 30;
			tetraCommPipe.WriteTimeout = 3000;
			tetraCommPipe.ReadTimeout = 500;
			while (i >= 0)
			{
				int num = tetraCommPipe.SendData(array, 0, array.Length);
				global::System.Threading.Thread.Sleep(50);
				if (num != 2)
				{
					break;
				}
				if (flag)
				{
					tetraCommPipe.ReceiveData(array2, 0, array2.Length);
					if (array2[0] == 90)
					{
						result = true;
						break;
					}
				}
				i--;
			}
			return result;
		}

		// Token: 0x04000030 RID: 48
		private const byte RCEBOOT_ACK = 80;

		// Token: 0x04000031 RID: 49
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _transport;
	}
}
