using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000079 RID: 121
	public static class SbepOpResultToCommRC
	{
		// Token: 0x060002CF RID: 719 RVA: 0x0000E250 File Offset: 0x0000C450
		public static global::Motorola.Common.Communication.CommonUtil.CommRC Covert(global::Motorola.Common.Communication.TetraMsgOpResult opResult)
		{
			switch (opResult)
			{
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1012_PR_CommErrSBEPTimeOut;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NOACKNOWLEDGE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1007_PR_CommErrSBEPNoAcknowledge;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ACK:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1023_PR_CommErrSBEPACK;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NACK:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1006_PR_CommErrSBEPNack;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1000_PR_CommErrSBEPGeneric;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_MSG_WRONG_FORMAT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1005_PR_CommErrSBEPMSGWrongFormat;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_MSG_CHECKSUM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1004_PR_CommErrSBEPMSGCheckSumError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS:
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS:
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_SUCCESS:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_INSUFFICIENT_BUFFER:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1003_PR_CommErrSBEPInsufficientBuffer;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1021_PR_CommErrSBEPWrongParameter;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SEND_MESSAGE_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1011_PR_CommErrSBEPSendMessageError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_RECEIVE_MESSAGE_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1010_PR_CommErrSBEPReceiveMessageError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_TYPE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1016_PR_CommErrSBEPUnsupportedType;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_REPLY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNKNOWN_REPLY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1014_PR_CommErrSBEPUnknownReply;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_CANNOT_OPEN_PIPE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1002_PR_CommErrSBEPCannotOpenPipe;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_COMM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1017_PR_CommErrSBEPWriteCommError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1020_PR_CommErrSBEPWriteTimeOut;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_COMM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1008_PR_CommErrSBEPReadCommError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_READ_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1009_PR_CommErrSBEPReadTimeOut;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_BAD_WRITE_REPLY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1001_PR_CommErrSBEPBadWriteReply;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNDEFINED_WRITE_REPLY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1013_PR_CommErrSBEPUndefinedWriteReply;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_ACK:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1000_PR_CommErrSBEPGeneric;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NACK:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1018_PR_CommErrSBEPWriteNack;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRITE_NOACKNOWLEDGE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1019_PR_CommErrSBEPWriteNoAcknowledge;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NONE_COMM_PIPE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1022_PR_CommErrSBEPNoneCommPipe;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1024_PR_CommErrRPMsgWrongFormat;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1025_PR_CommErrRPWrongParameter;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRITE_COMM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1026_PR_CommErrRPWriteCommError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRITE_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1027_PR_CommErrRPWriteTimeout;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_READ_COMM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1028_PR_CommErrRPReadCommError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_READ_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1029_PR_CommErrRPReadTimeout;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_NONE_COMM_PIPE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1030_PR_CommErrRPNoneCommPipe;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_REJECTED:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1031_PR_CommErrRPMsgRejected;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_REJCT_BAD_BATTERY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1032_PR_CommErrRPRejectBadBattery;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_REJCT_RP_EMERGENCY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1033_PR_CommErrRPRejectRPEmergency;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1034_PR_CommErrRPInvalidID;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_RECEIVE_MESSAGE_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1035_PR_CommErrRPReceiveMsgError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID_FORMAT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1036_PR_CommErrRPInvalidIDFormat;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_MODE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1037_PR_CommErrRPInvalidMode;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_UNSUPPORTED_PROTOCOL:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1038_PR_CommErrRPUnsupportedProtocol;
			case global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_NOT_ENOUGH_LENGTH_TO_PARSE_OPCODE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1039_PR_CommErrSbepNotEnoughLengthToParseOpcode;
			case global::Motorola.Common.Communication.TetraMsgOpResult.RP_RECEIVED_UNEXPECTED_INDICATION:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1040_PR_CommErrSbepReceivedUnexpectedIndication;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PARAMETER:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1048_PR_CommErrATInvalidInputParameters;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_NONE_COMM_PIPE:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1043_PR_CommErrATNoCommunicationPipe;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRITE_COMM_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1046_PR_CommErrATWriteDataError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRITE_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1047_PR_CommErrATWriteDataTimeout;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_READ_TIMEOUT:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1044_PR_CommErrATReadTimeout;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_RECEIVE_MESSAGE_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1045_PR_CommErrATReceiveMessageError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_DEVICE_BUSY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1041_PR_CommErrATDeviceIsBusy;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_PARSE_REPLY_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1049_PR_CommErrATInvalidReply;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_OPERATION_NOT_ALLOWED:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1050_PR_CommErrATOperationNotAllowed;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_LOW_BATTERY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1051_PR_CommErrATLowBattery;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_MS_IN_EMERGENCY:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1052_PR_CommErrATMsInEmergency;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_GENERAL_ERROR:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1042_PR_CommErrATGeneralError;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_PASSWORD_REQUIRED:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1053_PR_CommErrATAccessCodeNeedChange;
			case global::Motorola.Common.Communication.TetraMsgOpResult.AT_WRONG_PASSWORD:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1054_PR_CommErrATWrongPassword;
			case global::Motorola.Common.Communication.TetraMsgOpResult.Undefined:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1000_PR_CommErrSBEPGeneric;
			default:
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD1000_PR_CommErrSBEPGeneric;
			}
		}
	}
}
