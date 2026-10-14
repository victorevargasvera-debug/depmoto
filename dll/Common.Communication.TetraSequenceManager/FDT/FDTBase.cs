using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.FDT
{
	// Token: 0x02000005 RID: 5
	public class FDTBase
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000252C File Offset: 0x0000072C
		public static bool IsFDTSupportedbyCPRange(ushort modeltype, string version)
		{
			string text = string.Empty;
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modeltype);
			if (model == null)
			{
				return false;
			}
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapVersionMapConfigTable.RecordsList)
			{
				if (model.UniqueModelNumber.ToLowerInvariant() == memMapVersionMapRecord.ModelNumber.ToLowerInvariant() && global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(version, memMapVersionMapRecord.CPRange))
				{
					text = memMapVersionMapRecord.MemMapID;
					break;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			string key = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT.ToString().Substring(4);
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapConfigTable.RecordsList)
			{
				if (memMapRecord.MemMapID == text && memMapRecord.MapDefinition.ContainsKey(key) && memMapRecord.MapDefinition[key].Count == 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000266C File Offset: 0x0000086C
		public global::Motorola.Common.Communication.CommonUtil.FDTType SectionIDtoUnitType(uint sectionId)
		{
			if (sectionId <= 1179865163U)
			{
				if (sectionId <= 1129335879U)
				{
					if (sectionId == 0U)
					{
						return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_BAD_RECORD;
					}
					if (sectionId == 1129335879U)
					{
						return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG;
					}
				}
				else
				{
					if (sectionId == 1178883154U)
					{
						return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
					}
					if (sectionId == 1179473746U)
					{
						return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE;
					}
					if (sectionId == 1179865163U)
					{
						return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS;
					}
				}
			}
			else if (sectionId <= 1262836051U)
			{
				if (sectionId == 1179931216U)
				{
					return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP;
				}
				if (sectionId == 1262836051U)
				{
					return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_KEY;
				}
			}
			else
			{
				if (sectionId == 1280264004U)
				{
					return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA;
				}
				if (sectionId == 1380273225U)
				{
					return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_RELEASE_INFO;
				}
				if (sectionId == 4294967295U)
				{
					return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_DUMMY;
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026FC File Offset: 0x000008FC
		public global::Motorola.Common.Communication.FDT.FDTState StatetoUnitState(byte state)
		{
			switch (state)
			{
			case 0:
				return global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
			case 1:
				return global::Motorola.Common.Communication.FDT.FDTState.FDT_CORRUPTED;
			case 2:
				return global::Motorola.Common.Communication.FDT.FDTState.FDT_DELETED;
			default:
				if (state != 9)
				{
					return global::Motorola.Common.Communication.FDT.FDTState.FDT_CORRUPTED;
				}
				return global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002730 File Offset: 0x00000930
		public uint UnitTypetoSectionID(global::Motorola.Common.Communication.CommonUtil.FDTType type)
		{
			switch (type)
			{
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT:
				return 1178883154U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP:
				return 1179931216U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
				return 1179473746U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_KEY:
				return 1262836051U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
				return 1129335879U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
				return 1179865163U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA:
				return 1280264004U;
			case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_RELEASE_INFO:
				return 1380273225U;
			default:
				return 0U;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002798 File Offset: 0x00000998
		public byte UnitStatetoState(global::Motorola.Common.Communication.FDT.FDTState state)
		{
			switch (state)
			{
			case global::Motorola.Common.Communication.FDT.FDTState.FDT_READY:
				return 0;
			case global::Motorola.Common.Communication.FDT.FDTState.FDT_CORRUPTED:
				return 1;
			case global::Motorola.Common.Communication.FDT.FDTState.FDT_DELETED:
				return 2;
			case global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED:
				return 9;
			default:
				return 0;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000027CC File Offset: 0x000009CC
		public uint GetStartAddress(global::Motorola.Common.Communication.CommonUtil.FDTType type, ushort modeltype, string version)
		{
			string text = string.Empty;
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modeltype);
			if (model == null)
			{
				return 0U;
			}
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapVersionMapConfigTable.RecordsList)
			{
				if (model.UniqueModelNumber.ToLowerInvariant() == memMapVersionMapRecord.ModelNumber.ToLowerInvariant() && global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(version, memMapVersionMapRecord.CPRange))
				{
					text = memMapVersionMapRecord.MemMapID;
					break;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return 0U;
			}
			string key = type.ToString().Substring(4);
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapConfigTable.RecordsList)
			{
				if (memMapRecord.MemMapID == text && memMapRecord.MapDefinition.ContainsKey(key) && memMapRecord.MapDefinition[key].Count == 1)
				{
					return global::System.Convert.ToUInt32(memMapRecord.MapDefinition[key][0].Address);
				}
			}
			return 0U;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002928 File Offset: 0x00000B28
		public uint GetSize(global::Motorola.Common.Communication.CommonUtil.FDTType type, ushort modeltype, string version)
		{
			string text = "";
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modeltype);
			if (model == null)
			{
				return 0U;
			}
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapVersionMapConfigTable.RecordsList)
			{
				if (model.UniqueModelNumber.ToLowerInvariant() == memMapVersionMapRecord.ModelNumber.ToLowerInvariant() && global::Motorola.Common.Communication.TetraUtility.TetraUtil.InVersionRange(version, memMapVersionMapRecord.CPRange))
				{
					text = memMapVersionMapRecord.MemMapID;
					break;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return 0U;
			}
			string key = type.ToString().Substring(4);
			foreach (global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.MemMapConfigTable.RecordsList)
			{
				if (memMapRecord.MemMapID == text && memMapRecord.MapDefinition.ContainsKey(key) && memMapRecord.MapDefinition[key].Count == 1)
				{
					return global::System.Convert.ToUInt32(memMapRecord.MapDefinition[key][0].Size);
				}
			}
			return 0U;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A84 File Offset: 0x00000C84
		public void UnittoRec(global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit, global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec)
		{
			if (fdtUnit == null || fdtRec == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::UnittoRec: Input Parameters are not initialized.");
				return;
			}
			fdtRec.sectionId = this.UnitTypetoSectionID(fdtUnit.FdtType);
			fdtRec.state = this.UnitStatetoState(fdtUnit.State);
			string s = string.Format("{0:X4}.{1}", fdtUnit.ModelType, fdtUnit.Version);
			global::System.Text.Encoding encoding = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252);
			byte[] bytes = encoding.GetBytes(s);
			global::System.Array.Clear(fdtRec.versionName, 0, fdtRec.versionName.Length);
			global::System.Array.Copy(bytes, fdtRec.versionName, global::System.Math.Min(fdtRec.versionName.Length, bytes.Length));
			fdtRec.startAddress = this.GetStartAddress(fdtUnit.FdtType, fdtUnit.ModelType, fdtUnit.CPVersion);
			fdtRec.size = this.GetSize(fdtUnit.FdtType, fdtUnit.ModelType, fdtUnit.CPVersion);
			byte[] array = (byte[])fdtUnit.Reserved.Clone();
			global::System.Array.Clear(fdtRec.reserved, 0, fdtRec.reserved.Length);
			global::System.Array.Copy(array, fdtRec.reserved, global::System.Math.Min(fdtRec.reserved.Length, array.Length));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002BAC File Offset: 0x00000DAC
		public void RECtoUnit(global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec, global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			if (fdtUnit == null || fdtRec == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::RECtoUnit: Input Parameters are not initialized.");
				return;
			}
			fdtUnit.FdtType = this.SectionIDtoUnitType(fdtRec.sectionId);
			fdtUnit.State = this.StatetoUnitState(fdtRec.state);
			global::System.Text.Encoding encoding = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252);
			string @string = encoding.GetString(fdtRec.versionName);
			if (fdtRec.sectionId != 1178883154U)
			{
				ushort modelType;
				if (ushort.TryParse(@string.Substring(0, 4).Trim(), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out modelType))
				{
					fdtUnit.ModelType = modelType;
				}
				string text = @string.Substring(5, (int)global::Motorola.Common.Communication.TetraUtility.CPVersion.GetStringMaxLength()).Trim();
				char[] trimChars = new char[1];
				fdtUnit.Version = text.Trim(trimChars);
			}
			else
			{
				fdtUnit.Version = @string.Substring(4, 2).Trim();
			}
			fdtUnit.CPVersion = "0000";
			fdtUnit.StartAddress = fdtRec.startAddress;
			fdtUnit.Size = fdtRec.size;
			global::System.Array.Clear(fdtUnit.Reserved, 0, fdtUnit.Reserved.Length);
			global::System.Array.Copy(fdtRec.reserved, 0, fdtUnit.Reserved, 0, global::System.Math.Min(fdtUnit.Reserved.Length, fdtRec.reserved.Length));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002CDC File Offset: 0x00000EDC
		public bool ReadData()
		{
			if (!this._Init)
			{
				return false;
			}
			if (this._seqMgr == null)
			{
				return false;
			}
			if (this._hasRead)
			{
				return true;
			}
			byte[] array = null;
			if (this._seqMgr.DoReadFDT(out array) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				this._FDTRecordList.Clear();
				int num = 0;
				while (num < array.Length && array.Length >= num + 64)
				{
					global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtrecord = new global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord();
					fdtrecord.sectionId = (uint)((int)array[num] << 24 | (int)array[num + 1] << 16 | (int)array[num + 2] << 8 | (int)array[num + 3]);
					num += 4;
					fdtrecord.startAddress = (uint)((int)array[num] << 24 | (int)array[num + 1] << 16 | (int)array[num + 2] << 8 | (int)array[num + 3]);
					num += 4;
					fdtrecord.size = (uint)((int)array[num] << 24 | (int)array[num + 1] << 16 | (int)array[num + 2] << 8 | (int)array[num + 3]);
					num += 4;
					fdtrecord.flags = (ushort)((int)array[num] << 8 | (int)array[num + 1]);
					num += 2;
					fdtrecord.fdtState = array[num];
					num++;
					fdtrecord.state = array[num];
					num++;
					global::System.Array.Copy(array, num, fdtrecord.versionName, 0, fdtrecord.versionName.Length);
					num += fdtrecord.versionName.Length;
					global::System.Array.Copy(array, num, fdtrecord.reserved, 0, fdtrecord.reserved.Length);
					num += fdtrecord.reserved.Length;
					this._FDTRecordList.Add(fdtrecord);
				}
				this._hasRead = true;
				return true;
			}
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E48 File Offset: 0x00001048
		public bool WriteData(global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec)
		{
			if (fdtRec == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::WriteData: Input Parameters are not initialized.");
				return false;
			}
			if (!this._Init)
			{
				return false;
			}
			if (this._seqMgr == null)
			{
				return false;
			}
			byte[] array = new byte[64];
			int num = 0;
			byte[] bytes = global::System.BitConverter.GetBytes(fdtRec.sectionId);
			global::System.Array.Reverse(bytes);
			global::System.Array.Copy(bytes, 0, array, num, bytes.Length);
			num += bytes.Length;
			bytes = global::System.BitConverter.GetBytes(fdtRec.startAddress);
			global::System.Array.Reverse(bytes);
			global::System.Array.Copy(bytes, 0, array, num, bytes.Length);
			num += bytes.Length;
			bytes = global::System.BitConverter.GetBytes(fdtRec.size);
			global::System.Array.Reverse(bytes);
			global::System.Array.Copy(bytes, 0, array, num, bytes.Length);
			num += bytes.Length;
			bytes = global::System.BitConverter.GetBytes(fdtRec.flags);
			global::System.Array.Reverse(bytes);
			global::System.Array.Copy(bytes, 0, array, num, bytes.Length);
			num += bytes.Length;
			array[num] = fdtRec.fdtState;
			array[num + 1] = fdtRec.state;
			num += 2;
			global::System.Array.Copy(fdtRec.versionName, 0, array, num, fdtRec.versionName.Length);
			num += fdtRec.versionName.Length;
			global::System.Array.Copy(fdtRec.reserved, 0, array, num, fdtRec.reserved.Length);
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this._seqMgr.DoWriteFDT(array);
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._hasRead)
			{
				for (int i = 0; i < this._FDTRecordList.Count; i++)
				{
					if (fdtRec.sectionId == this._FDTRecordList[i].sectionId)
					{
						this._FDTRecordList[i].startAddress = fdtRec.startAddress;
						this._FDTRecordList[i].size = fdtRec.size;
						this._FDTRecordList[i].flags = fdtRec.flags;
						this._FDTRecordList[i].fdtState = fdtRec.fdtState;
						this._FDTRecordList[i].state = fdtRec.state;
						global::System.Array.Copy(fdtRec.versionName, 0, this._FDTRecordList[i].versionName, 0, fdtRec.versionName.Length);
						global::System.Array.Copy(fdtRec.reserved, 0, this._FDTRecordList[i].reserved, 0, fdtRec.reserved.Length);
					}
				}
			}
			return commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003092 File Offset: 0x00001292
		public bool Init(global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr seqMgr, bool doRead)
		{
			if (this._Init)
			{
				return true;
			}
			if (seqMgr == null)
			{
				return false;
			}
			this._seqMgr = seqMgr;
			this._Init = true;
			return !doRead || this.ReadData();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000030C0 File Offset: 0x000012C0
		public global::Motorola.Common.Communication.CommonUtil.CommRC ReadUnit(global::Motorola.Common.Communication.CommonUtil.FDTType type, global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			if (fdtUnit == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::ReadUnit: Input Parameters are not initialized.");
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5001_FDT_CommErrFDTInvalidParameter;
			}
			if (!this._Init)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
			}
			if (!this._hasRead && !this.ReadData())
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5002_FDT_CommErrCannotReadFDT;
			}
			for (int i = 0; i < this._FDTRecordList.Count; i++)
			{
				if (this.SectionIDtoUnitType(this._FDTRecordList[i].sectionId) == type)
				{
					this.RECtoUnit(this._FDTRecordList[i], fdtUnit);
					return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				}
			}
			fdtUnit.FdtType = type;
			fdtUnit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL;
			fdtUnit.ModelType = 0;
			fdtUnit.CPVersion = "0000";
			fdtUnit.Version = "0000";
			return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003178 File Offset: 0x00001378
		public global::Motorola.Common.Communication.CommonUtil.CommRC ReadUnitAddress(global::Motorola.Common.Communication.CommonUtil.FDTType type, out global::Motorola.Common.Communication.FDT.FDTState state, out uint address, out uint size)
		{
			state = global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL;
			address = 0U;
			size = 0U;
			if (!this._Init)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
			}
			if (!this._hasRead && !this.ReadData())
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5002_FDT_CommErrCannotReadFDT;
			}
			for (int i = 0; i < this._FDTRecordList.Count; i++)
			{
				if (this.SectionIDtoUnitType(this._FDTRecordList[i].sectionId) == type)
				{
					state = this.StatetoUnitState(this._FDTRecordList[i].fdtState);
					address = this._FDTRecordList[i].startAddress;
					size = this._FDTRecordList[i].size;
					return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003220 File Offset: 0x00001420
		public bool InitializefdtTable(global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			if (fdtUnit == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::InitializefdtTable: Input Parameters are not initialized.");
				return false;
			}
			bool flag = true;
			global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec = new global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord();
			this.UnittoRec(fdtUnit, fdtRec);
			if (!this.WriteData(fdtRec))
			{
				flag = false;
			}
			if (flag)
			{
				fdtUnit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE;
				fdtUnit.Version = "0001";
				this.UnittoRec(fdtUnit, fdtRec);
				if (!this.WriteData(fdtRec))
				{
					flag = false;
				}
			}
			if (flag)
			{
				fdtUnit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG;
				fdtUnit.Version = "0001";
				this.UnittoRec(fdtUnit, fdtRec);
				if (!this.WriteData(fdtRec))
				{
					flag = false;
				}
			}
			if (flag)
			{
				fdtUnit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS;
				fdtUnit.Version = "0001";
				this.UnittoRec(fdtUnit, fdtRec);
				if (!this.WriteData(fdtRec))
				{
					flag = false;
				}
			}
			if (flag)
			{
				fdtUnit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP;
				fdtUnit.Version = "0001";
				this.UnittoRec(fdtUnit, fdtRec);
				if (!this.WriteData(fdtRec))
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003304 File Offset: 0x00001504
		public global::Motorola.Common.Communication.CommonUtil.CommRC WriteUnitForTestFdt(global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			if (fdtUnit == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::WriteUnit: Input Parameters are not initialized.");
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5001_FDT_CommErrFDTInvalidParameter;
			}
			if (!this._Init)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
			}
			global::Motorola.Common.Communication.CommonUtil.CommRC result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec = new global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord();
			this.UnittoRec(fdtUnit, fdtRec);
			if (!this.WriteData(fdtRec))
			{
				result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5003_FDT_CommErrCannotWriteFDTUnit;
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003354 File Offset: 0x00001554
		public global::Motorola.Common.Communication.CommonUtil.CommRC WriteUnit(global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			if (fdtUnit == null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDTBase::WriteUnit: Input Parameters are not initialized.");
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5001_FDT_CommErrFDTInvalidParameter;
			}
			if (!this._Init)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
			}
			global::Motorola.Common.Communication.CommonUtil.CommRC result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (fdtUnit.FdtType == global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT)
			{
				if (!this.InitializefdtTable(fdtUnit))
				{
					result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
				}
			}
			else
			{
				global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtRec = new global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord();
				this.UnittoRec(fdtUnit, fdtRec);
				if (!this.WriteData(fdtRec))
				{
					result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5003_FDT_CommErrCannotWriteFDTUnit;
				}
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000033BC File Offset: 0x000015BC
		public global::Motorola.Common.Communication.CommonUtil.CommRC GetState(ref global::Motorola.Common.Communication.FDT.FDTTableState state)
		{
			state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_UNSUPPORT;
			if (!this._Init)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit;
			}
			if (!this._hasRead && !this.ReadData())
			{
				state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_UNSUPPORT;
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD5002_FDT_CommErrCannotReadFDT;
			}
			state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_INTEGRITY;
			if (this._FDTRecordList.Count == 0)
			{
				state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED;
			}
			else
			{
				for (int i = 0; i < this._FDTRecordList.Count; i++)
				{
					global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord fdtrecord = this._FDTRecordList[i];
					if (this.StatetoUnitState(fdtrecord.state) != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY)
					{
						switch (this.SectionIDtoUnitType(fdtrecord.sectionId))
						{
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT:
							state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED;
							break;
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
							state = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_HAS_CORRUPTED_SECTION;
							break;
						}
						if (global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED == state)
						{
							break;
						}
					}
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x04000003 RID: 3
		private const uint FDT_ID_FDT = 1178883154U;

		// Token: 0x04000004 RID: 4
		private const uint FDT_ID_FLASHSTRAP = 1179931216U;

		// Token: 0x04000005 RID: 5
		private const uint FDT_ID_FIRMWARE = 1179473746U;

		// Token: 0x04000006 RID: 6
		private const uint FDT_ID_CODEPLUG = 1129335879U;

		// Token: 0x04000007 RID: 7
		private const uint FDT_ID_FLASHPACKS = 1179865163U;

		// Token: 0x04000008 RID: 8
		private const uint FDT_ID_KEYS = 1262836051U;

		// Token: 0x04000009 RID: 9
		private const uint FDT_ID_LOGGING_DATA = 1280264004U;

		// Token: 0x0400000A RID: 10
		private const uint FDT_ID_RELEASE_INFO = 1380273225U;

		// Token: 0x0400000B RID: 11
		private const uint FDT_ID_BAD_RECORD = 0U;

		// Token: 0x0400000C RID: 12
		private const uint FDT_ID_DUMMY = 4294967295U;

		// Token: 0x0400000D RID: 13
		private const byte AREA_READY = 0;

		// Token: 0x0400000E RID: 14
		private const byte AREA_CORRUPTED = 1;

		// Token: 0x0400000F RID: 15
		private const byte AREA_DELETED = 2;

		// Token: 0x04000010 RID: 16
		private const byte AREA_UPDATED = 9;

		// Token: 0x04000011 RID: 17
		public const string DEFAULT_INIT_FDT_VERSION = "0001";

		// Token: 0x04000012 RID: 18
		public const string DEFAULT_FLASHPACK_VERSION = "0001";

		// Token: 0x04000013 RID: 19
		public const string DEFAULT_FLASHSTRAP_VERSION = "0001";

		// Token: 0x04000014 RID: 20
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord> _FDTRecordList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.FDT.FDTBase.FDTRecord>();

		// Token: 0x04000015 RID: 21
		private global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr _seqMgr;

		// Token: 0x04000016 RID: 22
		private bool _Init;

		// Token: 0x04000017 RID: 23
		private bool _hasRead;

		// Token: 0x02000006 RID: 6
		public class FDTRecord
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00003483 File Offset: 0x00001683
			// (set) Token: 0x06000032 RID: 50 RVA: 0x0000348B File Offset: 0x0000168B
			public uint sectionId { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00003494 File Offset: 0x00001694
			// (set) Token: 0x06000034 RID: 52 RVA: 0x0000349C File Offset: 0x0000169C
			public uint startAddress { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000035 RID: 53 RVA: 0x000034A5 File Offset: 0x000016A5
			// (set) Token: 0x06000036 RID: 54 RVA: 0x000034AD File Offset: 0x000016AD
			public uint size { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000037 RID: 55 RVA: 0x000034B6 File Offset: 0x000016B6
			// (set) Token: 0x06000038 RID: 56 RVA: 0x000034BE File Offset: 0x000016BE
			public ushort flags { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000039 RID: 57 RVA: 0x000034C7 File Offset: 0x000016C7
			// (set) Token: 0x0600003A RID: 58 RVA: 0x000034CF File Offset: 0x000016CF
			public byte fdtState { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003B RID: 59 RVA: 0x000034D8 File Offset: 0x000016D8
			// (set) Token: 0x0600003C RID: 60 RVA: 0x000034E0 File Offset: 0x000016E0
			public byte state { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003D RID: 61 RVA: 0x000034E9 File Offset: 0x000016E9
			// (set) Token: 0x0600003E RID: 62 RVA: 0x000034F1 File Offset: 0x000016F1
			public byte[] versionName { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600003F RID: 63 RVA: 0x000034FA File Offset: 0x000016FA
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00003502 File Offset: 0x00001702
			public byte[] reserved { get; set; }

			// Token: 0x06000041 RID: 65 RVA: 0x0000350C File Offset: 0x0000170C
			public FDTRecord()
			{
				this.sectionId = 0U;
				this.startAddress = 0U;
				this.size = 0U;
				this.flags = 0;
				this.fdtState = 0;
				this.state = 0;
				this.versionName = new byte[16];
				this.reserved = new byte[32];
				global::System.Array.Clear(this.versionName, 0, this.versionName.Length);
				global::System.Array.Clear(this.reserved, 0, this.reserved.Length);
			}

			// Token: 0x04000018 RID: 24
			public const int FDTRecordSize = 64;
		}
	}
}
