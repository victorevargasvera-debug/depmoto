using System;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001F RID: 31
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Method, AllowMultiple = true)]
	internal sealed class InitializerAttribute : global::System.Attribute
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00005BF1 File Offset: 0x00003DF1
		private InitializerAttribute()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005BF9 File Offset: 0x00003DF9
		public InitializerAttribute(global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType, global::Motorola.Common.Communication.CommonUtil.ProductFamily family, global::Motorola.Common.Communication.CommonUtil.RadioStorage storage, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			this.ConnectionType = connectionType;
			this.Family = family;
			this.Operation = operation;
			this.Storage = storage;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005C1E File Offset: 0x00003E1E
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00005C26 File Offset: 0x00003E26
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnectionType { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005C2F File Offset: 0x00003E2F
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005C37 File Offset: 0x00003E37
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005C40 File Offset: 0x00003E40
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005C48 File Offset: 0x00003E48
		public global::Motorola.Common.Communication.CommonUtil.RadioOperation Operation { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005C51 File Offset: 0x00003E51
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005C59 File Offset: 0x00003E59
		public global::Motorola.Common.Communication.CommonUtil.RadioStorage Storage { get; set; }

		// Token: 0x060000F9 RID: 249 RVA: 0x00005C64 File Offset: 0x00003E64
		public override bool Match(object obj)
		{
			global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute initializerAttribute = obj as global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute;
			return initializerAttribute != null && (initializerAttribute.ConnectionType & this.ConnectionType) == this.ConnectionType && (initializerAttribute.Family & this.Family) == this.Family && (initializerAttribute.Operation & this.Operation) == this.Operation && (initializerAttribute.Storage & this.Storage) == this.Storage;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005CDC File Offset: 0x00003EDC
		public static global::System.Type SearchSingleMatchedClass(global::System.Type baseType, global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch)
		{
			global::System.Type type = null;
			foreach (global::System.Type type2 in global::System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
			{
				if (baseType.IsAssignableFrom(type2))
				{
					global::System.Attribute[] customAttributes = global::System.Attribute.GetCustomAttributes(type2, typeof(global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute));
					foreach (global::System.Attribute obj in customAttributes)
					{
						if (attrToMatch.Match(obj))
						{
							if (!(type == null))
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerTooManyMatchedInitializer);
							}
							type = type2;
						}
					}
				}
			}
			if (type == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNoMatchedInitializer);
			}
			return type;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005D7C File Offset: 0x00003F7C
		private static global::System.Reflection.MethodInfo SearchSingleMatchedMethod(global::System.Type typeToSearch, global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch)
		{
			global::System.Reflection.MemberInfo[] array = typeToSearch.FindMembers(global::System.Reflection.MemberTypes.Method, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic, global::System.Type.FilterName, "*");
			global::System.Reflection.MemberInfo memberInfo = null;
			foreach (global::System.Reflection.MemberInfo memberInfo2 in array)
			{
				global::System.Attribute[] customAttributes = global::System.Attribute.GetCustomAttributes(memberInfo2, typeof(global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute));
				foreach (global::System.Attribute obj in customAttributes)
				{
					if (attrToMatch.Match(obj))
					{
						if (!(memberInfo == null))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerTooManyMatchedInitializer);
						}
						memberInfo = memberInfo2;
					}
				}
			}
			global::System.Reflection.MethodInfo methodInfo = memberInfo as global::System.Reflection.MethodInfo;
			if (methodInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNoMatchedInitializer);
			}
			return methodInfo;
		}
	}
}
