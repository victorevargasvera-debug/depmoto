using System;
using System.Globalization;
using System.Linq;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200002A RID: 42
	public class CPVersion
	{
		// Token: 0x0600015C RID: 348 RVA: 0x0000AE7E File Offset: 0x0000907E
		public CPVersion(string hexCpVer)
		{
			this.Init(hexCpVer, global::System.Globalization.NumberStyles.HexNumber);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000AEAB File Offset: 0x000090AB
		public CPVersion(byte[] binStructVer, byte[] binDefVer)
		{
			this.Init(binStructVer, binDefVer);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000AED4 File Offset: 0x000090D4
		public CPVersion(uint structVer, uint defVer)
		{
			byte[] bytes = global::System.BitConverter.GetBytes((ushort)structVer);
			byte[] bytes2 = global::System.BitConverter.GetBytes((ushort)defVer);
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
				global::System.Array.Reverse(bytes2);
			}
			this.Init(bytes, bytes2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000AF2C File Offset: 0x0000912C
		public override string ToString()
		{
			if (this.PrivateVer == 0)
			{
				return string.Format("{0:X2}{1:X2}", this.StructVerMajorPart, this.DefVerMajorPart);
			}
			return string.Format("{0:X2}{1:X2}{2}{3:X2}", new object[]
			{
				this.StructVerMajorPart,
				this.DefVerMajorPart,
				'-',
				this.PrivateVer
			});
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public static ushort GetStringMaxLength()
		{
			return (ushort)"7401-01".Length;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000AFB5 File Offset: 0x000091B5
		public uint ToUInt32()
		{
			return (uint)this.StructVerMajorPart * 256U + (uint)this.DefVerMajorPart;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000AFCA File Offset: 0x000091CA
		public ushort ToUInt16()
		{
			return global::System.Convert.ToUInt16((int)this.StructVerMajorPart * 256 + (int)this.DefVerMajorPart);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public byte[] GetBytes()
		{
			byte[] array = new byte[4];
			global::System.Array.Copy(this._structVer, array, 2);
			global::System.Array.Copy(this._defVer, 0, array, 2, 2);
			return array;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B015 File Offset: 0x00009215
		public static uint ToUInt32(string hexVersion)
		{
			return new global::Motorola.Common.Communication.TetraUtility.CPVersion(hexVersion).ToUInt32();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000B022 File Offset: 0x00009222
		public static ushort ToUint16(string hexVersion)
		{
			return new global::Motorola.Common.Communication.TetraUtility.CPVersion(hexVersion).ToUInt16();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000B02F File Offset: 0x0000922F
		public static byte[] GetBytes(string hexVersion)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.GetBytes(hexVersion, global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000B038 File Offset: 0x00009238
		public static byte[] GetBytes(string hexVersion, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder)
		{
			byte[] bytes = new global::Motorola.Common.Communication.TetraUtility.CPVersion(hexVersion).GetBytes();
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000B05B File Offset: 0x0000925B
		public static string ToHexString(ushort usCpVersion)
		{
			return string.Format("{0:X4}", usCpVersion);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000B070 File Offset: 0x00009270
		public static int Compare(string hexVersion1, string hexVersion2)
		{
			ushort num = 0;
			ushort value = 0;
			uint num2;
			global::Motorola.Common.Communication.TetraUtility.CPVersion.ParseVerString(hexVersion1, out num2, out num);
			uint num3;
			global::Motorola.Common.Communication.TetraUtility.CPVersion.ParseVerString(hexVersion2, out num3, out value);
			if (num2 == num3)
			{
				return num.CompareTo(value);
			}
			return num2.CompareTo(num3);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000B0AA File Offset: 0x000092AA
		public static bool operator >(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) > 0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000B0B6 File Offset: 0x000092B6
		public static bool operator >=(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) >= 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000B0C5 File Offset: 0x000092C5
		public static bool operator <(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) < 0;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000B0D1 File Offset: 0x000092D1
		public static bool operator <=(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) <= 0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000B0E0 File Offset: 0x000092E0
		public static bool operator ==(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return cpVersion1.Equals(cpVersion2) || global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) == 0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000B0F7 File Offset: 0x000092F7
		public static bool operator !=(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			return global::Motorola.Common.Communication.TetraUtility.CPVersion.Compare(cpVersion1, cpVersion2) != 0;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000B106 File Offset: 0x00009306
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000B10F File Offset: 0x0000930F
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000B117 File Offset: 0x00009317
		public static bool IsPrivateVersion(string cpVersion)
		{
			return new global::Motorola.Common.Communication.TetraUtility.CPVersion(cpVersion).IsPrivateVersion();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000B124 File Offset: 0x00009324
		public bool IsPrivateVersion()
		{
			return this.PrivateVer != 0;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000B134 File Offset: 0x00009334
		public static string GetBaseFormalVersion(string privateCpVersion)
		{
			if (privateCpVersion.Contains('-'))
			{
				string[] array = privateCpVersion.Split(new char[]
				{
					'-'
				});
				return array[0];
			}
			return privateCpVersion;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000B164 File Offset: 0x00009364
		private string Init(string cpVer, global::System.Globalization.NumberStyles style)
		{
			cpVer = cpVer.Trim();
			if (cpVer.Contains('-'))
			{
				string[] array = cpVer.Split(new char[]
				{
					'-'
				});
				byte[] bytes = global::System.BitConverter.GetBytes(ushort.Parse(array[0], style));
				if (global::System.BitConverter.IsLittleEndian)
				{
					global::System.Array.Reverse(bytes);
				}
				this.StructVerMajorPart = bytes[0];
				this.DefVerMajorPart = bytes[1];
				this.PrivateVer = byte.Parse(array[1]);
			}
			else
			{
				byte[] bytes2 = global::System.BitConverter.GetBytes(ushort.Parse(cpVer, style));
				if (global::System.BitConverter.IsLittleEndian)
				{
					global::System.Array.Reverse(bytes2);
				}
				this.StructVerMajorPart = bytes2[0];
				this.DefVerMajorPart = bytes2[1];
			}
			return cpVer;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000B202 File Offset: 0x00009402
		private void Init(byte[] binStructVer, byte[] binDefVer)
		{
			global::System.Array.Copy(binStructVer, this._structVer, 2);
			global::System.Array.Copy(binDefVer, this._defVer, 2);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000B21E File Offset: 0x0000941E
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000B228 File Offset: 0x00009428
		private byte StructVerMajorPart
		{
			get
			{
				return this._structVer[1];
			}
			set
			{
				this._structVer[1] = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000B233 File Offset: 0x00009433
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000B23D File Offset: 0x0000943D
		private byte DefVerMajorPart
		{
			get
			{
				return this._defVer[1];
			}
			set
			{
				this._defVer[1] = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000B248 File Offset: 0x00009448
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000B252 File Offset: 0x00009452
		private byte PrivateVer
		{
			get
			{
				return this._defVer[0];
			}
			set
			{
				this._defVer[0] = value;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000B260 File Offset: 0x00009460
		private static void ParseVerString(string hexVer, out uint version, out ushort privateVer)
		{
			string[] array = hexVer.Split(new char[]
			{
				'-'
			});
			version = uint.Parse(array[0], global::System.Globalization.NumberStyles.HexNumber);
			if (array.Length > 1)
			{
				privateVer = ushort.Parse(array[1], global::System.Globalization.NumberStyles.HexNumber);
				return;
			}
			privateVer = 0;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000B2AC File Offset: 0x000094AC
		private static int Compare(global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion1, global::Motorola.Common.Communication.TetraUtility.CPVersion cpVersion2)
		{
			if (cpVersion1.StructVerMajorPart != cpVersion2.StructVerMajorPart)
			{
				return (int)(cpVersion1.StructVerMajorPart - cpVersion2.StructVerMajorPart);
			}
			if (cpVersion1.DefVerMajorPart == cpVersion2.DefVerMajorPart)
			{
				return (int)(cpVersion1.PrivateVer - cpVersion2.PrivateVer);
			}
			return (int)(cpVersion1.DefVerMajorPart - cpVersion2.DefVerMajorPart);
		}

		// Token: 0x040000AA RID: 170
		private const char MinVerFlag = '-';

		// Token: 0x040000AB RID: 171
		private byte[] _structVer = new byte[2];

		// Token: 0x040000AC RID: 172
		private byte[] _defVer = new byte[2];
	}
}
