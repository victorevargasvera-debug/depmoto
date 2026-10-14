using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000008 RID: 8
	public static class Configurator
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002B64 File Offset: 0x00000D64
		public static global::Motorola.Common.LogUtility.ILog GetLogger(string loggerName)
		{
			global::Motorola.Common.LogUtility.ILog result;
			lock (global::Motorola.Common.LogUtility.Configurator.padLock)
			{
				try
				{
					global::Motorola.Common.LogUtility.Configurator.LoadConfig(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
				}
				catch (global::System.Exception e)
				{
					global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
					return null;
				}
				result = (global::Motorola.Common.LogUtility.Configurator.LoggerMap[loggerName] as global::Motorola.Common.LogUtility.ILog);
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public static global::Motorola.Common.LogUtility.IAppender GetDefaultAppender()
		{
			global::Motorola.Common.LogUtility.IAppender defaultAppender;
			lock (global::Motorola.Common.LogUtility.Configurator.padLock)
			{
				if (global::Motorola.Common.LogUtility.Configurator.DefaultAppender != null)
				{
					defaultAppender = global::Motorola.Common.LogUtility.Configurator.DefaultAppender;
				}
				else
				{
					global::Motorola.Common.LogUtility.Configurator.DefaultAppender = new global::Motorola.Common.LogUtility.FileAppender();
					global::Motorola.Common.LogUtility.Configurator.DefaultAppender.Name = "Default Appender";
					global::Motorola.Common.LogUtility.Configurator.DefaultAppender.FileName = "default.log";
					global::Motorola.Common.LogUtility.Configurator.DefaultAppender.MaxSize = 1;
					global::Motorola.Common.LogUtility.Configurator.DefaultAppender.MaxBackup = 3;
					defaultAppender = global::Motorola.Common.LogUtility.Configurator.DefaultAppender;
				}
			}
			return defaultAppender;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002C64 File Offset: 0x00000E64
		public static string GetLogDirectory()
		{
			string logDir;
			lock (global::Motorola.Common.LogUtility.Configurator.padLock)
			{
				if (!global::Motorola.Common.LogUtility.Configurator.DynamiclLogDir)
				{
					try
					{
						global::Motorola.Common.LogUtility.Configurator.LoadConfig(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
					}
				}
				try
				{
					if (!global::System.IO.Directory.Exists(global::Motorola.Common.LogUtility.Configurator.LogDir))
					{
						global::System.IO.Directory.CreateDirectory(global::Motorola.Common.LogUtility.Configurator.LogDir);
					}
				}
				catch (global::System.Exception e2)
				{
					global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e2);
					global::Motorola.Common.LogUtility.Configurator.LogDir = global::Motorola.Common.LogUtility.Configurator.BinDir;
				}
				logDir = global::Motorola.Common.LogUtility.Configurator.LogDir;
			}
			return logDir;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002D08 File Offset: 0x00000F08
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002D39 File Offset: 0x00000F39
		public static string ConfigFilePath
		{
			get
			{
				if (string.IsNullOrEmpty(global::Motorola.Common.LogUtility.Configurator._ConfigFilePath))
				{
					global::Motorola.Common.LogUtility.Configurator._ConfigFilePath = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "/LoggerConfig.xml";
				}
				return global::Motorola.Common.LogUtility.Configurator._ConfigFilePath;
			}
			set
			{
				global::Motorola.Common.LogUtility.Configurator._ConfigFilePath = value;
				global::Motorola.Common.LogUtility.Configurator.IsLoaded = false;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002D47 File Offset: 0x00000F47
		public static void UpdateLogDirectoryInMemory(string path)
		{
			global::Motorola.Common.LogUtility.Configurator.DynamiclLogDir = true;
			if (!global::System.IO.Directory.Exists(path))
			{
				return;
			}
			global::Motorola.Common.LogUtility.Configurator.SetLogDir(path);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002D60 File Offset: 0x00000F60
		public static void SetLogDirectory(string path)
		{
			lock (global::Motorola.Common.LogUtility.Configurator.padLock)
			{
				try
				{
					global::Motorola.Common.LogUtility.Configurator.LoadConfig(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
					if (global::System.IO.Directory.Exists(path))
					{
						if (global::Motorola.Common.LogUtility.Configurator.Doc != null)
						{
							global::System.Xml.XmlNode xmlNode = global::Motorola.Common.LogUtility.Configurator.Doc.SelectSingleNode("//global/directory");
							xmlNode.InnerText = path;
							global::Motorola.Common.LogUtility.Configurator.Doc.Save(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
							global::Motorola.Common.LogUtility.Configurator.IsLoaded = false;
							global::Motorola.Common.LogUtility.Configurator.LoadConfig(global::Motorola.Common.LogUtility.Configurator.ConfigFilePath);
						}
					}
				}
				catch (global::System.Exception e)
				{
					global::Motorola.Common.LogUtility.LoggerUtil.LogInnerException(e);
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E04 File Offset: 0x00001004
		private static void LoadConfig(string configFile)
		{
			if (global::Motorola.Common.LogUtility.Configurator.IsLoaded)
			{
				return;
			}
			global::Motorola.Common.LogUtility.Configurator.IsLoaded = true;
			global::Motorola.Common.LogUtility.Configurator.Doc = new global::System.Xml.XmlDocument();
			global::Motorola.Common.LogUtility.Configurator.Doc.Load(configFile);
			global::System.Xml.XmlNodeList nodes = global::Motorola.Common.LogUtility.Configurator.Doc.SelectNodes("//appender");
			global::Motorola.Common.LogUtility.Configurator.BuildAppenderMap(nodes);
			nodes = global::Motorola.Common.LogUtility.Configurator.Doc.SelectNodes("//logger");
			global::Motorola.Common.LogUtility.Configurator.BuildLoggerMap(nodes);
			global::System.Xml.XmlNode xmlNode = global::Motorola.Common.LogUtility.Configurator.Doc.SelectSingleNode("//global/directory");
			if (xmlNode != null && !global::Motorola.Common.LogUtility.Configurator.DynamiclLogDir)
			{
				global::Motorola.Common.LogUtility.Configurator.SetLogDir(xmlNode.InnerText);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002E85 File Offset: 0x00001085
		private static void SetLogDir(string path)
		{
			global::Motorola.Common.LogUtility.Configurator.LogDir = global::System.Environment.ExpandEnvironmentVariables(path);
			global::Motorola.Common.LogUtility.Configurator.CreateApplicationDataFolderIfNotExisted();
			if (!global::System.IO.Path.IsPathRooted(global::Motorola.Common.LogUtility.Configurator.LogDir))
			{
				global::Motorola.Common.LogUtility.Configurator.LogDir = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(global::Motorola.Common.LogUtility.Configurator.BinDir, global::Motorola.Common.LogUtility.Configurator.LogDir));
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002EBC File Offset: 0x000010BC
		private static void BuildAppenderMap(global::System.Xml.XmlNodeList nodes)
		{
			foreach (object obj in nodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["name"];
				if (xmlAttribute != null)
				{
					global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes["type"];
					if (xmlAttribute2 != null)
					{
						global::System.Xml.XmlAttribute xmlAttribute3 = xmlNode.Attributes["assembly"];
						global::Motorola.Common.LogUtility.IAppender appender = null;
						try
						{
							global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetCallingAssembly();
							if (xmlAttribute3 != null)
							{
								assembly = global::System.Reflection.Assembly.LoadFile(global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(assembly.Location), xmlAttribute3.Value));
							}
							appender = (assembly.CreateInstance(xmlAttribute2.Value) as global::Motorola.Common.LogUtility.IAppender);
							if (!appender.IsEnabled)
							{
								continue;
							}
						}
						catch (global::System.Exception)
						{
							continue;
						}
						appender.Name = xmlAttribute.Value;
						global::System.Xml.XmlNodeList xmlNodeList = xmlNode.SelectNodes("./param");
						foreach (object obj2 in xmlNodeList)
						{
							global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj2;
							global::System.Xml.XmlAttribute xmlAttribute4 = xmlNode2.Attributes["name"];
							if (xmlAttribute4 != null)
							{
								global::System.Xml.XmlAttribute xmlAttribute5 = xmlNode2.Attributes["value"];
								if (xmlAttribute5 != null)
								{
									global::System.Reflection.PropertyInfo property = appender.GetType().GetProperty(xmlAttribute4.Value);
									if (!(property == null))
									{
										object value = null;
										switch (global::System.Type.GetTypeCode(property.PropertyType))
										{
										case global::System.TypeCode.Boolean:
											value = bool.Parse(xmlAttribute5.Value);
											break;
										case global::System.TypeCode.Char:
											value = char.Parse(xmlAttribute5.Value);
											break;
										case global::System.TypeCode.SByte:
											value = sbyte.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Byte:
											value = byte.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Int16:
											value = short.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.UInt16:
											value = ushort.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Int32:
											value = int.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.UInt32:
											value = uint.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Int64:
											value = long.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.UInt64:
											value = ulong.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Single:
											value = float.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Double:
											value = double.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.Decimal:
											value = decimal.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.DateTime:
											value = global::System.DateTime.Parse(xmlAttribute5.Value, global::System.Globalization.CultureInfo.InvariantCulture);
											break;
										case global::System.TypeCode.String:
											value = xmlAttribute5.Value;
											break;
										}
										property.SetValue(appender, value, null);
									}
								}
							}
						}
						global::Motorola.Common.LogUtility.Configurator.AppenderMap[xmlAttribute.Value] = appender;
					}
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000032A8 File Offset: 0x000014A8
		private static void BuildLoggerMap(global::System.Xml.XmlNodeList nodes)
		{
			foreach (object obj in nodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["name"];
				if (xmlAttribute != null)
				{
					global::Motorola.Common.LogUtility.LogImpl logImpl = new global::Motorola.Common.LogUtility.LogImpl();
					logImpl.Name = xmlAttribute.Value;
					global::System.Xml.XmlNodeList xmlNodeList = xmlNode.SelectNodes("appender-ref/@ref");
					foreach (object obj2 in xmlNodeList)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj2;
						global::Motorola.Common.LogUtility.IAppender appender = global::Motorola.Common.LogUtility.Configurator.AppenderMap[xmlNode2.Value] as global::Motorola.Common.LogUtility.IAppender;
						if (appender == null)
						{
							appender = global::Motorola.Common.LogUtility.Configurator.GetDefaultAppender();
						}
						logImpl.AddAppender(appender);
					}
					global::System.Xml.XmlNode xmlNode3 = global::Motorola.Common.LogUtility.Configurator.Doc.SelectSingleNode("//global/level");
					if (xmlNode3 != null)
					{
						try
						{
							logImpl.Level = (global::Motorola.Common.LogUtility.LoggingLevel)global::System.Enum.Parse(typeof(global::Motorola.Common.LogUtility.LoggingLevel), xmlNode3.InnerText, true);
							goto IL_FE;
						}
						catch (global::System.Exception)
						{
							logImpl.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
							goto IL_FE;
						}
						goto IL_F6;
					}
					goto IL_F6;
					IL_FE:
					global::Motorola.Common.LogUtility.Configurator.LoggerMap[xmlAttribute.Value] = logImpl;
					continue;
					IL_F6:
					logImpl.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
					goto IL_FE;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003434 File Offset: 0x00001634
		private static string BinDir
		{
			get
			{
				global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
				if (executingAssembly != null)
				{
					return global::System.IO.Path.GetDirectoryName(executingAssembly.Location);
				}
				executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
				if (executingAssembly != null)
				{
					return global::System.IO.Path.GetDirectoryName(executingAssembly.Location);
				}
				return global::System.Diagnostics.Process.GetCurrentProcess().StartInfo.WorkingDirectory;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003488 File Offset: 0x00001688
		private static void CreateApplicationDataFolderIfNotExisted()
		{
			string text = global::System.IO.Path.Combine(global::System.Environment.ExpandEnvironmentVariables("%ALLUSERSPROFILE%"), "Application Data");
			if (global::System.IO.Directory.Exists(text))
			{
				return;
			}
			string format = "/c mklink /j \"{0}\" \"{1}\" ";
			string text2 = "cmd.exe";
			string text3 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, new object[]
			{
				text,
				global::System.Environment.ExpandEnvironmentVariables("%ALLUSERSPROFILE%")
			});
			using (global::System.Diagnostics.Process process = new global::System.Diagnostics.Process())
			{
				process.StartInfo.WorkingDirectory = global::System.IO.Path.GetDirectoryName(text2);
				process.StartInfo.FileName = text2;
				process.StartInfo.Arguments = text3;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.WindowStyle = global::System.Diagnostics.ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				int exitCode = process.ExitCode;
				if (exitCode != 0)
				{
					throw new global::System.Exception(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Command CMD:[{0} {1}] return code is not 0", new object[]
					{
						text2,
						text3
					}));
				}
				process.Close();
			}
		}

		// Token: 0x04000015 RID: 21
		private const string APPENDER_TAG = "appender";

		// Token: 0x04000016 RID: 22
		private const string PARAM_TAG = "param";

		// Token: 0x04000017 RID: 23
		private const string LOGGER_TAG = "logger";

		// Token: 0x04000018 RID: 24
		private const string APPENDER_REF_TAG = "appender-ref";

		// Token: 0x04000019 RID: 25
		private const string LEVEL_TAG = "level";

		// Token: 0x0400001A RID: 26
		private const string NAME_ATTR = "name";

		// Token: 0x0400001B RID: 27
		private const string TYPE_ATTR = "type";

		// Token: 0x0400001C RID: 28
		private const string VALUE_ATTR = "value";

		// Token: 0x0400001D RID: 29
		private const string REF_ATTR = "ref";

		// Token: 0x0400001E RID: 30
		private const string ASS_ATTR = "assembly";

		// Token: 0x0400001F RID: 31
		private const string XPath_Appender = "//appender";

		// Token: 0x04000020 RID: 32
		private const string XPath_Logger = "//logger";

		// Token: 0x04000021 RID: 33
		private const string XPath_Log_Dir = "//global/directory";

		// Token: 0x04000022 RID: 34
		private const string XPath_Global_Level = "//global/level";

		// Token: 0x04000023 RID: 35
		private static global::System.Collections.Hashtable AppenderMap = new global::System.Collections.Hashtable();

		// Token: 0x04000024 RID: 36
		private static global::System.Collections.Hashtable LoggerMap = new global::System.Collections.Hashtable();

		// Token: 0x04000025 RID: 37
		private static global::Motorola.Common.LogUtility.FileAppender DefaultAppender = null;

		// Token: 0x04000026 RID: 38
		private static global::System.Xml.XmlDocument Doc = null;

		// Token: 0x04000027 RID: 39
		private static bool IsLoaded = false;

		// Token: 0x04000028 RID: 40
		private static string LogDir = global::Motorola.Common.LogUtility.Configurator.BinDir;

		// Token: 0x04000029 RID: 41
		private static bool DynamiclLogDir = false;

		// Token: 0x0400002A RID: 42
		private static readonly object padLock = new object();

		// Token: 0x0400002B RID: 43
		private static string _ConfigFilePath = string.Empty;
	}
}
