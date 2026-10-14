using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006E RID: 110
	public class QueryCacher
	{
		// Token: 0x0600028C RID: 652 RVA: 0x0000C648 File Offset: 0x0000A848
		public QueryCacher(int maxCacheNum)
		{
			this.maxCacheNum = maxCacheNum;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000C678 File Offset: 0x0000A878
		public object GetCache(string key)
		{
			lock (this.locker)
			{
				if (string.IsNullOrEmpty(key))
				{
					return null;
				}
				if (this.cacheMap.ContainsKey(key))
				{
					object obj2 = this.cacheMap[key];
					global::System.ICloneable cloneable = obj2 as global::System.ICloneable;
					if (cloneable != null)
					{
						return cloneable.Clone();
					}
					return obj2;
				}
			}
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		public object GetCache(string keyFormat, params object[] keys)
		{
			return this.GetCache(string.Format(keyFormat, keys));
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000C707 File Offset: 0x0000A907
		public void DoCache(string key, global::System.ValueType value)
		{
			this.DoCacheImp(key, value);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000C711 File Offset: 0x0000A911
		public void DoCache(string key, global::System.ICloneable value)
		{
			this.DoCacheImp(key, value.Clone());
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000C720 File Offset: 0x0000A920
		public void DoCache(global::System.ValueType value, string keyFormat, params object[] keys)
		{
			this.DoCacheImp(value, keyFormat, keys);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000C72B File Offset: 0x0000A92B
		public void DoCache(global::System.ICloneable value, string keyFormat, params object[] keys)
		{
			if (value == null)
			{
				return;
			}
			this.DoCacheImp(value.Clone(), keyFormat, keys);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000C740 File Offset: 0x0000A940
		private void DoCacheImp(string key, object value)
		{
			lock (this.locker)
			{
				if (!string.IsNullOrEmpty(key))
				{
					if (this.cacheQueue.Count > this.maxCacheNum)
					{
						this.cacheMap.Remove(this.cacheQueue.Peek());
						this.cacheQueue.Dequeue();
					}
					this.cacheMap[key] = value;
					this.cacheQueue.Enqueue(key);
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		private void DoCacheImp(object value, string keyFormat, params object[] keys)
		{
			this.DoCacheImp(string.Format(keyFormat, keys), value);
		}

		// Token: 0x040002FD RID: 765
		private int maxCacheNum;

		// Token: 0x040002FE RID: 766
		private global::System.Collections.Generic.Dictionary<string, object> cacheMap = new global::System.Collections.Generic.Dictionary<string, object>();

		// Token: 0x040002FF RID: 767
		private global::System.Collections.Generic.Queue<string> cacheQueue = new global::System.Collections.Generic.Queue<string>();

		// Token: 0x04000300 RID: 768
		private object locker = new object();
	}
}
