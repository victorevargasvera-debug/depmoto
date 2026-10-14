using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000031 RID: 49
	public class XcmpComponentRead : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003EAB File Offset: 0x000020AB
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003EB3 File Offset: 0x000020B3
		public ushort NumberOfFiles { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003EBC File Offset: 0x000020BC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003EC4 File Offset: 0x000020C4
		public byte[] Information
		{
			get
			{
				return this.m_xferInformation;
			}
			private set
			{
				this.m_xferInformation = value;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003ED0 File Offset: 0x000020D0
		public XcmpComponentRead(ushort componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, byte listType, byte[] list)
		{
			base.Opcode = 270;
			this.m_componentType = componentType;
			this.m_componentInstance = componentInstance;
			this.m_level = (byte)level;
			this.m_listType = listType;
			this.m_list_length = (ushort)((list == null) ? 0 : list.Length);
			this.m_list = list;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003F25 File Offset: 0x00002125
		public XcmpComponentRead(ushort componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, byte listType)
		{
			base.Opcode = 270;
			this.m_componentType = componentType;
			this.m_componentInstance = componentInstance;
			this.m_level = (byte)level;
			this.m_listType = listType;
			this.m_list_length = 0;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003F5C File Offset: 0x0000215C
		public static int RequestHeaderLength
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003F60 File Offset: 0x00002160
		public static uint GetListItemLength(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStruct)
		{
			uint result;
			switch (listStruct)
			{
			case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes:
			case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions:
				result = 2U;
				break;
			case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshStartEndPairs:
			case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds:
				result = 4U;
				break;
			default:
				result = 0U;
				break;
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003F98 File Offset: 0x00002198
		public static byte[] ConvertListItemToBytes(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStruct, global::System.Collections.IEnumerable listItems)
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			try
			{
				foreach (object obj in listItems)
				{
					switch (listStruct)
					{
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes:
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions:
					{
						byte[] bytes = global::System.BitConverter.GetBytes((ushort)obj);
						if (global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						list.AddRange(bytes);
						break;
					}
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds:
					{
						global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair xcmpComponentTypeIdPair = (global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair)obj;
						byte[] bytes = global::System.BitConverter.GetBytes(xcmpComponentTypeIdPair.Type);
						if (global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						list.AddRange(bytes);
						bytes = global::System.BitConverter.GetBytes(xcmpComponentTypeIdPair.ID);
						if (global::System.BitConverter.IsLittleEndian)
						{
							global::System.Array.Reverse(bytes);
						}
						list.AddRange(bytes);
						break;
					}
					}
				}
			}
			catch (global::System.InvalidCastException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument, systemException);
			}
			return list.ToArray();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000040A4 File Offset: 0x000022A4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_list == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_componentType,
					this.m_componentInstance,
					this.m_level,
					this.m_listType,
					this.m_list_length
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_componentType,
				this.m_componentInstance,
				this.m_level,
				this.m_listType,
				this.m_list_length,
				this.m_list
			});
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000418C File Offset: 0x0000238C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.NumberOfFiles = (ushort)((int)replyBuffer[offset + 4] | (int)replyBuffer[offset + 3] << 8);
				int num = length - 5;
				if (this.m_xferInformation == null)
				{
					this.m_xferInformation = new byte[num];
				}
				else if (num != this.m_xferInformation.Length)
				{
					global::System.Array.Resize<byte>(ref this.m_xferInformation, num);
				}
				global::System.Array.Copy(replyBuffer, offset + 5, this.m_xferInformation, 0, num);
			}
		}

		// Token: 0x040000D8 RID: 216
		public const int InactiveComponentInstance = 2;

		// Token: 0x040000D9 RID: 217
		private ushort m_componentType;

		// Token: 0x040000DA RID: 218
		private ushort m_componentInstance;

		// Token: 0x040000DB RID: 219
		private byte m_level;

		// Token: 0x040000DC RID: 220
		private byte m_listType;

		// Token: 0x040000DD RID: 221
		private byte[] m_list;

		// Token: 0x040000DE RID: 222
		private ushort m_list_length;

		// Token: 0x040000DF RID: 223
		private byte[] m_xferInformation;

		// Token: 0x02000032 RID: 50
		public enum Level : byte
		{
			// Token: 0x040000E2 RID: 226
			GetVersion,
			// Token: 0x040000E3 RID: 227
			GetGlobalChange,
			// Token: 0x040000E4 RID: 228
			GetTypeChanges,
			// Token: 0x040000E5 RID: 229
			GetItemChanges,
			// Token: 0x040000E6 RID: 230
			ReadComponentData,
			// Token: 0x040000E7 RID: 231
			ReadDifferentialData
		}

		// Token: 0x02000033 RID: 51
		[global::System.Flags]
		public enum ComponentType : ushort
		{
			// Token: 0x040000E9 RID: 233
			None = 0,
			// Token: 0x040000EA RID: 234
			IshCodeplug = 1,
			// Token: 0x040000EB RID: 235
			NonIshCodeplug = 2,
			// Token: 0x040000EC RID: 236
			Arm = 3,
			// Token: 0x040000ED RID: 237
			Dsp = 4,
			// Token: 0x040000EE RID: 238
			Mace = 5,
			// Token: 0x040000EF RID: 239
			CouP = 6,
			// Token: 0x040000F0 RID: 240
			LanguagePack = 7,
			// Token: 0x040000F1 RID: 241
			LocalLangPack = 8,
			// Token: 0x040000F2 RID: 242
			LangSetupInfo = 9,
			// Token: 0x040000F3 RID: 243
			ToneFile = 10,
			// Token: 0x040000F4 RID: 244
			RoamingLog = 11,
			// Token: 0x040000F5 RID: 245
			ErrorLog = 12,
			// Token: 0x040000F6 RID: 246
			ControlHeadFW = 14,
			// Token: 0x040000F7 RID: 247
			ControlHeadCplg = 15,
			// Token: 0x040000F8 RID: 248
			EncryptionKey = 16,
			// Token: 0x040000F9 RID: 249
			CurrentConfig = 17,
			// Token: 0x040000FA RID: 250
			PossibleConfig = 18,
			// Token: 0x040000FB RID: 251
			Pictures = 19
		}

		// Token: 0x02000034 RID: 52
		[global::System.Flags]
		public enum ListMode : byte
		{
			// Token: 0x040000FD RID: 253
			CompleteList = 0,
			// Token: 0x040000FE RID: 254
			NewList = 64,
			// Token: 0x040000FF RID: 255
			ListContinue = 128,
			// Token: 0x04000100 RID: 256
			ListEnds = 192
		}

		// Token: 0x02000035 RID: 53
		public enum ListStructure : byte
		{
			// Token: 0x04000102 RID: 258
			NoList,
			// Token: 0x04000103 RID: 259
			ListofIshTypes,
			// Token: 0x04000104 RID: 260
			ListofIshStartEndPairs,
			// Token: 0x04000105 RID: 261
			ListofIshTypeIds,
			// Token: 0x04000106 RID: 262
			ListofIshPartitions
		}
	}
}
