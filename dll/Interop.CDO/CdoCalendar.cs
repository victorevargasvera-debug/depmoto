using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200001D RID: 29
	public abstract class CdoCalendar
	{
		// Token: 0x040000CF RID: 207
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAllDayEvent = "urn:schemas:calendar:alldayevent";

		// Token: 0x040000D0 RID: 208
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAttendeeRole = "urn:schemas:calendar:attendeerole";

		// Token: 0x040000D1 RID: 209
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAttendeeStatus = "urn:schemas:calendar:attendeestatus";

		// Token: 0x040000D2 RID: 210
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBusyStatus = "urn:schemas:calendar:busystatus";

		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCalendarLastModified = "urn:schemas:calendar:lastmodified";

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCalendarUID = "urn:schemas:calendar:uid";

		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContact = "urn:schemas:calendar:contact";

		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoContactURL = "urn:schemas:calendar:contacturl";

		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCreated = "urn:schemas:calendar:created";

		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDelegatedFrom = "urn:schemas:calendar:delegated-from";

		// Token: 0x040000D9 RID: 217
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDelegatedTo = "urn:schemas:calendar:delegated-to";

		// Token: 0x040000DA RID: 218
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDescriptionURL = "urn:schemas:calendar:descriptionurl";

		// Token: 0x040000DB RID: 219
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDTEnd = "urn:schemas:calendar:dtend";

		// Token: 0x040000DC RID: 220
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDTStamp = "urn:schemas:calendar:dtstamp";

		// Token: 0x040000DD RID: 221
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDTStart = "urn:schemas:calendar:dtstart";

		// Token: 0x040000DE RID: 222
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDuration = "urn:schemas:calendar:duration";

		// Token: 0x040000DF RID: 223
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoExDate = "urn:schemas:calendar:exdate";

		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoExRule = "urn:schemas:calendar:exrule";

		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFburl = "urn:schemas:calendar:fburl";

		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGEOLatitude = "urn:schemas:calendar:geolatitude";

		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGEOLongitude = "urn:schemas:calendar:geolongitude";

		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoInstanceType = "urn:schemas:calendar:instancetype";

		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoIsOrganizer = "urn:schemas:calendar:isorganizer";

		// Token: 0x040000E6 RID: 230
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLastModifiedTime = "urn:schemas:calendar:lastmodifiedtime";

		// Token: 0x040000E7 RID: 231
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLocation = "urn:schemas:calendar:location";

		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLocationURL = "urn:schemas:calendar:locationurl";

		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMeetingStatus = "urn:schemas:calendar:meetingstatus";

		// Token: 0x040000EA RID: 234
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMethod = "urn:schemas:calendar:method";

		// Token: 0x040000EB RID: 235
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoProdId = "urn:schemas:calendar:prodid";

		// Token: 0x040000EC RID: 236
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRDate = "urn:schemas:calendar:rdate";

		// Token: 0x040000ED RID: 237
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRecurrenceId = "urn:schemas:calendar:recurrenceid";

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRecurrenceIdRange = "urn:schemas:calendar:recurrenceidrange";

		// Token: 0x040000EF RID: 239
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReminderOffset = "urn:schemas:calendar:reminderoffset";

		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoReplyTime = "urn:schemas:calendar:replytime";

		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoResources = "urn:schemas:calendar:resources";

		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoResponseRequested = "urn:schemas:calendar:responserequested";

		// Token: 0x040000F3 RID: 243
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRRule = "urn:schemas:calendar:rrule";

		// Token: 0x040000F4 RID: 244
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRSVP = "urn:schemas:calendar:rsvp";

		// Token: 0x040000F5 RID: 245
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSentBy = "urn:schemas:calendar:sent-by";

		// Token: 0x040000F6 RID: 246
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSequence = "urn:schemas:calendar:sequence";

		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTimeZoneIDURN = "urn:schemas:calendar:timezoneid";

		// Token: 0x040000F8 RID: 248
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTimeZoneURN = "urn:schemas:calendar:timezone";

		// Token: 0x040000F9 RID: 249
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTransparency = "urn:schemas:calendar:transparent";

		// Token: 0x040000FA RID: 250
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoVersion = "urn:schemas:calendar:version";
	}
}
