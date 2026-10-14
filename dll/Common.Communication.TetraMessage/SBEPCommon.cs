using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	public static class SBEPCommon
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00006A78 File Offset: 0x00004C78
		public static global::Motorola.Common.Communication.TetraMsgOpResult ReverseBytesAndCopy(byte[] dstBuffer, int dstIndex, byte[] srcBuffer, int srcIndex, int reverseLength)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			if (dstBuffer == null || srcBuffer == null || reverseLength < 0)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (reverseLength > srcBuffer.Length - srcIndex)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (reverseLength > dstBuffer.Length - dstIndex)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (flag)
			{
				global::System.Array.Reverse(srcBuffer, srcIndex, reverseLength);
				global::System.Array.Copy(srcBuffer, srcIndex, dstBuffer, dstIndex, reverseLength);
				result = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public static global::Motorola.Common.Communication.TetraMsgOpResult Get_uOpCode(byte[] parseBuffer, out ushort uOpCode)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			uOpCode = 0;
			try
			{
				bool flag = true;
				if (parseBuffer.Length < 2)
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NOT_ENOUGH_LENGTH_TO_PARSE_OPCODE;
				}
				if (flag)
				{
					byte[] bytes = global::System.BitConverter.GetBytes(uOpCode);
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, parseBuffer, 0, 2);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
					if (flag)
					{
						uOpCode = global::System.BitConverter.ToUInt16(bytes, 0);
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
					}
				}
			}
			catch (global::System.Exception)
			{
			}
			return tetraMsgOpResult;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006B30 File Offset: 0x00004D30
		public static void AddCheckSum(byte[] buffer)
		{
			int num = 0;
			for (int i = 0; i < buffer.Length - 1; i++)
			{
				num += (int)buffer[i];
			}
			buffer[buffer.Length - 1] = (byte)(255 - num & 255);
		}
	}
}
