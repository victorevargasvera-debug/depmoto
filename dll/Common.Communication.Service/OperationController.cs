using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000005 RID: 5
	internal class OperationController : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.Service.OperationController>, global::System.IDisposable
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000026A8 File Offset: 0x000008A8
		public void AddPendingOperation(global::Motorola.Common.Communication.Service.IOperationAsyncResult asyncResult)
		{
			this.m_PendingOperationsLock.EnterWriteLock();
			try
			{
				this.m_PendingOperations[asyncResult.OperationId] = asyncResult;
				global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Pending Operations Added <{0}><{1}>", new object[]
				{
					asyncResult.InterfaceName,
					asyncResult.OperationId
				});
				global::System.Console.ResetColor();
				asyncResult.OnQueued();
			}
			finally
			{
				this.m_PendingOperationsLock.ExitWriteLock();
			}
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.Callback), asyncResult);
			int num;
			int num2;
			global::System.Threading.ThreadPool.GetMaxThreads(out num, out num2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002748 File Offset: 0x00000948
		public static object GetOperationResult(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.IOperationAsyncResult operationAsyncResult = asyncResult as global::Motorola.Common.Communication.Service.IOperationAsyncResult;
			operationAsyncResult.AsyncWaitHandle.WaitOne();
			object result = null;
			if (operationAsyncResult.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Canceled)
			{
				if (operationAsyncResult.Error != null)
				{
					global::Motorola.Common.CustomException.CommonException ex = operationAsyncResult.Error as global::Motorola.Common.CustomException.CommonException;
					if (ex == null)
					{
						ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, operationAsyncResult.Error);
					}
					global::System.Console.ForegroundColor = global::System.ConsoleColor.Red;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(ex.ToString(), new object[0]);
					global::System.Console.ResetColor();
					throw ex;
				}
				result = operationAsyncResult.Output;
				operationAsyncResult.Dispose();
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000027CC File Offset: 0x000009CC
		private void Callback(object state)
		{
			global::Motorola.Common.Communication.Service.IOperationAsyncResult operationAsyncResult = state as global::Motorola.Common.Communication.Service.IOperationAsyncResult;
			string interfaceName = operationAsyncResult.InterfaceName;
			string operationId = operationAsyncResult.OperationId;
			this.m_PendingOperationsLock.EnterReadLock();
			try
			{
				if (operationAsyncResult.AsyncStatus == global::Motorola.Common.Communication.Service.AsyncStatus.Canceled || !this.m_PendingOperations.ContainsKey(operationAsyncResult.OperationId))
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Pending Operations Callback Not Called Ended " + operationAsyncResult.OperationId, new object[0]);
					return;
				}
			}
			finally
			{
				this.m_PendingOperationsLock.ExitReadLock();
			}
			try
			{
				this.RemovePendingOperation(operationAsyncResult.OperationId);
				this.AddReadingOperation(operationAsyncResult);
				try
				{
					operationAsyncResult.OnStarted();
					operationAsyncResult.OnOperation();
				}
				catch (global::System.Exception error)
				{
					operationAsyncResult.Error = error;
				}
				finally
				{
					operationAsyncResult.OnCompleted();
					this.RemoveReadingOperation(operationAsyncResult.OperationId);
				}
			}
			catch (global::System.Exception error2)
			{
				operationAsyncResult.Error = error2;
			}
			global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Pending Operations Callback Called Ended <{0}><{1}>", new object[]
			{
				interfaceName,
				operationId
			});
			global::System.Console.ResetColor();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000028FC File Offset: 0x00000AFC
		private global::Motorola.Common.Communication.Service.AsyncStatus GetPendingOperationStatus(string operationId)
		{
			global::Motorola.Common.Communication.Service.AsyncStatus result = global::Motorola.Common.Communication.Service.AsyncStatus.Unknown;
			this.m_PendingOperationsLock.EnterReadLock();
			try
			{
				if (this.m_PendingOperations.ContainsKey(operationId))
				{
					result = this.m_PendingOperations[operationId].AsyncStatus;
				}
			}
			finally
			{
				this.m_PendingOperationsLock.ExitReadLock();
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002958 File Offset: 0x00000B58
		public bool CancelPendingOperation(string operationId)
		{
			bool result = false;
			global::Motorola.Common.Communication.Service.IOperationAsyncResult operationAsyncResult = null;
			this.m_PendingOperationsLock.EnterReadLock();
			try
			{
				if (this.m_PendingOperations.ContainsKey(operationId))
				{
					operationAsyncResult = this.m_PendingOperations[operationId];
				}
			}
			finally
			{
				this.m_PendingOperationsLock.ExitReadLock();
			}
			if (operationAsyncResult != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Pending Operations Cancel Start" + operationAsyncResult.OperationId, new object[0]);
				operationAsyncResult.OnCanceled();
				result = true;
				this.RemovePendingOperation(operationId);
				operationAsyncResult.Dispose();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Pending Operations Cancel Succeed " + operationAsyncResult.OperationId, new object[0]);
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002A08 File Offset: 0x00000C08
		public bool CancelReadingOperation(string operationId)
		{
			bool result = false;
			global::Motorola.Common.Communication.Service.IOperationAsyncResult operationAsyncResult = null;
			this.m_ReadingOperationsLock.EnterReadLock();
			try
			{
				if (this.m_ReadingOperations.ContainsKey(operationId))
				{
					operationAsyncResult = this.m_ReadingOperations[operationId];
				}
			}
			finally
			{
				this.m_ReadingOperationsLock.ExitReadLock();
			}
			if (operationAsyncResult != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Running Reading Operations Get Cancelled" + operationAsyncResult.OperationId, new object[0]);
				operationAsyncResult.OnCancelReading();
				result = true;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Running Reading Operations Cancel Succeed " + operationAsyncResult.OperationId, new object[0]);
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002AAC File Offset: 0x00000CAC
		private void RemovePendingOperation(string operationId)
		{
			this.m_PendingOperationsLock.EnterWriteLock();
			try
			{
				if (this.m_PendingOperations.ContainsKey(operationId))
				{
					this.m_PendingOperations.Remove(operationId);
				}
			}
			finally
			{
				this.m_PendingOperationsLock.ExitWriteLock();
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002B00 File Offset: 0x00000D00
		private void AddReadingOperation(global::Motorola.Common.Communication.Service.IOperationAsyncResult asyncResult)
		{
			if (asyncResult.OperationId.Contains("Read_CP"))
			{
				this.m_ReadingOperationsLock.EnterWriteLock();
				try
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Reading Operations Added " + asyncResult.OperationId, new object[0]);
					this.m_ReadingOperations[asyncResult.OperationId] = asyncResult;
				}
				finally
				{
					this.m_ReadingOperationsLock.ExitWriteLock();
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002B7C File Offset: 0x00000D7C
		private void RemoveReadingOperation(string operationId)
		{
			if (operationId.Contains("Read_CP"))
			{
				this.m_ReadingOperationsLock.EnterWriteLock();
				try
				{
					if (this.m_ReadingOperations.ContainsKey(operationId))
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Reading Operations Removed " + operationId, new object[0]);
						this.m_ReadingOperations.Remove(operationId);
					}
				}
				finally
				{
					this.m_ReadingOperationsLock.ExitWriteLock();
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002BF8 File Offset: 0x00000DF8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.m_ReadingOperationsLock.Dispose();
				this.m_PendingOperationsLock.Dispose();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002C13 File Offset: 0x00000E13
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000017 RID: 23
		private global::System.Threading.ReaderWriterLockSlim m_PendingOperationsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04000018 RID: 24
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.IOperationAsyncResult> m_PendingOperations = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.IOperationAsyncResult>();

		// Token: 0x04000019 RID: 25
		private global::System.Threading.ReaderWriterLockSlim m_ReadingOperationsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400001A RID: 26
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.IOperationAsyncResult> m_ReadingOperations = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.Service.IOperationAsyncResult>();
	}
}
