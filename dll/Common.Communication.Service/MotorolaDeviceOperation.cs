using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using SwitchOverManager;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000007 RID: 7
	[global::System.ServiceModel.ServiceBehavior(ConcurrencyMode = global::System.ServiceModel.ConcurrencyMode.Multiple, InstanceContextMode = global::System.ServiceModel.InstanceContextMode.PerSession)]
	public class MotorolaDeviceOperation : global::Motorola.Common.Communication.Service.IDeviceOperation
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002C60 File Offset: 0x00000E60
		public global::System.IAsyncResult BeginForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execForceWriteDevice(deviceInfo, pbaObject);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public void EndForceWriteDevice(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public void ForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginForceWriteDevice(deviceInfo, pbaObject, null, null, null);
			this.EndForceWriteDevice(asyncResult);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002CE4 File Offset: 0x00000EE4
		private void _execForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.ForceWriteDevice(pbaObject);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002D40 File Offset: 0x00000F40
		public global::System.IAsyncResult BeginUnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] values, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUnkillRadio(deviceInfo, values);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002D93 File Offset: 0x00000F93
		public void EndUnkillRadio(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002D9C File Offset: 0x00000F9C
		public void UnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] values)
		{
			global::System.IAsyncResult asyncResult = this.BeginUnkillRadio(deviceInfo, values, null, null, null);
			this.EndUnkillRadio(asyncResult);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002DBC File Offset: 0x00000FBC
		private void _execUnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] values)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.UnkillRadio(values);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002E10 File Offset: 0x00001010
		public global::System.IAsyncResult BeginReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadUnkillChallengeValue(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002E5B File Offset: 0x0000105B
		public byte[] EndReadUnkillChallengeValue(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (byte[])global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002E70 File Offset: 0x00001070
		public byte[] ReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadUnkillChallengeValue(deviceInfo, null, null, null);
			return this.EndReadUnkillChallengeValue(asyncResult);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002E90 File Offset: 0x00001090
		private byte[] _execReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "ReadUnkillChallengeValue");
			return motoDevice.ReadUnkillChallengeValue();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002EF4 File Offset: 0x000010F4
		public global::System.IAsyncResult BeginUpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpdateSerialNumber(deviceInfo, serialNumber);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002F47 File Offset: 0x00001147
		public void EndUpdateSerialNumber(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002F50 File Offset: 0x00001150
		public void UpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpdateSerialNumber(deviceInfo, serialNumber, null, null, null);
			this.EndUpdateSerialNumber(asyncResult);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002F70 File Offset: 0x00001170
		private void _execUpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.UpdateSerialNumber(serialNumber);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002FCC File Offset: 0x000011CC
		public global::System.IAsyncResult BeginUpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpdateMACAddress(deviceInfo, macAddress);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000301F File Offset: 0x0000121F
		public void EndUpdateMACAddress(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003028 File Offset: 0x00001228
		public void UpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpdateMACAddress(deviceInfo, macAddress, null, null, null);
			this.EndUpdateMACAddress(asyncResult);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003048 File Offset: 0x00001248
		private void _execUpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.UpdateMACAddress(macAddress);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000030A4 File Offset: 0x000012A4
		public global::System.IAsyncResult BeginSendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSendUpdateIMEType(deviceInfo, ime);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000030F7 File Offset: 0x000012F7
		public void EndSendUpdateIMEType(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003100 File Offset: 0x00001300
		public void SendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime)
		{
			global::System.IAsyncResult asyncResult = this.BeginSendUpdateIMEType(deviceInfo, ime, null, null, null);
			this.EndSendUpdateIMEType(asyncResult);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003120 File Offset: 0x00001320
		private void _execSendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.SendUpdateIMEType(ime);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003180 File Offset: 0x00001380
		public global::System.IAsyncResult BeginSendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSendUpdateDateCode(deviceInfo, dateCode, source);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000031DB File Offset: 0x000013DB
		public void EndSendUpdateDateCode(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000031E4 File Offset: 0x000013E4
		public void SendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source)
		{
			global::System.IAsyncResult asyncResult = this.BeginSendUpdateDateCode(deviceInfo, dateCode, source, null, null, null);
			this.EndSendUpdateIMEType(asyncResult);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003208 File Offset: 0x00001408
		private void _execSendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.SendUpdateDateCode(dateCode, source);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000325C File Offset: 0x0000145C
		public global::System.IAsyncResult BeginCBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execCBIProgramme(deviceInfo);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000032A7 File Offset: 0x000014A7
		public void EndCBIProgramme(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000032B0 File Offset: 0x000014B0
		public void CBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginCBIProgramme(deviceInfo, null, null, null);
			this.EndCBIProgramme(asyncResult);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000032D0 File Offset: 0x000014D0
		private void _execCBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram);
			motoDevice.CBIProgramme();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000032F1 File Offset: 0x000014F1
		private global::Motorola.Common.Communication.Service.OperationAsyncResult newOneOperationAsyncResult(string operationId, global::System.AsyncCallback callback, object state)
		{
			return new global::Motorola.Common.Communication.Service.OperationAsyncResult(operationId, callback, state);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003338 File Offset: 0x00001538
		public global::System.IAsyncResult BeginUpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpgradeFlashStrap(deviceInfo, pbaObject);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000338B File Offset: 0x0000158B
		public void EndUpgradeFlashStrap(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003394 File Offset: 0x00001594
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpgradeFlashStrap(deviceInfo, pbaObject, null, null, null);
			this.EndUpgradeFlashStrap(asyncResult);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000033B4 File Offset: 0x000015B4
		private void _execUpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.UpgradeFlashStrap(pbaObject);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000341C File Offset: 0x0000161C
		public global::System.IAsyncResult BeginUpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpgradeFDT(deviceInfo, destModel, destCPVersion, serialNumber);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000347F File Offset: 0x0000167F
		public void EndUpgradeFDT(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003488 File Offset: 0x00001688
		public void UpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpgradeFDT(deviceInfo, destModel, destCPVersion, serialNumber, null, null, null);
			this.EndUpgradeFDT(asyncResult);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000034AC File Offset: 0x000016AC
		private void _execUpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.UpgradeFDT(destModel, destCPVersion, serialNumber);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000350C File Offset: 0x0000170C
		public global::System.IAsyncResult BeginEraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execEraseRadio(deviceInfo, sections);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000035A0 File Offset: 0x000017A0
		public global::System.IAsyncResult BeginEraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execEraseRadioFromTo(deviceInfo, startAddress, size);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000035FB File Offset: 0x000017FB
		public void EndEraseRadio(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003604 File Offset: 0x00001804
		public void EndEraseRadioFromTo(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003610 File Offset: 0x00001810
		public void EraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections)
		{
			global::System.IAsyncResult asyncResult = this.BeginEraseRadio(deviceInfo, sections, null, null, null);
			this.EndEraseRadio(asyncResult);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003630 File Offset: 0x00001830
		public void EraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			global::System.IAsyncResult asyncResult = this.BeginEraseRadioFromTo(deviceInfo, startAddress, size, null, null, null);
			this.EndEraseRadioFromTo(asyncResult);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00003654 File Offset: 0x00001854
		private void _execEraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.EraseRadio(sections);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003674 File Offset: 0x00001874
		private void _execEraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.EraseRadioFromTo(startAddress, size);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000036D4 File Offset: 0x000018D4
		public global::System.IAsyncResult BeginWriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execWriteRamdownloader(deviceInfo, filePath);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003727 File Offset: 0x00001927
		public bool EndWriteRamdownloader(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000373C File Offset: 0x0000193C
		public bool WriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteRamdownloader(deviceInfo, filePath, null, null, null);
			return this.EndWriteRamdownloader(asyncResult);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000375C File Offset: 0x0000195C
		private bool _execWriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			return motoDevice.WriteRamdownloader(filePath);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000037B8 File Offset: 0x000019B8
		public global::System.IAsyncResult BeginReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadImage(deviceInfo, images);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000380B File Offset: 0x00001A0B
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData EndReadImage(global::System.IAsyncResult asyncResult)
		{
			return (global::Motorola.Common.Communication.Pba.UpdateDeviceData)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003818 File Offset: 0x00001A18
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadImage(deviceInfo, images, null, null, null);
			return this.EndReadImage(asyncResult);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003838 File Offset: 0x00001A38
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData _execReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			return motoDevice.ReadImage(images);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003894 File Offset: 0x00001A94
		public global::System.IAsyncResult BeginGetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execGetFdtInfo(deviceInfo, fdtType);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000038E7 File Offset: 0x00001AE7
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo EndGetFdtInfo(global::System.IAsyncResult asyncResult)
		{
			return (global::Motorola.Common.Communication.CommonUtil.FDTInfo)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000038F4 File Offset: 0x00001AF4
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			global::System.IAsyncResult asyncResult = this.BeginGetFdtInfo(deviceInfo, fdtType, null, null, null);
			return this.EndGetFdtInfo(asyncResult);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003914 File Offset: 0x00001B14
		private global::Motorola.Common.Communication.CommonUtil.FDTInfo _execGetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			return motoDevice.GetFdtInfo(fdtType);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003974 File Offset: 0x00001B74
		public global::System.IAsyncResult BeginReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadImageByAddress(deviceInfo, startAddress, size);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000039CF File Offset: 0x00001BCF
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage EndReadImageByAddress(global::System.IAsyncResult asyncResult)
		{
			return (global::Motorola.Common.Communication.CommonUtil.MemoryImage)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000039DC File Offset: 0x00001BDC
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadImageByAddress(deviceInfo, startAddress, size, null, null, null);
			return this.EndReadImageByAddress(asyncResult);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003A00 File Offset: 0x00001C00
		private global::Motorola.Common.Communication.CommonUtil.MemoryImage _execReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadImageByAddress(startAddress, size);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003A5C File Offset: 0x00001C5C
		public global::System.IAsyncResult BeginReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadFilesListInDir(deviceInfo, dir);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003AAF File Offset: 0x00001CAF
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> EndReadFilesListInDir(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadFilesListInDir(deviceInfo, dir, null, null, null);
			return this.EndReadFilesListInDir(asyncResult);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003AE4 File Offset: 0x00001CE4
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> _execReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadFilesListInDir(dir);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003B40 File Offset: 0x00001D40
		public global::System.IAsyncResult BeginReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadFile(deviceInfo, file);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003B93 File Offset: 0x00001D93
		public global::Motorola.Common.Communication.Pba.FileItem EndReadFile(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.FileItem)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadFile(deviceInfo, file, null, null, null);
			return this.EndReadFile(asyncResult);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003BC8 File Offset: 0x00001DC8
		private global::Motorola.Common.Communication.Pba.FileItem _execReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadFile(file);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003C24 File Offset: 0x00001E24
		public global::System.IAsyncResult BeginWriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execWriteFile(deviceInfo, file);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003C77 File Offset: 0x00001E77
		public void EndWriteFile(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003C88 File Offset: 0x00001E88
		public void WriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteFile(deviceInfo, file, null, null, null);
			this.EndWriteFile(asyncResult);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003CA8 File Offset: 0x00001EA8
		private void _execWriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.WriteFile(file);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003D04 File Offset: 0x00001F04
		public global::System.IAsyncResult BeginDeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execDeleteFile(deviceInfo, file);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003D57 File Offset: 0x00001F57
		public void EndDeleteFile(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003D68 File Offset: 0x00001F68
		public void DeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::System.IAsyncResult asyncResult = this.BeginDeleteFile(deviceInfo, file, null, null, null);
			this.EndDeleteFile(asyncResult);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003D88 File Offset: 0x00001F88
		private void _execDeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.DeleteFile(file);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public global::System.IAsyncResult BeginGetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execGetFileOrDirSize(deviceInfo, fileOrDir);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003E3B File Offset: 0x0000203B
		public long EndGetFileOrDirSize(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (long)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003E50 File Offset: 0x00002050
		public long GetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			global::System.IAsyncResult asyncResult = this.BeginGetFileOrDirSize(deviceInfo, fileOrDir, null, null, null);
			return this.EndGetFileOrDirSize(asyncResult);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003E70 File Offset: 0x00002070
		private long _execGetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.GetFileOrDirSize(fileOrDir);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003EC4 File Offset: 0x000020C4
		public global::System.IAsyncResult BeginReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadLanguagePacksInfo(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003F0F File Offset: 0x0000210F
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadLanguagePacksInfo(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003F24 File Offset: 0x00002124
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadLanguagePacksInfo(deviceInfo, null, null, null);
			return this.EndReadLanguagePacksInfo(asyncResult);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00003F44 File Offset: 0x00002144
		private global::Motorola.Common.Communication.Pba.LanguagePackData _execReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadLanguagePacksInfo();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003FA0 File Offset: 0x000021A0
		public global::System.IAsyncResult BeginWriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execWriteLanguagePacks(deviceInfo, languagePackData);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003FF3 File Offset: 0x000021F3
		public void EndWriteLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004004 File Offset: 0x00002204
		public void WriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndWriteLanguagePacks(asyncResult);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004024 File Offset: 0x00002224
		private void _execWriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.WriteLanguagePacks(languagePackData);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004080 File Offset: 0x00002280
		public global::System.IAsyncResult BeginDeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execDeleteLanguagePacks(deviceInfo, languagePackData);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000040D3 File Offset: 0x000022D3
		public void EndDeleteLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000040E4 File Offset: 0x000022E4
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::System.IAsyncResult asyncResult = this.BeginDeleteLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndDeleteLanguagePacks(asyncResult);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004104 File Offset: 0x00002304
		private void _execDeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.DeleteLanguagePacks(languagePackData);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004158 File Offset: 0x00002358
		public global::System.IAsyncResult BeginReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadRadioFirmwareDefinedFlashPacks(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000041A3 File Offset: 0x000023A3
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadRadioFirmwareDefinedFlashPacks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000041B8 File Offset: 0x000023B8
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadRadioFirmwareDefinedFlashPacks(deviceInfo, null, null, null);
			return this.EndReadRadioFirmwareDefinedFlashPacks(asyncResult);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000041D8 File Offset: 0x000023D8
		private global::Motorola.Common.Communication.Pba.LanguagePackData _execReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.Pba.LanguagePackData result = null;
			if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
			{
				result = (motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).ReadRadioFirmwareDefinedFlashPacks();
			}
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000423C File Offset: 0x0000243C
		public global::System.IAsyncResult BeginReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadTTSLanguagePacksInfo(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004287 File Offset: 0x00002487
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadTTSLanguagePacksInfo(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000429C File Offset: 0x0000249C
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadTTSLanguagePacksInfo(deviceInfo, null, null, null);
			return this.EndReadTTSLanguagePacksInfo(asyncResult);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000042BC File Offset: 0x000024BC
		private global::Motorola.Common.Communication.Pba.LanguagePackData _execReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadTTSLanguagePacksInfo();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004318 File Offset: 0x00002518
		public global::System.IAsyncResult BeginWriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execWriteTTSLanguagePacks(deviceInfo, languagePackData);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000436B File Offset: 0x0000256B
		public void EndWriteTTSLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000437C File Offset: 0x0000257C
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteTTSLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndWriteTTSLanguagePacks(asyncResult);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000439C File Offset: 0x0000259C
		private void _execWriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.WriteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000043F8 File Offset: 0x000025F8
		public global::System.IAsyncResult BeginDeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execDeleteTTSLanguagePacks(deviceInfo, languagePackData);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000444B File Offset: 0x0000264B
		public void EndDeleteTTSLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000445C File Offset: 0x0000265C
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::System.IAsyncResult asyncResult = this.BeginDeleteTTSLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndDeleteTTSLanguagePacks(asyncResult);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000447C File Offset: 0x0000267C
		private void _execDeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.DeleteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000044D4 File Offset: 0x000026D4
		public global::System.IAsyncResult BeginTurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execTurnOffRadio(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000451F File Offset: 0x0000271F
		public bool EndTurnOffRadio(global::System.IAsyncResult asyncResult)
		{
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000452C File Offset: 0x0000272C
		public bool TurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginTurnOffRadio(deviceInfo, null, null, null);
			return this.EndTurnOffRadio(asyncResult);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000454C File Offset: 0x0000274C
		private bool _execTurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.TurnOffRadio;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000045CC File Offset: 0x000027CC
		public global::System.IAsyncResult BeginRemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execRemoveRadio(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004617 File Offset: 0x00002817
		public bool EndRemoveRadio(global::System.IAsyncResult asyncResult)
		{
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004624 File Offset: 0x00002824
		public bool RemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginRemoveRadio(deviceInfo, null, null, null);
			return this.EndRemoveRadio(asyncResult);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004644 File Offset: 0x00002844
		private bool _execRemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.RemoveRadio;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000046C4 File Offset: 0x000028C4
		public global::System.IAsyncResult BeginLLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execLLPIsAvailable(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000470F File Offset: 0x0000290F
		public bool EndLLPIsAvailable(global::System.IAsyncResult asyncResult)
		{
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000471C File Offset: 0x0000291C
		public bool LLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginLLPIsAvailable(deviceInfo, null, null, null);
			return this.EndLLPIsAvailable(asyncResult);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000473C File Offset: 0x0000293C
		private bool _execLLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.LLPIsAvailable;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000047C0 File Offset: 0x000029C0
		public global::System.IAsyncResult BeginSwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSwitchRadioMode(deviceInfo, mode);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004813 File Offset: 0x00002A13
		public void EndSwitchRadioMode(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000481C File Offset: 0x00002A1C
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			global::System.IAsyncResult asyncResult = this.BeginSwitchRadioMode(deviceInfo, mode, null, null, null);
			this.EndSwitchRadioMode(asyncResult);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000483C File Offset: 0x00002A3C
		private void _execSwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.SwitchRadioMode(mode);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004890 File Offset: 0x00002A90
		public global::System.IAsyncResult BeginUpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpdateRadioDisplay(deviceInfo);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000048DB File Offset: 0x00002ADB
		public void EndUpdateRadioDisplay(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000048E4 File Offset: 0x00002AE4
		public void UpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpdateRadioDisplay(deviceInfo, null, null, null);
			this.EndUpdateRadioDisplay(asyncResult);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00004904 File Offset: 0x00002B04
		private void _execUpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			motoDevice.UpdateRadioDisplay();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004960 File Offset: 0x00002B60
		public global::System.IAsyncResult BeginWriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execWriteSoftware(deviceInfo, pbaObject);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000049B3 File Offset: 0x00002BB3
		public void EndWriteSoftware(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000049BC File Offset: 0x00002BBC
		public void WriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteSoftware(deviceInfo, pbaObject, null, null, null);
			this.EndWriteSoftware(asyncResult);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000049DC File Offset: 0x00002BDC
		private void _execWriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
			{
				(motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).WriteSoftware(pbaObject.FWpath);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004A48 File Offset: 0x00002C48
		public global::System.IAsyncResult BeginSendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSendFPGAErase(deviceInfo, fileType);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004A9B File Offset: 0x00002C9B
		public void EndSendFPGAErase(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public void SendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::System.IAsyncResult asyncResult = this.BeginSendFPGAErase(deviceInfo, fileType, null, null, null);
			this.EndSendFPGAErase(asyncResult);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004AC4 File Offset: 0x00002CC4
		private void _execSendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			motoDevice.SendFPGAErase(fileType);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00004B20 File Offset: 0x00002D20
		public global::System.IAsyncResult BeginSendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSendFPGAReset(deviceInfo, fileType);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004B73 File Offset: 0x00002D73
		public void EndSendFPGAReset(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004B7C File Offset: 0x00002D7C
		public void SendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::System.IAsyncResult asyncResult = this.BeginSendFPGAReset(deviceInfo, fileType, null, null, null);
			this.EndSendFPGAReset(asyncResult);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004B9C File Offset: 0x00002D9C
		private void _execSendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			motoDevice.SendFPGAReset(fileType);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004BBC File Offset: 0x00002DBC
		public bool WaitForPSUUpgrade(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "WaitForPSUUpgrade");
			return true;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004C1C File Offset: 0x00002E1C
		public global::System.IAsyncResult BeginUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execUpdateDevice(deviceInfo, pbaObject);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004C6F File Offset: 0x00002E6F
		public void EndUpdateDevice(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004C80 File Offset: 0x00002E80
		public void UpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpdateDevice(deviceInfo, pbaObject, null, null, null);
			this.EndUpdateDevice(asyncResult);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00004CA0 File Offset: 0x00002EA0
		private void _execUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "UpdateDevice");
			motoDevice.UpdateDevice(pbaObject);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004D10 File Offset: 0x00002F10
		public global::System.IAsyncResult BeginValidateRemotePassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string username, string password, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execValidateRemotePassword(deviceInfo, username, password);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004D6B File Offset: 0x00002F6B
		public bool EndValidateRemotePassword(global::System.IAsyncResult asyncResult)
		{
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004D78 File Offset: 0x00002F78
		public bool ValidateRemotePassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string username, string password)
		{
			global::System.IAsyncResult asyncResult = this.BeginValidateRemotePassword(deviceInfo, username, password, null, null, null);
			return this.EndValidateRemotePassword(asyncResult);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004D9C File Offset: 0x00002F9C
		private bool _execValidateRemotePassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string username, string password)
		{
			global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDevice pcrremoteDevice = (global::Motorola.Common.Communication.CommunicationManager.PCRRemoteDevice)this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.RemoteProgram);
			return pcrremoteDevice.ValidateRemotePassword(username, password);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004E00 File Offset: 0x00003000
		public global::System.IAsyncResult BeginValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execValidateLocalPassword(deviceInfo, password);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00004E53 File Offset: 0x00003053
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus EndValidateLocalPassword(global::System.IAsyncResult asyncResult)
		{
			return (global::Motorola.Common.Communication.CommonUtil.PasswordStatus)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004E60 File Offset: 0x00003060
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password)
		{
			global::System.IAsyncResult asyncResult = this.BeginValidateLocalPassword(deviceInfo, password, null, null, null);
			return this.EndValidateLocalPassword(asyncResult);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004E80 File Offset: 0x00003080
		private global::Motorola.Common.Communication.CommonUtil.PasswordStatus _execValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			return motoDevice.ValidateLocalPassword(password);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004EE4 File Offset: 0x000030E4
		public global::System.IAsyncResult BeginEnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execEnableFxFeature(deviceInfo, xmlHashInput, featureCodeIds);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00004F3F File Offset: 0x0000313F
		public void EndEnableFxFeature(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004F48 File Offset: 0x00003148
		public void EnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			global::System.IAsyncResult asyncResult = this.BeginEnableFxFeature(deviceInfo, xmlHashInput, featureCodeIDs, null, null, null);
			this.EndEnableFxFeature(asyncResult);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004F6C File Offset: 0x0000316C
		private void _execEnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature);
			motoDevice.EnableFeature(deviceInfo.SoftwareVersion, deviceInfo.SerialNumber, xmlHashInput, featureCodeIDs);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004FD8 File Offset: 0x000031D8
		public global::System.IAsyncResult BeginReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadHashInputAndValidate(deviceInfo, validatePba, blockList);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005033 File Offset: 0x00003233
		public string EndReadHashInputAndValidate(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (string)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005048 File Offset: 0x00003248
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadHashInputAndValidate(deviceInfo, validatePba, blockList, null, null, null);
			return this.EndReadHashInputAndValidate(asyncResult);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000506C File Offset: 0x0000326C
		private string _execReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadHashInputAndValidate(validatePba, blockList);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000050C4 File Offset: 0x000032C4
		public global::System.IAsyncResult BeginReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadDeviceInfo(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000510F File Offset: 0x0000330F
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo EndReadDeviceInfo(global::System.IAsyncResult asyncResult)
		{
			return (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000511C File Offset: 0x0000331C
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadDeviceInfo(deviceInfo, null, null, null);
			return this.EndReadDeviceInfo(asyncResult);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000513C File Offset: 0x0000333C
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo _execReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create);
			return motoDevice.ReadDeviceInfo();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005190 File Offset: 0x00003390
		public global::System.IAsyncResult BeginReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadExtendedDeviceInfo(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000051DB File Offset: 0x000033DB
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo EndReadExtendedDeviceInfo(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000051F0 File Offset: 0x000033F0
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadExtendedDeviceInfo(deviceInfo, null, null, null);
			return this.EndReadExtendedDeviceInfo(asyncResult);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005210 File Offset: 0x00003410
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo _execReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "ReadExtendedDeviceInfo");
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo result;
			if (motoDevice.DifferentialWriteCapableRadio)
			{
				result = motoDevice.ExtendedDeviceInfo;
			}
			else
			{
				result = motoDevice.ReadExtendedDeviceInfo();
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005298 File Offset: 0x00003498
		public global::System.IAsyncResult BeginReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadDevice(deviceInfo, referencePba);
			};
			operationAsyncResult.CancelReading += delegate(object sender, global::System.EventArgs args)
			{
				this._execCancelReadDevice(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000052FD File Offset: 0x000034FD
		public global::Motorola.Common.Communication.Pba.PbaObject EndReadDevice(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005310 File Offset: 0x00003510
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadDevice(deviceInfo, referencePba, deviceInfo.OperationId, null, null);
			return this.EndReadDevice(asyncResult);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005338 File Offset: 0x00003538
		private global::Motorola.Common.Communication.Pba.PbaObject _execReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "ReadDevice");
			return motoDevice.ReadDevice(referencePba);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005363 File Offset: 0x00003563
		private void _execCancelReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			this.targetDevice = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(deviceInfo);
			if (this.targetDevice != null)
			{
				this.targetDevice.WaitForCancelReading();
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000053C8 File Offset: 0x000035C8
		public global::System.IAsyncResult BeginReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadBlocks(deviceInfo, blockList);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000541B File Offset: 0x0000361B
		public global::Motorola.Common.Communication.Pba.PbaObject EndReadBlocks(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005430 File Offset: 0x00003630
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadBlocks(deviceInfo, blockList, null, null, null);
			return this.EndReadBlocks(asyncResult);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005450 File Offset: 0x00003650
		private global::Motorola.Common.Communication.Pba.PbaObject _execReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.ReadBlocks<object>((global::System.Collections.Generic.ICollection<object>)blockList);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000054B4 File Offset: 0x000036B4
		public global::System.IAsyncResult BeginWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execWriteDevice(deviceInfo, pbaObject);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005507 File Offset: 0x00003707
		public global::Motorola.Common.Communication.Pba.PbaObject EndWriteDevice(global::System.IAsyncResult asyncResult)
		{
			this.FreeDeviceIfClientDisable();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000551C File Offset: 0x0000371C
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteDevice(deviceInfo, pbaObject, null, null, null);
			return this.EndWriteDevice(asyncResult);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000553C File Offset: 0x0000373C
		private global::Motorola.Common.Communication.Pba.PbaObject _execWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.LogFunctionCall(motoDevice, "WriteDevice");
			global::Motorola.Common.Communication.Pba.PbaObject result;
			if (deviceInfo == null || deviceInfo.ConnectionInfo == null || deviceInfo.ConnectionInfo.AuthInfo == null)
			{
				result = motoDevice.WriteDevice(pbaObject, null);
			}
			else
			{
				result = motoDevice.WriteDevice(pbaObject, deviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID);
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000055D8 File Offset: 0x000037D8
		public global::System.IAsyncResult BeginWriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execWriteImage(deviceInfo, image);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000562B File Offset: 0x0000382B
		public void EndWriteImage(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005634 File Offset: 0x00003834
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			global::System.IAsyncResult asyncResult = this.BeginWriteImage(deviceInfo, image, null, null, null);
			this.EndWriteImage(asyncResult);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005654 File Offset: 0x00003854
		private void _execWriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			motoDevice.WriteImage(image);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000056BC File Offset: 0x000038BC
		public global::System.IAsyncResult BeginReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execReadCPData(deviceInfo, blockID, offset, size);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000571F File Offset: 0x0000391F
		public byte[] EndReadCPData(global::System.IAsyncResult asyncResult)
		{
			return (byte[])global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000572C File Offset: 0x0000392C
		public byte[] ReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size)
		{
			global::System.IAsyncResult asyncResult = this.BeginReadCPData(deviceInfo, blockID, offset, size, null, null, null);
			return this.EndReadCPData(asyncResult);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00005750 File Offset: 0x00003950
		private byte[] _execReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size)
		{
			byte[] result = null;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
			{
				result = (motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).ReadCPData(blockID, offset, (ushort)size);
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000057C0 File Offset: 0x000039C0
		public global::System.IAsyncResult BeginGeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execGeneralOperation(deviceInfo, pbaObject);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005813 File Offset: 0x00003A13
		public void EndGeneralOperation(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000581C File Offset: 0x00003A1C
		public void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.IAsyncResult asyncResult = this.BeginGeneralOperation(deviceInfo, pbaObject, null, null, null);
			this.EndGeneralOperation(asyncResult);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000583C File Offset: 0x00003A3C
		private void _execGeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
			{
				(motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).GeneralOperation(pbaObject);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000586B File Offset: 0x00003A6B
		public MotorolaDeviceOperation()
		{
			this.progressIndicator = new global::Motorola.Common.Communication.Service.DeviceProgressIndicator();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("New Device Operation Service Created.", new object[0]);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000589E File Offset: 0x00003A9E
		public MotorolaDeviceOperation(global::Motorola.Common.Communication.Service.IOperationServiceEvent serviceEvent)
		{
			this.progressIndicator = new global::Motorola.Common.Communication.Service.DeviceProgressIndicator(serviceEvent);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("New Device Operation Service Created.", new object[0]);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000058D4 File Offset: 0x00003AD4
		public bool CancelOperation(string operationId)
		{
			bool flag = this.operationController.CancelPendingOperation(operationId);
			if (!flag)
			{
				flag = this.operationController.CancelReadingOperation(operationId);
			}
			return flag;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00005944 File Offset: 0x00003B44
		public global::System.IAsyncResult BeginOpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execOpenSession(deviceInfo, operationType, sessionParameter);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000599F File Offset: 0x00003B9F
		public ushort EndOpenSession(global::System.IAsyncResult asyncResult)
		{
			return (ushort)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000059AC File Offset: 0x00003BAC
		public ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::System.IAsyncResult asyncResult = this.BeginOpenSession(deviceInfo, operationType, sessionParameter, null, null, null);
			return this.EndOpenSession(asyncResult);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000059D0 File Offset: 0x00003BD0
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			global::System.IAsyncResult asyncResult = this.BeginUpdateProgrammingStatus(devInfo, status, sessionID);
			return this.EndUpdateProgrammingStatus(asyncResult);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00005A34 File Offset: 0x00003C34
		private global::System.IAsyncResult BeginUpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(null, null, null);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._execUpdateProgrammingStatus(devInfo, status, sessionID);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005A8C File Offset: 0x00003C8C
		private bool EndUpdateProgrammingStatus(global::System.IAsyncResult asyncResult)
		{
			return (bool)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005A9C File Offset: 0x00003C9C
		private bool _execUpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.InitializeMotoDevice(devInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return motoDevice.UpdateProgrammingStatus(status, sessionID);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00005ABC File Offset: 0x00003CBC
		private ushort _execOpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			if (deviceInfo.RadioID != null && deviceInfo.SerialNumber != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Trying to OpenSession on {0} - {1}", new object[]
				{
					deviceInfo.RadioID,
					deviceInfo.SerialNumber
				});
			}
			bool flag = false;
			ushort num = 0;
			this.targetDevice = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(deviceInfo);
			if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232 && this.targetDevice == null)
			{
				return 99;
			}
			if (this.targetDevice == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			}
			if (this.targetDevice.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			}
			string text = "Unknown";
			try
			{
				text = this.targetDevice.DeviceInfo.RadioID;
				num = this.targetDevice.OpenSession(operationType, sessionParameter);
				flag = true;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in OpenSession {0} - {1}", new object[]
				{
					text,
					ex.Message
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in OpenSession {0} - {1}", new object[]
				{
					text,
					ex2.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened, ex2);
			}
			finally
			{
				if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232 && (this.targetDevice as global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device).CreateState)
				{
					if (string.IsNullOrEmpty(deviceInfo.OperationId))
					{
						global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.AddDevice(this.targetDevice);
					}
					else
					{
						string rs232PortName = (this.targetDevice as global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device).GetRS232PortName();
						if (!string.IsNullOrEmpty(rs232PortName))
						{
							lock (global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.Instance.RS232DevCreateStatusDic)
							{
								string portPlusTimeStamp = rs232PortName + deviceInfo.OperationId;
								global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus rs232DeviceCreateStatus = global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.Instance.GetRS232DevCreateStatus(portPlusTimeStamp);
								if (rs232DeviceCreateStatus == global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.CREATING)
								{
									global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.Instance.UpdateRS232DevCreateStatus(portPlusTimeStamp, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.CREATED);
									rs232DeviceCreateStatus = global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.CREATED;
								}
								if (rs232DeviceCreateStatus == global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.CREATED)
								{
									global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.AddDevice(this.targetDevice);
								}
							}
						}
					}
				}
				if (!flag)
				{
					this._execCloseSession(this.targetDevice.DeviceInfo, true);
				}
			}
			string text2 = string.Empty;
			if (this.targetDevice.DeviceInfo.ConnectionInfo != null)
			{
				text2 = this.targetDevice.DeviceInfo.ConnectionInfo.UniqueAddress;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("OpenSession {0} on the device {1}, IP={2}", new object[]
			{
				num,
				text,
				text2
			});
			return num;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public global::System.IAsyncResult BeginCloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execCloseSession(deviceInfo, pendingDeploy);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00005DFB File Offset: 0x00003FFB
		public void EndCloseSession(global::System.IAsyncResult asyncResult)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005E04 File Offset: 0x00004004
		public void CloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy)
		{
			global::System.IAsyncResult asyncResult = this.BeginCloseSession(deviceInfo, pendingDeploy, null, null, null);
			this.EndCloseSession(asyncResult);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00005E24 File Offset: 0x00004024
		private void _execCloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy)
		{
			if (deviceInfo.RadioID != null && deviceInfo.SerialNumber != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Trying to CloseSession on {0} - {1} - {2}", new object[]
				{
					deviceInfo.RadioID,
					deviceInfo.SerialNumber,
					pendingDeploy
				});
			}
			if (this.targetDevice == null)
			{
				return;
			}
			if (deviceInfo.ConnectionInfo.SessionID != this.targetDevice.DeviceInfo.ConnectionInfo.SessionID)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in CloseSession - session id mismatch : {0} vs {1} on the device {2}", new object[]
				{
					deviceInfo.ConnectionInfo.SessionID,
					this.targetDevice.DeviceInfo.ConnectionInfo.SessionID,
					deviceInfo.RadioID
				});
				return;
			}
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.RemoveNonPlugPlayDevice(this.targetDevice.DeviceInfo.RadioID);
				this.targetDevice.CloseSession(pendingDeploy);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail)
				{
					throw;
				}
				if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure)
				{
					throw;
				}
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in CloseSession {0} - {1}", new object[]
				{
					deviceInfo.RadioID,
					ex2.Message
				});
			}
			finally
			{
				this.targetDevice = null;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005FD4 File Offset: 0x000041D4
		public global::System.IAsyncResult BeginQueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, state);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				operationAsyncResult2.Output = this._queryRadioUpdateStatus(deviceInfo);
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000601F File Offset: 0x0000421F
		private byte _queryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			return this.targetDevice.QueryRadioUpdateStatus();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000602C File Offset: 0x0000422C
		public byte EndQueryRadioUpdateStatus(global::System.IAsyncResult asyncResult)
		{
			return (byte)global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(asyncResult);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000603C File Offset: 0x0000423C
		public byte QueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::System.IAsyncResult asyncResult = this.BeginQueryRadioUpdateStatus(deviceInfo, null, null, null);
			return this.EndQueryRadioUpdateStatus(asyncResult);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000060A4 File Offset: 0x000042A4
		public global::System.IAsyncResult BeginSwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option, string operationId, global::System.AsyncCallback callback, object asyncState)
		{
			global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult = this.newOneOperationAsyncResult(operationId, callback, asyncState);
			operationAsyncResult.Operation += delegate(object sender, global::System.EventArgs args)
			{
				global::Motorola.Common.Communication.Service.OperationAsyncResult operationAsyncResult2 = sender as global::Motorola.Common.Communication.Service.OperationAsyncResult;
				this._execSwitchOver(deviceInfo, sessionID, delayTime, option);
				operationAsyncResult2.Output = null;
			};
			this.operationController.AddPendingOperation(operationAsyncResult);
			return operationAsyncResult;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00006107 File Offset: 0x00004307
		public void EndSwitchOver(global::System.IAsyncResult result)
		{
			global::Motorola.Common.Communication.Service.OperationController.GetOperationResult(result);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00006110 File Offset: 0x00004310
		public void SwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option)
		{
			global::System.IAsyncResult result = this.BeginSwitchOver(deviceInfo, sessionID, delayTime, option, null, null, null);
			this.EndSwitchOver(result);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00006133 File Offset: 0x00004333
		private void _execSwitchOver(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, uint delayTime, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption option)
		{
			global::SwitchOverManager.SwitchOverManager.Instance.SwitchOver(deviceInfo, sessionID, delayTime, option);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00006144 File Offset: 0x00004344
		private global::Motorola.Common.Communication.IMotoDevice InitializeMotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (this.targetDevice == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			}
			this.targetDevice.Init(deviceInfo, operation, this.progressIndicator);
			return this.targetDevice;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00006174 File Offset: 0x00004374
		private static global::Motorola.Common.Communication.IMotoDevice FindMotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			string managedRadioId = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetManagedRadioId(deviceInfo);
			global::Motorola.Common.Communication.IMotoDevice device = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.GetDevice(managedRadioId);
			if (device == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			}
			return device;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000061A8 File Offset: 0x000043A8
		private void FreeDeviceIfClientDisable()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000061AC File Offset: 0x000043AC
		private static void LogFunctionCall(global::Motorola.Common.Communication.IMotoDevice motoDevice, string functionName)
		{
			if (motoDevice == null)
			{
				return;
			}
			int num = 0;
			string text = string.Empty;
			if (motoDevice.DeviceInfo != null && motoDevice.DeviceInfo.ConnectionInfo != null)
			{
				num = (int)motoDevice.DeviceInfo.ConnectionInfo.SessionID;
				text = motoDevice.DeviceInfo.ConnectionInfo.UniqueAddress;
			}
			if (motoDevice.DeviceInfo != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(functionName + " on device {0}, sessionID={1}, IP={2}", new object[]
				{
					motoDevice.DeviceInfo.RadioID,
					num,
					text
				});
			}
		}

		// Token: 0x0400001B RID: 27
		private global::Motorola.Common.Communication.Service.OperationController operationController = global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.Service.OperationController>.Instance();

		// Token: 0x0400001C RID: 28
		private global::Motorola.Common.Communication.IProgressIndicator progressIndicator;

		// Token: 0x0400001D RID: 29
		private global::Motorola.Common.Communication.IMotoDevice targetDevice;
	}
}
