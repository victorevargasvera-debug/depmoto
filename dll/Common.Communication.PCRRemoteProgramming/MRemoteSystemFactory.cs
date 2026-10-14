using System;
using System.Globalization;
using System.Text;
using LEAdaptor;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000007 RID: 7
	internal class MRemoteSystemFactory
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public static global::LEAdaptor.IMRemoteSystem Create(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo info)
		{
			global::LEAdaptor.IMRemoteSystem result = null;
			switch (info.SystemType)
			{
			case global::Motorola.Common.Communication.CommonUtil.PCRIPSystemType.DMR:
			{
				byte[] array = info.AuthenticationKey;
				bool flag = false;
				if (array != null && array.GetLength(0) > 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						int num = int.Parse(global::System.Text.Encoding.ASCII.GetString(array, i, 1), global::System.Globalization.NumberStyles.HexNumber);
						if (num != 0)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					byte[] array2 = new byte[20];
					int j = array.Length - 1;
					int num2 = 20;
					while (j >= 0)
					{
						int num3 = (j - 1 >= 0) ? int.Parse(global::System.Text.Encoding.ASCII.GetString(array, j - 1, 1), global::System.Globalization.NumberStyles.HexNumber) : 0;
						int num4 = int.Parse(global::System.Text.Encoding.ASCII.GetString(array, j, 1), global::System.Globalization.NumberStyles.HexNumber);
						array2[num2 - 1] = (byte)(num3 * 16 + num4);
						j -= 2;
						num2--;
					}
					array = array2;
				}
				else
				{
					array = null;
				}
				result = new global::LEAdaptor.MRemoteSystem((byte)info.LocalType, info.LocalID, (ushort)info.LocalUDPPort, info.RemoteHostNameOrAddress, (ushort)info.RemotePort, (ushort)global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.SYSTEM_ID_APP, array);
				break;
			}
			case global::Motorola.Common.Communication.CommonUtil.PCRIPSystemType.DMR3:
			{
				uint networkID = info.NetworkID;
				ushort siteID = (ushort)(info.LocalID >> 15 & 1023U);
				byte redundancyGrpID = (byte)(info.LocalID & 1U);
				uint peerID = (uint)((ushort)(info.LocalID >> 4 & 31U));
				result = new global::LEAdaptor.EmeraldRemoteSystem(info.RemoteHostNameOrAddress, (ushort)info.RemotePort, info.DeviceVersion, (ushort)networkID, siteID, redundancyGrpID, peerID, (ushort)info.LocalUDPPort);
				break;
			}
			}
			return result;
		}
	}
}
