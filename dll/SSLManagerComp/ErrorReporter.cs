using System;

namespace SSLMangrComp
{
	// Token: 0x02000026 RID: 38
	public sealed class ErrorReporter
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00006975 File Offset: 0x00004B75
		private ErrorReporter()
		{
			this.ResetErrorReport();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006983 File Offset: 0x00004B83
		public static global::SSLMangrComp.ErrorReporter Instance
		{
			get
			{
				return global::SSLMangrComp.ErrorReporter.ERInstance;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000698A File Offset: 0x00004B8A
		public void SetErrorReportCategory(global::SSLMangrComp.ErrorCategory ec)
		{
			this.m_ErrorReport.ErrCat = (uint)ec;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006998 File Offset: 0x00004B98
		public void SetErrorReportId(global::SSLMangrComp.ErrorID ei)
		{
			this.m_ErrorReport.ErrorID = (uint)ei;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000069A6 File Offset: 0x00004BA6
		public void ResetErrorReport()
		{
			this.m_ErrorReport.ErrCat = 0U;
			this.m_ErrorReport.ErrorID = 0U;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000069C0 File Offset: 0x00004BC0
		public uint ReportCategory
		{
			get
			{
				return this.m_ErrorReport.ErrCat;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000069CD File Offset: 0x00004BCD
		public uint ReportId
		{
			get
			{
				return this.m_ErrorReport.ErrorID;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000069DA File Offset: 0x00004BDA
		public void SendReportOnError(global::SSLMangrComp.ReportOnError_CallBack Rcb)
		{
			if (Rcb != null)
			{
				this.ERcb = Rcb;
			}
			if (this.m_ErrorReport.ErrorID != 0U)
			{
				this.CallErrorRepCallback(ref this.m_ErrorReport);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000069FF File Offset: 0x00004BFF
		public void CallErrorRepCallback(ref global::SSLMangrComp.ErrorReport ErrorRep)
		{
			if (this.ERcb != null)
			{
				this.ERcb(ref ErrorRep);
			}
		}

		// Token: 0x040000CB RID: 203
		private global::SSLMangrComp.ErrorReport m_ErrorReport;

		// Token: 0x040000CC RID: 204
		private static readonly global::SSLMangrComp.ErrorReporter ERInstance = new global::SSLMangrComp.ErrorReporter();

		// Token: 0x040000CD RID: 205
		private global::SSLMangrComp.ReportOnError_CallBack ERcb;
	}
}
