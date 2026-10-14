using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public class PBBSequenceManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		protected global::Motorola.Common.Communication.IMessageExecutor HttpExecutor
		{
			get
			{
				return this.m_HttpExecutor;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public PBBSequenceManager(global::Motorola.Common.Communication.IMessageExecutor executor)
		{
			this.m_HttpExecutor = executor;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E7 File Offset: 0x000002E7
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020EA File Offset: 0x000002EA
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020FB File Offset: 0x000002FB
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00000303
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000210C File Offset: 0x0000030C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00000314
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x0600000A RID: 10 RVA: 0x0000211D File Offset: 0x0000031D
		public bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return true;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002120 File Offset: 0x00000320
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002122 File Offset: 0x00000322
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002148 File Offset: 0x00000348
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			global::Motorola.Common.Communication.Pba.PBBReadData pbbreadData = new global::Motorola.Common.Communication.Pba.PBBReadData();
			try
			{
				global::Motorola.Common.Communication.HttpReadDeviceInventory httpReadDeviceInventory = new global::Motorola.Common.Communication.HttpReadDeviceInventory();
				this.m_HttpExecutor.SendAndReceiveMessage(httpReadDeviceInventory);
				if (httpReadDeviceInventory.ResponseData != null)
				{
					pbbreadData.FirmwareVersion = httpReadDeviceInventory.ResponseData.deviceInventory.bpHostFwVersion;
					pbbreadData.PBBFirmwareVersion = httpReadDeviceInventory.ResponseData.deviceInventory.fwVersion;
					pbbreadData.CodeplugVersion = httpReadDeviceInventory.ResponseData.deviceInventory.bpCodeplugVersion;
					if (httpReadDeviceInventory.ResponseData.deviceInventory.staged.ToLower() == "yes")
					{
						pbaObject.IsStaged = true;
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadDeviceInventoryFailed, ex.Message);
			}
			try
			{
				global::Motorola.Common.Communication.HttpListApp httpListApp = new global::Motorola.Common.Communication.HttpListApp();
				this.m_HttpExecutor.SendAndReceiveMessage(httpListApp);
				if (httpListApp.ResponseData != null)
				{
					foreach (global::Motorola.Common.Communication.App app in httpListApp.ResponseData.appInventory)
					{
						global::Motorola.Common.Communication.Pba.PBBApp pbbapp = new global::Motorola.Common.Communication.Pba.PBBApp();
						pbbapp.Name = app.appName;
						pbbapp.Label = app.appLabel;
						pbbapp.VersionCode = app.versionCode;
						pbbapp.VersionName = app.versionName;
						pbbreadData.Apps.Add(pbbapp);
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadAppInventoryFailed, ex2.Message);
			}
			try
			{
				global::Motorola.Common.Communication.HttpListLicense httpListLicense = new global::Motorola.Common.Communication.HttpListLicense();
				this.m_HttpExecutor.SendAndReceiveMessage(httpListLicense);
				if (httpListLicense.ResponseData != null)
				{
					foreach (global::Motorola.Common.Communication.License license in httpListLicense.ResponseData.licenseInventory)
					{
						pbbreadData.License.Add(license.featureName);
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadLicenseInventoryFailed, ex3.Message);
			}
			try
			{
				if (referencePba != null)
				{
					if (referencePba.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "FileCollection") > 0)
					{
						global::Motorola.Common.Communication.Pba.FileSet fileSet = referencePba.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "FileCollection");
						foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileSet.FileItemsList)
						{
							if (!global::System.IO.File.Exists(fileItem.URI))
							{
								throw new global::System.Exception("UE log upload manifest xml missing");
							}
							global::Motorola.Common.Communication.HttpUploadFileCollection httpUploadFileCollection = new global::Motorola.Common.Communication.HttpUploadFileCollection(fileItem.URI);
							this.m_HttpExecutor.SendAndReceiveMessage(httpUploadFileCollection);
							if (httpUploadFileCollection.ResultCode != global::System.Net.HttpStatusCode.Created)
							{
								throw new global::System.Exception("upload ue log manifest failed.");
							}
							global::Motorola.Common.Communication.HttpDownloadFileCollection httpDownloadFileCollection = new global::Motorola.Common.Communication.HttpDownloadFileCollection(httpUploadFileCollection.ResponseData.fileCollection.fileName);
							this.m_HttpExecutor.SendAndReceiveMessage(httpDownloadFileCollection);
							if (httpDownloadFileCollection.ResultCode != global::System.Net.HttpStatusCode.OK)
							{
								throw new global::System.Exception("download ue log package failed.");
							}
							fileItem.FileContent = httpDownloadFileCollection.ResponseData;
							fileItem.Name = httpUploadFileCollection.ResponseData.fileCollection.fileName;
						}
						pbaObject.FileSetList.Add(fileSet);
					}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex4)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadUELogFailed, ex4.Message);
			}
			pbaObject.PbbReadData = pbbreadData;
			return pbaObject;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002704 File Offset: 0x00000904
		public virtual global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string pcrNewPassword)
		{
			new global::System.Text.StringBuilder();
			if (pbaObject.IsFactoryResetOp)
			{
				try
				{
					global::Motorola.Common.Communication.HttpFactoryReset httpFactoryReset = new global::Motorola.Common.Communication.HttpFactoryReset(10, "Admin Factory Reset");
					this.m_HttpExecutor.SendAndReceiveMessage(httpFactoryReset);
					if (httpFactoryReset.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Failed to reset for Factory Reset.");
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeFactoryResetFailed, ex.Message);
				}
				try
				{
					global::Motorola.Common.Communication.HttpTerminateSession msg = new global::Motorola.Common.Communication.HttpTerminateSession(13, "Factory Reset");
					this.m_HttpExecutor.SendAndReceiveMessage(msg);
				}
				catch (global::System.Exception)
				{
				}
				return pbaObject;
			}
			try
			{
				if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBProvisioningPackage") > 0)
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBProvisioningPackage");
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileSet.FileItemsList)
					{
						if (!global::System.IO.File.Exists(fileItem.URI))
						{
							throw new global::System.Exception("Provisioning Package Missing.");
						}
						bool? needReboot = null;
						if (fileItem.FileSize > 0)
						{
							needReboot = new bool?(true);
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem.URI, needReboot);
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning);
						if (httpPackageProvisioning.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("Package Provisioning failed.");
						}
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePackageProvisioningFailed, ex2.Message);
			}
			try
			{
				if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "Configuration") > 0)
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet2 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "Configuration");
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in fileSet2.FileItemsList)
					{
						if (!global::System.IO.File.Exists(fileItem2.URI))
						{
							throw new global::System.Exception("Configuration Missing.");
						}
						bool? needReboot2 = null;
						if (fileItem2.FileSize > 0)
						{
							needReboot2 = new bool?(true);
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning2 = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem2.URI, needReboot2);
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning2);
						if (httpPackageProvisioning2.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("Configuration failed.");
						}
					}
				}
			}
			catch (global::System.Exception ex3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeConfigurationFailed, ex3.Message);
			}
			try
			{
				if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBHomeSet") > 0)
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet3 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBHomeSet");
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem3 in fileSet3.FileItemsList)
					{
						if (!global::System.IO.File.Exists(fileItem3.URI))
						{
							throw new global::System.Exception("Home Set Missing.");
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning3 = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem3.URI, null);
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning3);
						if (httpPackageProvisioning3.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("Home Set failed.");
						}
					}
				}
			}
			catch (global::System.Exception ex4)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeHomeSetFailed, ex4.Message);
			}
			try
			{
				if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "SimpleTouch") > 0)
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet4 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "SimpleTouch");
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem4 in fileSet4.FileItemsList)
					{
						if (!global::System.IO.File.Exists(fileItem4.URI))
						{
							throw new global::System.Exception("Simple Touch Missing.");
						}
						bool? needReboot3 = null;
						if (fileItem4.FileSize > 0)
						{
							needReboot3 = new bool?(true);
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning4 = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem4.URI, needReboot3);
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning4);
						if (httpPackageProvisioning4.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("Simple Touch Set failed.");
						}
					}
				}
			}
			catch (global::System.Exception ex5)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeHomeSetFailed, ex5.Message);
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBApplicationUninstall") > 0)
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSet5 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBApplicationUninstall");
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem5 in fileSet5.FileItemsList)
				{
					try
					{
						global::Motorola.Common.Communication.HttpRemoveApp httpRemoveApp = new global::Motorola.Common.Communication.HttpRemoveApp(fileItem5.Name);
						this.m_HttpExecutor.SendAndReceiveMessage(httpRemoveApp);
						if (httpRemoveApp.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception();
						}
					}
					catch (global::System.Exception ex6)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeRemoveAppFailed, string.Format("Failed to uninstall app:{0}\n{1}", fileItem5.Name, ex6.Message));
					}
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBApplicationInstall") > 0)
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSet6 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBApplicationInstall");
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem6 in fileSet6.FileItemsList)
				{
					try
					{
						if (!global::System.IO.File.Exists(fileItem6.URI))
						{
							throw new global::System.Exception(fileItem6.Name + "\t installer missing\n");
						}
						global::Motorola.Common.Communication.HttpInstallApp httpInstallApp = new global::Motorola.Common.Communication.HttpInstallApp(fileItem6.URI, fileItem6.Name);
						this.m_HttpExecutor.SendAndReceiveMessage(httpInstallApp);
						if (httpInstallApp.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception(string.Format("Failed to install app:{0}", fileItem6.Name));
						}
					}
					catch (global::System.Exception ex7)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInstallAppFailed, ex7.Message);
					}
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBUninstallAllCertificate") > 0)
			{
				try
				{
					global::Motorola.Common.Communication.HttpUninstallAllCert httpUninstallAllCert = new global::Motorola.Common.Communication.HttpUninstallAllCert();
					this.m_HttpExecutor.SendAndReceiveMessage(httpUninstallAllCert);
					if (httpUninstallAllCert.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Failed to uninstall all certificate");
					}
				}
				catch (global::System.Exception ex8)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUninstallAllCertificateFailed, ex8.Message);
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBCertificate") > 0)
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSet7 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBCertificate");
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem7 in fileSet7.FileItemsList)
				{
					try
					{
						if (!global::System.IO.File.Exists(fileItem7.URI))
						{
							throw new global::System.Exception(fileItem7.Name + "\t installer missing\n");
						}
						global::Motorola.Common.Communication.HttpInstallCert httpInstallCert = new global::Motorola.Common.Communication.HttpInstallCert(fileItem7.URI, fileItem7.Name);
						this.m_HttpExecutor.SendAndReceiveMessage(httpInstallCert);
						if (httpInstallCert.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception(string.Format("Failed to install certificate:{0}", fileItem7.Name));
						}
					}
					catch (global::System.Exception ex9)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInstallCertificateFailed, ex9.Message);
					}
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBDisableAllCertifcate") > 0)
			{
				try
				{
					global::Motorola.Common.Communication.HttpDisableAllSysCert httpDisableAllSysCert = new global::Motorola.Common.Communication.HttpDisableAllSysCert();
					this.m_HttpExecutor.SendAndReceiveMessage(httpDisableAllSysCert);
					if (httpDisableAllSysCert.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Failed to disable all system certificate");
					}
				}
				catch (global::System.Exception ex10)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeDisableAllSysCertificateFailed, ex10.Message);
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBEnableAllCertificate") > 0)
			{
				try
				{
					global::Motorola.Common.Communication.HttpEnableAllSysCert httpEnableAllSysCert = new global::Motorola.Common.Communication.HttpEnableAllSysCert();
					this.m_HttpExecutor.SendAndReceiveMessage(httpEnableAllSysCert);
					if (httpEnableAllSysCert.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Failed to enable all system certificate");
					}
				}
				catch (global::System.Exception ex11)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeEnableAllSysCertificateFailed, ex11.Message);
				}
			}
			if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBLicense") > 0)
			{
				try
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet8 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "PBBLicense");
					global::Motorola.Common.Communication.Pba.FileItem fileItem8 = fileSet8.FileItemsList.Find((global::Motorola.Common.Communication.Pba.FileItem m) => m.Name == "PBBLicense");
					if (!global::System.IO.File.Exists(fileItem8.FilePath))
					{
						throw new global::System.Exception("License File Missing.\n");
					}
					global::Motorola.Common.Communication.HttpUpdateLicense httpUpdateLicense = new global::Motorola.Common.Communication.HttpUpdateLicense(fileItem8.FilePath);
					this.m_HttpExecutor.SendAndReceiveMessage(httpUpdateLicense);
					if (httpUpdateLicense.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Failed to update license");
					}
					if (fileSet8.FileItemsList.Count((global::Motorola.Common.Communication.Pba.FileItem m) => m.Name == "PBBProvisioningPackage") > 0)
					{
						fileItem8 = fileSet8.FileItemsList.Find((global::Motorola.Common.Communication.Pba.FileItem m) => m.Name == "PBBProvisioningPackage");
						if (!global::System.IO.File.Exists(fileItem8.FilePath))
						{
							throw new global::System.Exception("License Provisioning Missing.");
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning5 = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem8.FilePath, null);
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning5);
						if (httpPackageProvisioning5.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("License Provisioning failed.");
						}
					}
				}
				catch (global::System.Exception ex12)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUpdateLicenseFailed, ex12.Message);
				}
			}
			if (pbaObject.UpdateData.MemoryImages.Count > 0)
			{
				try
				{
					global::Motorola.Common.Communication.Pba.RadioImage radioImage = pbaObject.UpdateData.MemoryImages.First<global::Motorola.Common.Communication.Pba.RadioImage>();
					if (!global::System.IO.File.Exists(radioImage.FilePath))
					{
						throw new global::System.Exception("Firmware File Missing.\n");
					}
					global::Motorola.Common.Communication.HttpUpdateFirmware httpUpdateFirmware = new global::Motorola.Common.Communication.HttpUpdateFirmware(radioImage.FilePath);
					this.m_HttpExecutor.SendAndReceiveMessage(httpUpdateFirmware);
					if (httpUpdateFirmware.ResultCode != global::System.Net.HttpStatusCode.Accepted)
					{
						throw new global::System.Exception("Update firmware failed");
					}
				}
				catch (global::System.Exception ex13)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUpdateFirmwareFailed, ex13.Message);
				}
			}
			try
			{
				if (pbaObject.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "FusionRebootPackage") > 0)
				{
					global::Motorola.Common.Communication.Pba.FileSet fileSet9 = pbaObject.FileSetList.First((global::Motorola.Common.Communication.Pba.FileSet f) => f.Name == "FusionRebootPackage");
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem9 in fileSet9.FileItemsList)
					{
						if (!global::System.IO.File.Exists(fileItem9.URI))
						{
							throw new global::System.Exception("Provisioning Package Missing.");
						}
						global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning6 = new global::Motorola.Common.Communication.HttpPackageProvisioning(fileItem9.URI, new bool?(true));
						this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning6);
						if (httpPackageProvisioning6.ResultCode != global::System.Net.HttpStatusCode.OK)
						{
							throw new global::System.Exception("Package Provisioning failed.");
						}
					}
				}
			}
			catch (global::System.Exception ex14)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePackageProvisioningFailed, ex14.Message);
			}
			return pbaObject;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003524 File Offset: 0x00001724
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
			global::Motorola.Common.Communication.HttpReadDeviceInventory httpReadDeviceInventory = new global::Motorola.Common.Communication.HttpReadDeviceInventory();
			this.m_HttpExecutor.SendAndReceiveMessage(httpReadDeviceInventory);
			if (httpReadDeviceInventory.ResponseData != null)
			{
				deviceInfo.IMEI = httpReadDeviceInventory.ResponseData.deviceInventory.imei;
				deviceInfo.SerialNumber = httpReadDeviceInventory.ResponseData.deviceInventory.serialNumber;
			}
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			return deviceInfo;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003590 File Offset: 0x00001790
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(string psw)
		{
			global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo();
			pbbdeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
			global::Motorola.Common.Communication.AuthenticatePassword jsonObj = new global::Motorola.Common.Communication.AuthenticatePassword(psw);
			try
			{
				global::Motorola.Common.Communication.HttpPasswordAuthenticate httpPasswordAuthenticate = new global::Motorola.Common.Communication.HttpPasswordAuthenticate(global::Motorola.Common.Communication.JSONHelper.ToString(jsonObj));
				this.m_HttpExecutor.SendAndReceiveMessage(httpPasswordAuthenticate);
				if (httpPasswordAuthenticate.ResponseData != null)
				{
					pbbdeviceInfo.FirmwareVersion = httpPasswordAuthenticate.ResponseData.deviceInventory.fwVersion;
					pbbdeviceInfo.IMEI = httpPasswordAuthenticate.ResponseData.deviceInventory.imei;
					pbbdeviceInfo.ProductIdentifier = httpPasswordAuthenticate.ResponseData.deviceInventory.model;
					pbbdeviceInfo.ManufacturerName = httpPasswordAuthenticate.ResponseData.deviceInventory.manufacturer;
					pbbdeviceInfo.InactivityTimer = httpPasswordAuthenticate.ResponseData.deviceInventory.inactivityTimer;
					pbbdeviceInfo.Staged = httpPasswordAuthenticate.ResponseData.deviceInventory.staged;
					pbbdeviceInfo.SerialNumber = httpPasswordAuthenticate.ResponseData.deviceInventory.serialNumber;
					pbbdeviceInfo.RMVersion = httpPasswordAuthenticate.ResponseData.deviceInventory.rmVersion;
					pbbdeviceInfo.LastPackage = httpPasswordAuthenticate.ResponseData.deviceInventory.lastPackage;
					pbbdeviceInfo.Certificates = httpPasswordAuthenticate.ResponseData.deviceInventory.certificates;
					pbbdeviceInfo.ResultCode = httpPasswordAuthenticate.ResponseData.deviceInventory.resultCode;
					pbbdeviceInfo.SoftwareVersion = httpPasswordAuthenticate.ResponseData.deviceInventory.bpHostFwVersion;
					pbbdeviceInfo.ModelNumber = httpPasswordAuthenticate.ResponseData.deviceInventory.bpModelNumber;
					if (pbbdeviceInfo.ProductIdentifier == "HK2062A")
					{
						pbbdeviceInfo.ProductIdentifier = "Si500";
						pbbdeviceInfo.ModelNumber = "HK2062A";
					}
					else if (pbbdeviceInfo.ModelNumber == null)
					{
						string productIdentifier;
						switch (productIdentifier = pbbdeviceInfo.ProductIdentifier)
						{
						case "LEX755":
							pbbdeviceInfo.ModelNumber = "T8167A";
							goto IL_301;
						case "LEX L10":
							pbbdeviceInfo.ModelNumber = "HK2056A";
							goto IL_301;
						case "LEX L10g":
							pbbdeviceInfo.ModelNumber = "HK2064A";
							goto IL_301;
						case "LEX L10i":
							pbbdeviceInfo.ModelNumber = "T4104A/T4105A/T4106A";
							goto IL_301;
						case "LEX L10ig":
							pbbdeviceInfo.ModelNumber = "T4107A/T4108A/T4109A";
							goto IL_301;
						case "LEX M20":
							pbbdeviceInfo.ModelNumber = "F0050A";
							goto IL_301;
						case "TML M30":
							pbbdeviceInfo.ModelNumber = "F0055A";
							goto IL_301;
						case "Si300":
							pbbdeviceInfo.ModelNumber = "HK2061A";
							goto IL_301;
						case "Si500":
							pbbdeviceInfo.ModelNumber = "HK2062A";
							goto IL_301;
						case "LTTS-TAB16-CAS":
							pbbdeviceInfo.ModelNumber = "AAAA";
							goto IL_301;
						}
						throw new global::System.NotImplementedException();
					}
					IL_301:
					pbbdeviceInfo.CodeplugVersion = httpPasswordAuthenticate.ResponseData.deviceInventory.bpCodeplugVersion;
				}
				pbbdeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAuthenticationFailure, "Authenticate failed");
			}
			return pbbdeviceInfo;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000038EC File Offset: 0x00001AEC
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo();
			pbbdeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
			try
			{
				global::Motorola.Common.Communication.HttpReadDeviceInventory httpReadDeviceInventory = new global::Motorola.Common.Communication.HttpReadDeviceInventory();
				this.m_HttpExecutor.SendAndReceiveMessage(httpReadDeviceInventory);
				if (httpReadDeviceInventory.ResponseData != null)
				{
					pbbdeviceInfo.FirmwareVersion = httpReadDeviceInventory.ResponseData.deviceInventory.fwVersion;
					pbbdeviceInfo.IMEI = httpReadDeviceInventory.ResponseData.deviceInventory.imei;
					pbbdeviceInfo.ProductIdentifier = httpReadDeviceInventory.ResponseData.deviceInventory.model;
					pbbdeviceInfo.ManufacturerName = httpReadDeviceInventory.ResponseData.deviceInventory.manufacturer;
					pbbdeviceInfo.InactivityTimer = httpReadDeviceInventory.ResponseData.deviceInventory.inactivityTimer;
					pbbdeviceInfo.Staged = httpReadDeviceInventory.ResponseData.deviceInventory.staged;
					pbbdeviceInfo.SerialNumber = httpReadDeviceInventory.ResponseData.deviceInventory.serialNumber;
					pbbdeviceInfo.RMVersion = httpReadDeviceInventory.ResponseData.deviceInventory.rmVersion;
					pbbdeviceInfo.LastPackage = httpReadDeviceInventory.ResponseData.deviceInventory.lastPackage;
					pbbdeviceInfo.Certificates = httpReadDeviceInventory.ResponseData.deviceInventory.certificates;
					pbbdeviceInfo.ResultCode = httpReadDeviceInventory.ResponseData.deviceInventory.resultCode;
					pbbdeviceInfo.SoftwareVersion = httpReadDeviceInventory.ResponseData.deviceInventory.bpHostFwVersion;
					pbbdeviceInfo.ModelNumber = httpReadDeviceInventory.ResponseData.deviceInventory.bpModelNumber;
					if (pbbdeviceInfo.ProductIdentifier == "HK2062A")
					{
						pbbdeviceInfo.ProductIdentifier = "Si500";
						pbbdeviceInfo.ModelNumber = "HK2062A";
					}
					else if (pbbdeviceInfo.ModelNumber == null)
					{
						string productIdentifier;
						switch (productIdentifier = pbbdeviceInfo.ProductIdentifier)
						{
						case "LEX755":
							pbbdeviceInfo.ModelNumber = "T8167A";
							goto IL_2F3;
						case "LEX L10":
							pbbdeviceInfo.ModelNumber = "HK2056A";
							goto IL_2F3;
						case "LEX L10g":
							pbbdeviceInfo.ModelNumber = "HK2064A";
							goto IL_2F3;
						case "LEX L10i":
							pbbdeviceInfo.ModelNumber = "T4104A/T4105A/T4106A";
							goto IL_2F3;
						case "LEX L10ig":
							pbbdeviceInfo.ModelNumber = "T4107A/T4108A/T4109A";
							goto IL_2F3;
						case "LEX M20":
							pbbdeviceInfo.ModelNumber = "F0050A";
							goto IL_2F3;
						case "TML M30":
							pbbdeviceInfo.ModelNumber = "F0055A";
							goto IL_2F3;
						case "Si300":
							pbbdeviceInfo.ModelNumber = "HK2061A";
							goto IL_2F3;
						case "Si500":
							pbbdeviceInfo.ModelNumber = "HK2062A";
							goto IL_2F3;
						case "LTTS-TAB16-CAS":
							pbbdeviceInfo.ModelNumber = "AAAA";
							goto IL_2F3;
						}
						throw new global::System.NotImplementedException();
					}
					IL_2F3:
					pbbdeviceInfo.CodeplugVersion = httpReadDeviceInventory.ResponseData.deviceInventory.bpCodeplugVersion;
				}
				pbbdeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlAuthenticationFailure, "Authenticate failed");
			}
			return pbbdeviceInfo;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003C3C File Offset: 0x00001E3C
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003C43 File Offset: 0x00001E43
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003C4A File Offset: 0x00001E4A
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003C51 File Offset: 0x00001E51
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003C58 File Offset: 0x00001E58
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003C5F File Offset: 0x00001E5F
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003C66 File Offset: 0x00001E66
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003C6D File Offset: 0x00001E6D
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003C74 File Offset: 0x00001E74
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003C7B File Offset: 0x00001E7B
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003C82 File Offset: 0x00001E82
		public void UpdateSerialNumber(string serialNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003C89 File Offset: 0x00001E89
		public void UnkillRadio(byte[] authenticationValue)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003C90 File Offset: 0x00001E90
		public byte[] ReadUnkillChallengeValue()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003C97 File Offset: 0x00001E97
		public void CBIProgramme()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public void TerminateSession(int code, string reason)
		{
			global::Motorola.Common.Communication.HttpTerminateSession msg = new global::Motorola.Common.Communication.HttpTerminateSession(code, reason);
			this.m_HttpExecutor.SendAndReceiveMessage(msg);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003CC1 File Offset: 0x00001EC1
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003CCF File Offset: 0x00001ECF
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003CDD File Offset: 0x00001EDD
		public void UpdateIMEType(byte ime)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003CEB File Offset: 0x00001EEB
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003CF2 File Offset: 0x00001EF2
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000001 RID: 1
		protected global::Motorola.Common.Communication.IMessageExecutor m_HttpExecutor;
	}
}
