using System;
using System.Collections;
using System.Windows.Forms;

namespace RegistryAccess
{
	// Token: 0x02000009 RID: 9
	public interface IPersistentApplicationSettings
	{
		// Token: 0x0600001C RID: 28
		void SetDefaultFolder(string strPath);

		// Token: 0x0600001D RID: 29
		void GetDefaultFolder(ref string strPath);

		// Token: 0x0600001E RID: 30
		void GetInstallPath(ref string strPath);

		// Token: 0x0600001F RID: 31
		void GetCPSInstallPath(ref string strPath);

		// Token: 0x06000020 RID: 32
		void GetXferFolderPath(ref string strXferFolderPath);

		// Token: 0x06000021 RID: 33
		void GetViewFolderPath(ref string strViewFolderPath);

		// Token: 0x06000022 RID: 34
		void SetShowContextHelp(bool bShowHelp);

		// Token: 0x06000023 RID: 35
		void GetShowContextHelp(ref bool bShowHelp);

		// Token: 0x06000024 RID: 36
		void SetPosition(global::System.Windows.Forms.Form objPosition);

		// Token: 0x06000025 RID: 37
		void GetPosition(ref global::System.Windows.Forms.Form objPosition);

		// Token: 0x06000026 RID: 38
		void SetMaximumMRUEntries(int iNumEntries);

		// Token: 0x06000027 RID: 39
		void GetMaximumMRUEntries(ref int iNumEntries);

		// Token: 0x06000028 RID: 40
		void AddToMRUList(string strFileName);

		// Token: 0x06000029 RID: 41
		void GetMRUList(global::System.Collections.ArrayList arrFileNameList);

		// Token: 0x0600002A RID: 42
		void AddCustomView(string strViewName, string strResourceFile);

		// Token: 0x0600002B RID: 43
		void SetViewSelection(string strViewSelection);

		// Token: 0x0600002C RID: 44
		void GetAvailableViews(ref global::System.Collections.ArrayList arrAvailableViews);

		// Token: 0x0600002D RID: 45
		void GetViewSelection(ref string strViewName, ref string strResourceFile);

		// Token: 0x0600002E RID: 46
		void SetTransmitOffset(string strTransmitOffset);

		// Token: 0x0600002F RID: 47
		void GetTransmitOffset(ref string strTransmitOffset);

		// Token: 0x06000030 RID: 48
		void GetSoundStatus(ref bool SoundOn);

		// Token: 0x06000031 RID: 49
		void SetSoundStatus(bool SoundOn);

		// Token: 0x06000032 RID: 50
		void GetCloneRadioIdentity(ref bool bCloneRadioIdentity);

		// Token: 0x06000033 RID: 51
		void SetCloneRadioIdentity(bool bCloneRadioIdentity);

		// Token: 0x06000034 RID: 52
		void GetNoShowWarning(string id, ref global::System.Collections.ArrayList alNoShowWarning);

		// Token: 0x06000035 RID: 53
		void SetNoShowWarning(global::System.Collections.ArrayList alNoShowWarning);

		// Token: 0x06000036 RID: 54
		void SetSystemKeyLocation(string sysKeyLocation);

		// Token: 0x06000037 RID: 55
		void GetSystemKeyLocation(ref string sysKeyLocation);

		// Token: 0x06000038 RID: 56
		void SetTcpPort(ushort tcpPort);

		// Token: 0x06000039 RID: 57
		void GetTcpPort(ref ushort tcpPort);

		// Token: 0x0600003A RID: 58
		void SetVAWorkerLocation(string vaWorkerLocation);

		// Token: 0x0600003B RID: 59
		void GetVAWorkeLocation(ref string vaWorkerLocation);

		// Token: 0x0600003C RID: 60
		void SetVAExportLocation(string vaExportLocation);

		// Token: 0x0600003D RID: 61
		void GetVAExportLocation(ref string vaExportLocation);

		// Token: 0x0600003E RID: 62
		void GetDatabasePath(ref string databaseLocation);

		// Token: 0x0600003F RID: 63
		void GetColumnEnable(ref global::System.Collections.BitArray columnMap);

		// Token: 0x06000040 RID: 64
		void SetColumnEnable(global::System.Collections.BitArray columnMap);

		// Token: 0x06000041 RID: 65
		void GetIntermediaryInfo(ref string ipAddress, ref uint port);

		// Token: 0x06000042 RID: 66
		void SetIntermediaryInfo(string ipAddress, uint port);

		// Token: 0x06000043 RID: 67
		void GetKeepAlive(ref uint keepAlive);

		// Token: 0x06000044 RID: 68
		void SetKeepAlive(uint keepAlive);

		// Token: 0x06000045 RID: 69
		void GetSourcePort(ref uint sourcePort);

		// Token: 0x06000046 RID: 70
		void SetSourcePort(uint sourcePort);

		// Token: 0x06000047 RID: 71
		void GetRetryTimer(ref uint timer);

		// Token: 0x06000048 RID: 72
		void SetRetryTimer(uint timer);

		// Token: 0x06000049 RID: 73
		void GetAppID(ref uint peerID);

		// Token: 0x0600004A RID: 74
		void SetAppID(uint peerID);

		// Token: 0x0600004B RID: 75
		void GetAuthentication(ref byte[] authKey);

		// Token: 0x0600004C RID: 76
		void SetAuthentication(byte[] authKey);

		// Token: 0x0600004D RID: 77
		void GetAutoReg(ref bool autoReg);

		// Token: 0x0600004E RID: 78
		void SetAutoReg(bool autoReg);

		// Token: 0x0600004F RID: 79
		void GetConnection(ref bool connection);

		// Token: 0x06000050 RID: 80
		void SetConnection(bool connection);

		// Token: 0x06000051 RID: 81
		void GetHasConfigured(ref bool isConfigured);

		// Token: 0x06000052 RID: 82
		void SetHasConfigured(bool isConfigured);

		// Token: 0x06000053 RID: 83
		void GetEmailStatus(ref bool EmailOn);

		// Token: 0x06000054 RID: 84
		void SetEmailStatus(bool EmailOn);

		// Token: 0x06000055 RID: 85
		void GetDiagnosticLoggingStatus(ref bool isDiagnosticLoggingOn);

		// Token: 0x06000056 RID: 86
		void SetDiagnosticLoggingStatus(bool isDiagnosticLoggingOn);

		// Token: 0x06000057 RID: 87
		void GetDiagnosticInterval(ref uint diagnosticInterval);

		// Token: 0x06000058 RID: 88
		void SetDiagnosticInterval(uint diagnosticInterval);

		// Token: 0x06000059 RID: 89
		void GetHidenWhenMinimize(ref bool HidenOn);

		// Token: 0x0600005A RID: 90
		void SetHidenWhenMinimize(bool HidenOn);

		// Token: 0x0600005B RID: 91
		void GetLogDVStatus(ref bool LogDVOn);

		// Token: 0x0600005C RID: 92
		void SetLogDVStatus(bool LogDVOn);

		// Token: 0x0600005D RID: 93
		global::RegistryAccess.UpgradePackageRegInfo[] GetUpgradePackageRegInfo();
	}
}
