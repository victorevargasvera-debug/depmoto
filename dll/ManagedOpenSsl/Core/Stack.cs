using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace OpenSSL.Core
{
	// Token: 0x02000073 RID: 115
	public class Stack<T> : global::OpenSSL.Core.BaseValueType, global::OpenSSL.Core.IStack, global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable where T : global::OpenSSL.Core.Base, global::OpenSSL.Core.IStackable
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x00008D18 File Offset: 0x00006F18
		internal Stack(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00008D22 File Offset: 0x00006F22
		public Stack() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.sk_new_null()), true)
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00008D38 File Offset: 0x00006F38
		public T Shift()
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.sk_shift(this.ptr);
			return this.CreateInstance(ptr);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00008D58 File Offset: 0x00006F58
		protected override void OnDispose()
		{
			this.Clear();
			global::OpenSSL.Core.Native.sk_free(this.ptr);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00008D6B File Offset: 0x00006F6B
		internal override global::System.IntPtr DuplicateHandle()
		{
			return global::OpenSSL.Core.Native.sk_dup(this.ptr);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00008D78 File Offset: 0x00006F78
		public int IndexOf(T item)
		{
			return global::OpenSSL.Core.Native.sk_find(this.ptr, item.Handle);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00008D92 File Offset: 0x00006F92
		public void Insert(int index, T item)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.sk_insert(this.ptr, item.Handle, index));
			item.AddRef();
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00008DC0 File Offset: 0x00006FC0
		public void RemoveAt(int index)
		{
			global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.sk_delete(this.ptr, index));
		}

		// Token: 0x170000AC RID: 172
		public T this[int index]
		{
			get
			{
				global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.sk_value(this.ptr, index));
				T result = this.CreateInstance(ptr);
				result.AddRef();
				return result;
			}
			set
			{
				int num = global::OpenSSL.Core.Native.sk_insert(this.ptr, value.Handle, index);
				if (num < 0)
				{
					throw new global::OpenSSL.Core.OpenSslException();
				}
				value.AddRef();
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00008E4A File Offset: 0x0000704A
		public void Add(T item)
		{
			if (global::OpenSSL.Core.Native.sk_push(this.ptr, item.Handle) <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			item.AddRef();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00008E7C File Offset: 0x0000707C
		public void Clear()
		{
			global::System.IntPtr intPtr = global::OpenSSL.Core.Native.sk_shift(this.ptr);
			while (intPtr != global::System.IntPtr.Zero)
			{
				T t = this.CreateInstance(intPtr);
				t.Dispose();
				intPtr = global::OpenSSL.Core.Native.sk_shift(this.ptr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00008EC8 File Offset: 0x000070C8
		public bool Contains(T item)
		{
			foreach (T t in this)
			{
				if (t.Equals(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00008F28 File Offset: 0x00007128
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new global::System.Exception("The method or operation is not implemented.");
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00008F34 File Offset: 0x00007134
		public int Count
		{
			get
			{
				int num = global::OpenSSL.Core.Native.sk_num(this.ptr);
				if (num < 0)
				{
					throw new global::OpenSSL.Core.OpenSslException();
				}
				return num;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00008F58 File Offset: 0x00007158
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00008F5C File Offset: 0x0000715C
		public bool Remove(T item)
		{
			global::System.IntPtr value = global::OpenSSL.Core.Native.sk_delete_ptr(this.ptr, item.Handle);
			return value != global::System.IntPtr.Zero;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00008F92 File Offset: 0x00007192
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::OpenSSL.Core.Stack<T>.Enumerator(this);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00008F9A File Offset: 0x0000719A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::OpenSSL.Core.Stack<T>.Enumerator(this);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00008FA4 File Offset: 0x000071A4
		private T CreateInstance(global::System.IntPtr ptr)
		{
			object[] args = new object[]
			{
				this,
				ptr
			};
			global::System.Reflection.BindingFlags bindingAttr = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic;
			return (T)((object)global::System.Activator.CreateInstance(typeof(T), bindingAttr, null, args, null));
		}

		// Token: 0x02000074 RID: 116
		private class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060004E6 RID: 1254 RVA: 0x00008FE4 File Offset: 0x000071E4
			public Enumerator(global::OpenSSL.Core.Stack<T> parent)
			{
				this.parent = parent;
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00008FFC File Offset: 0x000071FC
			public T Current
			{
				get
				{
					if (this.index < 0 || this.index >= this.parent.Count)
					{
						throw new global::System.InvalidOperationException();
					}
					global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.sk_value(this.parent.Handle, this.index));
					T result = this.parent.CreateInstance(ptr);
					result.AddRef();
					return result;
				}
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x00009062 File Offset: 0x00007262
			public void Dispose()
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00009064 File Offset: 0x00007264
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00009071 File Offset: 0x00007271
			public bool MoveNext()
			{
				this.index++;
				return this.index < this.parent.Count;
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00009097 File Offset: 0x00007297
			public void Reset()
			{
				this.index = -1;
			}

			// Token: 0x040003B2 RID: 946
			private global::OpenSSL.Core.Stack<T> parent;

			// Token: 0x040003B3 RID: 947
			private int index = -1;
		}
	}
}
