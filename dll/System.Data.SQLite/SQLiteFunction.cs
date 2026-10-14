using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Data.SQLite
{
	// Token: 0x0200003B RID: 59
	public abstract class SQLiteFunction : global::System.IDisposable
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0001CB80 File Offset: 0x0001BF80
		protected SQLiteFunction()
		{
			this._contextDataList = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteFunction.AggregateData>();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001CBA0 File Offset: 0x0001BFA0
		protected SQLiteFunction(global::System.Data.SQLite.SQLiteDateFormats format, global::System.DateTimeKind kind, string formatString, bool utf16) : this()
		{
			if (utf16)
			{
				this._base = new global::System.Data.SQLite.SQLite3_UTF16(format, kind, formatString, global::System.IntPtr.Zero, null, false);
				return;
			}
			this._base = new global::System.Data.SQLite.SQLite3(format, kind, formatString, global::System.IntPtr.Zero, null, false);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0001CBE4 File Offset: 0x0001BFE4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0001CC00 File Offset: 0x0001C000
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteFunction).Name);
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0001CC2C File Offset: 0x0001C02C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Data.SQLite.SQLiteFunction.AggregateData> keyValuePair in this._contextDataList)
					{
						global::System.IDisposable disposable = keyValuePair.Value._data as global::System.IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					this._contextDataList.Clear();
					this._contextDataList = null;
					this._flags = global::System.Data.SQLite.SQLiteConnectionFlags.None;
					this._InvokeFunc = null;
					this._StepFunc = null;
					this._FinalFunc = null;
					this._CompareFunc = null;
					this._base = null;
				}
				this.disposed = true;
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0001CCF4 File Offset: 0x0001C0F4
		~SQLiteFunction()
		{
			this.Dispose(false);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001CD30 File Offset: 0x0001C130
		public global::System.Data.SQLite.SQLiteConvert SQLiteConvert
		{
			get
			{
				this.CheckDisposed();
				return this._base;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001CD4C File Offset: 0x0001C14C
		public virtual object Invoke(object[] args)
		{
			this.CheckDisposed();
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001CD60 File Offset: 0x0001C160
		public virtual void Step(object[] args, int stepNumber, ref object contextData)
		{
			this.CheckDisposed();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001CD74 File Offset: 0x0001C174
		public virtual object Final(object contextData)
		{
			this.CheckDisposed();
			return null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0001CD88 File Offset: 0x0001C188
		public virtual int Compare(string param1, string param2)
		{
			this.CheckDisposed();
			return 0;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0001CD9C File Offset: 0x0001C19C
		internal object[] ConvertParams(int nArgs, global::System.IntPtr argsptr)
		{
			object[] array = new object[nArgs];
			global::System.IntPtr[] array2 = new global::System.IntPtr[nArgs];
			global::System.Runtime.InteropServices.Marshal.Copy(argsptr, array2, 0, nArgs);
			for (int i = 0; i < nArgs; i++)
			{
				switch (this._base.GetParamValueType(array2[i]))
				{
				case global::System.Data.SQLite.TypeAffinity.Int64:
					array[i] = this._base.GetParamValueInt64(array2[i]);
					break;
				case global::System.Data.SQLite.TypeAffinity.Double:
					array[i] = this._base.GetParamValueDouble(array2[i]);
					break;
				case global::System.Data.SQLite.TypeAffinity.Text:
					array[i] = this._base.GetParamValueText(array2[i]);
					break;
				case global::System.Data.SQLite.TypeAffinity.Blob:
				{
					int num = (int)this._base.GetParamValueBytes(array2[i], 0, null, 0, 0);
					byte[] array3 = new byte[num];
					this._base.GetParamValueBytes(array2[i], 0, array3, 0, num);
					array[i] = array3;
					break;
				}
				case global::System.Data.SQLite.TypeAffinity.Null:
					array[i] = global::System.DBNull.Value;
					break;
				case global::System.Data.SQLite.TypeAffinity.DateTime:
					array[i] = this._base.ToDateTime(this._base.GetParamValueText(array2[i]));
					break;
				}
			}
			return array;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0001CF08 File Offset: 0x0001C308
		private void SetReturnValue(global::System.IntPtr context, object returnValue)
		{
			if (returnValue == null || returnValue == global::System.DBNull.Value)
			{
				this._base.ReturnNull(context);
				return;
			}
			global::System.Type type = returnValue.GetType();
			if (type == typeof(global::System.DateTime))
			{
				this._base.ReturnText(context, this._base.ToString((global::System.DateTime)returnValue));
				return;
			}
			global::System.Exception ex = returnValue as global::System.Exception;
			if (ex != null)
			{
				this._base.ReturnError(context, ex.Message);
				return;
			}
			switch (global::System.Data.SQLite.SQLiteConvert.TypeToAffinity(type))
			{
			case global::System.Data.SQLite.TypeAffinity.Int64:
				this._base.ReturnInt64(context, global::System.Convert.ToInt64(returnValue, global::System.Globalization.CultureInfo.CurrentCulture));
				return;
			case global::System.Data.SQLite.TypeAffinity.Double:
				this._base.ReturnDouble(context, global::System.Convert.ToDouble(returnValue, global::System.Globalization.CultureInfo.CurrentCulture));
				return;
			case global::System.Data.SQLite.TypeAffinity.Text:
				this._base.ReturnText(context, returnValue.ToString());
				return;
			case global::System.Data.SQLite.TypeAffinity.Blob:
				this._base.ReturnBlob(context, (byte[])returnValue);
				return;
			case global::System.Data.SQLite.TypeAffinity.Null:
				this._base.ReturnNull(context);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001D008 File Offset: 0x0001C408
		internal void ScalarCallback(global::System.IntPtr context, int nArgs, global::System.IntPtr argsptr)
		{
			try
			{
				this._context = context;
				this.SetReturnValue(context, this.Invoke(this.ConvertParams(nArgs, argsptr)));
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Invoke\" method: {0}", new object[]
						{
							ex
						}));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001D0A0 File Offset: 0x0001C4A0
		internal int CompareCallback(global::System.IntPtr ptr, int len1, global::System.IntPtr ptr1, int len2, global::System.IntPtr ptr2)
		{
			try
			{
				return this.Compare(global::System.Data.SQLite.SQLiteConvert.UTF8ToString(ptr1, len1), global::System.Data.SQLite.SQLiteConvert.UTF8ToString(ptr2, len2));
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Compare\" (UTF8) method: {0}", new object[]
						{
							ex
						}));
					}
				}
				catch
				{
				}
			}
			if (this._base != null && this._base.IsOpen())
			{
				this._base.Cancel();
			}
			return 0;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0001D158 File Offset: 0x0001C558
		internal int CompareCallback16(global::System.IntPtr ptr, int len1, global::System.IntPtr ptr1, int len2, global::System.IntPtr ptr2)
		{
			try
			{
				return this.Compare(global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(ptr1, len1), global::System.Data.SQLite.SQLite3_UTF16.UTF16ToString(ptr2, len2));
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Compare\" (UTF16) method: {0}", new object[]
						{
							ex
						}));
					}
				}
				catch
				{
				}
			}
			if (this._base != null && this._base.IsOpen())
			{
				this._base.Cancel();
			}
			return 0;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001D210 File Offset: 0x0001C610
		internal void StepCallback(global::System.IntPtr context, int nArgs, global::System.IntPtr argsptr)
		{
			try
			{
				global::System.Data.SQLite.SQLiteFunction.AggregateData aggregateData = null;
				if (this._base != null)
				{
					global::System.IntPtr key = this._base.AggregateContext(context);
					if (this._contextDataList != null && !this._contextDataList.TryGetValue(key, out aggregateData))
					{
						aggregateData = new global::System.Data.SQLite.SQLiteFunction.AggregateData();
						this._contextDataList[key] = aggregateData;
					}
				}
				if (aggregateData == null)
				{
					aggregateData = new global::System.Data.SQLite.SQLiteFunction.AggregateData();
				}
				try
				{
					this._context = context;
					this.Step(this.ConvertParams(nArgs, argsptr), aggregateData._count, ref aggregateData._data);
				}
				finally
				{
					aggregateData._count++;
				}
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Step\" method: {1}", new object[]
						{
							ex
						}));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0001D324 File Offset: 0x0001C724
		internal void FinalCallback(global::System.IntPtr context)
		{
			try
			{
				object obj = null;
				if (this._base != null)
				{
					global::System.IntPtr key = this._base.AggregateContext(context);
					global::System.Data.SQLite.SQLiteFunction.AggregateData aggregateData;
					if (this._contextDataList != null && this._contextDataList.TryGetValue(key, out aggregateData))
					{
						obj = aggregateData._data;
						this._contextDataList.Remove(key);
					}
				}
				try
				{
					this._context = context;
					this.SetReturnValue(context, this.Final(obj));
				}
				finally
				{
					global::System.IDisposable disposable = obj as global::System.IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			catch (global::System.Exception ex)
			{
				try
				{
					if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException) == global::System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException)
					{
						global::System.Data.SQLite.SQLiteLog.LogMessage(-2146233088, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Caught exception in \"Final\" method: {1}", new object[]
						{
							ex
						}));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001D428 File Offset: 0x0001C828
		[global::System.Security.Permissions.FileIOPermission(global::System.Security.Permissions.SecurityAction.Assert, AllFiles = global::System.Security.Permissions.FileIOPermissionAccess.PathDiscovery)]
		static SQLiteFunction()
		{
			try
			{
				if (global::System.Environment.GetEnvironmentVariable("No_SQLiteFunctions") == null)
				{
					global::System.Reflection.Assembly[] assemblies = global::System.AppDomain.CurrentDomain.GetAssemblies();
					int num = assemblies.Length;
					global::System.Reflection.AssemblyName name = global::System.Reflection.Assembly.GetExecutingAssembly().GetName();
					int i = 0;
					while (i < num)
					{
						bool flag = false;
						global::System.Type[] types;
						try
						{
							global::System.Reflection.AssemblyName[] referencedAssemblies = assemblies[i].GetReferencedAssemblies();
							int num2 = referencedAssemblies.Length;
							for (int j = 0; j < num2; j++)
							{
								if (referencedAssemblies[j].Name == name.Name)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								goto IL_10D;
							}
							types = assemblies[i].GetTypes();
						}
						catch (global::System.Reflection.ReflectionTypeLoadException ex)
						{
							types = ex.Types;
						}
						goto IL_A3;
						IL_10D:
						i++;
						continue;
						IL_A3:
						int num3 = types.Length;
						for (int k = 0; k < num3; k++)
						{
							if (!(types[k] == null))
							{
								object[] customAttributes = types[k].GetCustomAttributes(typeof(global::System.Data.SQLite.SQLiteFunctionAttribute), false);
								int num4 = customAttributes.Length;
								for (int l = 0; l < num4; l++)
								{
									global::System.Data.SQLite.SQLiteFunctionAttribute sqliteFunctionAttribute = customAttributes[l] as global::System.Data.SQLite.SQLiteFunctionAttribute;
									if (sqliteFunctionAttribute != null)
									{
										sqliteFunctionAttribute.InstanceType = types[k];
										global::System.Data.SQLite.SQLiteFunction._registeredFunctions.Add(sqliteFunctionAttribute);
									}
								}
							}
						}
						goto IL_10D;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0001D588 File Offset: 0x0001C988
		public static void RegisterFunction(global::System.Type typ)
		{
			object[] customAttributes = typ.GetCustomAttributes(typeof(global::System.Data.SQLite.SQLiteFunctionAttribute), false);
			int num = customAttributes.Length;
			for (int i = 0; i < num; i++)
			{
				global::System.Data.SQLite.SQLiteFunctionAttribute sqliteFunctionAttribute = customAttributes[i] as global::System.Data.SQLite.SQLiteFunctionAttribute;
				if (sqliteFunctionAttribute != null)
				{
					sqliteFunctionAttribute.InstanceType = typ;
					global::System.Data.SQLite.SQLiteFunction._registeredFunctions.Add(sqliteFunctionAttribute);
				}
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001D5D8 File Offset: 0x0001C9D8
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.SQLite.SQLiteFunction> BindFunctions(global::System.Data.SQLite.SQLiteBase sqlbase, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction> list = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunction>();
			foreach (global::System.Data.SQLite.SQLiteFunctionAttribute sqliteFunctionAttribute in global::System.Data.SQLite.SQLiteFunction._registeredFunctions)
			{
				global::System.Data.SQLite.SQLiteFunction sqliteFunction = (global::System.Data.SQLite.SQLiteFunction)global::System.Activator.CreateInstance(sqliteFunctionAttribute.InstanceType);
				global::System.Data.SQLite.SQLiteFunction.BindFunction(sqlbase, sqliteFunctionAttribute, sqliteFunction, flags);
				list.Add(sqliteFunction);
			}
			return list;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0001D658 File Offset: 0x0001CA58
		internal static void BindFunction(global::System.Data.SQLite.SQLiteBase sqliteBase, global::System.Data.SQLite.SQLiteFunctionAttribute functionAttribute, global::System.Data.SQLite.SQLiteFunction function, global::System.Data.SQLite.SQLiteConnectionFlags flags)
		{
			if (sqliteBase == null)
			{
				throw new global::System.ArgumentNullException("sqliteBase");
			}
			if (functionAttribute == null)
			{
				throw new global::System.ArgumentNullException("functionAttribute");
			}
			if (function == null)
			{
				throw new global::System.ArgumentNullException("function");
			}
			global::System.Data.SQLite.FunctionType funcType = functionAttribute.FuncType;
			function._base = sqliteBase;
			function._flags = flags;
			function._InvokeFunc = ((funcType == global::System.Data.SQLite.FunctionType.Scalar) ? new global::System.Data.SQLite.SQLiteCallback(function.ScalarCallback) : null);
			function._StepFunc = ((funcType == global::System.Data.SQLite.FunctionType.Aggregate) ? new global::System.Data.SQLite.SQLiteCallback(function.StepCallback) : null);
			function._FinalFunc = ((funcType == global::System.Data.SQLite.FunctionType.Aggregate) ? new global::System.Data.SQLite.SQLiteFinalCallback(function.FinalCallback) : null);
			function._CompareFunc = ((funcType == global::System.Data.SQLite.FunctionType.Collation) ? new global::System.Data.SQLite.SQLiteCollation(function.CompareCallback) : null);
			function._CompareFunc16 = ((funcType == global::System.Data.SQLite.FunctionType.Collation) ? new global::System.Data.SQLite.SQLiteCollation(function.CompareCallback16) : null);
			string name = functionAttribute.Name;
			if (funcType != global::System.Data.SQLite.FunctionType.Collation)
			{
				bool needCollSeq = function is global::System.Data.SQLite.SQLiteFunctionEx;
				sqliteBase.CreateFunction(name, functionAttribute.Arguments, needCollSeq, function._InvokeFunc, function._StepFunc, function._FinalFunc);
				return;
			}
			sqliteBase.CreateCollation(name, function._CompareFunc, function._CompareFunc16);
		}

		// Token: 0x0400016B RID: 363
		internal global::System.Data.SQLite.SQLiteBase _base;

		// Token: 0x0400016C RID: 364
		private global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Data.SQLite.SQLiteFunction.AggregateData> _contextDataList;

		// Token: 0x0400016D RID: 365
		private global::System.Data.SQLite.SQLiteConnectionFlags _flags;

		// Token: 0x0400016E RID: 366
		private global::System.Data.SQLite.SQLiteCallback _InvokeFunc;

		// Token: 0x0400016F RID: 367
		private global::System.Data.SQLite.SQLiteCallback _StepFunc;

		// Token: 0x04000170 RID: 368
		private global::System.Data.SQLite.SQLiteFinalCallback _FinalFunc;

		// Token: 0x04000171 RID: 369
		private global::System.Data.SQLite.SQLiteCollation _CompareFunc;

		// Token: 0x04000172 RID: 370
		private global::System.Data.SQLite.SQLiteCollation _CompareFunc16;

		// Token: 0x04000173 RID: 371
		internal global::System.IntPtr _context;

		// Token: 0x04000174 RID: 372
		private static global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunctionAttribute> _registeredFunctions = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteFunctionAttribute>();

		// Token: 0x04000175 RID: 373
		private bool disposed;

		// Token: 0x0200003C RID: 60
		private class AggregateData
		{
			// Token: 0x04000176 RID: 374
			internal int _count = 1;

			// Token: 0x04000177 RID: 375
			internal object _data;
		}
	}
}
