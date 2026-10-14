using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public static class SerialNumberValidator
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00003348 File Offset: 0x00001548
		public static bool ValidateSerialNumber(string serialNumber)
		{
			bool result = false;
			try
			{
				byte[] bytes = global::System.Convert.FromBase64String(serialNumber);
				serialNumber = global::System.Text.Encoding.ASCII.GetString(bytes);
			}
			catch (global::System.Exception)
			{
			}
			if (serialNumber.Length == 10)
			{
				if (char.IsUpper(serialNumber[8]) || char.IsUpper(serialNumber[9]))
				{
					global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("[0-9][0-9][0-9][0-9A-Z-[O]][A-Z-[IO]][A-Z-[IO]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]]");
					if (regex.IsMatch(serialNumber))
					{
						result = true;
					}
				}
				else
				{
					global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("[0-9][0-9][0-9][0-9A-Z-[O]][A-Z-[IO]][A-Z-[IO]][0-9A-Z-[IO]][0-9A-Z-[IO]][0-9A-Z-[AEIOUY]][0-9A-Z-[AEIOUY]]");
					if (regex.IsMatch(serialNumber))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000340C File Offset: 0x0000160C
		public static bool IsCBISerialNumber(string serialNumber)
		{
			bool result = true;
			if (global::Motorola.Common.Communication.SerialNumberValidator.ValidateSerialNumber(serialNumber))
			{
				result = false;
			}
			else
			{
				byte[] array = global::System.Convert.FromBase64String(serialNumber);
				if (array.Length == global::Motorola.Common.Communication.SerialNumberValidator.CBI.Length)
				{
					for (int i = 0; i < global::Motorola.Common.Communication.SerialNumberValidator.CBI.Length; i++)
					{
						if (global::Motorola.Common.Communication.SerialNumberValidator.CBI[i] != array[i])
						{
							result = false;
							break;
						}
					}
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0400003E RID: 62
		public const short SERIALNUMBERSIZE = 10;

		// Token: 0x0400003F RID: 63
		private static readonly byte[] CBI = new byte[]
		{
			200,
			212,
			221,
			157,
			162,
			204,
			132,
			209,
			157,
			175
		};
	}
}
