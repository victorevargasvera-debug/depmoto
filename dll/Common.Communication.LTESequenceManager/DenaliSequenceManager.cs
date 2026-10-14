using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Xml;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class DenaliSequenceManager : global::Motorola.Common.Communication.PBBSequenceManager
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00003CF9 File Offset: 0x00001EF9
		public DenaliSequenceManager(global::Motorola.Common.Communication.IMessageExecutor executor) : base(executor)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D04 File Offset: 0x00001F04
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pba = base.ReadDevice(referencePba, sessionID);
			return this.ReadLMRCodePlug(pba);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003D24 File Offset: 0x00001F24
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string pcrNewPassword)
		{
			if (pbaObject.IsFactoryResetOp)
			{
				return pbaObject;
			}
			if (pbaObject.RebootCount == 0)
			{
				string text = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), "tmpcp");
				if (global::System.IO.Directory.Exists(text))
				{
					global::System.IO.Directory.Delete(text, true);
				}
				global::System.IO.Directory.CreateDirectory(text);
				string path = "Manifest.xml";
				string path2 = global::System.IO.Path.Combine(text, path);
				if (global::System.IO.File.Exists(path2))
				{
					global::System.IO.File.Delete(path2);
				}
				string text2 = string.Format("CP{0}.cmp", pbaObject.DenaliValidInfo.SerialNumber);
				string path3 = global::System.IO.Path.Combine(text, text2);
				string path4 = global::System.IO.Path.Combine(text, "validation.xml");
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(path4, global::System.IO.FileMode.Create))
				{
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(fileStream);
					streamWriter.WriteLine("<?xml version=\"1.0\"?>");
					streamWriter.WriteLine("<validation>");
					streamWriter.WriteLine("<target_check>");
					streamWriter.WriteLine(string.Format("<ModelNumber>{0}</ModelNumber>", pbaObject.DenaliValidInfo.ModelNumber));
					streamWriter.WriteLine(string.Format("<SerialNumber>{0}</SerialNumber>", pbaObject.DenaliValidInfo.SerialNumber));
					streamWriter.WriteLine(string.Format("<Uuid>{0}</Uuid>", pbaObject.DenaliValidInfo.RadioUuid));
					streamWriter.WriteLine(string.Format("<CodeplugVersion>{0}</CodeplugVersion>", pbaObject.DenaliValidInfo.CodeplugVersion));
					streamWriter.WriteLine("</target_check>");
					foreach (global::Motorola.Common.Communication.Pba.ValidationField validationField in pbaObject.ValidationFields)
					{
						if (!validationField.BypassMissing)
						{
							streamWriter.WriteLine("<ish_check>");
							streamWriter.WriteLine("<Partition>{0}</Partition>", validationField.PartitionID);
							streamWriter.WriteLine("<BlockType>{0}</BlockType>", validationField.BlockType);
							streamWriter.WriteLine("<BlockID>{0}</BlockID>", validationField.BlockID);
							streamWriter.WriteLine("<OffsetInBits>{0}</OffsetInBits>", validationField.OffsetInBits);
							streamWriter.WriteLine("<LengthInBits>{0}</LengthInBits>", validationField.LengthInBits);
							streamWriter.WriteLine("<Value>{0}</Value>", global::System.Convert.ToBase64String(validationField.Content));
							streamWriter.WriteLine("</ish_check>");
						}
					}
					streamWriter.WriteLine("</validation>");
					streamWriter.Flush();
				}
				string text3 = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), "codeplug.zip");
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
				codeplugCommFileHeader.HeaderVer = 16;
				codeplugCommFileHeader.FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full;
				codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
				global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
				byte[] array = partitionCommonFile.Serialize(codeplugCommFileHeader, pbaObject);
				using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(path3, global::System.IO.FileMode.Create))
				{
					fileStream2.Write(array, 0, array.Length);
					fileStream2.Flush();
					fileStream2.Close();
				}
				using (global::System.IO.FileStream fileStream3 = global::System.IO.File.Create(path2))
				{
					global::System.IO.StreamWriter streamWriter2 = new global::System.IO.StreamWriter(fileStream3);
					streamWriter2.WriteLine("<?xml version=\"1.0\"?>");
					streamWriter2.WriteLine("<PBBP schemaVersion=\"1.0.0\">");
					streamWriter2.WriteLine("<manifestVersion>1.0.0</manifestVersion>");
					streamWriter2.WriteLine("<packageVersion>1.1.1</packageVersion>");
					streamWriter2.WriteLine("<packageDescription>LMRCodePlug</packageDescription>");
					streamWriter2.WriteLine("<component>");
					streamWriter2.WriteLine(string.Format(" <sourceFilename>{0}</sourceFilename> ", text2));
					streamWriter2.WriteLine("<fileType>Codeplug</fileType> ");
					streamWriter2.WriteLine(string.Format("<fileName>{0}</fileName>", text2));
					streamWriter2.WriteLine("<targetDir>/data/system</targetDir>");
					streamWriter2.WriteLine("</component>");
					streamWriter2.WriteLine("<component>");
					streamWriter2.WriteLine(" <sourceFilename>validation.xml</sourceFilename> ");
					streamWriter2.WriteLine("<fileType>CodeplugValidation</fileType> ");
					streamWriter2.WriteLine("<fileName>validation.xml</fileName>");
					streamWriter2.WriteLine("<targetDir>/data/system</targetDir>");
					streamWriter2.WriteLine("</component>");
					streamWriter2.WriteLine("<action>reboot</action>");
					streamWriter2.WriteLine("</PBBP>");
					streamWriter2.Flush();
				}
				try
				{
					if (global::System.IO.File.Exists(text3))
					{
						global::System.IO.File.Delete(text3);
					}
					global::System.IO.Compression.ZipFile.CreateFromDirectory(text, text3);
					global::Motorola.Common.Communication.HttpPackageProvisioning httpPackageProvisioning = new global::Motorola.Common.Communication.HttpPackageProvisioning(text3, null);
					this.m_HttpExecutor.SendAndReceiveMessage(httpPackageProvisioning);
					if (httpPackageProvisioning.ResultCode != global::System.Net.HttpStatusCode.OK)
					{
						throw new global::System.Exception("Codeplug update failed.");
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteLMRCodeplugFailed, ex.Message);
				}
				finally
				{
					if (global::System.IO.File.Exists(path2))
					{
						global::System.IO.File.Delete(path2);
					}
					if (global::System.IO.File.Exists(path3))
					{
						global::System.IO.File.Delete(path3);
					}
					if (global::System.IO.File.Exists(text3))
					{
						global::System.IO.File.Delete(text3);
					}
					if (global::System.IO.File.Exists(path4))
					{
						global::System.IO.File.Delete(path4);
					}
					if (global::System.IO.Directory.Exists(text))
					{
						global::System.IO.Directory.Delete(text);
					}
				}
			}
			return base.WriteDevice(pbaObject, sessionID, null);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004260 File Offset: 0x00002460
		private global::Motorola.Common.Communication.Pba.PbaObject ReadLMRCodePlug(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = pba;
			try
			{
				string tempFileName = global::System.IO.Path.GetTempFileName();
				string text = null;
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(tempFileName))
				{
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(fileStream);
					streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
					streamWriter.WriteLine("<upload_requests>");
					streamWriter.WriteLine("<upload_request maximum_waiting_time=\"120\" is_package=\"true\" is_periodic=\"false\" client_id=\"RM\" retention_period=\"2\">");
					streamWriter.WriteLine("<filerequest file_type=\"LMRCodePlug\"/>");
					streamWriter.WriteLine("</upload_request>");
					streamWriter.WriteLine("</upload_requests>");
					streamWriter.Flush();
				}
				global::Motorola.Common.Communication.HttpUploadFileCollection httpUploadFileCollection = new global::Motorola.Common.Communication.HttpUploadFileCollection(tempFileName);
				this.m_HttpExecutor.SendAndReceiveMessage(httpUploadFileCollection);
				if (httpUploadFileCollection.ResponseData != null)
				{
					text = httpUploadFileCollection.ResponseData.fileCollection.fileName;
				}
				try
				{
					global::System.IO.File.Delete(tempFileName);
				}
				catch
				{
				}
				if (httpUploadFileCollection.ResultCode == global::System.Net.HttpStatusCode.Created && !string.IsNullOrEmpty(text))
				{
					global::Motorola.Common.Communication.HttpDownloadFileCollection httpDownloadFileCollection = new global::Motorola.Common.Communication.HttpDownloadFileCollection(text);
					this.m_HttpExecutor.SendAndReceiveMessage(httpDownloadFileCollection);
					if (httpDownloadFileCollection.ResultCode == global::System.Net.HttpStatusCode.OK && httpDownloadFileCollection.ResponseData != null)
					{
						string tempFileName2 = global::System.IO.Path.GetTempFileName();
						string text2 = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::System.Guid.NewGuid().ToString());
						try
						{
							try
							{
								global::System.IO.File.WriteAllBytes(tempFileName2, httpDownloadFileCollection.ResponseData);
								global::System.IO.Compression.ZipFile.ExtractToDirectory(tempFileName2, text2);
								string[] files = global::System.IO.Directory.GetFiles(text2, "UploadPackageContent.xml");
								string text3 = null;
								if (files.Count<string>() > 0)
								{
									global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
									xmlDocument.Load(files[0]);
									global::System.Xml.XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("filerequest");
									using (global::System.Collections.IEnumerator enumerator = elementsByTagName.GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
											global::System.Xml.XmlElement xmlElement = xmlNode as global::System.Xml.XmlElement;
											string attribute = xmlElement.GetAttribute("file_type");
											string attribute2 = xmlElement.GetAttribute("status");
											if (attribute == "LMRCodePlug" && attribute2 == "Success")
											{
												using (global::System.Collections.IEnumerator enumerator2 = xmlElement.ChildNodes.GetEnumerator())
												{
													while (enumerator2.MoveNext())
													{
														object obj2 = enumerator2.Current;
														global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj2;
														using (global::System.Collections.IEnumerator enumerator3 = xmlNode2.ChildNodes.GetEnumerator())
														{
															if (enumerator3.MoveNext())
															{
																global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)enumerator3.Current;
																global::System.Xml.XmlElement xmlElement2 = xmlNode3 as global::System.Xml.XmlElement;
																text3 = xmlElement2.GetAttribute("filename");
															}
														}
													}
													continue;
												}
											}
											throw new global::System.Exception("read Codeplug failed");
										}
										goto IL_2AA;
									}
									goto IL_29F;
									IL_2AA:
									if (text3.EndsWith(".bbf"))
									{
										pbaObject.CodeplugBBFBuffer = global::System.IO.File.ReadAllBytes(global::System.IO.Path.Combine(text2, text3));
									}
									else
									{
										if (!text3.EndsWith(".cmp"))
										{
											throw new global::System.Exception("not supported codeplug format, only support .bbf,.cmp");
										}
										global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
										pbaObject = partitionCommonFile.Deserialize(global::System.IO.File.ReadAllBytes(global::System.IO.Path.Combine(text2, text3)));
										char[] trimChars = new char[]
										{
											'\0',
											' ',
											'\r',
											'\n'
										};
										pbaObject.CodeplugData.CPVersion = pba.PbbReadData.CodeplugVersion.TrimEnd(trimChars);
										pbaObject.PbbReadData = pba.PbbReadData;
										pbaObject.IsStaged = pba.IsStaged;
									}
									goto IL_357;
								}
								IL_29F:
								throw new global::System.Exception("read Codeplug failed");
							}
							catch
							{
								throw;
							}
							IL_357:
							goto IL_379;
						}
						finally
						{
							try
							{
								global::System.IO.Directory.Delete(text2, true);
								global::System.IO.File.Delete(tempFileName2);
							}
							catch
							{
							}
						}
					}
					throw new global::System.Exception("read Codeplug failed");
				}
				IL_379:;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadLMRCodeplugFailed, ex.Message);
			}
			return pbaObject;
		}

		// Token: 0x0400001F RID: 31
		private const string Manifest = "UploadPackageContent.xml";

		// Token: 0x04000020 RID: 32
		private const string FileRequest = "filerequest";

		// Token: 0x04000021 RID: 33
		private const string FileType = "file_type";

		// Token: 0x04000022 RID: 34
		private const string FileName = "filename";

		// Token: 0x04000023 RID: 35
		private const string Status = "status";

		// Token: 0x04000024 RID: 36
		private const string LMRCodePlug = "LMRCodePlug";

		// Token: 0x04000025 RID: 37
		private const string Success = "Success";
	}
}
