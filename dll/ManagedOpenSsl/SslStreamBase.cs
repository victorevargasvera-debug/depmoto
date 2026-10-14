using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using OpenSSL.Core;
using OpenSSL.X509;

namespace OpenSSL
{
	// Token: 0x02000065 RID: 101
	internal abstract class SslStreamBase : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x06000422 RID: 1058
		protected internal abstract bool ProcessHandshake();

		// Token: 0x06000423 RID: 1059 RVA: 0x00006EC4 File Offset: 0x000050C4
		public SslStreamBase(global::System.IO.Stream stream, bool ownStream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (!stream.CanRead || !stream.CanWrite)
			{
				throw new global::System.ArgumentException("Stream must allow read and write capabilities", "stream");
			}
			this.innerStream = stream;
			this.ownStream = ownStream;
			this.read_buffer = new byte[16384];
			this.decrypted_data_stream = new global::System.IO.MemoryStream();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00006F2E File Offset: 0x0000512E
		public void SetCipherList(string cipherList)
		{
			this.explicitCipher = cipherList;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00006F37 File Offset: 0x00005137
		public bool HandshakeComplete
		{
			get
			{
				return this.handShakeState == global::OpenSSL.HandshakeState.Complete;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00006F42 File Offset: 0x00005142
		private bool NeedHandshake
		{
			get
			{
				return this.handShakeState == global::OpenSSL.HandshakeState.None || this.handShakeState == global::OpenSSL.HandshakeState.Renegotiate;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00006F57 File Offset: 0x00005157
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00006F5F File Offset: 0x0000515F
		public bool CheckCertificateRevocationStatus
		{
			get
			{
				return this.checkCertificateRevocationStatus;
			}
			set
			{
				this.checkCertificateRevocationStatus = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00006F68 File Offset: 0x00005168
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00006F70 File Offset: 0x00005170
		public global::OpenSSL.LocalCertificateSelectionHandler LocalCertSelectionCallback
		{
			get
			{
				return this.localCertificateSelectionCallback;
			}
			set
			{
				this.localCertificateSelectionCallback = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00006F79 File Offset: 0x00005179
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00006F81 File Offset: 0x00005181
		public global::OpenSSL.RemoteCertificateValidationHandler RemoteCertValidationCallback
		{
			get
			{
				return this.remoteCertificateSelectionCallback;
			}
			set
			{
				this.remoteCertificateSelectionCallback = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00006F8A File Offset: 0x0000518A
		public global::OpenSSL.X509.X509Certificate LocalCertificate
		{
			get
			{
				return this.ssl.LocalCertificate;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00006F97 File Offset: 0x00005197
		public global::OpenSSL.X509.X509Certificate RemoteCertificate
		{
			get
			{
				return this.ssl.RemoteCertificate;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00006FA4 File Offset: 0x000051A4
		public global::OpenSSL.CipherAlgorithmType CipherAlgorithm
		{
			get
			{
				return this.ssl.CurrentCipher.CipherAlgorithm;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00006FB6 File Offset: 0x000051B6
		public int CipherStrength
		{
			get
			{
				return this.ssl.CurrentCipher.Strength;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00006FC8 File Offset: 0x000051C8
		public global::OpenSSL.HashAlgorithmType HashAlgorithm
		{
			get
			{
				return this.ssl.CurrentCipher.HashAlgorithm;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00006FDC File Offset: 0x000051DC
		public int HashStrength
		{
			get
			{
				switch (this.HashAlgorithm)
				{
				case global::OpenSSL.HashAlgorithmType.Md5:
					return 128;
				case global::OpenSSL.HashAlgorithmType.Sha1:
					return 160;
				default:
					return 0;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000700F File Offset: 0x0000520F
		public global::OpenSSL.ExchangeAlgorithmType KeyExchangeAlgorithm
		{
			get
			{
				return this.ssl.CurrentCipher.KeyExchangeAlgorithm;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00007021 File Offset: 0x00005221
		public int KeyExchangeStrength
		{
			get
			{
				return this.ssl.CurrentCipher.KeyExchangeStrength;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00007033 File Offset: 0x00005233
		public global::OpenSSL.SslProtocols SslProtocol
		{
			get
			{
				return this.ssl.CurrentCipher.SslProtocol;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00007045 File Offset: 0x00005245
		public global::System.Collections.Generic.List<string> CipherList
		{
			get
			{
				return this.sslContext.GetCipherList();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00007052 File Offset: 0x00005252
		public override bool CanRead
		{
			get
			{
				return this.innerStream.CanRead;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000705F File Offset: 0x0000525F
		public override bool CanSeek
		{
			get
			{
				return this.innerStream.CanSeek;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000706C File Offset: 0x0000526C
		public override bool CanWrite
		{
			get
			{
				return this.innerStream.CanWrite;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00007079 File Offset: 0x00005279
		public override void Flush()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException("SslStreamBase");
			}
			this.innerStream.Flush();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000709B File Offset: 0x0000529B
		public override long Length
		{
			get
			{
				return this.innerStream.Length;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000070A8 File Offset: 0x000052A8
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000070B5 File Offset: 0x000052B5
		public override long Position
		{
			get
			{
				return this.innerStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000070BC File Offset: 0x000052BC
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x000070C9 File Offset: 0x000052C9
		public override int ReadTimeout
		{
			get
			{
				return this.innerStream.ReadTimeout;
			}
			set
			{
				this.innerStream.ReadTimeout = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000070D7 File Offset: 0x000052D7
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000070E4 File Offset: 0x000052E4
		public override int WriteTimeout
		{
			get
			{
				return this.innerStream.WriteTimeout;
			}
			set
			{
				this.innerStream.WriteTimeout = value;
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000070F2 File Offset: 0x000052F2
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000070F9 File Offset: 0x000052F9
		public override void SetLength(long value)
		{
			this.innerStream.SetLength(value);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00007107 File Offset: 0x00005307
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00007110 File Offset: 0x00005310
		public void SendShutdownAlert()
		{
			if (this.ssl.Shutdown() == 0)
			{
				uint bytesPending = this.write_bio.BytesPending;
				if (bytesPending <= 0U)
				{
					return;
				}
				global::System.ArraySegment<byte> arraySegment = this.write_bio.ReadBytes((int)bytesPending);
				if (arraySegment.Count <= 0)
				{
					return;
				}
				this.innerStream.Write(arraySegment.Array, 0, arraySegment.Count);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00007170 File Offset: 0x00005370
		public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer", "buffer can't be null");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset less than 0");
			}
			if (offset > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset must be less than buffer length");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count less than 0");
			}
			if (count > buffer.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count is greater than buffer length - offset");
			}
			bool continueAfterHandshake = true;
			if (count == 0)
			{
				continueAfterHandshake = false;
			}
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = new global::OpenSSL.SslStreamBase.InternalAsyncResult(asyncCallback, asyncState, buffer, offset, count, false, continueAfterHandshake);
			if (this.NeedHandshake)
			{
				this.BeginHandshake(internalAsyncResult);
			}
			else
			{
				this.InternalBeginRead(internalAsyncResult);
			}
			return internalAsyncResult;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00007218 File Offset: 0x00005418
		private void InternalBeginRead(global::OpenSSL.SslStreamBase.InternalAsyncResult asyncResult)
		{
			if (this.decrypted_data_stream.Position == this.decrypted_data_stream.Length)
			{
				this.decrypted_data_stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				this.decrypted_data_stream.SetLength(0L);
			}
			if (this.decrypted_data_stream.Length > 0L && this.decrypted_data_stream.Position != this.decrypted_data_stream.Length)
			{
				int complete = this.decrypted_data_stream.Read(asyncResult.Buffer, asyncResult.Offset, asyncResult.Count);
				asyncResult.SetComplete(complete);
				return;
			}
			this.innerStream.BeginRead(this.read_buffer, 0, this.read_buffer.Length, new global::System.AsyncCallback(this.InternalReadCallback), asyncResult);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000072D0 File Offset: 0x000054D0
		private void InternalReadCallback(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = (global::OpenSSL.SslStreamBase.InternalAsyncResult)asyncResult.AsyncState;
			bool flag = false;
			try
			{
				int num = 0;
				try
				{
					num = this.innerStream.EndRead(asyncResult);
				}
				catch (global::System.Exception complete)
				{
					internalAsyncResult.SetComplete(complete);
				}
				if (num <= 0)
				{
					internalAsyncResult.SetComplete(0);
				}
				else
				{
					this.read_bio.Write(this.read_buffer, num);
					if (this.handShakeState == global::OpenSSL.HandshakeState.InProcess || this.handShakeState == global::OpenSSL.HandshakeState.RenegotiateInProcess)
					{
						internalAsyncResult.SetComplete(num);
					}
					else
					{
						uint bytesPending = this.read_bio.BytesPending;
						byte[] array = new byte[18437];
						while (bytesPending > 0U)
						{
							int num2 = this.ssl.Read(array, array.Length);
							if (num2 <= 0)
							{
								global::OpenSSL.SslError error = this.ssl.GetError(num2);
								if (error == global::OpenSSL.SslError.SSL_ERROR_WANT_READ)
								{
									if (this.write_bio.BytesPending > 0U)
									{
										global::System.ArraySegment<byte> arraySegment = this.write_bio.ReadBytes((int)this.write_bio.BytesPending);
										this.innerStream.BeginWrite(arraySegment.Array, 0, arraySegment.Count, new global::System.AsyncCallback(this.RenegotiationWriteCallback), internalAsyncResult);
										return;
									}
								}
								else if (error != global::OpenSSL.SslError.SSL_ERROR_WANT_WRITE)
								{
									if (error == global::OpenSSL.SslError.SSL_ERROR_ZERO_RETURN)
									{
										this.SendShutdownAlert();
										break;
									}
									throw new global::OpenSSL.Core.OpenSslException();
								}
							}
							if (num2 > 0)
							{
								long position = this.decrypted_data_stream.Position;
								this.decrypted_data_stream.Seek(0L, global::System.IO.SeekOrigin.End);
								this.decrypted_data_stream.Write(array, 0, num2);
								this.decrypted_data_stream.Seek(position, global::System.IO.SeekOrigin.Begin);
								flag = true;
							}
							bytesPending = this.read_bio.BytesPending;
						}
						if (!flag)
						{
							this.innerStream.BeginRead(this.read_buffer, 0, this.read_buffer.Length, new global::System.AsyncCallback(this.InternalReadCallback), internalAsyncResult);
						}
						else
						{
							int complete2 = this.decrypted_data_stream.Read(internalAsyncResult.Buffer, internalAsyncResult.Offset, internalAsyncResult.Count);
							internalAsyncResult.SetComplete(complete2);
						}
					}
				}
			}
			catch (global::System.Exception complete3)
			{
				internalAsyncResult.SetComplete(complete3);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000074EC File Offset: 0x000056EC
		public override int EndRead(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = asyncResult as global::OpenSSL.SslStreamBase.InternalAsyncResult;
			if (internalAsyncResult == null)
			{
				throw new global::System.ArgumentException("AsyncResult was not obtained via BeginRead", "asyncResult");
			}
			if (!internalAsyncResult.IsCompleted && !internalAsyncResult.AsyncWaitHandle.WaitOne(300000, false))
			{
				throw new global::OpenSSL.ReadTimeoutException();
			}
			if (internalAsyncResult.CompletedWithError)
			{
				throw internalAsyncResult.AsyncException;
			}
			return internalAsyncResult.BytesRead;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00007549 File Offset: 0x00005749
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00007550 File Offset: 0x00005750
		public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer", "buffer can't be null");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset less than 0");
			}
			if (offset > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset must be less than buffer length");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count less than 0");
			}
			if (count > buffer.Length - offset)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count is greater than buffer length - offset");
			}
			bool continueAfterHandshake = true;
			if (count == 0)
			{
				continueAfterHandshake = false;
			}
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = new global::OpenSSL.SslStreamBase.InternalAsyncResult(asyncCallback, asyncState, buffer, offset, count, true, continueAfterHandshake);
			if (this.NeedHandshake)
			{
				this.BeginHandshake(internalAsyncResult);
			}
			else
			{
				this.InternalBeginWrite(internalAsyncResult);
			}
			return internalAsyncResult;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000075F8 File Offset: 0x000057F8
		private void InternalBeginWrite(global::OpenSSL.SslStreamBase.InternalAsyncResult asyncResult)
		{
			byte[] array = asyncResult.Buffer;
			if (asyncResult.Offset != 0 && asyncResult.Count != 0)
			{
				array = new byte[asyncResult.Count];
				global::System.Array.Copy(asyncResult.Buffer, asyncResult.Offset, array, 0, asyncResult.Count);
			}
			if (asyncResult.Count != 0)
			{
				int num = this.ssl.Write(array, asyncResult.Count);
				if (num < 0)
				{
					global::OpenSSL.SslError error = this.ssl.GetError(num);
					throw new global::OpenSSL.Core.OpenSslException();
				}
			}
			uint bytesPending = this.write_bio.BytesPending;
			global::System.ArraySegment<byte> arraySegment = this.write_bio.ReadBytes((int)bytesPending);
			this.innerStream.BeginWrite(arraySegment.Array, 0, arraySegment.Count, new global::System.AsyncCallback(this.InternalWriteCallback), asyncResult);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000076BC File Offset: 0x000058BC
		private void InternalWriteCallback(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = (global::OpenSSL.SslStreamBase.InternalAsyncResult)asyncResult.AsyncState;
			try
			{
				this.innerStream.EndWrite(asyncResult);
				internalAsyncResult.SetComplete();
			}
			catch (global::System.Exception complete)
			{
				internalAsyncResult.SetComplete(complete);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00007704 File Offset: 0x00005904
		public override void EndWrite(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = asyncResult as global::OpenSSL.SslStreamBase.InternalAsyncResult;
			if (internalAsyncResult == null)
			{
				throw new global::System.ArgumentException("AsyncResult object was not obtained from SslStream.BeginWrite", "asyncResult");
			}
			if (!internalAsyncResult.IsCompleted && !internalAsyncResult.AsyncWaitHandle.WaitOne(300000, false))
			{
				throw new global::System.IO.IOException("Failed to complete the Write operation");
			}
			if (internalAsyncResult.CompletedWithError)
			{
				throw internalAsyncResult.AsyncException;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00007760 File Offset: 0x00005960
		private void RenegotiationWriteCallback(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult asyncResult2 = (global::OpenSSL.SslStreamBase.InternalAsyncResult)asyncResult.AsyncState;
			this.innerStream.EndWrite(asyncResult);
			this.InternalBeginRead(asyncResult2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000778C File Offset: 0x0000598C
		private global::System.IAsyncResult BeginHandshake(global::OpenSSL.SslStreamBase.InternalAsyncResult readwriteAsyncResult)
		{
			if (this.handShakeState != global::OpenSSL.HandshakeState.Renegotiate)
			{
				this.handShakeState = global::OpenSSL.HandshakeState.InProcess;
			}
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = new global::OpenSSL.SslStreamBase.InternalAsyncResult(new global::System.AsyncCallback(this.AsyncHandshakeComplete), readwriteAsyncResult, null, 0, 0, readwriteAsyncResult.IsWriteOperation, readwriteAsyncResult.ContinueAfterHandshake);
			if (this.ProcessHandshake())
			{
				this.handShakeState = global::OpenSSL.HandshakeState.Complete;
				internalAsyncResult.SetComplete();
			}
			else if (this.write_bio.BytesPending > 0U)
			{
				internalAsyncResult.IsWriteOperation = true;
				this.BeginWrite(new byte[0], 0, 0, new global::System.AsyncCallback(this.AsyncHandshakeCallback), internalAsyncResult);
			}
			else
			{
				internalAsyncResult.IsWriteOperation = false;
				this.BeginRead(new byte[0], 0, 0, new global::System.AsyncCallback(this.AsyncHandshakeCallback), internalAsyncResult);
			}
			return internalAsyncResult;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000783C File Offset: 0x00005A3C
		private void AsyncHandshakeCallback(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = (global::OpenSSL.SslStreamBase.InternalAsyncResult)asyncResult.AsyncState;
			if (!internalAsyncResult.IsWriteOperation)
			{
				try
				{
					int num = this.EndRead(asyncResult);
					if (num > 0)
					{
						if (this.ProcessHandshake())
						{
							this.handShakeState = global::OpenSSL.HandshakeState.Complete;
							if (this.write_bio.BytesPending > 0U)
							{
								internalAsyncResult.IsWriteOperation = true;
								this.BeginWrite(new byte[0], 0, 0, new global::System.AsyncCallback(this.AsyncHandshakeCallback), internalAsyncResult);
							}
							else
							{
								internalAsyncResult.SetComplete();
							}
						}
						else
						{
							internalAsyncResult.IsWriteOperation = true;
							this.BeginWrite(new byte[0], 0, 0, new global::System.AsyncCallback(this.AsyncHandshakeCallback), internalAsyncResult);
						}
					}
					else
					{
						internalAsyncResult.SetComplete(new global::System.IO.IOException("The remote stream has been closed"));
					}
				}
				catch (global::System.Exception complete)
				{
					internalAsyncResult.SetComplete(complete);
				}
				return;
			}
			this.EndWrite(asyncResult);
			if (this.handShakeState == global::OpenSSL.HandshakeState.Complete)
			{
				internalAsyncResult.SetComplete();
				return;
			}
			if (this.handshakeException != null)
			{
				internalAsyncResult.SetComplete(this.handshakeException);
				return;
			}
			internalAsyncResult.IsWriteOperation = false;
			this.BeginRead(new byte[0], 0, 0, new global::System.AsyncCallback(this.AsyncHandshakeCallback), internalAsyncResult);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00007958 File Offset: 0x00005B58
		private void AsyncHandshakeComplete(global::System.IAsyncResult asyncResult)
		{
			this.EndHandshake(asyncResult);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00007964 File Offset: 0x00005B64
		private void EndHandshake(global::System.IAsyncResult asyncResult)
		{
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult = asyncResult as global::OpenSSL.SslStreamBase.InternalAsyncResult;
			global::OpenSSL.SslStreamBase.InternalAsyncResult internalAsyncResult2 = asyncResult.AsyncState as global::OpenSSL.SslStreamBase.InternalAsyncResult;
			if (!internalAsyncResult.IsCompleted)
			{
				internalAsyncResult.AsyncWaitHandle.WaitOne(300000, false);
			}
			if (internalAsyncResult.CompletedWithError)
			{
				internalAsyncResult2.SetComplete(internalAsyncResult.AsyncException);
				return;
			}
			if (!internalAsyncResult2.ContinueAfterHandshake)
			{
				internalAsyncResult2.SetComplete();
				return;
			}
			if (internalAsyncResult2.IsWriteOperation)
			{
				this.InternalBeginWrite(internalAsyncResult2);
				return;
			}
			this.InternalBeginRead(internalAsyncResult2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000079D9 File Offset: 0x00005BD9
		public override void Close()
		{
			if (this.ssl != null)
			{
				this.ssl.Dispose();
				this.ssl = null;
			}
			if (this.sslContext != null)
			{
				this.sslContext.Dispose();
				this.sslContext = null;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00007A0F File Offset: 0x00005C0F
		public void Renegotiate()
		{
			if (this.ssl != null)
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.SSL_renegotiate(this.ssl.Handle));
				this.handShakeState = global::OpenSSL.HandshakeState.Renegotiate;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00007A36 File Offset: 0x00005C36
		void global::System.IDisposable.Dispose()
		{
			bool flag = this.disposed;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00007A44 File Offset: 0x00005C44
		internal string GetCipherString(bool FIPSmode, global::OpenSSL.SslProtocols sslProtocols, global::OpenSSL.SslStrength sslStrength)
		{
			if (this.explicitCipher != null)
			{
				return this.explicitCipher;
			}
			string text = "";
			if (FIPSmode || (sslStrength & global::OpenSSL.SslStrength.High) == global::OpenSSL.SslStrength.High)
			{
				text = "HIGH";
			}
			if (FIPSmode || (sslStrength & global::OpenSSL.SslStrength.Medium) == global::OpenSSL.SslStrength.Medium)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = "MEDIUM";
				}
				else
				{
					text += ":MEDIUM";
				}
			}
			if (!FIPSmode && (sslStrength & global::OpenSSL.SslStrength.Low) == global::OpenSSL.SslStrength.Low)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = "LOW";
				}
				else
				{
					text += ":LOW";
				}
			}
			if (sslProtocols == global::OpenSSL.SslProtocols.Default || sslProtocols == global::OpenSSL.SslProtocols.Tls || sslProtocols == global::OpenSSL.SslProtocols.Ssl3)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = "!SSLv2";
				}
				else
				{
					text += ":!SSLv2";
				}
			}
			if (FIPSmode)
			{
				text += ":AES:3DES:SHA:!DES:!MD5:!IDEA:!RC2:!RC4";
			}
			return string.Format("{0}:!ADH:!aNULL:!eNULL:@STRENGTH", text);
		}

		// Token: 0x04000331 RID: 817
		private const int SSL3_RT_HEADER_LENGTH = 5;

		// Token: 0x04000332 RID: 818
		private const int SSL3_RT_MAX_PLAIN_LENGTH = 16384;

		// Token: 0x04000333 RID: 819
		private const int SSL3_RT_MAX_COMPRESSED_LENGTH = 17408;

		// Token: 0x04000334 RID: 820
		private const int SSL3_RT_MAX_ENCRYPTED_LENGTH = 18432;

		// Token: 0x04000335 RID: 821
		private const int SSL3_RT_MAX_PACKET_SIZE = 18437;

		// Token: 0x04000336 RID: 822
		private const int WaitTimeOut = 300000;

		// Token: 0x04000337 RID: 823
		internal global::System.IO.Stream innerStream;

		// Token: 0x04000338 RID: 824
		internal bool ownStream;

		// Token: 0x04000339 RID: 825
		private volatile bool disposed;

		// Token: 0x0400033A RID: 826
		internal global::OpenSSL.SslContext sslContext;

		// Token: 0x0400033B RID: 827
		internal global::OpenSSL.Ssl ssl;

		// Token: 0x0400033C RID: 828
		internal global::OpenSSL.Core.BIO read_bio;

		// Token: 0x0400033D RID: 829
		internal global::OpenSSL.Core.BIO write_bio;

		// Token: 0x0400033E RID: 830
		private byte[] read_buffer;

		// Token: 0x0400033F RID: 831
		private global::System.IO.MemoryStream decrypted_data_stream;

		// Token: 0x04000340 RID: 832
		protected global::OpenSSL.LocalCertificateSelectionHandler localCertificateSelectionCallback;

		// Token: 0x04000341 RID: 833
		protected global::OpenSSL.RemoteCertificateValidationHandler remoteCertificateSelectionCallback;

		// Token: 0x04000342 RID: 834
		protected bool checkCertificateRevocationStatus;

		// Token: 0x04000343 RID: 835
		protected global::OpenSSL.HandshakeState handShakeState;

		// Token: 0x04000344 RID: 836
		protected global::OpenSSL.Core.OpenSslException handshakeException;

		// Token: 0x04000345 RID: 837
		private string explicitCipher;

		// Token: 0x02000066 RID: 102
		private class InternalAsyncResult : global::System.IAsyncResult
		{
			// Token: 0x06000458 RID: 1112 RVA: 0x00007B04 File Offset: 0x00005D04
			public InternalAsyncResult(global::System.AsyncCallback userCallback, object userState, byte[] buffer, int offset, int count, bool isWriteOperation, bool continueAfterHandshake)
			{
				this.userCallback = userCallback;
				this.userState = userState;
				this.buffer = buffer;
				this.offset = offset;
				this.count = count;
				this.isWriteOperation = isWriteOperation;
				this.continueAfterHandshake = continueAfterHandshake;
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x00007B57 File Offset: 0x00005D57
			public bool ContinueAfterHandshake
			{
				get
				{
					return this.continueAfterHandshake;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x00007B5F File Offset: 0x00005D5F
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x00007B67 File Offset: 0x00005D67
			public bool IsWriteOperation
			{
				get
				{
					return this.isWriteOperation;
				}
				set
				{
					this.isWriteOperation = value;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x00007B70 File Offset: 0x00005D70
			public byte[] Buffer
			{
				get
				{
					return this.buffer;
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600045D RID: 1117 RVA: 0x00007B78 File Offset: 0x00005D78
			public int Offset
			{
				get
				{
					return this.offset;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00007B80 File Offset: 0x00005D80
			public int Count
			{
				get
				{
					return this.count;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600045F RID: 1119 RVA: 0x00007B88 File Offset: 0x00005D88
			public int BytesRead
			{
				get
				{
					return this.bytesRead;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x00007B90 File Offset: 0x00005D90
			public object AsyncState
			{
				get
				{
					return this.userState;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000461 RID: 1121 RVA: 0x00007B98 File Offset: 0x00005D98
			public global::System.Exception AsyncException
			{
				get
				{
					return this.asyncException;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x00007BA0 File Offset: 0x00005DA0
			public bool CompletedWithError
			{
				get
				{
					return this.IsCompleted && null != this.asyncException;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000463 RID: 1123 RVA: 0x00007BB8 File Offset: 0x00005DB8
			public global::System.Threading.WaitHandle AsyncWaitHandle
			{
				get
				{
					lock (this.locker)
					{
						if (this.asyncWaitHandle == null)
						{
							this.asyncWaitHandle = new global::System.Threading.ManualResetEvent(this.isCompleted);
						}
					}
					return this.asyncWaitHandle;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x00007C14 File Offset: 0x00005E14
			public bool CompletedSynchronously
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000465 RID: 1125 RVA: 0x00007C18 File Offset: 0x00005E18
			public bool IsCompleted
			{
				get
				{
					bool result;
					lock (this.locker)
					{
						result = this.isCompleted;
					}
					return result;
				}
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00007C5C File Offset: 0x00005E5C
			private void SetComplete(global::System.Exception ex, int bytesRead)
			{
				lock (this.locker)
				{
					if (this.isCompleted)
					{
						return;
					}
					this.isCompleted = true;
					this.asyncException = ex;
					this.bytesRead = bytesRead;
					if (this.asyncWaitHandle != null)
					{
						this.asyncWaitHandle.Set();
					}
				}
				if (this.userCallback != null)
				{
					this.userCallback.BeginInvoke(this, null, null);
				}
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00007CE0 File Offset: 0x00005EE0
			public void SetComplete(global::System.Exception ex)
			{
				this.SetComplete(ex, 0);
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00007CEA File Offset: 0x00005EEA
			public void SetComplete(int bytesRead)
			{
				this.SetComplete(null, bytesRead);
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00007CF4 File Offset: 0x00005EF4
			public void SetComplete()
			{
				this.SetComplete(null, 0);
			}

			// Token: 0x04000346 RID: 838
			private object locker = new object();

			// Token: 0x04000347 RID: 839
			private global::System.AsyncCallback userCallback;

			// Token: 0x04000348 RID: 840
			private object userState;

			// Token: 0x04000349 RID: 841
			private global::System.Exception asyncException;

			// Token: 0x0400034A RID: 842
			private global::System.Threading.ManualResetEvent asyncWaitHandle;

			// Token: 0x0400034B RID: 843
			private bool isCompleted;

			// Token: 0x0400034C RID: 844
			private int bytesRead;

			// Token: 0x0400034D RID: 845
			private bool isWriteOperation;

			// Token: 0x0400034E RID: 846
			private bool continueAfterHandshake;

			// Token: 0x0400034F RID: 847
			private byte[] buffer;

			// Token: 0x04000350 RID: 848
			private int offset;

			// Token: 0x04000351 RID: 849
			private int count;
		}
	}
}
