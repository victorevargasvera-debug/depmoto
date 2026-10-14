using System;
using System.Collections;
using System.Collections.Generic;
using constants;

namespace Controller
{
	// Token: 0x02000006 RID: 6
	public interface IController
	{
		// Token: 0x0600001F RID: 31
		void OpenController();

		// Token: 0x06000020 RID: 32
		void CloseController();

		// Token: 0x06000021 RID: 33
		void OpenConnection(string strIP, ref uint uiHandleToDatabase, global::constants.CCPTags.SetProgressBar pfSetProgressBar);

		// Token: 0x06000022 RID: 34
		void CloseConnection(uint uiHandleToDatabase);

		// Token: 0x06000023 RID: 35
		void ListConnectedDevices(out global::System.Collections.ArrayList alDeviceList);

		// Token: 0x06000024 RID: 36
		void ListConnectedBootmodeDevices(ref global::System.Collections.ArrayList alDeviceList);

		// Token: 0x06000025 RID: 37
		void ReadDevice(ref uint uiHandleToDatabase, ref string RetrievedXML, ref bool AutoCorrectionReq, global::constants.CCPTags.SetProgressBar pfSetProgressBar);

		// Token: 0x06000026 RID: 38
		void ReadDevice(ref uint uiHandleToDatabase, string strCommand, global::System.Collections.ArrayList strParameters);

		// Token: 0x06000027 RID: 39
		void SendUpdateIMEType(byte ime);

		// Token: 0x06000028 RID: 40
		void ConvertDevice(global::Controller.DeviceInfo dev, global::constants.CCPTags.SetProgressBar progressBar, int progressBarLength);

		// Token: 0x06000029 RID: 41
		void WriteDevice(uint uiHandleToDatabase, global::System.Collections.ArrayList alDataList, global::constants.CCPTags.SetProgressBar pfSetProgressBar);

		// Token: 0x0600002A RID: 42
		void VerifyUserLogin(string strUserName, string strPassword);

		// Token: 0x0600002B RID: 43
		void IsUserConnected();

		// Token: 0x0600002C RID: 44
		void IsMotorolaUser();

		// Token: 0x0600002D RID: 45
		void RetrieveItem(uint uiHandleToDatabase, global::System.Collections.ArrayList alTagName, global::System.Collections.ArrayList alListID, global::System.Collections.ArrayList alListLetID, ref string strXMLBuffer);

		// Token: 0x0600002E RID: 46
		void ModifyItem(uint uiHandleToDatabase, ref string strXMLBuffer);

		// Token: 0x0600002F RID: 47
		void GetAvailPackage(string Model, string tanapa, string Region, string CPSBuildVer, string PackagePath, int upgradeType, ref global::System.Collections.ArrayList alPackages);

		// Token: 0x06000030 RID: 48
		void UpdateDevice(string IPAddress, string CurrentCodeplugVersion, string SelPackage, bool FWUpdateReq, bool CPUpdateReq, bool PreserveTuning, bool PreserveSecurity, bool PreserveApp, bool PreserveUcl, global::constants.CCPTags.SetProgressBar pfSetProgressBar, ref global::Controller.DeviceInfo dev, int progressBarLength);

		// Token: 0x06000031 RID: 49
		void SendEnterFZMode(uint uiHandle);

		// Token: 0x06000032 RID: 50
		bool IsOpen();

		// Token: 0x06000033 RID: 51
		bool IsValidHandleToDB(uint uiHandleToDatabase);

		// Token: 0x06000034 RID: 52
		void Close(uint uiHandleToDatabase);

		// Token: 0x06000035 RID: 53
		void GetModelType(uint uiHandleToDatabase, string sModel, out string sRadioType);

		// Token: 0x06000036 RID: 54
		global::System.Collections.ArrayList EnterBootMode(string RDLFile, bool compressed, global::System.Collections.Generic.List<string> IPs, bool deviceMode, string uuid, int ishversion, int srcIshVersion);

		// Token: 0x06000037 RID: 55
		void ListBootModeDevices(string RDLFile, bool compressed, out global::System.Collections.ArrayList alDevs, string uuid, int ishversion, int srcIshVersion);

		// Token: 0x06000038 RID: 56
		bool CanDetectDevice(string ipAddres);
	}
}
