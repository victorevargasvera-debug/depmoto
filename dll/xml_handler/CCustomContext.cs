using System;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using custom_exception;

namespace xml_handler
{
	// Token: 0x02000003 RID: 3
	public class CCustomContext : global::System.Xml.Xsl.XsltContext
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public CCustomContext()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public CCustomContext(global::System.Xml.NameTable table) : base(table)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002144 File Offset: 0x00000344
		public override bool Whitespace
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return true;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002180 File Offset: 0x00000380
		public override int CompareDocument(string baseUri, string nextbaseUri)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021BC File Offset: 0x000003BC
		public override bool PreserveWhitespace(global::System.Xml.XPath.XPathNavigator node)
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			return true;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021F8 File Offset: 0x000003F8
		public override global::System.Xml.Xsl.IXsltContextFunction ResolveFunction(string prefix, string name, global::System.Xml.XPath.XPathResultType[] ArgTypes)
		{
			global::System.Xml.Xsl.IXsltContextFunction result;
			for (;;)
			{
				result = null;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (name == "equals")
						{
							num = 3;
							continue;
						}
						goto IL_63;
					case 1:
						return result;
					case 2:
						if (!(this.LookupNamespace(prefix) == "http://cps.local/"))
						{
							goto IL_63;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							if (false)
							{
							}
							num = 4;
							continue;
						}
						break;
					case 3:
						goto IL_7D;
					case 4:
						num = 0;
						continue;
					case 5:
						return result;
					}
					break;
					IL_63:
					result = new global::xml_handler.CCustomContext.b();
					num = 5;
					continue;
					IL_7D:
					result = new global::xml_handler.CCustomContext.a();
					num = 1;
				}
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022C4 File Offset: 0x000004C4
		public override global::System.Xml.Xsl.IXsltContextVariable ResolveVariable(string prefix, string name)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002300 File Offset: 0x00000500
		protected static string GetStringFromInvokeArgument(object arg)
		{
			switch (0)
			{
			default:
			{
				int num = 4;
				string result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
						{
							if (false)
							{
							}
							global::System.Xml.XPath.XPathNodeIterator xpathNodeIterator;
							global::System.Xml.XPath.XPathNavigator xpathNavigator = xpathNodeIterator.Current;
							result = xpathNavigator.ToString();
							num = 6;
							continue;
						}
						}
						break;
					case 1:
						if (arg is global::System.Xml.XPath.XPathNodeIterator)
						{
							num = 3;
							continue;
						}
						goto IL_C7;
					case 2:
					{
						global::System.Xml.XPath.XPathNodeIterator xpathNodeIterator;
						if (xpathNodeIterator.MoveNext())
						{
							num = 0;
							continue;
						}
						goto IL_56;
					}
					case 3:
					{
						if (true)
						{
						}
						global::System.Xml.XPath.XPathNodeIterator xpathNodeIterator = arg as global::System.Xml.XPath.XPathNodeIterator;
						num = 2;
						continue;
					}
					case 5:
						goto IL_C2;
					case 6:
						return result;
					case 7:
						result = (arg as string);
						num = 5;
						continue;
					}
					if (arg is string)
					{
						num = 7;
					}
					else
					{
						num = 1;
					}
				}
				IL_56:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2688U, "CPTags", "GetStringFromInvokeArgument", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_C2:
				return result;
				IL_C7:
				global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2688U, "CPTags", "GetStringFromInvokeArgument", global::System.Environment.StackTrace.ToString());
				throw ex2;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		public const string CUSTOM_NAMESPACE = "http://cps.local/";

		// Token: 0x04000004 RID: 4
		protected const string EQUALS_FUNCTION = "equals";

		// Token: 0x04000005 RID: 5
		protected const string CONTAINS_FUNCTION = "contains";

		// Token: 0x04000006 RID: 6
		protected const int MAX_ARGS = 2;

		// Token: 0x04000007 RID: 7
		protected const int MIN_ARGS = 2;

		// Token: 0x04000008 RID: 8
		protected const string CP_TAGS = "CPTags";

		// Token: 0x04000009 RID: 9
		protected const string CUSTOM_CONTEXT = "CustomContext";

		// Token: 0x02000004 RID: 4
		private class a : global::System.Xml.Xsl.IXsltContextFunction
		{
			// Token: 0x0600000C RID: 12 RVA: 0x00002458 File Offset: 0x00000658
			public global::System.Xml.XPath.XPathResultType[] c()
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.c;
			}

			// Token: 0x0600000D RID: 13 RVA: 0x0000249C File Offset: 0x0000069C
			public object Invoke(global::System.Xml.Xsl.XsltContext A_0, object[] A_1, global::System.Xml.XPath.XPathNavigator A_2)
			{
				if (A_1.Length == 2)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						if (false)
						{
						}
						string stringFromInvokeArgument = global::xml_handler.CCustomContext.GetStringFromInvokeArgument(A_1[0]);
						string stringFromInvokeArgument2 = global::xml_handler.CCustomContext.GetStringFromInvokeArgument(A_1[1]);
						bool flag = string.Equals(stringFromInvokeArgument, stringFromInvokeArgument2, global::System.StringComparison.InvariantCultureIgnoreCase);
						return flag;
					}
					}
				}
				if (true)
				{
				}
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2688U, "CPTags", "Invoke", global::System.Environment.StackTrace.ToString());
				throw ex;
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002524 File Offset: 0x00000724
			public int b()
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return 2;
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002560 File Offset: 0x00000760
			public int d()
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return 2;
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0000259C File Offset: 0x0000079C
			public global::System.Xml.XPath.XPathResultType a()
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::System.Xml.XPath.XPathResultType.Boolean;
			}

			// Token: 0x0400000A RID: 10
			public const string a = "http://cps.local/";

			// Token: 0x0400000B RID: 11
			public const string b = "equals";

			// Token: 0x0400000C RID: 12
			private global::System.Xml.XPath.XPathResultType[] c = new global::System.Xml.XPath.XPathResultType[]
			{
				global::System.Xml.XPath.XPathResultType.Any,
				global::System.Xml.XPath.XPathResultType.Any
			};
		}

		// Token: 0x02000005 RID: 5
		private class b : global::System.Xml.Xsl.IXsltContextFunction
		{
			// Token: 0x06000012 RID: 18 RVA: 0x00002604 File Offset: 0x00000804
			public global::System.Xml.XPath.XPathResultType[] c()
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.c;
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00002648 File Offset: 0x00000848
			public object Invoke(global::System.Xml.Xsl.XsltContext A_0, object[] A_1, global::System.Xml.XPath.XPathNavigator A_2)
			{
				while (A_1.Length != 2)
				{
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					}
					if (false)
					{
					}
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2688U, "CPTags", "Invoke", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				string stringFromInvokeArgument = global::xml_handler.CCustomContext.GetStringFromInvokeArgument(A_1[0]);
				string stringFromInvokeArgument2 = global::xml_handler.CCustomContext.GetStringFromInvokeArgument(A_1[1]);
				bool flag = stringFromInvokeArgument.IndexOf(stringFromInvokeArgument2, global::System.StringComparison.OrdinalIgnoreCase) >= 0;
				return flag;
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000026D4 File Offset: 0x000008D4
			public int b()
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return 2;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002710 File Offset: 0x00000910
			public int d()
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return 2;
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0000274C File Offset: 0x0000094C
			public global::System.Xml.XPath.XPathResultType a()
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return global::System.Xml.XPath.XPathResultType.Boolean;
			}

			// Token: 0x0400000D RID: 13
			public const string a = "http://cps.local/";

			// Token: 0x0400000E RID: 14
			public const string b = "contains";

			// Token: 0x0400000F RID: 15
			private global::System.Xml.XPath.XPathResultType[] c = new global::System.Xml.XPath.XPathResultType[]
			{
				global::System.Xml.XPath.XPathResultType.Any,
				global::System.Xml.XPath.XPathResultType.Any
			};
		}
	}
}
