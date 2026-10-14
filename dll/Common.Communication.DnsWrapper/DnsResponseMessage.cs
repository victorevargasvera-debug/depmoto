using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public class DnsResponseMessage : global::Motorola.Common.Communication.DnsBaseMessage
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002A14 File Offset: 0x00000C14
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR> PTRS
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordPTR>();
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord in from m in base.Answers
				where m is global::Motorola.Common.Communication.RecordPTR
				select m)
				{
					global::Motorola.Common.Communication.RecordPTR item = (global::Motorola.Common.Communication.RecordPTR)resourceRecord;
					list.Add(item);
				}
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord2 in from m in base.Additionals
				where m is global::Motorola.Common.Communication.RecordPTR
				select m)
				{
					global::Motorola.Common.Communication.RecordPTR item2 = (global::Motorola.Common.Communication.RecordPTR)resourceRecord2;
					list.Add(item2);
				}
				return list;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002B10 File Offset: 0x00000D10
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT> TXTS
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordTXT>();
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord in from m in base.Answers
				where m is global::Motorola.Common.Communication.RecordTXT
				select m)
				{
					global::Motorola.Common.Communication.RecordTXT item = (global::Motorola.Common.Communication.RecordTXT)resourceRecord;
					list.Add(item);
				}
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord2 in from m in base.Additionals
				where m is global::Motorola.Common.Communication.RecordTXT
				select m)
				{
					global::Motorola.Common.Communication.RecordTXT item2 = (global::Motorola.Common.Communication.RecordTXT)resourceRecord2;
					list.Add(item2);
				}
				return list;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002C0C File Offset: 0x00000E0C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA> AS
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordA>();
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord in from m in base.Answers
				where m is global::Motorola.Common.Communication.RecordA
				select m)
				{
					global::Motorola.Common.Communication.RecordA item = (global::Motorola.Common.Communication.RecordA)resourceRecord;
					list.Add(item);
				}
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord2 in from m in base.Additionals
				where m is global::Motorola.Common.Communication.RecordA
				select m)
				{
					global::Motorola.Common.Communication.RecordA item2 = (global::Motorola.Common.Communication.RecordA)resourceRecord2;
					list.Add(item2);
				}
				return list;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002D08 File Offset: 0x00000F08
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV> SRVS
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>();
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord in from m in base.Answers
				where m is global::Motorola.Common.Communication.RecordSRV
				select m)
				{
					global::Motorola.Common.Communication.RecordSRV item = (global::Motorola.Common.Communication.RecordSRV)resourceRecord;
					list.Add(item);
				}
				foreach (global::Motorola.Common.Communication.ResourceRecord resourceRecord2 in from m in base.Additionals
				where m is global::Motorola.Common.Communication.RecordSRV
				select m)
				{
					global::Motorola.Common.Communication.RecordSRV item2 = (global::Motorola.Common.Communication.RecordSRV)resourceRecord2;
					list.Add(item2);
				}
				return list;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002DEC File Offset: 0x00000FEC
		public DnsResponseMessage()
		{
			base.Header = new global::Motorola.Common.Communication.Header();
			base.Questions = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>();
			base.Answers = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
			base.Authorities = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
			base.Additionals = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.ResourceRecord>();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002E2C File Offset: 0x0000102C
		public int GenerateBoardcastMessage(byte[] sendBuffer, string serialNum, string modelNum)
		{
			global::Motorola.Common.Communication.RecordPTR recordPTR = new global::Motorola.Common.Communication.RecordPTR();
			recordPTR.NAME = "_otap._tcp.local";
			recordPTR.TYPE = 12;
			recordPTR.CLASS = 1;
			recordPTR.TTL = 120U;
			recordPTR.RDLENGTH = 44;
			recordPTR.RDATA = global::System.Text.Encoding.ASCII.GetBytes("MOTOTRBO_2a30010864605700._otap._tcp.local");
			base.Answers.Add(recordPTR);
			global::Motorola.Common.Communication.RecordSRV item = new global::Motorola.Common.Communication.RecordSRV();
			base.Answers.Add(item);
			global::Motorola.Common.Communication.RecordTXT item2 = new global::Motorola.Common.Communication.RecordTXT();
			base.Answers.Add(item2);
			global::Motorola.Common.Communication.RecordA item3 = new global::Motorola.Common.Communication.RecordA();
			base.Additionals.Add(item3);
			return 0;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002EC4 File Offset: 0x000010C4
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			if (sendBuffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(sendBuffer, 0, sendBuffer.Length, true))
			{
				try
				{
					memoryStream.WriteByte((byte)((base.Header.ID & 65280) >> 8));
					memoryStream.WriteByte((byte)(base.Header.ID & 255));
					byte b = 0;
					b |= (byte)(base.Header.QR << 7);
					b |= (byte)(base.Header.OPCODE << 3);
					b |= (byte)(base.Header.AA << 2);
					b |= (byte)(base.Header.TC << 1);
					b |= base.Header.RD;
					memoryStream.WriteByte(b);
					b = 0;
					b |= (byte)(base.Header.RA << 7);
					b |= (byte)(base.Header.Z << 4);
					b |= base.Header.RCODE;
					memoryStream.WriteByte(b);
					memoryStream.WriteByte((byte)((base.Header.QDCOUNT & 65280) >> 8));
					memoryStream.WriteByte((byte)(base.Header.QDCOUNT & 255));
					memoryStream.WriteByte((byte)((base.Header.ANCOUNT & 65280) >> 8));
					memoryStream.WriteByte((byte)(base.Header.ANCOUNT & 255));
					memoryStream.WriteByte((byte)((base.Header.NSCOUNT & 65280) >> 8));
					memoryStream.WriteByte((byte)(base.Header.NSCOUNT & 255));
					memoryStream.WriteByte((byte)((base.Header.ARCOUNT & 65280) >> 8));
					memoryStream.WriteByte((byte)(base.Header.ARCOUNT & 255));
					foreach (global::Motorola.Common.Communication.Question question in base.Questions)
					{
						string[] array = question.QNAME.Split(new char[]
						{
							'.'
						});
						foreach (string s in array)
						{
							byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
							memoryStream.WriteByte((byte)bytes.Length);
							for (int j = 0; j < bytes.Length; j++)
							{
								memoryStream.WriteByte(bytes[j]);
							}
						}
						memoryStream.WriteByte(0);
						memoryStream.WriteByte((byte)((question.QTYPE & 65280) >> 8));
						memoryStream.WriteByte((byte)(question.QTYPE & 255));
						memoryStream.WriteByte((byte)((question.QClass & 65280) >> 8));
						memoryStream.WriteByte((byte)(question.QClass & 255));
					}
					result = (int)memoryStream.Position;
				}
				catch (global::System.NotSupportedException)
				{
					throw;
				}
			}
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000031E4 File Offset: 0x000013E4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			if (replyBuffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (replyBuffer.Length < global::Motorola.Common.Communication.DnsConfigConstants.DNS_BODY_START_INDEX)
			{
				return;
			}
			this.CheckReplyHeader(replyBuffer);
			this.DecodeBytes(replyBuffer, global::Motorola.Common.Communication.DnsConfigConstants.DNS_BODY_START_INDEX, length);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003214 File Offset: 0x00001414
		private void DecodeBytes(byte[] buffer, int offset, int length)
		{
			for (int i = 0; i < (int)base.Header.QDCOUNT; i++)
			{
				this.ResolveQuestionRecord(buffer, ref offset);
			}
			for (int j = 0; j < (int)base.Header.ANCOUNT; j++)
			{
				this.ResolveResourceRecord(buffer, ref offset, 0);
			}
			for (int k = 0; k < (int)base.Header.NSCOUNT; k++)
			{
				this.ResolveResourceRecord(buffer, ref offset, 1);
			}
			for (int l = 0; l < (int)base.Header.ARCOUNT; l++)
			{
				this.ResolveResourceRecord(buffer, ref offset, 2);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000032A0 File Offset: 0x000014A0
		private void CheckReplyHeader(byte[] buffer)
		{
			base.Header.ID = ((ushort)(buffer[0] << 8) | (ushort)buffer[1]);
			base.Header.QR = (buffer[2] & 128);
			base.Header.OPCODE = (buffer[2] & 120);
			base.Header.AA = (buffer[2] & 4);
			base.Header.TC = (buffer[2] & 2);
			base.Header.RD = (buffer[2] & 1);
			base.Header.RA = (buffer[3] & 128);
			base.Header.Z = (buffer[3] & 112);
			base.Header.RCODE = (buffer[3] & 15);
			base.Header.QDCOUNT = ((ushort)(buffer[4] << 8) | (ushort)buffer[5]);
			base.Header.ANCOUNT = ((ushort)(buffer[6] << 8) | (ushort)buffer[7]);
			base.Header.NSCOUNT = ((ushort)(buffer[8] << 8) | (ushort)buffer[9]);
			base.Header.ARCOUNT = ((ushort)(buffer[10] << 8) | (ushort)buffer[11]);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000033B4 File Offset: 0x000015B4
		private string GetStringIncludingPointer(byte[] bytes, int ind)
		{
			string text = "";
			while (bytes[ind] != 0)
			{
				if ((bytes[ind] & 192) == 192)
				{
					int num = (int)(bytes[ind] & 15) << 8;
					int num2 = (int)bytes[++ind];
					string stringIncludingPointer = this.GetStringIncludingPointer(bytes, num + num2);
					if (text.Length > 0)
					{
						text += ".";
					}
					text += stringIncludingPointer;
					break;
				}
				byte b = bytes[ind];
				byte[] array = new byte[(int)b];
				for (int i = 0; i < (int)b; i++)
				{
					array[i] = bytes[++ind];
				}
				if (text.Length > 0)
				{
					text += ".";
				}
				text += global::System.Text.Encoding.ASCII.GetString(array);
				ind++;
			}
			return text;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000347C File Offset: 0x0000167C
		private void ResolveQuestionRecord(byte[] bytes, ref int ind)
		{
			string text = "";
			if ((bytes[ind] & 192) == 192)
			{
				int num = (int)(bytes[ind] & 15) << 8;
				int num2 = (int)bytes[++ind];
				string stringIncludingPointer = this.GetStringIncludingPointer(bytes, num + num2);
				if (text.Length > 0)
				{
					text += ".";
				}
				text += stringIncludingPointer;
			}
			else
			{
				while (bytes[ind] != 0 && (long)ind < bytes.LongLength)
				{
					if ((bytes[ind] & 192) == 192)
					{
						int num3 = (int)(bytes[ind] & 15) << 8;
						int num4 = (int)bytes[++ind];
						string stringIncludingPointer2 = this.GetStringIncludingPointer(bytes, num3 + num4);
						if (text.Length > 0)
						{
							text += ".";
						}
						text += stringIncludingPointer2;
						break;
					}
					byte b = bytes[ind];
					byte[] array = new byte[(int)b];
					for (int i = 0; i < (int)b; i++)
					{
						array[i] = bytes[++ind];
					}
					if (text.Length > 0)
					{
						text += ".";
					}
					text += global::System.Text.Encoding.ASCII.GetString(array);
					ind++;
				}
			}
			global::Motorola.Common.Communication.Question question = new global::Motorola.Common.Communication.Question();
			question.QNAME = text;
			question.QTYPE = ((ushort)(bytes[++ind] << 8) | (ushort)bytes[++ind]);
			question.QClass = ((ushort)(bytes[++ind] << 8) | (ushort)bytes[++ind]);
			ind++;
			base.Questions.Add(question);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003624 File Offset: 0x00001824
		private void AddToList(global::Motorola.Common.Communication.ResourceRecord record, int recordType)
		{
			switch (recordType)
			{
			case 0:
				base.Answers.Add(record);
				return;
			case 1:
				base.Authorities.Add(record);
				return;
			case 2:
				base.Additionals.Add(record);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000366C File Offset: 0x0000186C
		protected virtual void ResolveResourceRecord(byte[] bytes, ref int ind, int recordType)
		{
			string text = "";
			if (bytes[ind] != 0)
			{
				if ((bytes[ind] & 192) == 192)
				{
					int num = (int)(bytes[ind] & 15) << 8;
					int num2 = (int)bytes[++ind];
					string stringIncludingPointer = this.GetStringIncludingPointer(bytes, num + num2);
					if (text.Length > 0)
					{
						text += ".";
					}
					text += stringIncludingPointer;
				}
				else
				{
					while (bytes[ind] != 0 && (long)ind < bytes.LongLength)
					{
						if ((bytes[ind] & 192) == 192)
						{
							int num3 = (int)(bytes[ind] & 15) << 8;
							int num4 = (int)bytes[++ind];
							string stringIncludingPointer2 = this.GetStringIncludingPointer(bytes, num3 + num4);
							if (text.Length > 0)
							{
								text += ".";
							}
							text += stringIncludingPointer2;
							break;
						}
						byte b = bytes[ind];
						byte[] array = new byte[(int)b];
						for (int i = 0; i < (int)b; i++)
						{
							array[i] = bytes[++ind];
						}
						if (text.Length > 0)
						{
							text += ".";
						}
						text += global::System.Text.Encoding.ASCII.GetString(array);
						ind++;
					}
				}
			}
			ushort num5 = (ushort)(bytes[++ind] << 8) | (ushort)bytes[++ind];
			ushort num6 = num5;
			if (num6 <= 16)
			{
				if (num6 == 1)
				{
					global::Motorola.Common.Communication.RecordA recordA = new global::Motorola.Common.Communication.RecordA();
					recordA.NAME = text;
					recordA.TYPE = num5;
					this.GetARecord(bytes, ref ind, recordA);
					this.AddToList(recordA, recordType);
					goto IL_2DE;
				}
				if (num6 == 12)
				{
					global::Motorola.Common.Communication.RecordPTR recordPTR = new global::Motorola.Common.Communication.RecordPTR();
					recordPTR.NAME = text;
					recordPTR.TYPE = num5;
					this.GetPTRRecord(bytes, ref ind, recordPTR);
					this.AddToList(recordPTR, recordType);
					goto IL_2DE;
				}
				if (num6 == 16)
				{
					global::Motorola.Common.Communication.RecordTXT recordTXT = new global::Motorola.Common.Communication.RecordTXT();
					recordTXT.NAME = text;
					recordTXT.TYPE = num5;
					this.GetTXTRecord(bytes, ref ind, recordTXT);
					this.AddToList(recordTXT, recordType);
					goto IL_2DE;
				}
			}
			else
			{
				if (num6 == 28)
				{
					global::Motorola.Common.Communication.RecordAAA recordAAA = new global::Motorola.Common.Communication.RecordAAA();
					recordAAA.NAME = text;
					recordAAA.TYPE = num5;
					this.GetAAARecord(bytes, ref ind, recordAAA);
					this.AddToList(recordAAA, recordType);
					goto IL_2DE;
				}
				if (num6 == 33)
				{
					global::Motorola.Common.Communication.RecordSRV recordSRV = new global::Motorola.Common.Communication.RecordSRV();
					recordSRV.NAME = text;
					recordSRV.TYPE = num5;
					this.GetSRVRecord(bytes, ref ind, recordSRV);
					this.AddToList(recordSRV, recordType);
					goto IL_2DE;
				}
				if (num6 == 41)
				{
					global::Motorola.Common.Communication.RecordOPT recordOPT = new global::Motorola.Common.Communication.RecordOPT();
					recordOPT.NAME = text;
					recordOPT.TYPE = num5;
					this.GetOPTRecord(bytes, ref ind, recordOPT);
					this.AddToList(recordOPT, recordType);
					goto IL_2DE;
				}
			}
			global::Motorola.Common.Communication.ResourceRecord resourceRecord = new global::Motorola.Common.Communication.ResourceRecord();
			resourceRecord.NAME = text;
			resourceRecord.TYPE = num5;
			this.GetCommonRecord(bytes, ref ind, resourceRecord);
			this.AddToList(resourceRecord, recordType);
			IL_2DE:
			ind++;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003960 File Offset: 0x00001B60
		private void GetPTRRecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordPTR ptr)
		{
			ptr.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			ptr.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			ptr.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			string stringIncludingPointer = this.GetStringIncludingPointer(bytes, ind + 1);
			ptr.DomainName = stringIncludingPointer;
			ind += (int)ptr.RDLENGTH;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003A14 File Offset: 0x00001C14
		private void GetARecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordA a)
		{
			a.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			a.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			a.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			byte[] array = new byte[(int)a.RDLENGTH];
			for (int i = 0; i < (int)a.RDLENGTH; i++)
			{
				array[i] = bytes[ind + i + 1];
			}
			uint num = global::System.BitConverter.ToUInt32(array, 0);
			global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress((long)((ulong)num));
			a.IP = ipaddress.ToString();
			ind += (int)a.RDLENGTH;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003B00 File Offset: 0x00001D00
		private void GetTXTRecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordTXT txt)
		{
			txt.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			txt.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			txt.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			ushort num = 0;
			while (num < txt.RDLENGTH)
			{
				ushort num2 = (ushort)bytes[++ind];
				num += 1;
				num += num2;
				byte[] array = new byte[(int)num2];
				for (int i = 0; i < (int)num2; i++)
				{
					array[i] = bytes[ind + 1 + i];
				}
				string @string = global::System.Text.Encoding.ASCII.GetString(array);
				string[] array2 = @string.Split(new char[]
				{
					';'
				});
				foreach (string text in array2)
				{
					string[] array4 = text.Split(new char[]
					{
						'='
					});
					if (array4.Length == 2)
					{
						txt.Txts.Add(array4[0], array4[1]);
					}
				}
				ind += (int)num2;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003C60 File Offset: 0x00001E60
		private void GetAAARecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordAAA aaa)
		{
			aaa.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			aaa.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			aaa.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			byte[] array = new byte[(int)aaa.RDLENGTH];
			for (int i = 0; i < (int)aaa.RDLENGTH; i++)
			{
				array[i] = bytes[ind + i + 1];
			}
			global::System.BitConverter.ToUInt32(array, 0);
			global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress(array);
			aaa.IPV6 = ipaddress.ToString();
			ind += (int)aaa.RDLENGTH;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003D48 File Offset: 0x00001F48
		private void GetSRVRecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordSRV srv)
		{
			srv.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.Priority = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.Weight = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.Port = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			srv.Target = this.GetStringIncludingPointer(bytes, ind + 1);
			ind += (int)(srv.RDLENGTH - 6);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003E64 File Offset: 0x00002064
		private void GetOPTRecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.RecordOPT opt)
		{
			opt.CacheFlush = (bytes[ind + 1] & 128);
			opt.UDPPayloadSize = (ushort)((int)(bytes[++ind] & 127) << 8 | (int)bytes[++ind]);
			opt.ExtendedRCODE = bytes[++ind];
			opt.EDNS0Version = bytes[++ind];
			opt.Z = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			opt.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			ind += (int)opt.RDLENGTH;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003F1C File Offset: 0x0000211C
		private void GetCommonRecord(byte[] bytes, ref int ind, global::Motorola.Common.Communication.ResourceRecord r)
		{
			r.CLASS = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			r.TTL = (uint)((int)bytes[++ind] << 24 | (int)bytes[++ind] << 16 | (int)bytes[++ind] << 8 | (int)bytes[++ind]);
			r.RDLENGTH = (ushort)((int)bytes[++ind] << 8 | (int)bytes[++ind]);
			ind += (int)r.RDLENGTH;
		}
	}
}
