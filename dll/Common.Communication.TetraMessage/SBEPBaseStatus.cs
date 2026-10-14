using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public abstract class SBEPBaseStatus : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00006186 File Offset: 0x00004386
		protected SBEPBaseStatus()
		{
			this._myStartAddress = 0U;
			this._myStatus = 0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000619C File Offset: 0x0000439C
		public override void ExecuteMessage()
		{
			bool flag = true;
			ushort uOpCode = 0;
			(base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).SupressTriggerUSBAnalyzer = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.BaseBuildCommandMessage();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag && !base.Executor.OpenPort())
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_CANNOT_OPEN_PIPE;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (tetraCommPipe != null)
			{
				flag = true;
			}
			else
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE;
			}
			if (flag && tetraCommPipe.Reliable)
			{
				this.SetCommunicationType();
			}
			if (flag)
			{
				tetraMsgOpResult = base.Executor.SendRequest(true, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.Get_uOpCode(this._myReplyMessageBuffer, out uOpCode);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer, uOpCode);
			}
			(base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).SupressTriggerUSBAnalyzer = false;
			base.OperationResult = tetraMsgOpResult;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00006283 File Offset: 0x00004483
		protected byte InternalStatus
		{
			get
			{
				return this._myStatus;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000628B File Offset: 0x0000448B
		protected uint InternalStartAddress
		{
			get
			{
				return this._myStartAddress;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006294 File Offset: 0x00004494
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			ushort value = 61716;
			if ((base.OperationFlag & 1U) > 0U)
			{
				value = 61764;
			}
			if (base.AddCheckSum)
			{
				base.MyCommandBuffer = new byte[3];
			}
			else
			{
				base.MyCommandBuffer = new byte[2];
			}
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 0, bytes, 0, 2);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag && base.AddCheckSum)
			{
				global::Motorola.Common.Communication.SBEPCommon.AddCheckSum(base.MyCommandBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000631C File Offset: 0x0000451C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			int num = 3;
			if (buffer == null || buffer.Length <= 2)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (flag)
			{
				if (uOpCode != 61830)
				{
					if (uOpCode == 62851 || uOpCode == 63155)
					{
						if (uOpCode == 63155)
						{
							num++;
						}
						this._myStatus = buffer[2];
						byte[] bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 3, num);
						if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							flag = false;
						}
						if (flag)
						{
							this._myStartAddress = global::System.BitConverter.ToUInt32(bytes, 0);
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
						}
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNKNOWN_REPLY;
					}
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_REPLY;
				}
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					base.LogStatusInformation("SBEPBaseStatus");
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000063C8 File Offset: 0x000045C8
		private void SetCommunicationType()
		{
			bool flag = true;
			(base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PurgeInputBuffer();
			(base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PurgeOutputBuffer();
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendMessage(base.MyCommandBuffer, base.MyCommandBuffer.Length);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				int num = 3;
				bool flag2 = false;
				do
				{
					byte[] array = new byte[1];
					if (base.Executor.CommPipe.ReceiveData(array, 0, 1) == 0)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NOACKNOWLEDGE;
					}
					else if (array[0] == 80)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
						flag2 = true;
					}
					else if (array[0] == 96)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NACK;
					}
					else if (array[0] == 255)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NOACKNOWLEDGE;
					}
					num--;
				}
				while (num >= 0 && tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NACK);
				if (flag2)
				{
					(base.Executor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).Reliable = false;
				}
			}
		}

		// Token: 0x04000059 RID: 89
		private byte _myStatus;

		// Token: 0x0400005A RID: 90
		private uint _myStartAddress;
	}
}
