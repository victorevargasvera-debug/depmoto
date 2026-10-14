using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02000024 RID: 36
	internal static class SQLiteConnectionPool
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00019268 File Offset: 0x00018668
		internal static void GetCounts(string fileName, ref global::System.Collections.Generic.Dictionary<string, int> counts, ref int openCount, ref int closeCount, ref int totalCount)
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool = global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			if (connectionPool != null)
			{
				connectionPool.GetCounts(fileName, ref counts, ref openCount, ref closeCount, ref totalCount);
				return;
			}
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				openCount = global::System.Data.SQLite.SQLiteConnectionPool._poolOpened;
				closeCount = global::System.Data.SQLite.SQLiteConnectionPool._poolClosed;
				if (counts == null)
				{
					counts = new global::System.Collections.Generic.Dictionary<string, int>(global::System.StringComparer.OrdinalIgnoreCase);
				}
				if (fileName != null)
				{
					global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue poolQueue;
					if (global::System.Data.SQLite.SQLiteConnectionPool._queueList.TryGetValue(fileName, out poolQueue))
					{
						global::System.Collections.Generic.Queue<global::System.WeakReference> queue = poolQueue.Queue;
						int num = (queue != null) ? queue.Count : 0;
						counts.Add(fileName, num);
						totalCount += num;
					}
				}
				else
				{
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue> keyValuePair in global::System.Data.SQLite.SQLiteConnectionPool._queueList)
					{
						if (keyValuePair.Value != null)
						{
							global::System.Collections.Generic.Queue<global::System.WeakReference> queue2 = keyValuePair.Value.Queue;
							int num2 = (queue2 != null) ? queue2.Count : 0;
							counts.Add(keyValuePair.Key, num2);
							totalCount += num2;
						}
					}
				}
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000193A4 File Offset: 0x000187A4
		internal static void ClearPool(string fileName)
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool = global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			if (connectionPool != null)
			{
				connectionPool.ClearPool(fileName);
				return;
			}
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue poolQueue;
				if (global::System.Data.SQLite.SQLiteConnectionPool._queueList.TryGetValue(fileName, out poolQueue))
				{
					poolQueue.PoolVersion++;
					global::System.Collections.Generic.Queue<global::System.WeakReference> queue = poolQueue.Queue;
					if (queue != null)
					{
						while (queue.Count > 0)
						{
							global::System.WeakReference weakReference = queue.Dequeue();
							if (weakReference != null)
							{
								global::System.Data.SQLite.SQLiteConnectionHandle sqliteConnectionHandle = weakReference.Target as global::System.Data.SQLite.SQLiteConnectionHandle;
								if (sqliteConnectionHandle != null)
								{
									sqliteConnectionHandle.Dispose();
								}
								global::System.GC.KeepAlive(sqliteConnectionHandle);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00019458 File Offset: 0x00018858
		internal static void ClearAllPools()
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool = global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			if (connectionPool != null)
			{
				connectionPool.ClearAllPools();
				return;
			}
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue> keyValuePair in global::System.Data.SQLite.SQLiteConnectionPool._queueList)
				{
					if (keyValuePair.Value != null)
					{
						global::System.Collections.Generic.Queue<global::System.WeakReference> queue = keyValuePair.Value.Queue;
						while (queue.Count > 0)
						{
							global::System.WeakReference weakReference = queue.Dequeue();
							if (weakReference != null)
							{
								global::System.Data.SQLite.SQLiteConnectionHandle sqliteConnectionHandle = weakReference.Target as global::System.Data.SQLite.SQLiteConnectionHandle;
								if (sqliteConnectionHandle != null)
								{
									sqliteConnectionHandle.Dispose();
								}
								global::System.GC.KeepAlive(sqliteConnectionHandle);
							}
						}
						if (global::System.Data.SQLite.SQLiteConnectionPool._poolVersion <= keyValuePair.Value.PoolVersion)
						{
							global::System.Data.SQLite.SQLiteConnectionPool._poolVersion = keyValuePair.Value.PoolVersion + 1;
						}
					}
				}
				global::System.Data.SQLite.SQLiteConnectionPool._queueList.Clear();
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00019570 File Offset: 0x00018970
		internal static void Add(string fileName, global::System.Data.SQLite.SQLiteConnectionHandle handle, int version)
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool = global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			if (connectionPool != null)
			{
				connectionPool.Add(fileName, handle, version);
				return;
			}
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue poolQueue;
				if (global::System.Data.SQLite.SQLiteConnectionPool._queueList.TryGetValue(fileName, out poolQueue) && version == poolQueue.PoolVersion)
				{
					global::System.Data.SQLite.SQLiteConnectionPool.ResizePool(poolQueue, true);
					global::System.Collections.Generic.Queue<global::System.WeakReference> queue = poolQueue.Queue;
					if (queue == null)
					{
						return;
					}
					queue.Enqueue(new global::System.WeakReference(handle, false));
					global::System.Threading.Interlocked.Increment(ref global::System.Data.SQLite.SQLiteConnectionPool._poolClosed);
				}
				else
				{
					handle.Close();
				}
				global::System.GC.KeepAlive(handle);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001961C File Offset: 0x00018A1C
		internal static global::System.Data.SQLite.SQLiteConnectionHandle Remove(string fileName, int maxPoolSize, out int version)
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool = global::System.Data.SQLite.SQLiteConnectionPool.GetConnectionPool();
			if (connectionPool != null)
			{
				return connectionPool.Remove(fileName, maxPoolSize, out version) as global::System.Data.SQLite.SQLiteConnectionHandle;
			}
			int version2;
			global::System.Collections.Generic.Queue<global::System.WeakReference> queue;
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				version = global::System.Data.SQLite.SQLiteConnectionPool._poolVersion;
				global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue poolQueue;
				if (!global::System.Data.SQLite.SQLiteConnectionPool._queueList.TryGetValue(fileName, out poolQueue))
				{
					poolQueue = new global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue(global::System.Data.SQLite.SQLiteConnectionPool._poolVersion, maxPoolSize);
					global::System.Data.SQLite.SQLiteConnectionPool._queueList.Add(fileName, poolQueue);
					return null;
				}
				version2 = (version = poolQueue.PoolVersion);
				poolQueue.MaxPoolSize = maxPoolSize;
				global::System.Data.SQLite.SQLiteConnectionPool.ResizePool(poolQueue, false);
				queue = poolQueue.Queue;
				if (queue == null)
				{
					return null;
				}
				global::System.Data.SQLite.SQLiteConnectionPool._queueList.Remove(fileName);
				queue = new global::System.Collections.Generic.Queue<global::System.WeakReference>(queue);
			}
			try
			{
				while (queue.Count > 0)
				{
					global::System.WeakReference weakReference = queue.Dequeue();
					if (weakReference != null)
					{
						global::System.Data.SQLite.SQLiteConnectionHandle sqliteConnectionHandle = weakReference.Target as global::System.Data.SQLite.SQLiteConnectionHandle;
						if (sqliteConnectionHandle != null)
						{
							global::System.GC.SuppressFinalize(sqliteConnectionHandle);
							try
							{
								global::System.GC.WaitForPendingFinalizers();
								if (!sqliteConnectionHandle.IsInvalid && !sqliteConnectionHandle.IsClosed)
								{
									global::System.Threading.Interlocked.Increment(ref global::System.Data.SQLite.SQLiteConnectionPool._poolOpened);
									return sqliteConnectionHandle;
								}
							}
							finally
							{
								global::System.GC.ReRegisterForFinalize(sqliteConnectionHandle);
							}
							global::System.GC.KeepAlive(sqliteConnectionHandle);
						}
					}
				}
			}
			finally
			{
				lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
				{
					global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue poolQueue2;
					bool flag3;
					if (global::System.Data.SQLite.SQLiteConnectionPool._queueList.TryGetValue(fileName, out poolQueue2))
					{
						flag3 = false;
					}
					else
					{
						flag3 = true;
						poolQueue2 = new global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue(version2, maxPoolSize);
					}
					global::System.Collections.Generic.Queue<global::System.WeakReference> queue2 = poolQueue2.Queue;
					while (queue.Count > 0)
					{
						queue2.Enqueue(queue.Dequeue());
					}
					global::System.Data.SQLite.SQLiteConnectionPool.ResizePool(poolQueue2, false);
					if (flag3)
					{
						global::System.Data.SQLite.SQLiteConnectionPool._queueList.Add(fileName, poolQueue2);
					}
				}
			}
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00019824 File Offset: 0x00018C24
		internal static global::System.Data.SQLite.ISQLiteConnectionPool GetConnectionPool()
		{
			global::System.Data.SQLite.ISQLiteConnectionPool connectionPool;
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				connectionPool = global::System.Data.SQLite.SQLiteConnectionPool._connectionPool;
			}
			return connectionPool;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00019870 File Offset: 0x00018C70
		internal static void SetConnectionPool(global::System.Data.SQLite.ISQLiteConnectionPool connectionPool)
		{
			lock (global::System.Data.SQLite.SQLiteConnectionPool._syncRoot)
			{
				global::System.Data.SQLite.SQLiteConnectionPool._connectionPool = connectionPool;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000198BC File Offset: 0x00018CBC
		private static void ResizePool(global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue queue, bool add)
		{
			int num = queue.MaxPoolSize;
			if (add && num > 0)
			{
				num--;
			}
			global::System.Collections.Generic.Queue<global::System.WeakReference> queue2 = queue.Queue;
			if (queue2 == null)
			{
				return;
			}
			while (queue2.Count > num)
			{
				global::System.WeakReference weakReference = queue2.Dequeue();
				if (weakReference != null)
				{
					global::System.Data.SQLite.SQLiteConnectionHandle sqliteConnectionHandle = weakReference.Target as global::System.Data.SQLite.SQLiteConnectionHandle;
					if (sqliteConnectionHandle != null)
					{
						sqliteConnectionHandle.Dispose();
					}
					global::System.GC.KeepAlive(sqliteConnectionHandle);
				}
			}
		}

		// Token: 0x040000C5 RID: 197
		private static readonly object _syncRoot = new object();

		// Token: 0x040000C6 RID: 198
		private static global::System.Data.SQLite.ISQLiteConnectionPool _connectionPool = null;

		// Token: 0x040000C7 RID: 199
		private static global::System.Collections.Generic.SortedList<string, global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue> _queueList = new global::System.Collections.Generic.SortedList<string, global::System.Data.SQLite.SQLiteConnectionPool.PoolQueue>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040000C8 RID: 200
		private static int _poolVersion = 1;

		// Token: 0x040000C9 RID: 201
		private static int _poolOpened = 0;

		// Token: 0x040000CA RID: 202
		private static int _poolClosed = 0;

		// Token: 0x02000025 RID: 37
		private sealed class PoolQueue
		{
			// Token: 0x06000253 RID: 595 RVA: 0x00019954 File Offset: 0x00018D54
			internal PoolQueue(int version, int maxSize)
			{
				this.PoolVersion = version;
				this.MaxPoolSize = maxSize;
			}

			// Token: 0x040000CB RID: 203
			internal readonly global::System.Collections.Generic.Queue<global::System.WeakReference> Queue = new global::System.Collections.Generic.Queue<global::System.WeakReference>();

			// Token: 0x040000CC RID: 204
			internal int PoolVersion;

			// Token: 0x040000CD RID: 205
			internal int MaxPoolSize;
		}
	}
}
