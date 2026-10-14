using System;
using System.Collections;
using System.Globalization;
using custom_exception;

namespace flex_licensing
{
	// Token: 0x02000218 RID: 536
	public class CLicenseManager
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00005A0C File Offset: 0x00004E0C
		public unsafe CLicenseManager(global::System.Collections.ArrayList featureList, string version)
		{
			global::flex_licensing.CFlexLicenseManager* ptr = global::<Module>.@new(664U);
			global::flex_licensing.CFlexLicenseManager* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : global::<Module>.flex_licensing.CFlexLicenseManager.{ctor}(ptr));
			}
			catch
			{
				global::<Module>.delete((void*)ptr);
				throw;
			}
			this.baseClass = ptr2;
			if (null != this.baseClass)
			{
				ref double result = 0;
				if (null == featureList || featureList.Count <= 0 || null == version || !double.TryParse(version, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out result))
				{
					global::custom_exception.CCustomException ex = this.CreateException(-602, new string((sbyte*)(&global::<Module>.?A0xaef22b49.unnamed-global-44)), global::System.Environment.StackTrace);
					throw ex;
				}
				this.Features = featureList;
				this.SetVersion(version);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000587C File Offset: 0x00004C7C
		public unsafe CLicenseManager(string feature, string version)
		{
			double num = 0.0;
			if (null != feature && null != version && double.TryParse(version, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				global::flex_licensing.CFlexLicenseManager* ptr = global::<Module>.@new(664U);
				global::flex_licensing.CFlexLicenseManager* ptr2;
				try
				{
					ptr2 = ((ptr == null) ? null : global::<Module>.flex_licensing.CFlexLicenseManager.{ctor}(ptr));
				}
				catch
				{
					global::<Module>.delete((void*)ptr);
					throw;
				}
				this.baseClass = ptr2;
				if (null != this.baseClass)
				{
					this.AddFeature(feature);
					this.SetVersion(version);
				}
				return;
			}
			global::custom_exception.CCustomException ex = this.CreateException(-602, new string((sbyte*)(&global::<Module>.?A0xaef22b49.unnamed-global-43)), global::System.Environment.StackTrace);
			throw ex;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000056B0 File Offset: 0x00004AB0
		protected unsafe override void Finalize()
		{
			global::flex_licensing.CFlexLicenseManager* ptr = this.baseClass;
			if (ptr != null)
			{
				void* ptr2 = calli(System.Void* modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.UInt32), ptr, 1, *(*(int*)ptr));
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00005934 File Offset: 0x00004D34
		public unsafe void ValidateFeature(int featureID)
		{
			int num = global::<Module>.flex_licensing.CFlexLicenseManager.ValidateFeature(this.baseClass, featureID);
			if (num != 0)
			{
				global::custom_exception.CCustomException ex = this.CreateException(num, new string((sbyte*)(&global::<Module>.?A0xaef22b49.unnamed-global-45)), global::System.Environment.StackTrace);
				throw ex;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000056D8 File Offset: 0x00004AD8
		public unsafe void SetVersion(string version)
		{
			fixed (ushort* ptr = global::<Module>.PtrToStringChars(version))
			{
				uint num = global::<Module>.wcslen(ptr);
				uint num2 = num;
				sbyte* ptr2 = global::<Module>.new[](num2 + 1U);
				global::<Module>.WideCharToMultiByte(0U, 0, ptr, (int)(num2 + 1U), ptr2, (int)(num2 + 1U), null, null);
				global::<Module>.flex_licensing.CFlexLicenseManager.SetVersion(this.baseClass, ptr2);
				global::<Module>.delete[]((void*)ptr2);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000573C File Offset: 0x00004B3C
		public unsafe void AddFeature(string feature)
		{
			fixed (ushort* ptr = global::<Module>.PtrToStringChars(feature))
			{
				uint num = global::<Module>.wcslen(ptr);
				uint num2 = num;
				sbyte* ptr2 = global::<Module>.new[](num2 + 1U);
				global::<Module>.WideCharToMultiByte(0U, 0, ptr, (int)(num2 + 1U), ptr2, (int)(num2 + 1U), null, null);
				global::<Module>.flex_licensing.CFlexLicenseManager.AddFeature(this.baseClass, ptr2);
				global::<Module>.delete[]((void*)ptr2);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00005724 File Offset: 0x00004B24
		public void ClearFeatures()
		{
			global::<Module>.flex_licensing.CFlexLicenseManager.ClearFeatures(this.baseClass);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00005788 File Offset: 0x00004B88
		public unsafe void SetLicenseDir(string licenseDir)
		{
			fixed (ushort* ptr = global::<Module>.PtrToStringChars(licenseDir))
			{
				uint num = global::<Module>.wcslen(ptr);
				uint num2 = num;
				sbyte* ptr2 = global::<Module>.new[](num2 + 1U);
				global::<Module>.WideCharToMultiByte(0U, 0, ptr, (int)(num2 + 1U), ptr2, (int)(num2 + 1U), null, null);
				global::<Module>.flex_licensing.CFlexLicenseManager.SetLicenseDir(this.baseClass, ptr2);
				global::<Module>.delete[]((void*)ptr2);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000059A0 File Offset: 0x00004DA0
		public unsafe void GetAuthCode(ref string outbuf, ref int out_size)
		{
			outbuf = "";
			int num = 0;
			fixed (char* ptr = global::<Module>.PtrToStringChars(outbuf))
			{
				sbyte* ptr2 = global::<Module>.new[](255U);
				int num2 = global::<Module>.flex_licensing.CFlexLicenseManager.GetAuthCode(this.baseClass, ptr2, &num);
				if (num != 0)
				{
					outbuf = new string((sbyte*)ptr2);
					out_size = num;
				}
				global::<Module>.delete[]((void*)ptr2);
				if (num2 != 0)
				{
					global::custom_exception.CCustomException ex = this.CreateException(num2, new string((sbyte*)(&global::<Module>.?A0xaef22b49.unnamed-global-46)), global::System.Environment.StackTrace);
					throw ex;
				}
				return;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00005AC4 File Offset: 0x00004EC4
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000596C File Offset: 0x00004D6C
		public global::System.Collections.ArrayList Features
		{
			get
			{
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				for (uint num = 0U; num < global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.size(this.baseClass + 4 / sizeof(global::flex_licensing.CFlexLicenseManager)); num += 1U)
				{
					string value = new string(global::<Module>.std.basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>.c_str(global::<Module>.std.vector<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>,std::allocator<std::basic_string<char,std::char_traits<char>,std::allocator<char>\u0020>\u0020>\u0020>.[](this.baseClass + 4 / sizeof(global::flex_licensing.CFlexLicenseManager), num)));
					arrayList.Add(value);
				}
				return arrayList;
			}
			set
			{
				for (int i = 0; i < value.Count; i++)
				{
					string feature = value[i];
					this.AddFeature(feature);
				}
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000057D4 File Offset: 0x00004BD4
		public int GetErrorCode(int errNo)
		{
			int result = errNo;
			if (errNo != 0)
			{
				global::System.Array values = global::System.Enum.GetValues(typeof(global::flex_licensing.FLEXLM_ERRORS));
				global::System.Array.Reverse(values);
				for (int i = 0; i < values.Length; i++)
				{
					object value = values.GetValue(i);
					int num = (int)value;
					if (errNo == num)
					{
						result = i + 3281;
					}
				}
			}
			return result;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00005838 File Offset: 0x00004C38
		public global::custom_exception.CCustomException CreateException(int errorID, string functionName, string trace)
		{
			int errorCode = this.GetErrorCode(errorID);
			string class_NAME = global::flex_licensing.CLicenseManager.CLASS_NAME;
			string.Concat<char>(global::flex_licensing.CLicenseManager.COMMA_SPACE);
			string.Concat<char>(functionName);
			return new global::custom_exception.CCustomException((uint)errorCode, global::flex_licensing.CLicenseManager.COMP_SOURCE, class_NAME, trace);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005B20 File Offset: 0x00004F20
		public void {dtor}()
		{
			global::System.GC.SuppressFinalize(this);
			this.Finalize();
		}

		// Token: 0x0400029E RID: 670
		private unsafe global::flex_licensing.CFlexLicenseManager* baseClass;

		// Token: 0x0400029F RID: 671
		private static string CLASS_NAME = new string((sbyte*)(&global::<Module>.??_C@_0BA@EPIGMDCL@CLicenseManager?$AA@));

		// Token: 0x040002A0 RID: 672
		private static string COMP_SOURCE = new string((sbyte*)(&global::<Module>.??_C@_0P@ONCCLJAL@Flex_Licensing?$AA@));

		// Token: 0x040002A1 RID: 673
		private static string COMMA_SPACE = new string((sbyte*)(&global::<Module>.??_C@_02KEGNLNML@?0?5?$AA@));
	}
}
