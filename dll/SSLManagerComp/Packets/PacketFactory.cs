using System;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000031 RID: 49
	public static class PacketFactory
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0000770C File Offset: 0x0000590C
		public static global::SSLMangrComp.Packets.PacketBase GetPacket(byte[] data, ushort lengthbytes)
		{
			global::SSLMangrComp.Packets.PacketBase result = null;
			byte b = data[(int)lengthbytes];
			switch (b)
			{
			case 2:
			case 4:
				try
				{
					return new global::SSLMangrComp.Packets.Notify(data, lengthbytes);
				}
				catch (global::System.Exception ex)
				{
					global::System.Console.Write("Invalid Notify packet recived!\n\nDetails: " + ex.Message, "Error");
					return null;
				}
				break;
			case 3:
				return result;
			default:
				if (b != 11)
				{
					return result;
				}
				break;
			}
			return new global::SSLMangrComp.Packets.KeepAlive
			{
				MessageID = data[(int)lengthbytes],
				DialogID = global::System.BitConverter.ToUInt16(data, (int)(lengthbytes + 1))
			};
		}
	}
}
