using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.InteropServices.Guid("3050F3DB-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLCurrentStyle
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600091D RID: 2333
		[global::System.Runtime.InteropServices.DispId(-2147413022)]
		string position { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413022)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600091E RID: 2334
		[global::System.Runtime.InteropServices.DispId(-2147413042)]
		string styleFloat { [global::System.Runtime.InteropServices.DispId(-2147413042)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600091F RID: 2335
		[global::System.Runtime.InteropServices.DispId(-2147413110)]
		object color { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413110)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000920 RID: 2336
		[global::System.Runtime.InteropServices.DispId(-501)]
		object backgroundColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000921 RID: 2337
		[global::System.Runtime.InteropServices.DispId(-2147413094)]
		string fontFamily { [global::System.Runtime.InteropServices.DispId(-2147413094)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000922 RID: 2338
		[global::System.Runtime.InteropServices.DispId(-2147413088)]
		string fontStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413088)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000923 RID: 2339
		[global::System.Runtime.InteropServices.DispId(-2147413087)]
		string fontVariant { [global::System.Runtime.InteropServices.DispId(-2147413087)] [global::System.Runtime.InteropServices.TypeLibFunc(84)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000924 RID: 2340
		[global::System.Runtime.InteropServices.DispId(-2147413085)]
		object fontWeight { [global::System.Runtime.InteropServices.DispId(-2147413085)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000925 RID: 2341
		[global::System.Runtime.InteropServices.DispId(-2147413093)]
		object fontSize { [global::System.Runtime.InteropServices.DispId(-2147413093)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000926 RID: 2342
		[global::System.Runtime.InteropServices.DispId(-2147413111)]
		string backgroundImage { [global::System.Runtime.InteropServices.DispId(-2147413111)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000927 RID: 2343
		[global::System.Runtime.InteropServices.DispId(-2147413079)]
		object backgroundPositionX { [global::System.Runtime.InteropServices.DispId(-2147413079)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000928 RID: 2344
		[global::System.Runtime.InteropServices.DispId(-2147413078)]
		object backgroundPositionY { [global::System.Runtime.InteropServices.DispId(-2147413078)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000929 RID: 2345
		[global::System.Runtime.InteropServices.DispId(-2147413068)]
		string backgroundRepeat { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413068)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600092A RID: 2346
		[global::System.Runtime.InteropServices.DispId(-2147413054)]
		object borderLeftColor { [global::System.Runtime.InteropServices.DispId(-2147413054)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600092B RID: 2347
		[global::System.Runtime.InteropServices.DispId(-2147413057)]
		object borderTopColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413057)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600092C RID: 2348
		[global::System.Runtime.InteropServices.DispId(-2147413056)]
		object borderRightColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600092D RID: 2349
		[global::System.Runtime.InteropServices.DispId(-2147413055)]
		object borderBottomColor { [global::System.Runtime.InteropServices.DispId(-2147413055)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600092E RID: 2350
		[global::System.Runtime.InteropServices.DispId(-2147413047)]
		string borderTopStyle { [global::System.Runtime.InteropServices.DispId(-2147413047)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600092F RID: 2351
		[global::System.Runtime.InteropServices.DispId(-2147413046)]
		string borderRightStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413046)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000930 RID: 2352
		[global::System.Runtime.InteropServices.DispId(-2147413045)]
		string borderBottomStyle { [global::System.Runtime.InteropServices.DispId(-2147413045)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000931 RID: 2353
		[global::System.Runtime.InteropServices.DispId(-2147413044)]
		string borderLeftStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000932 RID: 2354
		[global::System.Runtime.InteropServices.DispId(-2147413052)]
		object borderTopWidth { [global::System.Runtime.InteropServices.DispId(-2147413052)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000933 RID: 2355
		[global::System.Runtime.InteropServices.DispId(-2147413051)]
		object borderRightWidth { [global::System.Runtime.InteropServices.DispId(-2147413051)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000934 RID: 2356
		[global::System.Runtime.InteropServices.DispId(-2147413050)]
		object borderBottomWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000935 RID: 2357
		[global::System.Runtime.InteropServices.DispId(-2147413049)]
		object borderLeftWidth { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000936 RID: 2358
		[global::System.Runtime.InteropServices.DispId(-2147418109)]
		object left { [global::System.Runtime.InteropServices.DispId(-2147418109)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000937 RID: 2359
		[global::System.Runtime.InteropServices.DispId(-2147418108)]
		object top { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000938 RID: 2360
		[global::System.Runtime.InteropServices.DispId(-2147418107)]
		object width { [global::System.Runtime.InteropServices.DispId(-2147418107)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000939 RID: 2361
		[global::System.Runtime.InteropServices.DispId(-2147418106)]
		object height { [global::System.Runtime.InteropServices.DispId(-2147418106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600093A RID: 2362
		[global::System.Runtime.InteropServices.DispId(-2147413097)]
		object paddingLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413097)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600093B RID: 2363
		[global::System.Runtime.InteropServices.DispId(-2147413100)]
		object paddingTop { [global::System.Runtime.InteropServices.DispId(-2147413100)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600093C RID: 2364
		[global::System.Runtime.InteropServices.DispId(-2147413099)]
		object paddingRight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413099)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600093D RID: 2365
		[global::System.Runtime.InteropServices.DispId(-2147413098)]
		object paddingBottom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413098)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600093E RID: 2366
		[global::System.Runtime.InteropServices.DispId(-2147418040)]
		string textAlign { [global::System.Runtime.InteropServices.DispId(-2147418040)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600093F RID: 2367
		[global::System.Runtime.InteropServices.DispId(-2147413077)]
		string textDecoration { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413077)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000940 RID: 2368
		[global::System.Runtime.InteropServices.DispId(-2147413041)]
		string display { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413041)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000941 RID: 2369
		[global::System.Runtime.InteropServices.DispId(-2147413032)]
		string visibility { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413032)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000942 RID: 2370
		[global::System.Runtime.InteropServices.DispId(-2147413021)]
		object zIndex { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413021)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000943 RID: 2371
		[global::System.Runtime.InteropServices.DispId(-2147413104)]
		object letterSpacing { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000944 RID: 2372
		[global::System.Runtime.InteropServices.DispId(-2147413106)]
		object lineHeight { [global::System.Runtime.InteropServices.DispId(-2147413106)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000945 RID: 2373
		[global::System.Runtime.InteropServices.DispId(-2147413105)]
		object textIndent { [global::System.Runtime.InteropServices.DispId(-2147413105)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000946 RID: 2374
		[global::System.Runtime.InteropServices.DispId(-2147413064)]
		object verticalAlign { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000947 RID: 2375
		[global::System.Runtime.InteropServices.DispId(-2147413067)]
		string backgroundAttachment { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000948 RID: 2376
		[global::System.Runtime.InteropServices.DispId(-2147413075)]
		object marginTop { [global::System.Runtime.InteropServices.DispId(-2147413075)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000949 RID: 2377
		[global::System.Runtime.InteropServices.DispId(-2147413074)]
		object marginRight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413074)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600094A RID: 2378
		[global::System.Runtime.InteropServices.DispId(-2147413073)]
		object marginBottom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413073)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600094B RID: 2379
		[global::System.Runtime.InteropServices.DispId(-2147413072)]
		object marginLeft { [global::System.Runtime.InteropServices.DispId(-2147413072)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600094C RID: 2380
		[global::System.Runtime.InteropServices.DispId(-2147413096)]
		string clear { [global::System.Runtime.InteropServices.DispId(-2147413096)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600094D RID: 2381
		[global::System.Runtime.InteropServices.DispId(-2147413040)]
		string listStyleType { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600094E RID: 2382
		[global::System.Runtime.InteropServices.DispId(-2147413039)]
		string listStylePosition { [global::System.Runtime.InteropServices.DispId(-2147413039)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600094F RID: 2383
		[global::System.Runtime.InteropServices.DispId(-2147413038)]
		string listStyleImage { [global::System.Runtime.InteropServices.DispId(-2147413038)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000950 RID: 2384
		[global::System.Runtime.InteropServices.DispId(-2147413019)]
		object clipTop { [global::System.Runtime.InteropServices.DispId(-2147413019)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000951 RID: 2385
		[global::System.Runtime.InteropServices.DispId(-2147413018)]
		object clipRight { [global::System.Runtime.InteropServices.DispId(-2147413018)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000952 RID: 2386
		[global::System.Runtime.InteropServices.DispId(-2147413017)]
		object clipBottom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413017)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000953 RID: 2387
		[global::System.Runtime.InteropServices.DispId(-2147413016)]
		object clipLeft { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413016)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000954 RID: 2388
		[global::System.Runtime.InteropServices.DispId(-2147413102)]
		string overflow { [global::System.Runtime.InteropServices.DispId(-2147413102)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000955 RID: 2389
		[global::System.Runtime.InteropServices.DispId(-2147413035)]
		string pageBreakBefore { [global::System.Runtime.InteropServices.DispId(-2147413035)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000956 RID: 2390
		[global::System.Runtime.InteropServices.DispId(-2147413034)]
		string pageBreakAfter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000957 RID: 2391
		[global::System.Runtime.InteropServices.DispId(-2147413010)]
		string cursor { [global::System.Runtime.InteropServices.DispId(-2147413010)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000958 RID: 2392
		[global::System.Runtime.InteropServices.DispId(-2147413014)]
		string tableLayout { [global::System.Runtime.InteropServices.DispId(-2147413014)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000959 RID: 2393
		[global::System.Runtime.InteropServices.DispId(-2147413028)]
		string borderCollapse { [global::System.Runtime.InteropServices.DispId(-2147413028)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600095A RID: 2394
		[global::System.Runtime.InteropServices.DispId(-2147412993)]
		string direction { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412993)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600095B RID: 2395
		[global::System.Runtime.InteropServices.DispId(-2147412997)]
		string behavior { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412997)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x0600095C RID: 2396
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600095D RID: 2397
		[global::System.Runtime.InteropServices.DispId(-2147412994)]
		string unicodeBidi { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412994)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600095E RID: 2398
		[global::System.Runtime.InteropServices.DispId(-2147418035)]
		object right { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418035)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600095F RID: 2399
		[global::System.Runtime.InteropServices.DispId(-2147418034)]
		object bottom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147418034)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000960 RID: 2400
		[global::System.Runtime.InteropServices.DispId(-2147412992)]
		string imeMode { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412992)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000961 RID: 2401
		[global::System.Runtime.InteropServices.DispId(-2147412991)]
		string rubyAlign { [global::System.Runtime.InteropServices.DispId(-2147412991)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000962 RID: 2402
		[global::System.Runtime.InteropServices.DispId(-2147412990)]
		string rubyPosition { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412990)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000963 RID: 2403
		[global::System.Runtime.InteropServices.DispId(-2147412989)]
		string rubyOverhang { [global::System.Runtime.InteropServices.DispId(-2147412989)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000964 RID: 2404
		[global::System.Runtime.InteropServices.DispId(-2147412980)]
		string textAutospace { [global::System.Runtime.InteropServices.DispId(-2147412980)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000965 RID: 2405
		[global::System.Runtime.InteropServices.DispId(-2147412979)]
		string lineBreak { [global::System.Runtime.InteropServices.DispId(-2147412979)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000966 RID: 2406
		[global::System.Runtime.InteropServices.DispId(-2147412978)]
		string wordBreak { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412978)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000967 RID: 2407
		[global::System.Runtime.InteropServices.DispId(-2147412977)]
		string textJustify { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412977)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000968 RID: 2408
		[global::System.Runtime.InteropServices.DispId(-2147412976)]
		string textJustifyTrim { [global::System.Runtime.InteropServices.DispId(-2147412976)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000969 RID: 2409
		[global::System.Runtime.InteropServices.DispId(-2147412975)]
		object textKashida { [global::System.Runtime.InteropServices.DispId(-2147412975)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600096A RID: 2410
		[global::System.Runtime.InteropServices.DispId(-2147412995)]
		string blockDirection { [global::System.Runtime.InteropServices.DispId(-2147412995)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600096B RID: 2411
		[global::System.Runtime.InteropServices.DispId(-2147412985)]
		object layoutGridChar { [global::System.Runtime.InteropServices.DispId(-2147412985)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600096C RID: 2412
		[global::System.Runtime.InteropServices.DispId(-2147412984)]
		object layoutGridLine { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412984)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600096D RID: 2413
		[global::System.Runtime.InteropServices.DispId(-2147412983)]
		string layoutGridMode { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412983)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600096E RID: 2414
		[global::System.Runtime.InteropServices.DispId(-2147412982)]
		string layoutGridType { [global::System.Runtime.InteropServices.DispId(-2147412982)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600096F RID: 2415
		[global::System.Runtime.InteropServices.DispId(-2147413048)]
		string borderStyle { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000970 RID: 2416
		[global::System.Runtime.InteropServices.DispId(-2147413058)]
		string borderColor { [global::System.Runtime.InteropServices.DispId(-2147413058)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000971 RID: 2417
		[global::System.Runtime.InteropServices.DispId(-2147413053)]
		string borderWidth { [global::System.Runtime.InteropServices.DispId(-2147413053)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000972 RID: 2418
		[global::System.Runtime.InteropServices.DispId(-2147413101)]
		string padding { [global::System.Runtime.InteropServices.DispId(-2147413101)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000973 RID: 2419
		[global::System.Runtime.InteropServices.DispId(-2147413076)]
		string margin { [global::System.Runtime.InteropServices.DispId(-2147413076)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000974 RID: 2420
		[global::System.Runtime.InteropServices.DispId(-2147412965)]
		string accelerator { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412965)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000975 RID: 2421
		[global::System.Runtime.InteropServices.DispId(-2147412973)]
		string overflowX { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412973)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000976 RID: 2422
		[global::System.Runtime.InteropServices.DispId(-2147412972)]
		string overflowY { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412972)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000977 RID: 2423
		[global::System.Runtime.InteropServices.DispId(-2147413108)]
		string textTransform { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413108)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
