using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class DnsQueryMessage : global::Motorola.Common.Communication.DnsBaseMessage
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000025E8 File Offset: 0x000007E8
		public DnsQueryMessage(string queryType, ushort type)
		{
			base.Header = new global::Motorola.Common.Communication.Header();
			base.Header.ID = 0;
			base.Header.QR = 0;
			base.Header.OPCODE = 0;
			base.Header.AA = 0;
			base.Header.TC = 0;
			base.Header.RD = 0;
			base.Header.RA = 0;
			base.Header.Z = 0;
			base.Header.RCODE = 0;
			base.Header.QDCOUNT = 1;
			base.Header.ANCOUNT = 0;
			base.Header.NSCOUNT = 0;
			base.Header.ARCOUNT = 0;
			base.Questions = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>();
			global::Motorola.Common.Communication.Question question = new global::Motorola.Common.Communication.Question();
			question.QNAME = queryType;
			question.QTYPE = type;
			question.QClass = 1;
			base.Questions.Add(question);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000026D4 File Offset: 0x000008D4
		public override int BuildCommandMessage(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer, 0, buffer.Length, true))
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

		// Token: 0x06000077 RID: 119 RVA: 0x000029F4 File Offset: 0x00000BF4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
