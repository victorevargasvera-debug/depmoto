using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000032 RID: 50
	public class TarHeader : global::System.ICloneable
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000A0DC File Offset: 0x000090DC
		public TarHeader()
		{
			this.Magic = "ustar ";
			this.Version = " ";
			this.Name = "";
			this.LinkName = "";
			this.UserId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId;
			this.GroupId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId;
			this.UserName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser;
			this.GroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName;
			this.Size = 0L;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000A14F File Offset: 0x0000914F
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000A157 File Offset: 0x00009157
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.name = value;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A16E File Offset: 0x0000916E
		[global::System.Obsolete("Use the Name property instead", true)]
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000A176 File Offset: 0x00009176
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000A17E File Offset: 0x0000917E
		public int Mode
		{
			get
			{
				return this.mode;
			}
			set
			{
				this.mode = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000A187 File Offset: 0x00009187
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000A18F File Offset: 0x0000918F
		public int UserId
		{
			get
			{
				return this.userId;
			}
			set
			{
				this.userId = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A198 File Offset: 0x00009198
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000A1A0 File Offset: 0x000091A0
		public int GroupId
		{
			get
			{
				return this.groupId;
			}
			set
			{
				this.groupId = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000A1A9 File Offset: 0x000091A9
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000A1B1 File Offset: 0x000091B1
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				if (value < 0L)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Cannot be less than zero");
				}
				this.size = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000A1CF File Offset: 0x000091CF
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000A1D8 File Offset: 0x000091D8
		public global::System.DateTime ModTime
		{
			get
			{
				return this.modTime;
			}
			set
			{
				if (value < global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "ModTime cannot be before Jan 1st 1970");
				}
				this.modTime = new global::System.DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000A237 File Offset: 0x00009237
		public int Checksum
		{
			get
			{
				return this.checksum;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000A23F File Offset: 0x0000923F
		public bool IsChecksumValid
		{
			get
			{
				return this.isChecksumValid;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000A247 File Offset: 0x00009247
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000A24F File Offset: 0x0000924F
		public byte TypeFlag
		{
			get
			{
				return this.typeFlag;
			}
			set
			{
				this.typeFlag = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000A258 File Offset: 0x00009258
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000A260 File Offset: 0x00009260
		public string LinkName
		{
			get
			{
				return this.linkName;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.linkName = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000A277 File Offset: 0x00009277
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000A27F File Offset: 0x0000927F
		public string Magic
		{
			get
			{
				return this.magic;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.magic = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000A296 File Offset: 0x00009296
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000A29E File Offset: 0x0000929E
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.version = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000A2B5 File Offset: 0x000092B5
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000A2C0 File Offset: 0x000092C0
		public string UserName
		{
			get
			{
				return this.userName;
			}
			set
			{
				if (value != null)
				{
					this.userName = value.Substring(0, global::System.Math.Min(32, value.Length));
					return;
				}
				string text = global::System.Environment.UserName;
				if (text.Length > 32)
				{
					text = text.Substring(0, 32);
				}
				this.userName = text;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000A30C File Offset: 0x0000930C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000A314 File Offset: 0x00009314
		public string GroupName
		{
			get
			{
				return this.groupName;
			}
			set
			{
				if (value == null)
				{
					this.groupName = "None";
					return;
				}
				this.groupName = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A32C File Offset: 0x0000932C
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000A334 File Offset: 0x00009334
		public int DevMajor
		{
			get
			{
				return this.devMajor;
			}
			set
			{
				this.devMajor = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000A33D File Offset: 0x0000933D
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000A345 File Offset: 0x00009345
		public int DevMinor
		{
			get
			{
				return this.devMinor;
			}
			set
			{
				this.devMinor = value;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A34E File Offset: 0x0000934E
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A358 File Offset: 0x00009358
		public void ParseBuffer(byte[] header)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			int num = 0;
			this.name = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 100).ToString();
			num += 100;
			this.mode = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.UserId = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.GroupId = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.Size = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 12);
			num += 12;
			this.ModTime = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetDateTimeFromCTime(global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 12));
			num += 12;
			this.checksum = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.TypeFlag = header[num++];
			this.LinkName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 100).ToString();
			num += 100;
			this.Magic = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 6).ToString();
			num += 6;
			this.Version = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 2).ToString();
			num += 2;
			this.UserName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 32).ToString();
			num += 32;
			this.GroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 32).ToString();
			num += 32;
			this.DevMajor = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.DevMinor = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			this.isChecksumValid = (this.Checksum == global::ICSharpCode.SharpZipLib.Tar.TarHeader.MakeCheckSum(header));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A4C4 File Offset: 0x000094C4
		public void WriteHeader(byte[] outBuffer)
		{
			if (outBuffer == null)
			{
				throw new global::System.ArgumentNullException("outBuffer");
			}
			int i = 0;
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.Name, outBuffer, i, 100);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.mode, outBuffer, i, 8);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.UserId, outBuffer, i, 8);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.GroupId, outBuffer, i, 8);
			long value = this.Size;
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetLongOctalBytes(value, outBuffer, i, 12);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetLongOctalBytes((long)global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetCTime(this.ModTime), outBuffer, i, 12);
			int offset = i;
			for (int j = 0; j < 8; j++)
			{
				outBuffer[i++] = 32;
			}
			outBuffer[i++] = this.TypeFlag;
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.LinkName, outBuffer, i, 100);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetAsciiBytes(this.Magic, 0, outBuffer, i, 6);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.Version, outBuffer, i, 2);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.UserName, outBuffer, i, 32);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.GroupName, outBuffer, i, 32);
			if (this.TypeFlag == 51 || this.TypeFlag == 52)
			{
				i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.DevMajor, outBuffer, i, 8);
				i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.DevMinor, outBuffer, i, 8);
			}
			while (i < outBuffer.Length)
			{
				outBuffer[i++] = 0;
			}
			this.checksum = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ComputeCheckSum(outBuffer);
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetCheckSumOctalBytes((long)this.checksum, outBuffer, offset, 8);
			this.isChecksumValid = true;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A623 File Offset: 0x00009623
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A630 File Offset: 0x00009630
		public override bool Equals(object obj)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = obj as global::ICSharpCode.SharpZipLib.Tar.TarHeader;
			return tarHeader != null && (this.name == tarHeader.name && this.mode == tarHeader.mode && this.UserId == tarHeader.UserId && this.GroupId == tarHeader.GroupId && this.Size == tarHeader.Size && this.ModTime == tarHeader.ModTime && this.Checksum == tarHeader.Checksum && this.TypeFlag == tarHeader.TypeFlag && this.LinkName == tarHeader.LinkName && this.Magic == tarHeader.Magic && this.Version == tarHeader.Version && this.UserName == tarHeader.UserName && this.GroupName == tarHeader.GroupName && this.DevMajor == tarHeader.DevMajor) && this.DevMinor == tarHeader.DevMinor;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A758 File Offset: 0x00009758
		internal static void SetValueDefaults(int userId, string userName, int groupId, string groupName)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.userIdAsSet = userId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId = userId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.userNameAsSet = userName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser = userName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupIdAsSet = groupId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId = groupId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupNameAsSet = groupName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName = groupName;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A78A File Offset: 0x0000978A
		internal static void RestoreSetValues()
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.userIdAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser = global::ICSharpCode.SharpZipLib.Tar.TarHeader.userNameAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupIdAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupNameAsSet;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A7B4 File Offset: 0x000097B4
		public static long ParseOctal(byte[] header, int offset, int length)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			long num = 0L;
			bool flag = true;
			int num2 = offset + length;
			int num3 = offset;
			while (num3 < num2 && header[num3] != 0)
			{
				if (header[num3] != 32 && header[num3] != 48)
				{
					goto IL_38;
				}
				if (!flag)
				{
					if (header[num3] != 32)
					{
						goto IL_38;
					}
					break;
				}
				IL_46:
				num3++;
				continue;
				IL_38:
				flag = false;
				num = (num << 3) + (long)(header[num3] - 48);
				goto IL_46;
			}
			return num;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A810 File Offset: 0x00009810
		public static global::System.Text.StringBuilder ParseName(byte[] header, int offset, int length)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be less than zero");
			}
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length", "Cannot be less than zero");
			}
			if (offset + length > header.Length)
			{
				throw new global::System.ArgumentException("Exceeds header size", "length");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
			int num = offset;
			while (num < offset + length && header[num] != 0)
			{
				stringBuilder.Append((char)header[num]);
				num++;
			}
			return stringBuilder;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A890 File Offset: 0x00009890
		public static int GetNameBytes(global::System.Text.StringBuilder name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name.ToString(), nameOffset, buffer, bufferOffset, length);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A8C0 File Offset: 0x000098C0
		public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int i;
			for (i = 0; i < length - 1; i++)
			{
				if (nameOffset + i >= name.Length)
				{
					break;
				}
				buffer[bufferOffset + i] = (byte)name[nameOffset + i];
			}
			while (i < length)
			{
				buffer[bufferOffset + i] = 0;
				i++;
			}
			return bufferOffset + length;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A927 File Offset: 0x00009927
		public static int GetNameBytes(global::System.Text.StringBuilder name, byte[] buffer, int offset, int length)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name.ToString(), 0, buffer, offset, length);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A954 File Offset: 0x00009954
		public static int GetNameBytes(string name, byte[] buffer, int offset, int length)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name, 0, buffer, offset, length);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A97C File Offset: 0x0000997C
		public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			if (toAdd == null)
			{
				throw new global::System.ArgumentNullException("toAdd");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int num = 0;
			while (num < length && nameOffset + num < toAdd.Length)
			{
				buffer[bufferOffset + num] = (byte)toAdd[nameOffset + num];
				num++;
			}
			return bufferOffset + length;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A9D0 File Offset: 0x000099D0
		public static int GetOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int i = length - 1;
			buffer[offset + i] = 0;
			i--;
			if (value > 0L)
			{
				long num = value;
				while (i >= 0)
				{
					if (num <= 0L)
					{
						break;
					}
					buffer[offset + i] = 48 + (byte)(num & 7L);
					num >>= 3;
					i--;
				}
			}
			while (i >= 0)
			{
				buffer[offset + i] = 48;
				i--;
			}
			return offset + length;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000AA35 File Offset: 0x00009A35
		public static int GetLongOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes(value, buffer, offset, length);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000AA40 File Offset: 0x00009A40
		private static int GetCheckSumOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes(value, buffer, offset, length - 1);
			return offset + length;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000AA54 File Offset: 0x00009A54
		private static int ComputeCheckSum(byte[] buffer)
		{
			int num = 0;
			for (int i = 0; i < buffer.Length; i++)
			{
				num += (int)buffer[i];
			}
			return num;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000AA78 File Offset: 0x00009A78
		private static int MakeCheckSum(byte[] buffer)
		{
			int num = 0;
			for (int i = 0; i < 148; i++)
			{
				num += (int)buffer[i];
			}
			for (int j = 0; j < 8; j++)
			{
				num += 32;
			}
			for (int k = 156; k < buffer.Length; k++)
			{
				num += (int)buffer[k];
			}
			return num;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AAC8 File Offset: 0x00009AC8
		private static int GetCTime(global::System.DateTime dateTime)
		{
			return (int)((dateTime.Ticks - global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970.Ticks) / 10000000L);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AAF4 File Offset: 0x00009AF4
		private static global::System.DateTime GetDateTimeFromCTime(long ticks)
		{
			global::System.DateTime result;
			try
			{
				result = new global::System.DateTime(global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970.Ticks + ticks * 10000000L);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970;
			}
			return result;
		}

		// Token: 0x040000C1 RID: 193
		public const int NAMELEN = 100;

		// Token: 0x040000C2 RID: 194
		public const int MODELEN = 8;

		// Token: 0x040000C3 RID: 195
		public const int UIDLEN = 8;

		// Token: 0x040000C4 RID: 196
		public const int GIDLEN = 8;

		// Token: 0x040000C5 RID: 197
		public const int CHKSUMLEN = 8;

		// Token: 0x040000C6 RID: 198
		public const int CHKSUMOFS = 148;

		// Token: 0x040000C7 RID: 199
		public const int SIZELEN = 12;

		// Token: 0x040000C8 RID: 200
		public const int MAGICLEN = 6;

		// Token: 0x040000C9 RID: 201
		public const int VERSIONLEN = 2;

		// Token: 0x040000CA RID: 202
		public const int MODTIMELEN = 12;

		// Token: 0x040000CB RID: 203
		public const int UNAMELEN = 32;

		// Token: 0x040000CC RID: 204
		public const int GNAMELEN = 32;

		// Token: 0x040000CD RID: 205
		public const int DEVLEN = 8;

		// Token: 0x040000CE RID: 206
		public const byte LF_OLDNORM = 0;

		// Token: 0x040000CF RID: 207
		public const byte LF_NORMAL = 48;

		// Token: 0x040000D0 RID: 208
		public const byte LF_LINK = 49;

		// Token: 0x040000D1 RID: 209
		public const byte LF_SYMLINK = 50;

		// Token: 0x040000D2 RID: 210
		public const byte LF_CHR = 51;

		// Token: 0x040000D3 RID: 211
		public const byte LF_BLK = 52;

		// Token: 0x040000D4 RID: 212
		public const byte LF_DIR = 53;

		// Token: 0x040000D5 RID: 213
		public const byte LF_FIFO = 54;

		// Token: 0x040000D6 RID: 214
		public const byte LF_CONTIG = 55;

		// Token: 0x040000D7 RID: 215
		public const byte LF_GHDR = 103;

		// Token: 0x040000D8 RID: 216
		public const byte LF_XHDR = 120;

		// Token: 0x040000D9 RID: 217
		public const byte LF_ACL = 65;

		// Token: 0x040000DA RID: 218
		public const byte LF_GNU_DUMPDIR = 68;

		// Token: 0x040000DB RID: 219
		public const byte LF_EXTATTR = 69;

		// Token: 0x040000DC RID: 220
		public const byte LF_META = 73;

		// Token: 0x040000DD RID: 221
		public const byte LF_GNU_LONGLINK = 75;

		// Token: 0x040000DE RID: 222
		public const byte LF_GNU_LONGNAME = 76;

		// Token: 0x040000DF RID: 223
		public const byte LF_GNU_MULTIVOL = 77;

		// Token: 0x040000E0 RID: 224
		public const byte LF_GNU_NAMES = 78;

		// Token: 0x040000E1 RID: 225
		public const byte LF_GNU_SPARSE = 83;

		// Token: 0x040000E2 RID: 226
		public const byte LF_GNU_VOLHDR = 86;

		// Token: 0x040000E3 RID: 227
		public const string TMAGIC = "ustar ";

		// Token: 0x040000E4 RID: 228
		public const string GNU_TMAGIC = "ustar  ";

		// Token: 0x040000E5 RID: 229
		private const long timeConversionFactor = 10000000L;

		// Token: 0x040000E6 RID: 230
		private static readonly global::System.DateTime dateTime1970 = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0);

		// Token: 0x040000E7 RID: 231
		private string name;

		// Token: 0x040000E8 RID: 232
		private int mode;

		// Token: 0x040000E9 RID: 233
		private int userId;

		// Token: 0x040000EA RID: 234
		private int groupId;

		// Token: 0x040000EB RID: 235
		private long size;

		// Token: 0x040000EC RID: 236
		private global::System.DateTime modTime;

		// Token: 0x040000ED RID: 237
		private int checksum;

		// Token: 0x040000EE RID: 238
		private bool isChecksumValid;

		// Token: 0x040000EF RID: 239
		private byte typeFlag;

		// Token: 0x040000F0 RID: 240
		private string linkName;

		// Token: 0x040000F1 RID: 241
		private string magic;

		// Token: 0x040000F2 RID: 242
		private string version;

		// Token: 0x040000F3 RID: 243
		private string userName;

		// Token: 0x040000F4 RID: 244
		private string groupName;

		// Token: 0x040000F5 RID: 245
		private int devMajor;

		// Token: 0x040000F6 RID: 246
		private int devMinor;

		// Token: 0x040000F7 RID: 247
		internal static int userIdAsSet;

		// Token: 0x040000F8 RID: 248
		internal static int groupIdAsSet;

		// Token: 0x040000F9 RID: 249
		internal static string userNameAsSet;

		// Token: 0x040000FA RID: 250
		internal static string groupNameAsSet = "None";

		// Token: 0x040000FB RID: 251
		internal static int defaultUserId;

		// Token: 0x040000FC RID: 252
		internal static int defaultGroupId;

		// Token: 0x040000FD RID: 253
		internal static string defaultGroupName = "None";

		// Token: 0x040000FE RID: 254
		internal static string defaultUser;
	}
}
