using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000059 RID: 89
	[global::System.Runtime.Serialization.DataContract]
	public enum CommRC
	{
		// Token: 0x040002A5 RID: 677
		[global::System.Runtime.Serialization.EnumMember]
		RD0000_CommSuccess,
		// Token: 0x040002A6 RID: 678
		[global::System.Runtime.Serialization.EnumMember]
		RD0001_RH_CommErrGeneric,
		// Token: 0x040002A7 RID: 679
		[global::System.Runtime.Serialization.EnumMember]
		RD0002_RH_CommErrDataSize,
		// Token: 0x040002A8 RID: 680
		[global::System.Runtime.Serialization.EnumMember]
		RD0003_RH_CommErrBadImage,
		// Token: 0x040002A9 RID: 681
		[global::System.Runtime.Serialization.EnumMember]
		RD0004_RH_CommErrBadMemMap,
		// Token: 0x040002AA RID: 682
		[global::System.Runtime.Serialization.EnumMember]
		RD0005_RH_CommErrInvalidParameter,
		// Token: 0x040002AB RID: 683
		[global::System.Runtime.Serialization.EnumMember]
		RD0006_RH_CommErrUnknownHWID,
		// Token: 0x040002AC RID: 684
		[global::System.Runtime.Serialization.EnumMember]
		RD0007_RH_CommErrFlashType,
		// Token: 0x040002AD RID: 685
		[global::System.Runtime.Serialization.EnumMember]
		RD0008_RH_CommErrOperationMode,
		// Token: 0x040002AE RID: 686
		[global::System.Runtime.Serialization.EnumMember]
		RD0009_RH_CommErrInvalidTEI,
		// Token: 0x040002AF RID: 687
		[global::System.Runtime.Serialization.EnumMember]
		RD0010_RH_CommErrCPUIDMismatch,
		// Token: 0x040002B0 RID: 688
		[global::System.Runtime.Serialization.EnumMember]
		RD0011_RH_CommErrCannotDetectCPArea,
		// Token: 0x040002B1 RID: 689
		[global::System.Runtime.Serialization.EnumMember]
		RD0012_RH_CommErrSrecordLoadFailed,
		// Token: 0x040002B2 RID: 690
		[global::System.Runtime.Serialization.EnumMember]
		RD0013_RH_CommErrModelMisedInMetadata,
		// Token: 0x040002B3 RID: 691
		[global::System.Runtime.Serialization.EnumMember]
		RD0014_RH_CommErrInvalidCPVersion,
		// Token: 0x040002B4 RID: 692
		[global::System.Runtime.Serialization.EnumMember]
		RD0015_RH_CommErrByteOrderConflict,
		// Token: 0x040002B5 RID: 693
		[global::System.Runtime.Serialization.EnumMember]
		RD0015_RH_CommErrReceivedDataLengthGreaterThanExpectedLength,
		// Token: 0x040002B6 RID: 694
		[global::System.Runtime.Serialization.EnumMember]
		RD0016_RH_CommErrInvalidInputAddress,
		// Token: 0x040002B7 RID: 695
		[global::System.Runtime.Serialization.EnumMember]
		RD0017_RH_CommErrNoSpecifyFilePath,
		// Token: 0x040002B8 RID: 696
		[global::System.Runtime.Serialization.EnumMember]
		RD0018_RH_CommErrIOCanceled,
		// Token: 0x040002B9 RID: 697
		[global::System.Runtime.Serialization.EnumMember]
		RD0019_RH_CommErrInvalidFDTStatus,
		// Token: 0x040002BA RID: 698
		[global::System.Runtime.Serialization.EnumMember]
		RD0020_RH_CommErrNotSupportedOperation,
		// Token: 0x040002BB RID: 699
		[global::System.Runtime.Serialization.EnumMember]
		RD0021_RH_CommErrReadZeroLengthData,
		// Token: 0x040002BC RID: 700
		[global::System.Runtime.Serialization.EnumMember]
		RD0022_RH_CommErrUnknownCPUByteOrder,
		// Token: 0x040002BD RID: 701
		[global::System.Runtime.Serialization.EnumMember]
		RD0023_RH_CommErrInvalidSWFile,
		// Token: 0x040002BE RID: 702
		[global::System.Runtime.Serialization.EnumMember]
		RD0024_RH_CommErrInvalidHardwareId,
		// Token: 0x040002BF RID: 703
		[global::System.Runtime.Serialization.EnumMember]
		RD0025_RH_PowerOffRadioFailed,
		// Token: 0x040002C0 RID: 704
		[global::System.Runtime.Serialization.EnumMember]
		RD0026_RH_CanNotGetRadioModelInfoViaModelType,
		// Token: 0x040002C1 RID: 705
		[global::System.Runtime.Serialization.EnumMember]
		RD0100_PNP_CommErrProcessPnPMsg,
		// Token: 0x040002C2 RID: 706
		[global::System.Runtime.Serialization.EnumMember]
		RD0200_RH_CommErrInvalidModelTableFile,
		// Token: 0x040002C3 RID: 707
		[global::System.Runtime.Serialization.EnumMember]
		RD4000_FDI_CommErrFDISizeAreaMismatch,
		// Token: 0x040002C4 RID: 708
		[global::System.Runtime.Serialization.EnumMember]
		RD4001_FDI_CommErrFDIBlockSize,
		// Token: 0x040002C5 RID: 709
		[global::System.Runtime.Serialization.EnumMember]
		RD4002_FDI_CommErrFDIException,
		// Token: 0x040002C6 RID: 710
		[global::System.Runtime.Serialization.EnumMember]
		RD4003_FDI_CommErrFDIMissingBlock,
		// Token: 0x040002C7 RID: 711
		[global::System.Runtime.Serialization.EnumMember]
		RD4004_FDI_CommErrFDIConfig,
		// Token: 0x040002C8 RID: 712
		[global::System.Runtime.Serialization.EnumMember]
		RD5000_FDT_CommErrFDTNotInit,
		// Token: 0x040002C9 RID: 713
		[global::System.Runtime.Serialization.EnumMember]
		RD5001_FDT_CommErrFDTInvalidParameter,
		// Token: 0x040002CA RID: 714
		[global::System.Runtime.Serialization.EnumMember]
		RD5002_FDT_CommErrCannotReadFDT,
		// Token: 0x040002CB RID: 715
		[global::System.Runtime.Serialization.EnumMember]
		RD5003_FDT_CommErrCannotWriteFDTUnit,
		// Token: 0x040002CC RID: 716
		[global::System.Runtime.Serialization.EnumMember]
		RD5004_FDT_CommErrUnknownFDTType,
		// Token: 0x040002CD RID: 717
		[global::System.Runtime.Serialization.EnumMember]
		RD5050_FP_CommErrFPInitError,
		// Token: 0x040002CE RID: 718
		[global::System.Runtime.Serialization.EnumMember]
		RD5063_FP_HuffmanFail,
		// Token: 0x040002CF RID: 719
		[global::System.Runtime.Serialization.EnumMember]
		RD5064_FP_UnHuffmanFail,
		// Token: 0x040002D0 RID: 720
		[global::System.Runtime.Serialization.EnumMember]
		RD5065_FP_BuildLLPFail,
		// Token: 0x040002D1 RID: 721
		[global::System.Runtime.Serialization.EnumMember]
		RD5066_FP_ParseLLPFail,
		// Token: 0x040002D2 RID: 722
		[global::System.Runtime.Serialization.EnumMember]
		RD5070_FP_ERASESLOTFail,
		// Token: 0x040002D3 RID: 723
		[global::System.Runtime.Serialization.EnumMember]
		RD5072_FP_CommErrWriteMandatoryFPFailed,
		// Token: 0x040002D4 RID: 724
		[global::System.Runtime.Serialization.EnumMember]
		RD5073_FP_CommErrWriteLLPFailed,
		// Token: 0x040002D5 RID: 725
		[global::System.Runtime.Serialization.EnumMember]
		RD5074_FP_DeleteFlashPackFromCathcFailed,
		// Token: 0x040002D6 RID: 726
		[global::System.Runtime.Serialization.EnumMember]
		RD5075_FP_ReleaseIDTypeIsNone,
		// Token: 0x040002D7 RID: 727
		[global::System.Runtime.Serialization.EnumMember]
		RD5076_FP_InvalidCopyRightStringInReleaseID,
		// Token: 0x040002D8 RID: 728
		[global::System.Runtime.Serialization.EnumMember]
		RD5078_FP_NoSoftwareVersionInfoInReleaseID,
		// Token: 0x040002D9 RID: 729
		[global::System.Runtime.Serialization.EnumMember]
		RD1000_PR_CommErrSBEPGeneric,
		// Token: 0x040002DA RID: 730
		[global::System.Runtime.Serialization.EnumMember]
		RD1001_PR_CommErrSBEPBadWriteReply,
		// Token: 0x040002DB RID: 731
		[global::System.Runtime.Serialization.EnumMember]
		RD1002_PR_CommErrSBEPCannotOpenPipe,
		// Token: 0x040002DC RID: 732
		[global::System.Runtime.Serialization.EnumMember]
		RD1003_PR_CommErrSBEPInsufficientBuffer,
		// Token: 0x040002DD RID: 733
		[global::System.Runtime.Serialization.EnumMember]
		RD1004_PR_CommErrSBEPMSGCheckSumError,
		// Token: 0x040002DE RID: 734
		[global::System.Runtime.Serialization.EnumMember]
		RD1005_PR_CommErrSBEPMSGWrongFormat,
		// Token: 0x040002DF RID: 735
		[global::System.Runtime.Serialization.EnumMember]
		RD1006_PR_CommErrSBEPNack,
		// Token: 0x040002E0 RID: 736
		[global::System.Runtime.Serialization.EnumMember]
		RD1007_PR_CommErrSBEPNoAcknowledge,
		// Token: 0x040002E1 RID: 737
		[global::System.Runtime.Serialization.EnumMember]
		RD1008_PR_CommErrSBEPReadCommError,
		// Token: 0x040002E2 RID: 738
		[global::System.Runtime.Serialization.EnumMember]
		RD1009_PR_CommErrSBEPReadTimeOut,
		// Token: 0x040002E3 RID: 739
		[global::System.Runtime.Serialization.EnumMember]
		RD1010_PR_CommErrSBEPReceiveMessageError,
		// Token: 0x040002E4 RID: 740
		[global::System.Runtime.Serialization.EnumMember]
		RD1011_PR_CommErrSBEPSendMessageError,
		// Token: 0x040002E5 RID: 741
		[global::System.Runtime.Serialization.EnumMember]
		RD1012_PR_CommErrSBEPTimeOut,
		// Token: 0x040002E6 RID: 742
		[global::System.Runtime.Serialization.EnumMember]
		RD1013_PR_CommErrSBEPUndefinedWriteReply,
		// Token: 0x040002E7 RID: 743
		[global::System.Runtime.Serialization.EnumMember]
		RD1014_PR_CommErrSBEPUnknownReply,
		// Token: 0x040002E8 RID: 744
		[global::System.Runtime.Serialization.EnumMember]
		RD1015_PR_CommErrSBEPUnsupportReply,
		// Token: 0x040002E9 RID: 745
		[global::System.Runtime.Serialization.EnumMember]
		RD1016_PR_CommErrSBEPUnsupportedType,
		// Token: 0x040002EA RID: 746
		[global::System.Runtime.Serialization.EnumMember]
		RD1017_PR_CommErrSBEPWriteCommError,
		// Token: 0x040002EB RID: 747
		[global::System.Runtime.Serialization.EnumMember]
		RD1018_PR_CommErrSBEPWriteNack,
		// Token: 0x040002EC RID: 748
		[global::System.Runtime.Serialization.EnumMember]
		RD1019_PR_CommErrSBEPWriteNoAcknowledge,
		// Token: 0x040002ED RID: 749
		[global::System.Runtime.Serialization.EnumMember]
		RD1020_PR_CommErrSBEPWriteTimeOut,
		// Token: 0x040002EE RID: 750
		[global::System.Runtime.Serialization.EnumMember]
		RD1021_PR_CommErrSBEPWrongParameter,
		// Token: 0x040002EF RID: 751
		[global::System.Runtime.Serialization.EnumMember]
		RD1022_PR_CommErrSBEPNoneCommPipe,
		// Token: 0x040002F0 RID: 752
		[global::System.Runtime.Serialization.EnumMember]
		RD1023_PR_CommErrSBEPACK,
		// Token: 0x040002F1 RID: 753
		[global::System.Runtime.Serialization.EnumMember]
		RD1024_PR_CommErrRPMsgWrongFormat,
		// Token: 0x040002F2 RID: 754
		[global::System.Runtime.Serialization.EnumMember]
		RD1025_PR_CommErrRPWrongParameter,
		// Token: 0x040002F3 RID: 755
		[global::System.Runtime.Serialization.EnumMember]
		RD1026_PR_CommErrRPWriteCommError,
		// Token: 0x040002F4 RID: 756
		[global::System.Runtime.Serialization.EnumMember]
		RD1027_PR_CommErrRPWriteTimeout,
		// Token: 0x040002F5 RID: 757
		[global::System.Runtime.Serialization.EnumMember]
		RD1028_PR_CommErrRPReadCommError,
		// Token: 0x040002F6 RID: 758
		[global::System.Runtime.Serialization.EnumMember]
		RD1029_PR_CommErrRPReadTimeout,
		// Token: 0x040002F7 RID: 759
		[global::System.Runtime.Serialization.EnumMember]
		RD1030_PR_CommErrRPNoneCommPipe,
		// Token: 0x040002F8 RID: 760
		[global::System.Runtime.Serialization.EnumMember]
		RD1031_PR_CommErrRPMsgRejected,
		// Token: 0x040002F9 RID: 761
		[global::System.Runtime.Serialization.EnumMember]
		RD1032_PR_CommErrRPRejectBadBattery,
		// Token: 0x040002FA RID: 762
		[global::System.Runtime.Serialization.EnumMember]
		RD1033_PR_CommErrRPRejectRPEmergency,
		// Token: 0x040002FB RID: 763
		[global::System.Runtime.Serialization.EnumMember]
		RD1034_PR_CommErrRPInvalidID,
		// Token: 0x040002FC RID: 764
		[global::System.Runtime.Serialization.EnumMember]
		RD1035_PR_CommErrRPReceiveMsgError,
		// Token: 0x040002FD RID: 765
		[global::System.Runtime.Serialization.EnumMember]
		RD1036_PR_CommErrRPInvalidIDFormat,
		// Token: 0x040002FE RID: 766
		[global::System.Runtime.Serialization.EnumMember]
		RD1037_PR_CommErrRPInvalidMode,
		// Token: 0x040002FF RID: 767
		[global::System.Runtime.Serialization.EnumMember]
		RD1038_PR_CommErrRPUnsupportedProtocol,
		// Token: 0x04000300 RID: 768
		[global::System.Runtime.Serialization.EnumMember]
		RD1039_PR_CommErrSbepNotEnoughLengthToParseOpcode,
		// Token: 0x04000301 RID: 769
		[global::System.Runtime.Serialization.EnumMember]
		RD1040_PR_CommErrSbepReceivedUnexpectedIndication,
		// Token: 0x04000302 RID: 770
		[global::System.Runtime.Serialization.EnumMember]
		RD1041_PR_CommErrATDeviceIsBusy,
		// Token: 0x04000303 RID: 771
		[global::System.Runtime.Serialization.EnumMember]
		RD1042_PR_CommErrATGeneralError,
		// Token: 0x04000304 RID: 772
		[global::System.Runtime.Serialization.EnumMember]
		RD1043_PR_CommErrATNoCommunicationPipe,
		// Token: 0x04000305 RID: 773
		[global::System.Runtime.Serialization.EnumMember]
		RD1044_PR_CommErrATReadTimeout,
		// Token: 0x04000306 RID: 774
		[global::System.Runtime.Serialization.EnumMember]
		RD1045_PR_CommErrATReceiveMessageError,
		// Token: 0x04000307 RID: 775
		[global::System.Runtime.Serialization.EnumMember]
		RD1046_PR_CommErrATWriteDataError,
		// Token: 0x04000308 RID: 776
		[global::System.Runtime.Serialization.EnumMember]
		RD1047_PR_CommErrATWriteDataTimeout,
		// Token: 0x04000309 RID: 777
		[global::System.Runtime.Serialization.EnumMember]
		RD1048_PR_CommErrATInvalidInputParameters,
		// Token: 0x0400030A RID: 778
		[global::System.Runtime.Serialization.EnumMember]
		RD1049_PR_CommErrATInvalidReply,
		// Token: 0x0400030B RID: 779
		[global::System.Runtime.Serialization.EnumMember]
		RD1050_PR_CommErrATOperationNotAllowed,
		// Token: 0x0400030C RID: 780
		[global::System.Runtime.Serialization.EnumMember]
		RD1051_PR_CommErrATLowBattery,
		// Token: 0x0400030D RID: 781
		[global::System.Runtime.Serialization.EnumMember]
		RD1052_PR_CommErrATMsInEmergency,
		// Token: 0x0400030E RID: 782
		[global::System.Runtime.Serialization.EnumMember]
		RD1053_PR_CommErrATAccessCodeNeedChange,
		// Token: 0x0400030F RID: 783
		[global::System.Runtime.Serialization.EnumMember]
		RD1054_PR_CommErrATWrongPassword,
		// Token: 0x04000310 RID: 784
		[global::System.Runtime.Serialization.EnumMember]
		RD1055_PR_CommErrATChargerNotConnected,
		// Token: 0x04000311 RID: 785
		[global::System.Runtime.Serialization.EnumMember]
		RD6001_RH_CommErrFailedToResetDataBoxRadio,
		// Token: 0x04000312 RID: 786
		[global::System.Runtime.Serialization.EnumMember]
		RD6002_MS_CommErrTargetFolderNotExist,
		// Token: 0x04000313 RID: 787
		[global::System.Runtime.Serialization.EnumMember]
		RD6003_MS_CommErrFileOperationError,
		// Token: 0x04000314 RID: 788
		[global::System.Runtime.Serialization.EnumMember]
		RD6004_MS_CommErrSizeLargerThanExpected,
		// Token: 0x04000315 RID: 789
		[global::System.Runtime.Serialization.EnumMember]
		RD6005_MS_CommErrSourceFileNotExist,
		// Token: 0x04000316 RID: 790
		[global::System.Runtime.Serialization.EnumMember]
		RD6006_MS_CommErrSwitchModeFail,
		// Token: 0x04000317 RID: 791
		[global::System.Runtime.Serialization.EnumMember]
		RD6007_MS_CommErrNotEnoughSpaceForPush,
		// Token: 0x04000318 RID: 792
		[global::System.Runtime.Serialization.EnumMember]
		RD7001_S19_CommErrInvalidS19Header,
		// Token: 0x04000319 RID: 793
		[global::System.Runtime.Serialization.EnumMember]
		RD7002_S19_CommErrUnsupportedS19FileType,
		// Token: 0x0400031A RID: 794
		[global::System.Runtime.Serialization.EnumMember]
		RD7003_S19_CommErrInvalidS19Format,
		// Token: 0x0400031B RID: 795
		[global::System.Runtime.Serialization.EnumMember]
		RD7004_S19_CommErrFailedToValidateAddress,
		// Token: 0x0400031C RID: 796
		[global::System.Runtime.Serialization.EnumMember]
		RD8001_NAND_CommErrConvertS19ToImage,
		// Token: 0x0400031D RID: 797
		[global::System.Runtime.Serialization.EnumMember]
		RD8002_NAND_CommErrLoadFromImage,
		// Token: 0x0400031E RID: 798
		[global::System.Runtime.Serialization.EnumMember]
		RD8003_NAND_ExportToS19File,
		// Token: 0x0400031F RID: 799
		[global::System.Runtime.Serialization.EnumMember]
		RD9001_GeneralOperation_CommErrInvalidOperationCode,
		// Token: 0x04000320 RID: 800
		[global::System.Runtime.Serialization.EnumMember]
		RE0001_LANGUAGE_LPValidFail,
		// Token: 0x04000321 RID: 801
		[global::System.Runtime.Serialization.EnumMember]
		RD9001_AUTHEN_Failed,
		// Token: 0x04000322 RID: 802
		[global::System.Runtime.Serialization.EnumMember]
		RF0001_FlashRegionOperation_FaiedToReadRegion,
		// Token: 0x04000323 RID: 803
		[global::System.Runtime.Serialization.EnumMember]
		RF0002_FlashRegionOperation_FailedToConvertImageToFile,
		// Token: 0x04000324 RID: 804
		[global::System.Runtime.Serialization.EnumMember]
		RF0003_FlashRegionOperation_CanNotFindImageBackupFile,
		// Token: 0x04000325 RID: 805
		[global::System.Runtime.Serialization.EnumMember]
		RF0004_FlashRegionOperation_FailedToLoadImageFromBackupFile,
		// Token: 0x04000326 RID: 806
		[global::System.Runtime.Serialization.EnumMember]
		RF0005_FlashRegionOperation_FailedToConstructSRecordFromImage,
		// Token: 0x04000327 RID: 807
		[global::System.Runtime.Serialization.EnumMember]
		RF0006_FlashRegionOperation_InvalidBackupFileFormat,
		// Token: 0x04000328 RID: 808
		[global::System.Runtime.Serialization.EnumMember]
		RF0007_FlashRegionOperation_DatalightUpgradeFailed,
		// Token: 0x04000329 RID: 809
		[global::System.Runtime.Serialization.EnumMember]
		RG0001_CommMetadataNoRecordOfFPSupport
	}
}
