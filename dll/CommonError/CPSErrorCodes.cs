using System;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000007 RID: 7
	public enum CPSErrorCodes
	{
		// Token: 0x04000684 RID: 1668
		ASTROUnknownIssue = 100000000,
		// Token: 0x04000685 RID: 1669
		DefaultValue,
		// Token: 0x04000686 RID: 1670
		InvalidMessageNotProvided,
		// Token: 0x04000687 RID: 1671
		IPAddressGeneralError,
		// Token: 0x04000688 RID: 1672
		IPAddressCannotBeZero,
		// Token: 0x04000689 RID: 1673
		InvalidValueBecauseofSystemKey,
		// Token: 0x0400068A RID: 1674
		AccessoryButtons_RadErgoCfgRSMConventionalBCO_A19639_1 = 100100101,
		// Token: 0x0400068B RID: 1675
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_1 = 100100201,
		// Token: 0x0400068C RID: 1676
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_2,
		// Token: 0x0400068D RID: 1677
		AccessoryButtons_RadErgoCfgRSMTrunkingBCO_A19741_3,
		// Token: 0x0400068E RID: 1678
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_1 = 100100401,
		// Token: 0x0400068F RID: 1679
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_2,
		// Token: 0x04000690 RID: 1680
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_3,
		// Token: 0x04000691 RID: 1681
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_4,
		// Token: 0x04000692 RID: 1682
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_5,
		// Token: 0x04000693 RID: 1683
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_6,
		// Token: 0x04000694 RID: 1684
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_7,
		// Token: 0x04000695 RID: 1685
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_8,
		// Token: 0x04000696 RID: 1686
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_9,
		// Token: 0x04000697 RID: 1687
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_10,
		// Token: 0x04000698 RID: 1688
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_11,
		// Token: 0x04000699 RID: 1689
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_12,
		// Token: 0x0400069A RID: 1690
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_13,
		// Token: 0x0400069B RID: 1691
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_14,
		// Token: 0x0400069C RID: 1692
		AccessoryButtons_RadErgoCfgRSMlConventionalFeature_A19640_15,
		// Token: 0x0400069D RID: 1693
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_1 = 100100501,
		// Token: 0x0400069E RID: 1694
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_2,
		// Token: 0x0400069F RID: 1695
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_3,
		// Token: 0x040006A0 RID: 1696
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_4,
		// Token: 0x040006A1 RID: 1697
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_5,
		// Token: 0x040006A2 RID: 1698
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_6,
		// Token: 0x040006A3 RID: 1699
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_7,
		// Token: 0x040006A4 RID: 1700
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_8,
		// Token: 0x040006A5 RID: 1701
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_9,
		// Token: 0x040006A6 RID: 1702
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_10,
		// Token: 0x040006A7 RID: 1703
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_11,
		// Token: 0x040006A8 RID: 1704
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_12,
		// Token: 0x040006A9 RID: 1705
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_13,
		// Token: 0x040006AA RID: 1706
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_14,
		// Token: 0x040006AB RID: 1707
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_15,
		// Token: 0x040006AC RID: 1708
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_16,
		// Token: 0x040006AD RID: 1709
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_17,
		// Token: 0x040006AE RID: 1710
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_18,
		// Token: 0x040006AF RID: 1711
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_19,
		// Token: 0x040006B0 RID: 1712
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_20,
		// Token: 0x040006B1 RID: 1713
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_21,
		// Token: 0x040006B2 RID: 1714
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_22,
		// Token: 0x040006B3 RID: 1715
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_23,
		// Token: 0x040006B4 RID: 1716
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_24,
		// Token: 0x040006B5 RID: 1717
		AccessoryButtons_RadErgoCfgRSMlTrunkingFeature_A19742_25,
		// Token: 0x040006B6 RID: 1718
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_1 = 100200100,
		// Token: 0x040006B7 RID: 1719
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_2,
		// Token: 0x040006B8 RID: 1720
		ActionConsolidation_RadioErgoConfigACSirenType_A36584_3,
		// Token: 0x040006B9 RID: 1721
		ActionConsolidation_RadioErgoConfigACGpsReport_A36587_1 = 100200200,
		// Token: 0x040006BA RID: 1722
		ActionConsolidation_RelayPattern_1 = 100200300,
		// Token: 0x040006BB RID: 1723
		ASTRO25FixedNetworkEquipment_TrkSysGeneralSystemID_A9239_2 = 100400202,
		// Token: 0x040006BC RID: 1724
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_1 = 100400101,
		// Token: 0x040006BD RID: 1725
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_2,
		// Token: 0x040006BE RID: 1726
		ASTRO25FixedNetworkEquipment_TrkSysGeneralCoverageType_A7782_3,
		// Token: 0x040006BF RID: 1727
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25ValidateNACAgainstSystemID_A20608_1 = 100400201,
		// Token: 0x040006C0 RID: 1728
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25ValidateNACAgainstSystemID_A20608_2 = 100400204,
		// Token: 0x040006C1 RID: 1729
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25WUIDValiditySupport_A41483_1 = 100400301,
		// Token: 0x040006C2 RID: 1730
		ASTRO25FixedNetworkEquipment_TrkSysASTRO25F2VoiceCapable_A1395_1 = 100400401,
		// Token: 0x040006C3 RID: 1731
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDIdentifierEnable_A8222_1 = 100500101,
		// Token: 0x040006C4 RID: 1732
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_1 = 100500201,
		// Token: 0x040006C5 RID: 1733
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_2,
		// Token: 0x040006C6 RID: 1734
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_1 = 100500301,
		// Token: 0x040006C7 RID: 1735
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_2,
		// Token: 0x040006C8 RID: 1736
		ASTRO25FNEChannelID_TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_1 = 100500401,
		// Token: 0x040006C9 RID: 1737
		ASTRO25FNEControlChannel_TrkSysControlChannelsRxFrequencyMHz_A9018_1 = 100600101,
		// Token: 0x040006CA RID: 1738
		ASTRO25FNEControlChannel_TrkSysControlChannelsRxFrequencyMHz_A9018_2,
		// Token: 0x040006CB RID: 1739
		ASTRO25FNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_1 = 100600201,
		// Token: 0x040006CC RID: 1740
		ASTRO25FNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_2,
		// Token: 0x040006CD RID: 1741
		ASTRO25FNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_1 = 100800101,
		// Token: 0x040006CE RID: 1742
		ASTRO25FNETalkgroup_TrkPerTalkgroupTalkgroup_A9274_1 = 100900101,
		// Token: 0x040006CF RID: 1743
		ASTRO25FNETalkgroup_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_1 = 100900201,
		// Token: 0x040006D0 RID: 1744
		ASTRO25FNETalkgroup_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_1 = 100900301,
		// Token: 0x040006D1 RID: 1745
		ASTRO25FNETalkgroup_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_1 = 100900401,
		// Token: 0x040006D2 RID: 1746
		ASTRO25FNETalkgroup_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_1 = 100900501,
		// Token: 0x040006D3 RID: 1747
		ASTRO25FNETalkgroup_TrkPerTalkgroup_42163_1 = 100900601,
		// Token: 0x040006D4 RID: 1748
		UclAstro25TrkHotList_CallID_a00038_1 = 101200101,
		// Token: 0x040006D5 RID: 1749
		UclAstro25Trk_IndividualID_A00013_1 = 101400101,
		// Token: 0x040006D6 RID: 1750
		UclAstro25Trk_IndividualID_A00013_2,
		// Token: 0x040006D7 RID: 1751
		UclAstro25Trk_IndividualID_A00013_3,
		// Token: 0x040006D8 RID: 1752
		UclAstro25Trk_IndividualID_A00013_4,
		// Token: 0x040006D9 RID: 1753
		UclAstro25Trk_IndividualID_A00013_5,
		// Token: 0x040006DA RID: 1754
		ASTRO25TrunkingOneTouch_TrkSysOneTouchFeature_A8614_1 = 101500101,
		// Token: 0x040006DB RID: 1755
		ASTRO25TrunkingOneTouch_TrkSysOneTouchFeature_A8614_2,
		// Token: 0x040006DC RID: 1756
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_1 = 101500201,
		// Token: 0x040006DD RID: 1757
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_2,
		// Token: 0x040006DE RID: 1758
		ASTRO25TrunkingOneTouch_TrkSysOneTouchIndex_A8618_3,
		// Token: 0x040006DF RID: 1759
		ASTRO25TrunkingPersonlaity_TrkPerCallPageCallAlertPageOperation_A7597_1 = 101600101,
		// Token: 0x040006E0 RID: 1760
		ASTRO25TrunkingPersonlaity_TrkPerCallPagePrivateCallOperation_A8759_1 = 101600201,
		// Token: 0x040006E1 RID: 1761
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_1 = 101600301,
		// Token: 0x040006E2 RID: 1762
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_2,
		// Token: 0x040006E3 RID: 1763
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_3,
		// Token: 0x040006E4 RID: 1764
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_4,
		// Token: 0x040006E5 RID: 1765
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesScanListSelection_A9053_5,
		// Token: 0x040006E6 RID: 1766
		ASTRO25TrunkingPersonlaity_TrkPerFeaturesStatusEnable_A9188_1 = 101600401,
		// Token: 0x040006E7 RID: 1767
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_1 = 101600501,
		// Token: 0x040006E8 RID: 1768
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_2,
		// Token: 0x040006E9 RID: 1769
		ASTRO25TrunkingPersonlaity_TrkEmerProfGeneralKeySelect_A8970_3,
		// Token: 0x040006EA RID: 1770
		ASTRO25TrunkingPersonlaity_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_1 = 101600601,
		// Token: 0x040006EB RID: 1771
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertZone_A41916_1 = 101600701,
		// Token: 0x040006EC RID: 1772
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_1 = 101600801,
		// Token: 0x040006ED RID: 1773
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_2,
		// Token: 0x040006EE RID: 1774
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_3,
		// Token: 0x040006EF RID: 1775
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_4,
		// Token: 0x040006F0 RID: 1776
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_5,
		// Token: 0x040006F1 RID: 1777
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_6,
		// Token: 0x040006F2 RID: 1778
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_7,
		// Token: 0x040006F3 RID: 1779
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_8,
		// Token: 0x040006F4 RID: 1780
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_9,
		// Token: 0x040006F5 RID: 1781
		ASTRO25TrunkingPersonlaity_TrkPerGeneralRevertChannel_A41917_10,
		// Token: 0x040006F6 RID: 1782
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGKeySelect_A7414_1 = 101600901,
		// Token: 0x040006F7 RID: 1783
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGKeySelect_A7414_2,
		// Token: 0x040006F8 RID: 1784
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_1 = 101601001,
		// Token: 0x040006F9 RID: 1785
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_2,
		// Token: 0x040006FA RID: 1786
		ASTRO25TrunkingPersonlaity_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_1 = 101601101,
		// Token: 0x040006FB RID: 1787
		ASTRO25TrunkingPersonlaity_TrkPerGeneralTimeOutTimersec_A9379_1 = 101601201,
		// Token: 0x040006FC RID: 1788
		TxFreqValueMismatchRxFreqValue_1,
		// Token: 0x040006FD RID: 1789
		TrunkingSystem_1 = 101700001,
		// Token: 0x040006FE RID: 1790
		TrunkingSystem_2,
		// Token: 0x040006FF RID: 1791
		ASTRO25TrunkingSystem_TrkSysGeneralUnitID_A12651_1 = 101700201,
		// Token: 0x04000700 RID: 1792
		Error_RadioID_Empty,
		// Token: 0x04000701 RID: 1793
		Error_RadioID_OutOfRange,
		// Token: 0x04000702 RID: 1794
		Error_RadioID_OutOfASKRange,
		// Token: 0x04000703 RID: 1795
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_1 = 101700301,
		// Token: 0x04000704 RID: 1796
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_2,
		// Token: 0x04000705 RID: 1797
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_3,
		// Token: 0x04000706 RID: 1798
		ASTRO25TrunkingSystem_TrkSysGeneralDataProfileSelection_A19449_4,
		// Token: 0x04000707 RID: 1799
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_1 = 101700401,
		// Token: 0x04000708 RID: 1800
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_2,
		// Token: 0x04000709 RID: 1801
		ASTRO25TrunkingSystem_TrkSysFixedNetworkEquipment_42165_3,
		// Token: 0x0400070A RID: 1802
		ASTRO25TrunkingSystem_TrkSysFeaturesRadioInhibit_A8833_1 = 101700501,
		// Token: 0x0400070B RID: 1803
		ASTRO25TrunkingSystem_TrkSysFeaturesTextMessagingService_A9373_1 = 101700601,
		// Token: 0x0400070C RID: 1804
		ASTRO25TrunkingSystem_TrkSysFeaturesTextMessagingService_A9373_2,
		// Token: 0x0400070D RID: 1805
		ASTRO25TrunkingSystem_TrkSysFeaturesZone_A9717_1 = 101700701,
		// Token: 0x0400070E RID: 1806
		ASTRO25TrunkingSystem_TrkSysFeaturesZone_A9717_2,
		// Token: 0x0400070F RID: 1807
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_1 = 101700801,
		// Token: 0x04000710 RID: 1808
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_2,
		// Token: 0x04000711 RID: 1809
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_3,
		// Token: 0x04000712 RID: 1810
		ASTRO25TrunkingSystem_TrkSysFeaturesChannel_A7647_4,
		// Token: 0x04000713 RID: 1811
		ASTRO25TrunkingSystem_SiteSelectableAlertList_A42060_1 = 101700901,
		// Token: 0x04000714 RID: 1812
		ASTRO25TrunkingSystem_TrkSysSiteAliasSiteAliasEnable_A9148_1 = 101701001,
		// Token: 0x04000715 RID: 1813
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyKMFProfileIndex_A8382_1 = 101701101,
		// Token: 0x04000716 RID: 1814
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_1 = 101701201,
		// Token: 0x04000717 RID: 1815
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_2,
		// Token: 0x04000718 RID: 1816
		ASTRO25TrunkingSystem_TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_3,
		// Token: 0x04000719 RID: 1817
		ASTRO25TrunkingSystem_TrkSysFeatureLocationOnPTT_43026_1 = 101701301,
		// Token: 0x0400071A RID: 1818
		ASTRO25TrunkingTalkgroupRecSetInvalid = 101800001,
		// Token: 0x0400071B RID: 1819
		UclAstroCnvHotList_CallID_A00044_1 = 102200101,
		// Token: 0x0400071C RID: 1820
		UclAstroCnv_SystemAlias_A00022_1 = 102400101,
		// Token: 0x0400071D RID: 1821
		UclAstroCnv_IndividualID_A00024_1 = 102400201,
		// Token: 0x0400071E RID: 1822
		UclAstroCnv_IndividualID_A00024_2,
		// Token: 0x0400071F RID: 1823
		UclAstroCnv_IndividualID_A00024_3,
		// Token: 0x04000720 RID: 1824
		UclAstroCnv_IndividualID_A00024_4,
		// Token: 0x04000721 RID: 1825
		UclAstroCnv_IndividualID_A00024_5,
		// Token: 0x04000722 RID: 1826
		UclAstroCnv_IndividualID_A00024_6,
		// Token: 0x04000723 RID: 1827
		UclAstroCnv_ListinfoCallType_A00025_1 = 102400301,
		// Token: 0x04000724 RID: 1828
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_1 = 102500101,
		// Token: 0x04000725 RID: 1829
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_2,
		// Token: 0x04000726 RID: 1830
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_3,
		// Token: 0x04000727 RID: 1831
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_4,
		// Token: 0x04000728 RID: 1832
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_5,
		// Token: 0x04000729 RID: 1833
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_6,
		// Token: 0x0400072A RID: 1834
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_7,
		// Token: 0x0400072B RID: 1835
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_8,
		// Token: 0x0400072C RID: 1836
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_9,
		// Token: 0x0400072D RID: 1837
		ConventionalOneTouch_CnvPerOneTouchFeature_A19662_10,
		// Token: 0x0400072E RID: 1838
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_1 = 102500201,
		// Token: 0x0400072F RID: 1839
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_2,
		// Token: 0x04000730 RID: 1840
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_3,
		// Token: 0x04000731 RID: 1841
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_4,
		// Token: 0x04000732 RID: 1842
		ConventionalOneTouch_CnvPerOneTouchIndex_A19663_5,
		// Token: 0x04000733 RID: 1843
		ConventionalPersonality_CnvPerFeaturesTacticalRekeyEnable_A19309_1 = 102600101,
		// Token: 0x04000734 RID: 1844
		ConventionalPersonality_CnvPerFeaturesTacticalRekeyEnable_A19309_2,
		// Token: 0x04000735 RID: 1845
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_1 = 102600201,
		// Token: 0x04000736 RID: 1846
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_2,
		// Token: 0x04000737 RID: 1847
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_3,
		// Token: 0x04000738 RID: 1848
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_4,
		// Token: 0x04000739 RID: 1849
		ConventionalPersonality_ConPerFeatureIncidentSignalingType_A41507_5,
		// Token: 0x0400073A RID: 1850
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_1 = 102600301,
		// Token: 0x0400073B RID: 1851
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_2,
		// Token: 0x0400073C RID: 1852
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_3,
		// Token: 0x0400073D RID: 1853
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_4,
		// Token: 0x0400073E RID: 1854
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_5,
		// Token: 0x0400073F RID: 1855
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_6,
		// Token: 0x04000740 RID: 1856
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_7,
		// Token: 0x04000741 RID: 1857
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_8,
		// Token: 0x04000742 RID: 1858
		ConventionalPersonality_CnvPerLabtoolScanListSelection_A9054_9,
		// Token: 0x04000743 RID: 1859
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_1 = 102600401,
		// Token: 0x04000744 RID: 1860
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_2,
		// Token: 0x04000745 RID: 1861
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_3,
		// Token: 0x04000746 RID: 1862
		ConventionalPersonality_CnvPerFeaturesFiregroundRegistration_A33242_4,
		// Token: 0x04000747 RID: 1863
		ConventionalPersonality_CnvPerFeaturesTxVoiceType_A9573_1 = 102600501,
		// Token: 0x04000748 RID: 1864
		ConventionalPersonality_CnvPerTxOptionsTransmitPreEmphasis_A9411_1 = 102600601,
		// Token: 0x04000749 RID: 1865
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_1 = 102600701,
		// Token: 0x0400074A RID: 1866
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_2,
		// Token: 0x0400074B RID: 1867
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_4,
		// Token: 0x0400074C RID: 1868
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_6,
		// Token: 0x0400074D RID: 1869
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_7,
		// Token: 0x0400074E RID: 1870
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_8,
		// Token: 0x0400074F RID: 1871
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_9,
		// Token: 0x04000750 RID: 1872
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_10,
		// Token: 0x04000751 RID: 1873
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_11,
		// Token: 0x04000752 RID: 1874
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_12,
		// Token: 0x04000753 RID: 1875
		ConventionalPersonality_CnvPerSignalingRevertChannel_A13267_13,
		// Token: 0x04000754 RID: 1876
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_1 = 102600801,
		// Token: 0x04000755 RID: 1877
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_2,
		// Token: 0x04000756 RID: 1878
		ConventionalPersonality_CnvPerSignalingRevertType_A8953_3,
		// Token: 0x04000757 RID: 1879
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_1 = 102600901,
		// Token: 0x04000758 RID: 1880
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_2,
		// Token: 0x04000759 RID: 1881
		ConventionalPersonality_CnvPerSignalingASTRORxUnmuteRule_A9042_3,
		// Token: 0x0400075A RID: 1882
		ConventionalPersonality_CnvPerTxOptionsTxVoiceSignalType_A9574_1 = 102601001,
		// Token: 0x0400075B RID: 1883
		ConventionalPersonality_CnvPerTxOptionsTxVoiceSignalType_A9574_2,
		// Token: 0x0400075C RID: 1884
		ConventionalPersonality_CnvPerSecureOTARTx_A8675_1 = 102601101,
		// Token: 0x0400075D RID: 1885
		ConventionalPersonality_CnvPerSecureScanSelect_A9056_1 = 102601201,
		// Token: 0x0400075E RID: 1886
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_1 = 102601301,
		// Token: 0x0400075F RID: 1887
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_3,
		// Token: 0x04000760 RID: 1888
		ConventionalPersonality_CnvPerSecureSecureVoiceSignalType_A9086_4,
		// Token: 0x04000761 RID: 1889
		ConventionalPersonality_CnvPerSecureASTROOTAR_A7493_1 = 102601401,
		// Token: 0x04000762 RID: 1890
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_1 = 102601501,
		// Token: 0x04000763 RID: 1891
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_2,
		// Token: 0x04000764 RID: 1892
		ConventionalPersonality_CnvPerTacticalInhibitKillOperation_A41553_3,
		// Token: 0x04000765 RID: 1893
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_1 = 102601601,
		// Token: 0x04000766 RID: 1894
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_2,
		// Token: 0x04000767 RID: 1895
		ConventionalPersonality_CnvPerTacticalInhibitStunOperation_A41557_3,
		// Token: 0x04000768 RID: 1896
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_1 = 102601701,
		// Token: 0x04000769 RID: 1897
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_2,
		// Token: 0x0400076A RID: 1898
		ConventionalPersonality_CnvPerNonASTROCallRTTButtonAccess_A8493_3,
		// Token: 0x0400076B RID: 1899
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_1 = 102601801,
		// Token: 0x0400076C RID: 1900
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_2,
		// Token: 0x0400076D RID: 1901
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_3,
		// Token: 0x0400076E RID: 1902
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_4,
		// Token: 0x0400076F RID: 1903
		ConventionalPersonality_CnvPerPhonePhoneOperation_A8703_5,
		// Token: 0x04000770 RID: 1904
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_1 = 102601901,
		// Token: 0x04000771 RID: 1905
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_2,
		// Token: 0x04000772 RID: 1906
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_1 = 102602001,
		// Token: 0x04000773 RID: 1907
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_2,
		// Token: 0x04000774 RID: 1908
		ConventionalPersonality_CnvPerRxOptionsRxVoiceSignalType_A9044_3,
		// Token: 0x04000775 RID: 1909
		ConventionalPersonality_CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_1 = 102602101,
		// Token: 0x04000776 RID: 1910
		ConventionalPersonality_CnvPerLabtoolOTACROTACSMessaging_A8663_1 = 102602201,
		// Token: 0x04000777 RID: 1911
		ConventionalPersonality_CnvPerFeaturesMixedVoteScanEnable_A38723_1 = 102602301,
		// Token: 0x04000778 RID: 1912
		ConventionalPersonality_CnvPerFeaturesMixedVoteScanEnable_A38723_2,
		// Token: 0x04000779 RID: 1913
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_1 = 102602401,
		// Token: 0x0400077A RID: 1914
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_2,
		// Token: 0x0400077B RID: 1915
		ConventionalPersonality_CnvPerSecureSecureClearStrapping1_A9090_3,
		// Token: 0x0400077C RID: 1916
		ConventionalPersonality_CnvPerSecureKMFProfileIndex_A8381_1 = 102602501,
		// Token: 0x0400077D RID: 1917
		ConventionalPersonality_CnvPerSignalingSignalingType_A9129_1 = 102602601,
		// Token: 0x0400077E RID: 1918
		ConventionalPersonality_CnvPerSignalingRevertZone_A13269_1 = 102602701,
		// Token: 0x0400077F RID: 1919
		ConventionalPersonality_CnvPerSignalingSystemNumber_A9243_1 = 102602801,
		// Token: 0x04000780 RID: 1920
		ConventionalPersonality_CnvPerSignalingSystemNumber_A9243_2,
		// Token: 0x04000781 RID: 1921
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_1 = 102602901,
		// Token: 0x04000782 RID: 1922
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_2,
		// Token: 0x04000783 RID: 1923
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_3,
		// Token: 0x04000784 RID: 1924
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_4,
		// Token: 0x04000785 RID: 1925
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_5,
		// Token: 0x04000786 RID: 1926
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_6,
		// Token: 0x04000787 RID: 1927
		ConventionalPersonality_CnvPerSignalingASTROSystem_A7498_7,
		// Token: 0x04000788 RID: 1928
		ConventionalPersonality_CnvPerSignalingDigitalModulatorType_A7857_1 = 102603001,
		// Token: 0x04000789 RID: 1929
		ConventionalPersonality_CnvPerRACRepeaterAccess_A8939_1 = 102603101,
		// Token: 0x0400078A RID: 1930
		ConventionalPersonality_CnvPerRACRepeaterAccess_A8939_2,
		// Token: 0x0400078B RID: 1931
		ConventionalPersonality_CnvPerRACCodeType2_A8817_1 = 102603201,
		// Token: 0x0400078C RID: 1932
		ConventionalPersonality_CnvPerRACCodeType2_A8817_2,
		// Token: 0x0400078D RID: 1933
		ConventionalPersonality_CnvPerASTROCallCallAlertRxTx_A7586_1 = 102603301,
		// Token: 0x0400078E RID: 1934
		ConventionalPersonality_CnvPerNonASTROCallCallAlertRxTx_A7588_1 = 102603401,
		// Token: 0x0400078F RID: 1935
		ConventionalPersonality_CnvPerNonASTROCallCallAlertRxTx_A7588_2,
		// Token: 0x04000790 RID: 1936
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_1 = 102603501,
		// Token: 0x04000791 RID: 1937
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_2,
		// Token: 0x04000792 RID: 1938
		ConventionalPersonality_CnvPerNonASTROCallSelectiveCallRxTx_A9116_3,
		// Token: 0x04000793 RID: 1939
		ConventionalPersonality_CnvPerFeaturesDVRSProf_A41794_1 = 102603601,
		// Token: 0x04000794 RID: 1940
		ConventionalPersonality_CnvPerRxOptionsRxDeEmphasis_A9010_1 = 102603701,
		// Token: 0x04000795 RID: 1941
		ConventionalPersonality_CnvPerRxOptionsHearClear_A36408_1 = 102603801,
		// Token: 0x04000796 RID: 1942
		ConventionalPersonality_CnvPerAdvancedAnalogFlatAudio_A7443_1 = 102603901,
		// Token: 0x04000797 RID: 1943
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_1 = 102604001,
		// Token: 0x04000798 RID: 1944
		ConventionalPersonality_CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_2,
		// Token: 0x04000799 RID: 1945
		ConventionalPersonality_CnvPerAGAGKeySel_A40159_1 = 102604101,
		// Token: 0x0400079A RID: 1946
		ConventionalPersonality_CnvPerSecureKeySelection1_A8368_1 = 102604201,
		// Token: 0x0400079B RID: 1947
		ConventionalPersonality_CnvPerSignalingRevertTGKeySel_A40154_1 = 102604401,
		// Token: 0x0400079C RID: 1948
		ConventionalPersonality_CnvPerTxOptionsAdaptivePower_A7405_1 = 102604501,
		// Token: 0x0400079D RID: 1949
		ConventionalPersonality_CnvPerFeatureRFModem_42485_1 = 102604601,
		// Token: 0x0400079E RID: 1950
		ConventionalPersonality_CnvPerFeaturesAstroAlertingToneTable_1 = 102604701,
		// Token: 0x0400079F RID: 1951
		ConventionalPersonality_CnvPerFeaturesAstroAlertingToneTable_2,
		// Token: 0x040007A0 RID: 1952
		ConventionalPersonality_CnvPerFeaturesOTARadioAliasType_42784_1 = 102604801,
		// Token: 0x040007A1 RID: 1953
		ConventionalPersonality_CnvPerFeaturesOTARadioAliasType_42784_2,
		// Token: 0x040007A2 RID: 1954
		ConventionalPersonality_CnvPerTxOptionsTimeOutTimersec_A9378_1 = 102604901,
		// Token: 0x040007A3 RID: 1955
		ConventionalPersonality_CnvPerRACCodeType1_A7680_1 = 102605001,
		// Token: 0x040007A4 RID: 1956
		ConventionalPersonality_CnvPerRACCodeType1_A7680_2,
		// Token: 0x040007A5 RID: 1957
		CnvPerRACSingletone_1 = 102605101,
		// Token: 0x040007A6 RID: 1958
		ConventionalSystem_ConvConfigConvSystemFeatRSISys_A41838_1 = 102700101,
		// Token: 0x040007A7 RID: 1959
		ConventionalSystem_CnvSysFeaturesRemoteRadioMode_A8935_1 = 102700201,
		// Token: 0x040007A8 RID: 1960
		ConventionalSystem_CnvSysFeatureDynRegroupZone_A40145_1 = 102700301,
		// Token: 0x040007A9 RID: 1961
		ConventionalSystem_CnvSysFeatureDynRegroupZone_A40145_2,
		// Token: 0x040007AA RID: 1962
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_1 = 102700401,
		// Token: 0x040007AB RID: 1963
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_2,
		// Token: 0x040007AC RID: 1964
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_3,
		// Token: 0x040007AD RID: 1965
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_4,
		// Token: 0x040007AE RID: 1966
		ConventionalSystem_CnvSysFeatureDynRegroupChannel_A40144_5,
		// Token: 0x040007AF RID: 1967
		ConventionalSystem_CnvSysFeatureCallType_A40147_1 = 102700501,
		// Token: 0x040007B0 RID: 1968
		Error_RadioID_Contain_F = 102700601,
		// Token: 0x040007B1 RID: 1969
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_1 = 102700701,
		// Token: 0x040007B2 RID: 1970
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_2,
		// Token: 0x040007B3 RID: 1971
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_3,
		// Token: 0x040007B4 RID: 1972
		ConventionalSystem_CnvSysGeneralDataProfileSelection_A13266_4,
		// Token: 0x040007B5 RID: 1973
		ConventionalSystem_CnvSysGeneralEmergencyProfileSelection_A19421_1 = 102700801,
		// Token: 0x040007B6 RID: 1974
		ConventionalSystem_CnvSysFeaturesSelectCallInCallReset_A9102_1 = 102700901,
		// Token: 0x040007B7 RID: 1975
		ConventionalSystem_CnvSysFeaturesSelectCallInCallReset_A9102_2,
		// Token: 0x040007B8 RID: 1976
		ConventionalSystem_DataProfFeaturesTextMessagingService_A9372_1 = 102701001,
		// Token: 0x040007B9 RID: 1977
		ConventionalSystem_DataProfFeaturesTextMessagingService_A9372_2,
		// Token: 0x040007BA RID: 1978
		ConventionalSystem_CnvSysFeaturesDynamicIDEnable_A40100_1 = 102701101,
		// Token: 0x040007BB RID: 1979
		ConventionalSystem_CnvSysSecureDynTGKeySel_A40133_1 = 102701201,
		// Token: 0x040007BC RID: 1980
		ConventionalSystem_CnvSysSecureFSKeySel_A40134_1 = 102701301,
		// Token: 0x040007BD RID: 1981
		ConventionalSystem_CnvSysSecureInterConnectKeySel_A40135_1 = 102701401,
		// Token: 0x040007BE RID: 1982
		ConventionalSystem_CnvSysSecurePatchKeySel_A40136_1 = 102701501,
		// Token: 0x040007BF RID: 1983
		ConventionalSystem_CnvSysSecurePrivateCallKeySel_A40137_1 = 102701601,
		// Token: 0x040007C0 RID: 1984
		ConventionalSystem_CnvSysFeaturesCAIDataRegistration_A7585_1 = 102701701,
		// Token: 0x040007C1 RID: 1985
		ConventionalSystem_CnvSysGeneralIndividualID_A8287_1 = 102701801,
		// Token: 0x040007C2 RID: 1986
		ConventionalSystem_CnvSysGeneralIndividualID_A8287_2,
		// Token: 0x040007C3 RID: 1987
		ConventionalSystem_CnvSysFeaturesPASelection_A42880_1 = 102701901,
		// Token: 0x040007C4 RID: 1988
		ConventionalSystem_CnvSysGeneralQc2Code_A42234_1 = 102702001,
		// Token: 0x040007C5 RID: 1989
		ConventionalSystem_CnvSysFeaturesSendLocationToPeer_42427_1 = 102702101,
		// Token: 0x040007C6 RID: 1990
		BacklightColor_ColorText_1 = 103100101,
		// Token: 0x040007C7 RID: 1991
		ZnChanCfgChannelsChannelName_A7659_1 = 103300001,
		// Token: 0x040007C8 RID: 1992
		ZnChanCfgChannelsPersonality_A8698_1 = 103300101,
		// Token: 0x040007C9 RID: 1993
		ZnChanCfgChannelsPersonality_A8698_2,
		// Token: 0x040007CA RID: 1994
		ZnChanCfgChannelsPersonality_A8698_3,
		// Token: 0x040007CB RID: 1995
		ZnChanCfgChannelsPersonality_A8698_4,
		// Token: 0x040007CC RID: 1996
		ZnChanCfgChannelsTalkgroup_A9276_1 = 103300201,
		// Token: 0x040007CD RID: 1997
		ZnChanCfgChannelsTalkgroup_A9276_2,
		// Token: 0x040007CE RID: 1998
		ZnChanCfgChannelsTalkgroup_A9276_3,
		// Token: 0x040007CF RID: 1999
		ZnChanCfgChannelsTalkgroup_A9276_4,
		// Token: 0x040007D0 RID: 2000
		ZnChanCfgChannelsTalkgroup_A9276_5,
		// Token: 0x040007D1 RID: 2001
		ZnChanCfgChannelsConventionalChannelReference_A20560_1 = 103300301,
		// Token: 0x040007D2 RID: 2002
		ZnChanCfgChannelsFiregroundSectorID_A33630_1 = 103300401,
		// Token: 0x040007D3 RID: 2003
		Channels_ChannelsChannel_1 = 103300501,
		// Token: 0x040007D4 RID: 2004
		Channels_ChannelsChannel_2,
		// Token: 0x040007D5 RID: 2005
		Channels_ChannelsChannel_3,
		// Token: 0x040007D6 RID: 2006
		Channels_ChannelsChannel_4,
		// Token: 0x040007D7 RID: 2007
		Channels_ChannelsChannel_5,
		// Token: 0x040007D8 RID: 2008
		Channels_ChannelsChannel_6,
		// Token: 0x040007D9 RID: 2009
		Channels_ChannelsChannel_7,
		// Token: 0x040007DA RID: 2010
		Channels_ChannelsChannel_8,
		// Token: 0x040007DB RID: 2011
		Channels_ChannelsChannel_9,
		// Token: 0x040007DC RID: 2012
		ConsolidatedActions_RadioErgoConfigACGeneralChannel_A36593_1 = 103500101,
		// Token: 0x040007DD RID: 2013
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_1 = 103500201,
		// Token: 0x040007DE RID: 2014
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_2,
		// Token: 0x040007DF RID: 2015
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_3,
		// Token: 0x040007E0 RID: 2016
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_4,
		// Token: 0x040007E1 RID: 2017
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_5,
		// Token: 0x040007E2 RID: 2018
		ConsolidatedActions_RadioErgoConfigACActionID_A36590_6,
		// Token: 0x040007E3 RID: 2019
		ConsolidatedActions_Zone_1 = 103500301,
		// Token: 0x040007E4 RID: 2020
		ConsolidatedActions_RadioErgoConfigACAlertInterval_A42877_1 = 103500401,
		// Token: 0x040007E5 RID: 2021
		ConsolidatedActions_RadioErgoConfigACAlertInterval_A42877_2,
		// Token: 0x040007E6 RID: 2022
		ConventionalEmergencyProfiles_CnvEmerProfMDCEnable2_A7924_1 = 104000101,
		// Token: 0x040007E7 RID: 2023
		ConventionalEmergencyProfiles_ConEmerProEmergencyAutoTransmitMode_A22532_1 = 104000201,
		// Token: 0x040007E8 RID: 2024
		ConventionalEmergencyToneList_EmerTonePeriodSec_42048_1 = 104100101,
		// Token: 0x040007E9 RID: 2025
		ConventionalWide_CnvWideConventionalCustomerID_41558_1 = 104500001,
		// Token: 0x040007EA RID: 2026
		DataProfiles_DataProfilesDACOperationalMode_A36199_1 = 104600101,
		// Token: 0x040007EB RID: 2027
		DataProfiles_DataProfilesDACOperationalMode_A36199_2,
		// Token: 0x040007EC RID: 2028
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_1 = 104700101,
		// Token: 0x040007ED RID: 2029
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_2,
		// Token: 0x040007EE RID: 2030
		DataProfiles_DataProfilesGeneralBTDUNSUIPAddress_A41126_3,
		// Token: 0x040007EF RID: 2031
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_1 = 104700201,
		// Token: 0x040007F0 RID: 2032
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_2,
		// Token: 0x040007F1 RID: 2033
		DataProfiles_DataProfilesGeneralBTDUNPeerIPAddress_A41127_3,
		// Token: 0x040007F2 RID: 2034
		DataProfiles_DataProfGeneralSubscriberIPAddress_A21157_2 = 104700402,
		// Token: 0x040007F3 RID: 2035
		DataProfiles_DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_1 = 104700501,
		// Token: 0x040007F4 RID: 2036
		DataProfiles_DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_2,
		// Token: 0x040007F5 RID: 2037
		DataProfiles_DataProfGeneralPacketDataMode_A8689_1 = 104700601,
		// Token: 0x040007F6 RID: 2038
		DataProfiles_DataProfLTEEnabled_A42075_1 = 104700701,
		// Token: 0x040007F7 RID: 2039
		DataProfiles_DataWideGeneralNATEnable_A38866_1 = 104700801,
		// Token: 0x040007F8 RID: 2040
		DataProfiles_DatProFeaturesPADMode_A20536_1 = 104700901,
		// Token: 0x040007F9 RID: 2041
		DataProfiles_DataProfFeaturesAutomaticRegistrationServerAddress_A7524_1 = 104701001,
		// Token: 0x040007FA RID: 2042
		DataProfiles_DataProfFeaturesAutomaticRegistrationServerAddress_A7524_2,
		// Token: 0x040007FB RID: 2043
		DataProfiles_DatProFeaturesDestinationPort_A20544_1 = 104701101,
		// Token: 0x040007FC RID: 2044
		DataProfiles_DatProFeaturesEscapeSequence_A20539_1 = 104701201,
		// Token: 0x040007FD RID: 2045
		DataProfiles_DatProFeaturesStopSequence_A20538_1 = 104701301,
		// Token: 0x040007FE RID: 2046
		DataProfiles_DatProFeaturesStartSequence_A20537_1 = 104701401,
		// Token: 0x040007FF RID: 2047
		DataProfiles_DataProfFeaturesARSMode_A7465_1 = 104701501,
		// Token: 0x04000800 RID: 2048
		DataProfiles_DataProfFeaturesLocServerIPAddr_A42333_1 = 104701601,
		// Token: 0x04000801 RID: 2049
		DataProfiles_DataConigurationDataProfilePacketDataRegistrationVersion_A36210_1 = 104701701,
		// Token: 0x04000802 RID: 2050
		DataProfiles_DataProfNLSKeySele_A36410_1 = 104701801,
		// Token: 0x04000803 RID: 2051
		DataProfiles_DataProfNLSKeySele_A36410_2,
		// Token: 0x04000804 RID: 2052
		DataProfiles_DatProFeaturesDestinationAddress_A20543_1 = 104701901,
		// Token: 0x04000805 RID: 2053
		DataProfiles_DataProfNLSSecClrStrp_A36415_1 = 104702001,
		// Token: 0x04000806 RID: 2054
		DataProfiles_DataProfBroadbandSource_A42858_1,
		// Token: 0x04000807 RID: 2055
		DataProfiles_DataProfBroadbandSource_A42858_2,
		// Token: 0x04000808 RID: 2056
		DataWide_DataWideNATListLANPort_A8385_1 = 105000101,
		// Token: 0x04000809 RID: 2057
		DataWide_DataWideEnhDataPortListPortNum_A42008_1 = 105000201,
		// Token: 0x0400080A RID: 2058
		DataWide_DataWideEnhDataPortListPortNum_A42008_2,
		// Token: 0x0400080B RID: 2059
		DataWide_DataWideEnhDataPortListPortNum_A42008_3,
		// Token: 0x0400080C RID: 2060
		DataWide_QuickTextMessage_1 = 105000301,
		// Token: 0x0400080D RID: 2061
		DataWide_DataWideGeneralBTDUNSUIPAddress_A41120_2 = 105000402,
		// Token: 0x0400080E RID: 2062
		DataWide_DataWideGeneralBTDUNSUIPAddress_A41120_3,
		// Token: 0x0400080F RID: 2063
		DataWide_DataWideGeneralMobileSubIPAddress_A41819_2 = 105000502,
		// Token: 0x04000810 RID: 2064
		DataWide_DataWideGeneralDVRIPAddress_A41818_2 = 105000602,
		// Token: 0x04000811 RID: 2065
		DataWide_DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_1 = 105000701,
		// Token: 0x04000812 RID: 2066
		DataWide_DataWideP25LocationReportingUDPPort_42413_1 = 105000801,
		// Token: 0x04000813 RID: 2067
		DataWide_DataWideP25LocationReportingUDPPort_42413_2,
		// Token: 0x04000814 RID: 2068
		DataWide_DataWideP25LocationReportingUDPPort_42413_3,
		// Token: 0x04000815 RID: 2069
		DataWide_DataWideP25LocationReportingUDPPort_42413_4,
		// Token: 0x04000816 RID: 2070
		DataWide_DataWideP25LocationReportingUDPPort_42413_5,
		// Token: 0x04000817 RID: 2071
		DataWide_DataWideP25LocationReportingUDPPort_42413_6,
		// Token: 0x04000818 RID: 2072
		DataWide_DataWideGeneralInternalRadioSubnet_A42073_1 = 105000901,
		// Token: 0x04000819 RID: 2073
		DataWide_DataWideGeneralInternalRadioSubnet_A42073_2,
		// Token: 0x0400081A RID: 2074
		DataWide_DataWideWIFIOTAPTCPPort_42627_0 = 105001000,
		// Token: 0x0400081B RID: 2075
		DataWide_DataWideWIFIOTAPTCPPort_42627_1,
		// Token: 0x0400081C RID: 2076
		DataWide_DataWideWIFIOTAPTCPPort_42627_2,
		// Token: 0x0400081D RID: 2077
		DataWide_DataWideWIFIOTAPTCPPort_42627_3,
		// Token: 0x0400081E RID: 2078
		DataWide_DataWideWIFIOTAPTCPPort_42627_4,
		// Token: 0x0400081F RID: 2079
		DataWide_DataWideWIFIOTAPTCPPort_42627_5,
		// Token: 0x04000820 RID: 2080
		DataWide_DataWideWIFIOTAPTCPPort_42627_6,
		// Token: 0x04000821 RID: 2081
		DataWide_SensorMeasurementReportingUDPPort_A43022_0,
		// Token: 0x04000822 RID: 2082
		DataWide_SensorMeasurementReportingUDPPort_A43022_1,
		// Token: 0x04000823 RID: 2083
		DataWide_SensorMeasurementReportingUDPPort_A43022_2,
		// Token: 0x04000824 RID: 2084
		DataWide_SensorMeasurementReportingUDPPort_A43022_3,
		// Token: 0x04000825 RID: 2085
		DataWide_SensorMeasurementReportingUDPPort_A43022_4,
		// Token: 0x04000826 RID: 2086
		DataWide_SensorMeasurementReportingUDPPort_A43022_5,
		// Token: 0x04000827 RID: 2087
		DataWide_SensorMeasurementReportingUDPPort_A43022_6,
		// Token: 0x04000828 RID: 2088
		DataWide_DataWideDataModemPassword_A42848_1,
		// Token: 0x04000829 RID: 2089
		DataWide_DataWideDataModemPassword_A42848_2,
		// Token: 0x0400082A RID: 2090
		DEKButtons_DEKButtonFeature_A21353_1 = 105100101,
		// Token: 0x0400082B RID: 2091
		DEKButtons_DEKButtonFeature_A21353_2,
		// Token: 0x0400082C RID: 2092
		DEKButtons_DEKButtonFeature_A21353_3,
		// Token: 0x0400082D RID: 2093
		DEKButtons_DEKButtonIndex_A22570_1 = 105100201,
		// Token: 0x0400082E RID: 2094
		DEKButtons_DEKButtonIndex_A22570_2,
		// Token: 0x0400082F RID: 2095
		DEKButtons_DEKZone_A22566_1 = 105100301,
		// Token: 0x04000830 RID: 2096
		DEKVIP_DEKVIPOutputFeature_A21346_1 = 105200101,
		// Token: 0x04000831 RID: 2097
		DEKVIP_DEKVIPOutputFeature_A21346_2,
		// Token: 0x04000832 RID: 2098
		DEKVIP_DEKVIPOutputFeature_A21346_3,
		// Token: 0x04000833 RID: 2099
		DEKVIP_DEKVIPOutputFeature_A21346_4,
		// Token: 0x04000834 RID: 2100
		DEKVIP_DEKVIPOutputFeature_A21346_5,
		// Token: 0x04000835 RID: 2101
		DEKVIP_DEKVIPOutputFeature_A21346_6,
		// Token: 0x04000836 RID: 2102
		DEKVIP_DEKVIPOutputFeature_A21346_7,
		// Token: 0x04000837 RID: 2103
		DEKVIP_DEKVIPOutputFeature_A21346_8,
		// Token: 0x04000838 RID: 2104
		DEKVIP_DEKVIPOutputFeature_A21346_9,
		// Token: 0x04000839 RID: 2105
		DEKVIP_DEKVIPOutputFeature_A21346_10,
		// Token: 0x0400083A RID: 2106
		DEKVIPInputFeature_A21338_1 = 105200201,
		// Token: 0x0400083B RID: 2107
		DEKVIPInputFeature_A21338_2,
		// Token: 0x0400083C RID: 2108
		O9DirectionalButtons_Feature_1 = 105300101,
		// Token: 0x0400083D RID: 2109
		O9DirectionalButtons_Feature_2,
		// Token: 0x0400083E RID: 2110
		O9DirectionalButtons_Index_1 = 105300201,
		// Token: 0x0400083F RID: 2111
		O9DirectionalButtons_Index_2,
		// Token: 0x04000840 RID: 2112
		O9DirectionalButtons_Index_3,
		// Token: 0x04000841 RID: 2113
		O9DirectionalButtons_Index_4,
		// Token: 0x04000842 RID: 2114
		O9DirectionalButtons_Prepend_Index_1 = 105300301,
		// Token: 0x04000843 RID: 2115
		Display_ScrollConfigurationFastScrollRatems_1 = 105700101,
		// Token: 0x04000844 RID: 2116
		Display_DefaultBacklightColor_1 = 105700201,
		// Token: 0x04000845 RID: 2117
		Display_FeatureInactivityTimeoutsec_1 = 105700301,
		// Token: 0x04000846 RID: 2118
		Display_FeatureInactivityAlertTone_1 = 105700401,
		// Token: 0x04000847 RID: 2119
		Language_DispMenuAdvancedLanguageSelection_A8386_ChineseTradition = 105790001,
		// Token: 0x04000848 RID: 2120
		Language_DispMenuAdvancedLanguageSelection_A8386_Arabic,
		// Token: 0x04000849 RID: 2121
		DTMFTiming_PhnWideDTMFCodesDeaccess_A7803_1 = 105900101,
		// Token: 0x0400084A RID: 2122
		DVRSProfGeneralMSUSysPTTInLocalMode_A41803_1 = 106500101,
		// Token: 0x0400084B RID: 2123
		DVRSProfGeneralLocalTxFallback_A41806_1 = 106500201,
		// Token: 0x0400084C RID: 2124
		EIDBypassList_DataProfEIDByPassListIPAddr_A36417_1 = 106700001,
		// Token: 0x0400084D RID: 2125
		EIDBypassList_DataProfEIDByPassListIPAddr_A36417_2,
		// Token: 0x0400084E RID: 2126
		EmergencyWide_EmerWideGeneralSuppressEmergencyCall_A42142_1 = 1069001001,
		// Token: 0x0400084F RID: 2127
		EmergencyWide_EmerWideGeneralEmergencyPowerUp_A7942_1 = 1069002001,
		// Token: 0x04000850 RID: 2128
		EmergencyWide_EmerWideGeneralUnmuteOption_A9598_1 = 1069003001,
		// Token: 0x04000851 RID: 2129
		EncryptionKeyList_SecWideMultikeyListCKR_A7665_1 = 107000101,
		// Token: 0x04000852 RID: 2130
		EncryptionKeyList_SecWideMultikeyListKeyName_A8362_1 = 107000201,
		// Token: 0x04000853 RID: 2131
		EncryptionKeyList_SecWideMultikeyListSelectableADPKeyID_A9107_1 = 107000301,
		// Token: 0x04000854 RID: 2132
		EncryptionKeyList_SecWideMultikeyListSelectableADPKeyData_A9106_1 = 107000401,
		// Token: 0x04000855 RID: 2133
		GlobalFrequencyOptions_FrequencyMustBeInValidRange = 107500000,
		// Token: 0x04000856 RID: 2134
		GlobalFrequencyOptions_FrequencyMustBeOnValidStep,
		// Token: 0x04000857 RID: 2135
		GlobalFrequencyOptions_NetworkIDCanotBe3966,
		// Token: 0x04000858 RID: 2136
		GlobalFrequencyOptions_RxNetworkIDValueMustBeSameAsFirstOne,
		// Token: 0x04000859 RID: 2137
		GlobalFrequencyOptions_TxNetworkIDValueMustBeSameAsFirstOne,
		// Token: 0x0400085A RID: 2138
		GlobalFrequencyOptions_AstroTalkgroupIDInvalid,
		// Token: 0x0400085B RID: 2139
		GlobalFrequencyOptions_TxFrequencyValueMustBeSameAsFirstOne,
		// Token: 0x0400085C RID: 2140
		GlobalFrequencyOptions_TxDeviationSpacing,
		// Token: 0x0400085D RID: 2141
		GlobalFrequencyOptions_TxDeviationChannelSpacingValueMustBeSameAsFirstOne,
		// Token: 0x0400085E RID: 2142
		GlobalFrequencyOptions_TxFrequencyIsNotInFCCAllowedRange,
		// Token: 0x0400085F RID: 2143
		GlobalFrequencyOptions_DirectTalkaroundMustBeDisabled,
		// Token: 0x04000860 RID: 2144
		GlobalFrequencyOptions_DirectTalkaroundMustBeDisabled2,
		// Token: 0x04000861 RID: 2145
		GlobalFrequencyOptions_DynamiceRegroupEnableDYN,
		// Token: 0x04000862 RID: 2146
		GlobalFrequencyOptions_ATGtalkgroupDisabled,
		// Token: 0x04000863 RID: 2147
		GlobalFrequencyOptions_RxTADPLValueMustBeSameAsFirstOne,
		// Token: 0x04000864 RID: 2148
		GlobalFrequencyOptions_RxTADPLInvertValueMustBeSameAsFirstOne,
		// Token: 0x04000865 RID: 2149
		GlobalFrequencyOptions_VoteScanEnableSelectPLMPL,
		// Token: 0x04000866 RID: 2150
		GlobalFrequencyOptions_TxSquelchTypeMustBeSameAsFirstOne,
		// Token: 0x04000867 RID: 2151
		GlobalFrequencyOptions_TxPLFreqMustBeSameAsFirstOne,
		// Token: 0x04000868 RID: 2152
		GlobalFrequencyOptions_TxPLCodeMustBeSameAsFirstOne,
		// Token: 0x04000869 RID: 2153
		GlobalFrequencyOptions_TxDPLInvertMustBeSameAsFirstOne,
		// Token: 0x0400086A RID: 2154
		GlobalFrequencyOptions_TxDPLCodeMustBeSameAsFirstOne,
		// Token: 0x0400086B RID: 2155
		GlobalFrequencyOptions_RxTASquelchTypeMustBeSameAsFirstOne,
		// Token: 0x0400086C RID: 2156
		GlobalFrequencyOptions_RxTAPLFreqMustBeSameAsFirstOne,
		// Token: 0x0400086D RID: 2157
		GlobalFrequencyOptions_RxTAPLCodeMustBeSameAsFirstOne,
		// Token: 0x0400086E RID: 2158
		GlobalFrequencyOptions_25125InvalidInASTROMode,
		// Token: 0x0400086F RID: 2159
		GlobalFrequencyOptions_25125InvalidInNonASTROMode,
		// Token: 0x04000870 RID: 2160
		GlobalFrequencyOptions_TxFrequency_FrequencyMustBeInValidRange,
		// Token: 0x04000871 RID: 2161
		GlobalFrequencyOptions_TxFrequency_FrequencyMustBeOnValidStep,
		// Token: 0x04000872 RID: 2162
		GlobalFrequencyOptions_UserSelectableEnhance_MustBeDisabled,
		// Token: 0x04000873 RID: 2163
		Error_string_must_be_16 = 107600001,
		// Token: 0x04000874 RID: 2164
		Error_string_must_be_64,
		// Token: 0x04000875 RID: 2165
		Error_string_must_be_124,
		// Token: 0x04000876 RID: 2166
		Error_string_must_be_248,
		// Token: 0x04000877 RID: 2167
		Error_string_must_be_128_or_more,
		// Token: 0x04000878 RID: 2168
		IDDisplayTable_Display_1 = 107900101,
		// Token: 0x04000879 RID: 2169
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_1 = 108100101,
		// Token: 0x0400087A RID: 2170
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_2,
		// Token: 0x0400087B RID: 2171
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_3,
		// Token: 0x0400087C RID: 2172
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_4,
		// Token: 0x0400087D RID: 2173
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_5,
		// Token: 0x0400087E RID: 2174
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_6,
		// Token: 0x0400087F RID: 2175
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_7,
		// Token: 0x04000880 RID: 2176
		KMButton_RadErgoCfgKMConventionalKMButtonFeature_A19646_8,
		// Token: 0x04000881 RID: 2177
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_1 = 108100201,
		// Token: 0x04000882 RID: 2178
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_2,
		// Token: 0x04000883 RID: 2179
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_3,
		// Token: 0x04000884 RID: 2180
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_4,
		// Token: 0x04000885 RID: 2181
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_5,
		// Token: 0x04000886 RID: 2182
		KMButton_RadErgoCfgKMTrunkingKMButtonFeature_A19746_6,
		// Token: 0x04000887 RID: 2183
		UclMDCCnvHotList_CallID_A00047_1 = 108400101,
		// Token: 0x04000888 RID: 2184
		UclMDCCnv_PrimaryID_A00030_1 = 108600101,
		// Token: 0x04000889 RID: 2185
		UclMDCCnv_PrimaryID_A00030_2,
		// Token: 0x0400088A RID: 2186
		UclMDCCnv_PrimaryID_A00030_3,
		// Token: 0x0400088B RID: 2187
		UclMDCCnv_PrimaryID_A00030_4,
		// Token: 0x0400088C RID: 2188
		UclMDCCnv_PrimaryID_A00030_5,
		// Token: 0x0400088D RID: 2189
		UclMDCCnv_SystemAlias_A00028_1 = 108600201,
		// Token: 0x0400088E RID: 2190
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_1 = 109300100,
		// Token: 0x0400088F RID: 2191
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_2,
		// Token: 0x04000890 RID: 2192
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_3,
		// Token: 0x04000891 RID: 2193
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_4,
		// Token: 0x04000892 RID: 2194
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_5,
		// Token: 0x04000893 RID: 2195
		MobileControl_BtnTrunkingButtonDatatButtonFeature_A22608_6,
		// Token: 0x04000894 RID: 2196
		MobileControl_CHO3DataButtonConvIndex_A41419_1 = 109300200,
		// Token: 0x04000895 RID: 2197
		MobileControl_CHO3DataButtonConvIndex_A41419_2,
		// Token: 0x04000896 RID: 2198
		MobileControl_CHO3DataButtonConvIndex_A41419_3,
		// Token: 0x04000897 RID: 2199
		MobileControl_CHO3DataButtonConvIndex_A41419_4,
		// Token: 0x04000898 RID: 2200
		MobileControl_CHO3DataButtonConvIndex_A41419_5,
		// Token: 0x04000899 RID: 2201
		MobileControl_CHO3DataButtonConvIndex_A41419_6,
		// Token: 0x0400089A RID: 2202
		MobileControl_DataButtons_ConventionalFeature_1 = 109300300,
		// Token: 0x0400089B RID: 2203
		MobileControl_DataButtons_ConventionalFeature_2,
		// Token: 0x0400089C RID: 2204
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_1 = 109300400,
		// Token: 0x0400089D RID: 2205
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_2,
		// Token: 0x0400089E RID: 2206
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_3,
		// Token: 0x0400089F RID: 2207
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_4,
		// Token: 0x040008A0 RID: 2208
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_5,
		// Token: 0x040008A1 RID: 2209
		CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_x,
		// Token: 0x040008A2 RID: 2210
		MobileConvMenuItems_ConventionalSelectedMenuItem_1 = 109400101,
		// Token: 0x040008A3 RID: 2211
		MobileConvMenuItems_ConventionalSelectedMenuItem_2 = 109400201,
		// Token: 0x040008A4 RID: 2212
		MobileKeypadButton_Index_1 = 109600101,
		// Token: 0x040008A5 RID: 2213
		MobileKeypadButton_Index_2,
		// Token: 0x040008A6 RID: 2214
		MobileKeypadButton_Prepend_Index_1 = 109600201,
		// Token: 0x040008A7 RID: 2215
		MobileKeypadButton_Feature_1 = 109600301,
		// Token: 0x040008A8 RID: 2216
		MobileKeypadButton_Feature_2,
		// Token: 0x040008A9 RID: 2217
		MobileKeypadButton_Feature_3,
		// Token: 0x040008AA RID: 2218
		MobileKeypadButton_Feature_4,
		// Token: 0x040008AB RID: 2219
		MobileKeypadButton_Feature_5,
		// Token: 0x040008AC RID: 2220
		MobileKeypadButton_Feature_6,
		// Token: 0x040008AD RID: 2221
		MobileKeypadButton_Feature_7,
		// Token: 0x040008AE RID: 2222
		MobileKeypadButton_Feature_8,
		// Token: 0x040008AF RID: 2223
		MobileMFKAssignmentControl_Feature_1 = 109700101,
		// Token: 0x040008B0 RID: 2224
		MobileMFKAssignmentControl_Feature_2,
		// Token: 0x040008B1 RID: 2225
		MobileMFKAssignmentControl_Feature_3,
		// Token: 0x040008B2 RID: 2226
		MobileMFKAssignmentControl_Feature_4,
		// Token: 0x040008B3 RID: 2227
		O3HHCHButton_ConvAndTrkFeature_1 = 111100101,
		// Token: 0x040008B4 RID: 2228
		O3HHCHButton_ConvAndTrkFeature_2,
		// Token: 0x040008B5 RID: 2229
		O3HHCHButton_ConvAndTrkFeature_3,
		// Token: 0x040008B6 RID: 2230
		O9BottomFuncPgmBtn_Index_1 = 111300101,
		// Token: 0x040008B7 RID: 2231
		O9BottomFuncPgmBtn_Index_2,
		// Token: 0x040008B8 RID: 2232
		O9BottomFuncPgmBtn_Index_3,
		// Token: 0x040008B9 RID: 2233
		O9BottomFuncPgmBtn_Index_4,
		// Token: 0x040008BA RID: 2234
		O9BottomFuncPgmBtn_Index_5,
		// Token: 0x040008BB RID: 2235
		O9BottomFuncPgmBtn_Index_6,
		// Token: 0x040008BC RID: 2236
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_1 = 111300201,
		// Token: 0x040008BD RID: 2237
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_2,
		// Token: 0x040008BE RID: 2238
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_3,
		// Token: 0x040008BF RID: 2239
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_4,
		// Token: 0x040008C0 RID: 2240
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_5,
		// Token: 0x040008C1 RID: 2241
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_6,
		// Token: 0x040008C2 RID: 2242
		O9BottomFunctionButton_CHO9BottomFunctionButtonFeature_A36664_7,
		// Token: 0x040008C3 RID: 2243
		OTACItem_CnvWideASTROOTACChannel_A8629_1 = 115000101,
		// Token: 0x040008C4 RID: 2244
		OTACItem_CnvWideASTROOTACChannel_A8629_2,
		// Token: 0x040008C5 RID: 2245
		OTACItem_CnvWideASTROOTACZone_A8645_1 = 115000201,
		// Token: 0x040008C6 RID: 2246
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_1 = 111600101,
		// Token: 0x040008C7 RID: 2247
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_2,
		// Token: 0x040008C8 RID: 2248
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_3,
		// Token: 0x040008C9 RID: 2249
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_4,
		// Token: 0x040008CA RID: 2250
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_5,
		// Token: 0x040008CB RID: 2251
		PASirenButtons_CHO9PASirenButtonsFeature_A41540_6,
		// Token: 0x040008CC RID: 2252
		PerAccList_RadioErgoConfigACReference_A42911_1 = 111600201,
		// Token: 0x040008CD RID: 2253
		UclPhoneHotList_CallID_A00050_1 = 111700101,
		// Token: 0x040008CE RID: 2254
		UclPhone_ListinfoPhoneCategory_A00034_1 = 111900101,
		// Token: 0x040008CF RID: 2255
		UclPhone_PhoneNumber_A00033_1 = 111900201,
		// Token: 0x040008D0 RID: 2256
		UclPhone_PhoneNumber_A00033_2,
		// Token: 0x040008D1 RID: 2257
		PortableButton_BtnGeneralConventionalFeature_A19544_1 = 112100101,
		// Token: 0x040008D2 RID: 2258
		PortableButton_BtnGeneralConventionalFeature_A19544_2,
		// Token: 0x040008D3 RID: 2259
		PortableButton_BtnGeneralConventionalFeature_A19544_3,
		// Token: 0x040008D4 RID: 2260
		PortableButton_BtnGeneralConventionalFeature_A19544_4,
		// Token: 0x040008D5 RID: 2261
		PortableButton_BtnGeneralConventionalFeature_A19544_5,
		// Token: 0x040008D6 RID: 2262
		PortableButton_BtnGeneralConventionalFeature_A19544_6,
		// Token: 0x040008D7 RID: 2263
		PortableButton_BtnGeneralConventionalFeature_A19544_7,
		// Token: 0x040008D8 RID: 2264
		PortableButton_BtnGeneralConventionalFeature_A19544_8,
		// Token: 0x040008D9 RID: 2265
		PortableButton_BtnGeneralConventionalFeature_A19544_9,
		// Token: 0x040008DA RID: 2266
		PortableButton_BtnGeneralConventionalFeature_A19544_10,
		// Token: 0x040008DB RID: 2267
		PortableButton_BtnGeneralConventionalFeature_A19544_11,
		// Token: 0x040008DC RID: 2268
		PortableButton_BtnGeneralConventionalFeature_A19544_12,
		// Token: 0x040008DD RID: 2269
		PortableButton_BtnGeneralConventionalFeature_A19544_13,
		// Token: 0x040008DE RID: 2270
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_1 = 112100201,
		// Token: 0x040008DF RID: 2271
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_2,
		// Token: 0x040008E0 RID: 2272
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_3,
		// Token: 0x040008E1 RID: 2273
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_4,
		// Token: 0x040008E2 RID: 2274
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_5,
		// Token: 0x040008E3 RID: 2275
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_6,
		// Token: 0x040008E4 RID: 2276
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_7,
		// Token: 0x040008E5 RID: 2277
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_8,
		// Token: 0x040008E6 RID: 2278
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_9,
		// Token: 0x040008E7 RID: 2279
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_10,
		// Token: 0x040008E8 RID: 2280
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_11,
		// Token: 0x040008E9 RID: 2281
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_12,
		// Token: 0x040008EA RID: 2282
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_13,
		// Token: 0x040008EB RID: 2283
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_14,
		// Token: 0x040008EC RID: 2284
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_15,
		// Token: 0x040008ED RID: 2285
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_16,
		// Token: 0x040008EE RID: 2286
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_17,
		// Token: 0x040008EF RID: 2287
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_18,
		// Token: 0x040008F0 RID: 2288
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_19,
		// Token: 0x040008F1 RID: 2289
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_20,
		// Token: 0x040008F2 RID: 2290
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_21,
		// Token: 0x040008F3 RID: 2291
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_22,
		// Token: 0x040008F4 RID: 2292
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_23,
		// Token: 0x040008F5 RID: 2293
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_24,
		// Token: 0x040008F6 RID: 2294
		PortableButton_BtnTrunkingPortableButtonFeature_A19546_25,
		// Token: 0x040008F7 RID: 2295
		PortConvMenuItems_ConventionalSelectedMenuItem_1 = 112200101,
		// Token: 0x040008F8 RID: 2296
		BtnSideUpDownArrowButtonPrimaryFunction_A41568_1 = 112500101,
		// Token: 0x040008F9 RID: 2297
		BtnSideUpDownArrowButtonSecondaryFunction_A41592_1 = 112500201,
		// Token: 0x040008FA RID: 2298
		RadErgoWideAdvancedLongKeypressDurationms_A8450_1 = 113000101,
		// Token: 0x040008FB RID: 2299
		RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_1 = 113000201,
		// Token: 0x040008FC RID: 2300
		RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451_2,
		// Token: 0x040008FD RID: 2301
		RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126_1,
		// Token: 0x040008FE RID: 2302
		RadErgoWidePASirenManualTone_A8464_1 = 113000301,
		// Token: 0x040008FF RID: 2303
		RadErgoWideControlHeadMulCHTxAudioRouting_A38459_1 = 113000401,
		// Token: 0x04000900 RID: 2304
		RadErgoWideControlHeadControlHeadVIPInputSource_A7724_1 = 113000501,
		// Token: 0x04000901 RID: 2305
		RadErgoWideControlHeadControlHeadVIPInputSource_A7724_2,
		// Token: 0x04000902 RID: 2306
		RadErgoWideAdvancedLongKeypressDurationforMFK_A38506_1 = 113000601,
		// Token: 0x04000903 RID: 2307
		RadErgoWidePASirenSirenPAAfterReset_A9140_1 = 113000701,
		// Token: 0x04000904 RID: 2308
		RadErgoWidePASirenSirenPAAfterReset_A9140_2,
		// Token: 0x04000905 RID: 2309
		RadErgoWidePASirenSirenPAAfterReset_A9140_3,
		// Token: 0x04000906 RID: 2310
		RadErgoWideHomeModeZone_A9691_1 = 113000801,
		// Token: 0x04000907 RID: 2311
		RadErgoWideHomeModeZone_A9691_2,
		// Token: 0x04000908 RID: 2312
		HomeModeChannel_1 = 113000901,
		// Token: 0x04000909 RID: 2313
		HomeModeChannel_2,
		// Token: 0x0400090A RID: 2314
		HomeModeChannel_3,
		// Token: 0x0400090B RID: 2315
		RadErgoWideAdvancedConsoletteEnable_A37231_1 = 113001001,
		// Token: 0x0400090C RID: 2316
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_1 = 113001101,
		// Token: 0x0400090D RID: 2317
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_2,
		// Token: 0x0400090E RID: 2318
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_3,
		// Token: 0x0400090F RID: 2319
		RadErgoWideControlHeadExpectedNumofControlHeads_A7982_4,
		// Token: 0x04000910 RID: 2320
		RadioErgonomicsWide_RadErgoWideHornandLightsHornLights_A8206_1 = 113001201,
		// Token: 0x04000911 RID: 2321
		RadioErgonomicsWide_RadErgoWidePASirenSirenOperation_A9139_1 = 113001301,
		// Token: 0x04000912 RID: 2322
		RadioErgonomicsWide_RadErgoWideControlHeadAggregateCableLength_A38456_1 = 113001401,
		// Token: 0x04000913 RID: 2323
		RadioErgonomicsWide_RadErgoWideControlHeadMultiControlHead_A8550_1 = 113001501,
		// Token: 0x04000914 RID: 2324
		RadioErgonomicsWide_RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787_1 = 113001601,
		// Token: 0x04000915 RID: 2325
		RadErgoWideMOSCADDataEnable_A8545_1 = 113001701,
		// Token: 0x04000916 RID: 2326
		RadErgoWideMOSCADDataEnable_A8545_2,
		// Token: 0x04000917 RID: 2327
		RadErgoWideMOSCADDataEnable_A8545_3,
		// Token: 0x04000918 RID: 2328
		RadErgoWideMOSCADDataEnable_A8545_4,
		// Token: 0x04000919 RID: 2329
		McGeofencePriority_42879_1 = 113010101,
		// Token: 0x0400091A RID: 2330
		McGeofenceRadiusInMeters_42890_1,
		// Token: 0x0400091B RID: 2331
		McGeofenceRadiusInMeters_42890_2,
		// Token: 0x0400091C RID: 2332
		RadioErgoConfigACActionType_A42871_1,
		// Token: 0x0400091D RID: 2333
		RadioErgoConfigACActionType_A42871_2,
		// Token: 0x0400091E RID: 2334
		RadioProfiles_MinimumAlertToneVolume_1 = 113100101,
		// Token: 0x0400091F RID: 2335
		RadioProfiles_VolumeControlMinimumAudioVolume_1 = 113100201,
		// Token: 0x04000920 RID: 2336
		RadioProfiles_TxDigitalAnalogBalance_1 = 113100301,
		// Token: 0x04000921 RID: 2337
		RadioProfiles_IntelligentLightingDisableCallNotification_1 = 113100401,
		// Token: 0x04000922 RID: 2338
		RadioProfiles_IntelligentLightingDisableCriticalNotification_1 = 113100501,
		// Token: 0x04000923 RID: 2339
		RadioProfiles_IntelligentLightingDisableEmergencyNotification_1 = 113100601,
		// Token: 0x04000924 RID: 2340
		RadioProfiles_SurveillanceModeDisableLights_1 = 113100701,
		// Token: 0x04000925 RID: 2341
		RadioProfiles_PermanentDisableTxRxLED_1 = 113100801,
		// Token: 0x04000926 RID: 2342
		RadioProfiles_PermanentFrontDisplayBacklight_1 = 113100901,
		// Token: 0x04000927 RID: 2343
		RadioProfiles_NoiseReductionExternalMicBackgroundNoiseReductionLevel_1 = 113101101,
		// Token: 0x04000928 RID: 2344
		RadioProfiles_NoiseReductionExternalMicBackgroundNoiseReductionLevel_2,
		// Token: 0x04000929 RID: 2345
		RadioProfiles_RadProfExternalMicWindNoiseReductionLevelSelection_A21511_1 = 113101501,
		// Token: 0x0400092A RID: 2346
		RadioProfiles_RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292_1 = 113101601,
		// Token: 0x0400092B RID: 2347
		RadioProfiles_RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292_2,
		// Token: 0x0400092C RID: 2348
		RadioProfiles_RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194_1 = 113101701,
		// Token: 0x0400092D RID: 2349
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_1 = 113101901,
		// Token: 0x0400092E RID: 2350
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_1 = 113102001,
		// Token: 0x0400092F RID: 2351
		RadioProfiles_ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_1 = 113102101,
		// Token: 0x04000930 RID: 2352
		RadioProfiles_IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_1 = 113102201,
		// Token: 0x04000931 RID: 2353
		RadioProfiles_IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_1 = 113102301,
		// Token: 0x04000932 RID: 2354
		RadioProfiles_IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_1 = 113102401,
		// Token: 0x04000933 RID: 2355
		RadioProfiles_RadProfAudioSettingsAnalogAGC2_A7439_1 = 113108501,
		// Token: 0x04000934 RID: 2356
		RadioProfiles_NoRadioWide,
		// Token: 0x04000935 RID: 2357
		RadioProfiles_RadioNOTSameAcc,
		// Token: 0x04000936 RID: 2358
		RadioProfiles_AnalogBanalanceAcc_1,
		// Token: 0x04000937 RID: 2359
		RadioProfiles_FieldValueDoesNotMatchTheGroupSettingDefinedValue_1,
		// Token: 0x04000938 RID: 2360
		RadioVIP_OutputFeature_1 = 113200101,
		// Token: 0x04000939 RID: 2361
		RadioVIP_OutputFeature_2,
		// Token: 0x0400093A RID: 2362
		RadioVIP_OutputFeature_3,
		// Token: 0x0400093B RID: 2363
		RadioVIP_OutputFeature_4,
		// Token: 0x0400093C RID: 2364
		RadioVIP_OutputFeature_5,
		// Token: 0x0400093D RID: 2365
		RadioVIP_OutputFeature_6,
		// Token: 0x0400093E RID: 2366
		RadioVIP_OutputFeature_7,
		// Token: 0x0400093F RID: 2367
		RadioVIP_OutputFeature_8,
		// Token: 0x04000940 RID: 2368
		RadioVIP_OutputFeature_9,
		// Token: 0x04000941 RID: 2369
		RadioVIP_OutputFeature_10,
		// Token: 0x04000942 RID: 2370
		RadioVIP_OutputFeature_11,
		// Token: 0x04000943 RID: 2371
		RadioVIP_OutputFeature_12,
		// Token: 0x04000944 RID: 2372
		RadioVIP_OutputFeature_13,
		// Token: 0x04000945 RID: 2373
		RadioVIP_OutputFeature_14,
		// Token: 0x04000946 RID: 2374
		RadioVIP_OutputFeature_15,
		// Token: 0x04000947 RID: 2375
		RadioVIP_OutputFeature_16,
		// Token: 0x04000948 RID: 2376
		RadioVIP_InputFeature_1 = 113200201,
		// Token: 0x04000949 RID: 2377
		RadioVIP_InputFeature_2,
		// Token: 0x0400094A RID: 2378
		RadioVIP_InputFeature_3,
		// Token: 0x0400094B RID: 2379
		GCAIVIP_InputFeature_1 = 113210000,
		// Token: 0x0400094C RID: 2380
		GCAIVIP_InputFeature_2,
		// Token: 0x0400094D RID: 2381
		AdvancedAuxTransmitSensitivity_A7530_1 = 113400101,
		// Token: 0x0400094E RID: 2382
		SwitchConventionalSwitchesPosition1_A12643_1 = 113400201,
		// Token: 0x0400094F RID: 2383
		SwitchConventionalSwitchesPosition1_A12643_2,
		// Token: 0x04000950 RID: 2384
		SwitchConventionalSwitchesPosition1_A12643_3,
		// Token: 0x04000951 RID: 2385
		RadWideLocationUserSelectableLocationEnable_A9605_1 = 113400301,
		// Token: 0x04000952 RID: 2386
		RadWideLocationUserSelectableLocationEnable_A9605_2,
		// Token: 0x04000953 RID: 2387
		RadWideLabtoolDigitalAnalogBalance_A7851_1 = 113400401,
		// Token: 0x04000954 RID: 2388
		RadWideAdvancedRFModem_A8972_1 = 113400701,
		// Token: 0x04000955 RID: 2389
		RadWideBluetoothBluetoothPANNetworkAddress_41983_1 = 113400801,
		// Token: 0x04000956 RID: 2390
		RadWideBluetoothBluetoothPANNetworkAddress_41983_2,
		// Token: 0x04000957 RID: 2391
		RadWideBluetoothBluetoothPANNetworkAddress_41983_3,
		// Token: 0x04000958 RID: 2392
		RadWideBluetoothBluetoothPANNetworkAddress_41983_4,
		// Token: 0x04000959 RID: 2393
		RadWideBluetoothBluetoothPANNetworkAddress_41983_5,
		// Token: 0x0400095A RID: 2394
		RadWideBluetoothBluetoothPANNetworkAddress_41983_6,
		// Token: 0x0400095B RID: 2395
		RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_1 = 113400901,
		// Token: 0x0400095C RID: 2396
		RadWideUserInformationandPasswordsRadioLock_A8836_1 = 113401001,
		// Token: 0x0400095D RID: 2397
		RadWideBluetoothBluetoothDropTimer_A37038_1 = 113401101,
		// Token: 0x0400095E RID: 2398
		RadWideUniversalRelayControllerEquipped_A37191_1 = 113401201,
		// Token: 0x0400095F RID: 2399
		RadWideUniversalRelayControllerEquipped_A37191_2,
		// Token: 0x04000960 RID: 2400
		RadWideDualRadioSecRadioTransmissionCapability_A42238_1 = 113401301,
		// Token: 0x04000961 RID: 2401
		RadWideDualRadioSecRadioTransmissionCapability_A42238_2,
		// Token: 0x04000962 RID: 2402
		RadWideDualRadioEmergencyRadio_A42239_1 = 113401401,
		// Token: 0x04000963 RID: 2403
		RadWideDualRadioEmergencyRadio_A42239_2,
		// Token: 0x04000964 RID: 2404
		RadWideDualRadioEmergencyRadio_A42239_3,
		// Token: 0x04000965 RID: 2405
		RadWideFeaturesTargetZoneOnOffHook_A42355,
		// Token: 0x04000966 RID: 2406
		RadWideFeaturesTargetChanOnOffHook_A42356,
		// Token: 0x04000967 RID: 2407
		RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551,
		// Token: 0x04000968 RID: 2408
		RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552,
		// Token: 0x04000969 RID: 2409
		RadWideLabtoolRadioPassword_A8837_1,
		// Token: 0x0400096A RID: 2410
		RadWideLabtoolRadioPassword_A8837_2,
		// Token: 0x0400096B RID: 2411
		RadWideFeaturesExtRFRoute_A43020_1 = 113401501,
		// Token: 0x0400096C RID: 2412
		RadWideLocationSystemManagedGeofence_43042_1 = 113401601,
		// Token: 0x0400096D RID: 2413
		RadWideGenLightBarPatternRelay1_A36506_1 = 113500101,
		// Token: 0x0400096E RID: 2414
		RadWideGenLightBarPatternRelay1_A36506_2,
		// Token: 0x0400096F RID: 2415
		RadWideGenLightBarPatternRelay2_A36507_1 = 113500201,
		// Token: 0x04000970 RID: 2416
		RadWideGenLightBarPatternRelay2_A36507_2,
		// Token: 0x04000971 RID: 2417
		RadWideGenLightBarPatternRelay3_A36508_1 = 113500301,
		// Token: 0x04000972 RID: 2418
		RadWideGenLightBarPatternRelay3_A36508_2,
		// Token: 0x04000973 RID: 2419
		RadWideGenLightBarPatternRelay4_A36509_1 = 113500401,
		// Token: 0x04000974 RID: 2420
		RadWideGenLightBarPatternRelay4_A36509_2,
		// Token: 0x04000975 RID: 2421
		RadWideGenLightBarPatternRelay5_A36510_1 = 113500501,
		// Token: 0x04000976 RID: 2422
		RadWideGenLightBarPatternRelay5_A36510_2,
		// Token: 0x04000977 RID: 2423
		RadWideGenLightBarPatternRelay6_A36511_1 = 113500601,
		// Token: 0x04000978 RID: 2424
		RadWideGenLightBarPatternRelay6_A36511_2,
		// Token: 0x04000979 RID: 2425
		RadWideGenLightBarPatternRelay7_A36512_1 = 113500701,
		// Token: 0x0400097A RID: 2426
		RadWideGenLightBarPatternRelay7_A36512_2,
		// Token: 0x0400097B RID: 2427
		RadWideGenLightBarPatternRelay8_A36513_1 = 113500801,
		// Token: 0x0400097C RID: 2428
		RadWideGenLightBarPatternRelay8_A36513_2,
		// Token: 0x0400097D RID: 2429
		RadWideGenLightBarPatternRelay9_A36515_1 = 113500901,
		// Token: 0x0400097E RID: 2430
		RadWideGenLightBarPatternRelay9_A36515_2,
		// Token: 0x0400097F RID: 2431
		RadWideGenLightBarPatternRelay10_A36516_1 = 113501001,
		// Token: 0x04000980 RID: 2432
		RadWideGenLightBarPatternRelay10_A36516_2,
		// Token: 0x04000981 RID: 2433
		O9ResponseSelector_Index_1 = 113800101,
		// Token: 0x04000982 RID: 2434
		O9ResponseSelector_Index_2,
		// Token: 0x04000983 RID: 2435
		O9ResponseSelector_Index_3,
		// Token: 0x04000984 RID: 2436
		FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_1 = 114000101,
		// Token: 0x04000985 RID: 2437
		FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_2,
		// Token: 0x04000986 RID: 2438
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_1 = 114100101,
		// Token: 0x04000987 RID: 2439
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_2,
		// Token: 0x04000988 RID: 2440
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_3,
		// Token: 0x04000989 RID: 2441
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_4,
		// Token: 0x0400098A RID: 2442
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_5,
		// Token: 0x0400098B RID: 2443
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_6,
		// Token: 0x0400098C RID: 2444
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_7,
		// Token: 0x0400098D RID: 2445
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_8,
		// Token: 0x0400098E RID: 2446
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_9,
		// Token: 0x0400098F RID: 2447
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_10,
		// Token: 0x04000990 RID: 2448
		ScanList_ScanLstGeneralDesignatedDataMember_A7829_11,
		// Token: 0x04000991 RID: 2449
		ScanList_ScanLstGeneralPriority1Type_A8745_1 = 114100201,
		// Token: 0x04000992 RID: 2450
		ScanList_ScanLstGeneralPriorityMember1_A8747_1 = 114100301,
		// Token: 0x04000993 RID: 2451
		ScanList_ScanLstGeneralPriorityMember1_A8747_2,
		// Token: 0x04000994 RID: 2452
		ScanList_ScanLstGeneralPriorityMember1_A8747_3,
		// Token: 0x04000995 RID: 2453
		ScanList_ScanLstGeneralPriorityMember2_A8749_1 = 114100401,
		// Token: 0x04000996 RID: 2454
		ScanList_ScanLstGeneralPriorityMember2_A8749_2,
		// Token: 0x04000997 RID: 2455
		ScanList_ScanLstGeneralPriorityMember2_A8749_3,
		// Token: 0x04000998 RID: 2456
		ScanList_ScanLstGeneralDesignatedVoiceTxMemberType_A21524_1 = 114100501,
		// Token: 0x04000999 RID: 2457
		ScanList_ScanLstGeneralDesignatedVoiceTxMember_A7830_1 = 114100601,
		// Token: 0x0400099A RID: 2458
		ScanList_ScanLstGeneralDesignatedVoiceTxMember_A7830_2,
		// Token: 0x0400099B RID: 2459
		ScanMemberList_ScanLstScanListChannel_A7620_1 = 114200101,
		// Token: 0x0400099C RID: 2460
		ScanMemberList_ScanLstScanListChannel_A7620_2,
		// Token: 0x0400099D RID: 2461
		ScanMemberList_ScanLstScanListChannel_A7620_3,
		// Token: 0x0400099E RID: 2462
		ScanMemberList_ScanLstScanListChannel_A7620_5,
		// Token: 0x0400099F RID: 2463
		ScanMemberList_ScanLstScanListChannel_A7620_6,
		// Token: 0x040009A0 RID: 2464
		ScanMemberList_ScanLstScanListChannel_A7620_7,
		// Token: 0x040009A1 RID: 2465
		ScanMemberList_ScanLstScanListChannel_A7620_8,
		// Token: 0x040009A2 RID: 2466
		ScanMemberList_ScanLstScanListChannel_A7620_9,
		// Token: 0x040009A3 RID: 2467
		ScanMemberList_ScanLstScanListChannel_A7620_10,
		// Token: 0x040009A4 RID: 2468
		ScanMemberList_ScanLstScanListChannel_A7620_13,
		// Token: 0x040009A5 RID: 2469
		ScanMemberList_ScanLstScanListChannel_A7620_14,
		// Token: 0x040009A6 RID: 2470
		ScanMemberList_ScanLstScanListChannel_A7620_15,
		// Token: 0x040009A7 RID: 2471
		ScanMemberList_ScanLstScanListChannel_A7620_16,
		// Token: 0x040009A8 RID: 2472
		ScanMemberList_ScanLstScanListChannel_A7620_17,
		// Token: 0x040009A9 RID: 2473
		ScanMemberList_ScanLstScanListChannel_A7620_18,
		// Token: 0x040009AA RID: 2474
		ScanMemberList_ScanLstScanListChannel_A7620_19,
		// Token: 0x040009AB RID: 2475
		ScanMemberList_ScanLstScanListChannel_A7620_20,
		// Token: 0x040009AC RID: 2476
		ScanMemberList_ScanLstScanListChannel_A7620_21,
		// Token: 0x040009AD RID: 2477
		ScanMemberList_ScanLstScanListChannel_A7620_22,
		// Token: 0x040009AE RID: 2478
		ScanMemberList_ScanLstScanListChannel_A7620_23,
		// Token: 0x040009AF RID: 2479
		ScanMemberList_ScanLstScanListChannel_A7620_25,
		// Token: 0x040009B0 RID: 2480
		ScanMemberList_ScanLstScanListChannel_A7620_26,
		// Token: 0x040009B1 RID: 2481
		ScanMemberList_ScanLstScanListChannel_A7620_27,
		// Token: 0x040009B2 RID: 2482
		ScanMemberList_ScanLstScanListChannel_A7620_28,
		// Token: 0x040009B3 RID: 2483
		ScanMemberList_ScanLstScanListChannel_A7620_29,
		// Token: 0x040009B4 RID: 2484
		ScanMemberList_ScanLstScanListChannel_A7620_31,
		// Token: 0x040009B5 RID: 2485
		ScanMemberList_ScanLstScanListChannel_A7620_32,
		// Token: 0x040009B6 RID: 2486
		ScanMemberList_ScanLstScanListChannel_A7620_33,
		// Token: 0x040009B7 RID: 2487
		ScanMemberList_ScanLstScanListChannel_A7620_34,
		// Token: 0x040009B8 RID: 2488
		ScanMemberList_ScanLstScanListChannel_A7620_35,
		// Token: 0x040009B9 RID: 2489
		ScanMemberList_ScanLstScanListZone_A9718_1 = 114200201,
		// Token: 0x040009BA RID: 2490
		ScanMemberList_ScanLstScanListZone_A9718_2,
		// Token: 0x040009BB RID: 2491
		ScanMemberList_ScanLstScanListZone_A9718_3,
		// Token: 0x040009BC RID: 2492
		ScanMemberList_MaxNumber_Conventional = 114200301,
		// Token: 0x040009BD RID: 2493
		ScanMemberList_MaxNumber_PriorityMon,
		// Token: 0x040009BE RID: 2494
		ScanMemberList_MaxNumber_MultiSystem,
		// Token: 0x040009BF RID: 2495
		ScanMemberList_MaxNumber_VotingScan,
		// Token: 0x040009C0 RID: 2496
		ScanMemberList_MaxNumber_Default,
		// Token: 0x040009C1 RID: 2497
		FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_1 = 114400101,
		// Token: 0x040009C2 RID: 2498
		FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_2,
		// Token: 0x040009C3 RID: 2499
		SecureHardwareEncryptionKeyReferencesList_SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_1 = 114500101,
		// Token: 0x040009C4 RID: 2500
		SecKmfProfDataTransportKMFIPAddress_A8375_1 = 1146001001,
		// Token: 0x040009C5 RID: 2501
		SecureWide_SecWideGeneralSecureOperation_A9067_1 = 1147001001,
		// Token: 0x040009C6 RID: 2502
		SecureWide_SecWideGeneralSecureOperation_A9067_2,
		// Token: 0x040009C7 RID: 2503
		SecureWide_SecWideASTROOTARASTROOTAREnable_A7496_1 = 1147002001,
		// Token: 0x040009C8 RID: 2504
		SecureWide_SecWideMDCOTARMDCOTAREnable_A8488_1 = 1147003001,
		// Token: 0x040009C9 RID: 2505
		SecureWide_SecWideMDCOTARMDCOTARSystem_A8490_1 = 1147004001,
		// Token: 0x040009CA RID: 2506
		SecureWide_SecWideMDCOTARMDCOTARSystem_A8490_2,
		// Token: 0x040009CB RID: 2507
		SecureWide_SecWideFeaturesInfiniteKeyRetention_A8292_1 = 1147005001,
		// Token: 0x040009CC RID: 2508
		SecureWide_SecWideFeaturesClearAlertTones_A9524_1 = 1147006001,
		// Token: 0x040009CD RID: 2509
		SecureWide_SecWideInfiniteUKEKRetention_A41551_1 = 1147007001,
		// Token: 0x040009CE RID: 2510
		SecureWide_SecWideMultikeyErasePreviousOnUserChange_A8373_1 = 114700801,
		// Token: 0x040009CF RID: 2511
		SecureWide_SecWideMultikeyDisplayOnModeChange_A7877_1 = 114700901,
		// Token: 0x040009D0 RID: 2512
		SecureWide_SecWideMultikeyDisplayOnPTT_A7879_1 = 114701001,
		// Token: 0x040009D1 RID: 2513
		SecureWide_SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_1 = 114701101,
		// Token: 0x040009D2 RID: 2514
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_1 = 115600101,
		// Token: 0x040009D3 RID: 2515
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_2,
		// Token: 0x040009D4 RID: 2516
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_3,
		// Token: 0x040009D5 RID: 2517
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_4,
		// Token: 0x040009D6 RID: 2518
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_5,
		// Token: 0x040009D7 RID: 2519
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_6,
		// Token: 0x040009D8 RID: 2520
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_7,
		// Token: 0x040009D9 RID: 2521
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_8,
		// Token: 0x040009DA RID: 2522
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_9,
		// Token: 0x040009DB RID: 2523
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_10,
		// Token: 0x040009DC RID: 2524
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_11,
		// Token: 0x040009DD RID: 2525
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_12,
		// Token: 0x040009DE RID: 2526
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_13,
		// Token: 0x040009DF RID: 2527
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_14,
		// Token: 0x040009E0 RID: 2528
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_15,
		// Token: 0x040009E1 RID: 2529
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_16,
		// Token: 0x040009E2 RID: 2530
		SmartKeyFob_RadErgoCfgFobConventionalFeature_A41574_17,
		// Token: 0x040009E3 RID: 2531
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_1,
		// Token: 0x040009E4 RID: 2532
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_2,
		// Token: 0x040009E5 RID: 2533
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_3,
		// Token: 0x040009E6 RID: 2534
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_4,
		// Token: 0x040009E7 RID: 2535
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_5,
		// Token: 0x040009E8 RID: 2536
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_6,
		// Token: 0x040009E9 RID: 2537
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_7,
		// Token: 0x040009EA RID: 2538
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_8,
		// Token: 0x040009EB RID: 2539
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_9,
		// Token: 0x040009EC RID: 2540
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_10,
		// Token: 0x040009ED RID: 2541
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_11,
		// Token: 0x040009EE RID: 2542
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_12,
		// Token: 0x040009EF RID: 2543
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_13,
		// Token: 0x040009F0 RID: 2544
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_14,
		// Token: 0x040009F1 RID: 2545
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_15,
		// Token: 0x040009F2 RID: 2546
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_16,
		// Token: 0x040009F3 RID: 2547
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_17,
		// Token: 0x040009F4 RID: 2548
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_18,
		// Token: 0x040009F5 RID: 2549
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_19,
		// Token: 0x040009F6 RID: 2550
		SmartKeyFob_RadErgoCfgFobTrunkingFeature_A41575_20,
		// Token: 0x040009F7 RID: 2551
		Switches_SwitchConventionalSwitchesPosition1_A7734_1 = 115800101,
		// Token: 0x040009F8 RID: 2552
		Switches_SwitchConventionalSwitchesPosition1_A7734_2,
		// Token: 0x040009F9 RID: 2553
		Switches_SwitchConventionalSwitchesPosition1_A7734_3,
		// Token: 0x040009FA RID: 2554
		Switches_SwitchConventionalSwitchesPosition1_A7734_4,
		// Token: 0x040009FB RID: 2555
		Switches_SwitchConventionalSwitchesPosition1_A7734_5,
		// Token: 0x040009FC RID: 2556
		Switches_SwitchConventionalSwitchesPosition1_A7734_6,
		// Token: 0x040009FD RID: 2557
		Switches_SwitchConventionalSwitchesPosition1_A7734_7,
		// Token: 0x040009FE RID: 2558
		Switches_SwitchConventionalSwitchesPosition1_A7734_8,
		// Token: 0x040009FF RID: 2559
		Switches_SwitchConventionalSwitchesPosition1_A7734_9,
		// Token: 0x04000A00 RID: 2560
		Switches_SwitchConventionalSwitchesPosition1_A7734_10,
		// Token: 0x04000A01 RID: 2561
		Switches_SwitchConventionalSwitchesPosition1_A7734_11,
		// Token: 0x04000A02 RID: 2562
		Switches_SwitchConventionalSwitchesPosition1_A7734_12,
		// Token: 0x04000A03 RID: 2563
		Switches_SwitchConventionalSwitchesPosition1_A7734_13,
		// Token: 0x04000A04 RID: 2564
		Switches_SwitchConventionalSwitchesPosition1_A7734_14,
		// Token: 0x04000A05 RID: 2565
		Switches_SwitchConventionalSwitchesPosition1_A7734_15,
		// Token: 0x04000A06 RID: 2566
		Switches_SwitchConventionalSwitchesPosition1_A7734_16,
		// Token: 0x04000A07 RID: 2567
		Switches_SwitchConventionalSwitchesPosition1_A7734_17,
		// Token: 0x04000A08 RID: 2568
		Switches_SwitchConventionalSwitchesPosition1_A7734_18,
		// Token: 0x04000A09 RID: 2569
		Switches_SwitchConventionalSwitchesPosition2_A7735_1 = 115800201,
		// Token: 0x04000A0A RID: 2570
		Switches_SwitchConventionalSwitchesPosition2_A7735_2,
		// Token: 0x04000A0B RID: 2571
		Switches_SwitchConventionalSwitchesPosition2_A7735_3,
		// Token: 0x04000A0C RID: 2572
		Switches_SwitchConventionalSwitchesPosition2_A7735_4,
		// Token: 0x04000A0D RID: 2573
		Switches_SwitchConventionalSwitchesPosition2_A7735_5,
		// Token: 0x04000A0E RID: 2574
		Switches_SwitchConventionalSwitchesPosition2_A7735_6,
		// Token: 0x04000A0F RID: 2575
		Switches_SwitchConventionalSwitchesPosition2_A7735_7,
		// Token: 0x04000A10 RID: 2576
		Switches_SwitchConventionalSwitchesPosition2_A7735_8,
		// Token: 0x04000A11 RID: 2577
		Switches_SwitchConventionalSwitchesPosition2_A7735_9,
		// Token: 0x04000A12 RID: 2578
		Switches_SwitchConventionalSwitchesPosition2_A7735_10,
		// Token: 0x04000A13 RID: 2579
		Switches_SwitchConventionalSwitchesPosition2_A7735_11,
		// Token: 0x04000A14 RID: 2580
		Switches_SwitchConventionalSwitchesPosition2_A7735_12,
		// Token: 0x04000A15 RID: 2581
		Switches_SwitchConventionalSwitchesPosition2_A7735_13,
		// Token: 0x04000A16 RID: 2582
		Switches_SwitchConventionalSwitchesPosition2_A7735_14,
		// Token: 0x04000A17 RID: 2583
		Switches_SwitchConventionalSwitchesPosition2_A7735_15,
		// Token: 0x04000A18 RID: 2584
		Switches_SwitchConventionalSwitchesPosition2_A7735_16,
		// Token: 0x04000A19 RID: 2585
		Switches_SwitchConventionalSwitchesPosition2_A7735_17,
		// Token: 0x04000A1A RID: 2586
		Switches_SwitchConventionalSwitchesPosition2_A7735_18,
		// Token: 0x04000A1B RID: 2587
		Switches_SwitchConventionalSwitchesPosition2_A7735_19,
		// Token: 0x04000A1C RID: 2588
		Switches_SwitchConventionalSwitchesPosition3_A7737_1 = 115800301,
		// Token: 0x04000A1D RID: 2589
		Switches_SwitchConventionalSwitchesPosition3_A7737_2,
		// Token: 0x04000A1E RID: 2590
		Switches_SwitchConventionalSwitchesPosition3_A7737_3,
		// Token: 0x04000A1F RID: 2591
		Switches_SwitchConventionalSwitchesPosition3_A7737_4,
		// Token: 0x04000A20 RID: 2592
		Switches_SwitchConventionalSwitchesPosition3_A7737_5,
		// Token: 0x04000A21 RID: 2593
		Switches_SwitchConventionalSwitchesPosition3_A7737_6,
		// Token: 0x04000A22 RID: 2594
		Switches_SwitchConventionalSwitchesPosition3_A7737_7,
		// Token: 0x04000A23 RID: 2595
		Switches_SwitchConventionalSwitchesPosition3_A7737_8,
		// Token: 0x04000A24 RID: 2596
		Switches_SwitchConventionalSwitchesPosition3_A7737_9,
		// Token: 0x04000A25 RID: 2597
		Switches_SwitchConventionalSwitchesPosition3_A7737_10,
		// Token: 0x04000A26 RID: 2598
		Switches_SwitchConventionalSwitchesPosition3_A7737_11,
		// Token: 0x04000A27 RID: 2599
		Switches_SwitchConventionalSwitchesPosition3_A7737_12,
		// Token: 0x04000A28 RID: 2600
		Switches_SwitchConventionalSwitchesPosition3_A7737_13,
		// Token: 0x04000A29 RID: 2601
		Switches_SwitchConventionalSwitchesPosition3_A7737_14,
		// Token: 0x04000A2A RID: 2602
		Switches_SwitchConventionalSwitchesPosition3_A7737_15,
		// Token: 0x04000A2B RID: 2603
		Switches_SwitchConventionalSwitchesPosition3_A7737_16,
		// Token: 0x04000A2C RID: 2604
		Switches_SwitchConventionalSwitchesPosition3_A7737_17,
		// Token: 0x04000A2D RID: 2605
		Switches_SwitchConventionalSwitchesPosition3_A7737_18,
		// Token: 0x04000A2E RID: 2606
		Switches_SwitchConventionalSwitchesPosition3_A7737_19,
		// Token: 0x04000A2F RID: 2607
		Switches_SwitchConventionalSwitchesPosition4_A21530_1 = 115800401,
		// Token: 0x04000A30 RID: 2608
		Switches_SwitchConventionalSwitchesPosition4_A21530_2,
		// Token: 0x04000A31 RID: 2609
		Switches_SwitchConventionalSwitchesPosition4_A21530_3,
		// Token: 0x04000A32 RID: 2610
		Switches_SwitchConventionalSwitchesPosition4_A21530_4,
		// Token: 0x04000A33 RID: 2611
		Switches_SwitchConventionalSwitchesPosition4_A21530_5,
		// Token: 0x04000A34 RID: 2612
		Switches_SwitchConventionalSwitchesPosition4_A21530_6,
		// Token: 0x04000A35 RID: 2613
		Switches_SwitchConventionalSwitchesPosition4_A21530_7,
		// Token: 0x04000A36 RID: 2614
		Switches_SwitchConventionalSwitchesPosition4_A21530_8,
		// Token: 0x04000A37 RID: 2615
		Switches_SwitchConventionalSwitchesPosition4_A21530_9,
		// Token: 0x04000A38 RID: 2616
		Switches_SwitchConventionalSwitchesPosition4_A21530_10,
		// Token: 0x04000A39 RID: 2617
		Switches_SwitchConventionalSwitchesPosition4_A21530_11,
		// Token: 0x04000A3A RID: 2618
		Switches_SwitchConventionalSwitchesPosition4_A21530_12,
		// Token: 0x04000A3B RID: 2619
		Switches_SwitchConventionalSwitchesPosition4_A21530_13,
		// Token: 0x04000A3C RID: 2620
		Switches_SwitchConventionalSwitchesPosition4_A21530_14,
		// Token: 0x04000A3D RID: 2621
		Switches_SwitchConventionalSwitchesPosition4_A21530_15,
		// Token: 0x04000A3E RID: 2622
		Switches_SwitchConventionalSwitchesPosition4_A21530_16,
		// Token: 0x04000A3F RID: 2623
		Switches_SwitchConventionalSwitchesPosition4_A21530_17,
		// Token: 0x04000A40 RID: 2624
		Switches_SwitchConventionalSwitchesPosition4_A21530_18,
		// Token: 0x04000A41 RID: 2625
		Switches_SwitchConventionalSwitchesPosition4_A21530_19,
		// Token: 0x04000A42 RID: 2626
		Switches_SwitchConventionalSwitchesPosition5_A21531_1 = 115800501,
		// Token: 0x04000A43 RID: 2627
		Switches_SwitchConventionalSwitchesPosition5_A21531_2,
		// Token: 0x04000A44 RID: 2628
		Switches_SwitchConventionalSwitchesPosition5_A21531_3,
		// Token: 0x04000A45 RID: 2629
		Switches_SwitchConventionalSwitchesPosition5_A21531_4,
		// Token: 0x04000A46 RID: 2630
		Switches_SwitchConventionalSwitchesPosition5_A21531_5,
		// Token: 0x04000A47 RID: 2631
		Switches_SwitchConventionalSwitchesPosition5_A21531_6,
		// Token: 0x04000A48 RID: 2632
		Switches_SwitchConventionalSwitchesPosition5_A21531_7,
		// Token: 0x04000A49 RID: 2633
		Switches_SwitchConventionalSwitchesPosition5_A21531_8,
		// Token: 0x04000A4A RID: 2634
		Switches_SwitchConventionalSwitchesPosition5_A21531_9,
		// Token: 0x04000A4B RID: 2635
		Switches_SwitchConventionalSwitchesPosition5_A21531_10,
		// Token: 0x04000A4C RID: 2636
		Switches_SwitchConventionalSwitchesPosition5_A21531_11,
		// Token: 0x04000A4D RID: 2637
		Switches_SwitchConventionalSwitchesPosition5_A21531_12,
		// Token: 0x04000A4E RID: 2638
		Switches_SwitchConventionalSwitchesPosition5_A21531_13,
		// Token: 0x04000A4F RID: 2639
		Switches_SwitchConventionalSwitchesPosition5_A21531_14,
		// Token: 0x04000A50 RID: 2640
		Switches_SwitchConventionalSwitchesPosition5_A21531_15,
		// Token: 0x04000A51 RID: 2641
		Switches_SwitchConventionalSwitchesPosition5_A21531_16,
		// Token: 0x04000A52 RID: 2642
		Switches_SwitchConventionalSwitchesPosition5_A21531_17,
		// Token: 0x04000A53 RID: 2643
		Switches_SwitchConventionalSwitchesPosition5_A21531_18,
		// Token: 0x04000A54 RID: 2644
		Switches_SwitchConventionalSwitchesPosition5_A21531_19,
		// Token: 0x04000A55 RID: 2645
		Switches_SwitchGeneralRotaryControl_A8984_1 = 115800601,
		// Token: 0x04000A56 RID: 2646
		Switches_SwitchGeneralRotaryControl_A8984_2,
		// Token: 0x04000A57 RID: 2647
		Switches_TrunkingSwitchesPosition1_A9466_1 = 115800701,
		// Token: 0x04000A58 RID: 2648
		Switches_TrunkingSwitchesPosition1_A9466_2,
		// Token: 0x04000A59 RID: 2649
		Switches_TrunkingSwitchesPosition1_A9466_3,
		// Token: 0x04000A5A RID: 2650
		Switches_TrunkingSwitchesPosition1_A9466_4,
		// Token: 0x04000A5B RID: 2651
		Switches_TrunkingSwitchesPosition1_A9466_5,
		// Token: 0x04000A5C RID: 2652
		Switches_TrunkingSwitchesPosition1_A9466_6,
		// Token: 0x04000A5D RID: 2653
		Switches_TrunkingSwitchesPosition1_A9466_7,
		// Token: 0x04000A5E RID: 2654
		Switches_TrunkingSwitchesPosition1_A9466_8,
		// Token: 0x04000A5F RID: 2655
		Switches_TrunkingSwitchesPosition1_A9466_9,
		// Token: 0x04000A60 RID: 2656
		Switches_TrunkingSwitchesPosition1_A9466_10,
		// Token: 0x04000A61 RID: 2657
		Switches_TrunkingSwitchesPosition1_A9466_11,
		// Token: 0x04000A62 RID: 2658
		Switches_TrunkingSwitchesPosition1_A9466_12,
		// Token: 0x04000A63 RID: 2659
		Switches_TrunkingSwitchesPosition1_A9466_13,
		// Token: 0x04000A64 RID: 2660
		Switches_TrunkingSwitchesPosition1_A9466_14,
		// Token: 0x04000A65 RID: 2661
		Switches_TrunkingSwitchesPosition1_A9466_15,
		// Token: 0x04000A66 RID: 2662
		Switches_TrunkingSwitchesPosition1_A9466_16,
		// Token: 0x04000A67 RID: 2663
		Switches_TrunkingSwitchesPosition1_A9466_17,
		// Token: 0x04000A68 RID: 2664
		Switches_TrunkingSwitchesPosition1_A9466_18,
		// Token: 0x04000A69 RID: 2665
		Switches_TrunkingSwitchesPosition1_A9466_19,
		// Token: 0x04000A6A RID: 2666
		Switches_TrunkingSwitchesPosition1_A9466_20,
		// Token: 0x04000A6B RID: 2667
		Switches_TrunkingSwitchesPosition1_A9466_21,
		// Token: 0x04000A6C RID: 2668
		Switches_TrunkingSwitchesPosition1_A9466_22,
		// Token: 0x04000A6D RID: 2669
		Switches_TrunkingSwitchesPosition1_A9466_23,
		// Token: 0x04000A6E RID: 2670
		Switches_TrunkingSwitchesPosition2_A9467_1 = 115800801,
		// Token: 0x04000A6F RID: 2671
		Switches_TrunkingSwitchesPosition2_A9467_2,
		// Token: 0x04000A70 RID: 2672
		Switches_TrunkingSwitchesPosition2_A9467_3,
		// Token: 0x04000A71 RID: 2673
		Switches_TrunkingSwitchesPosition2_A9467_4,
		// Token: 0x04000A72 RID: 2674
		Switches_TrunkingSwitchesPosition2_A9467_5,
		// Token: 0x04000A73 RID: 2675
		Switches_TrunkingSwitchesPosition2_A9467_6,
		// Token: 0x04000A74 RID: 2676
		Switches_TrunkingSwitchesPosition2_A9467_7,
		// Token: 0x04000A75 RID: 2677
		Switches_TrunkingSwitchesPosition2_A9467_8,
		// Token: 0x04000A76 RID: 2678
		Switches_TrunkingSwitchesPosition2_A9467_9,
		// Token: 0x04000A77 RID: 2679
		Switches_TrunkingSwitchesPosition2_A9467_10,
		// Token: 0x04000A78 RID: 2680
		Switches_TrunkingSwitchesPosition2_A9467_11,
		// Token: 0x04000A79 RID: 2681
		Switches_TrunkingSwitchesPosition2_A9467_12,
		// Token: 0x04000A7A RID: 2682
		Switches_TrunkingSwitchesPosition2_A9467_13,
		// Token: 0x04000A7B RID: 2683
		Switches_TrunkingSwitchesPosition2_A9467_14,
		// Token: 0x04000A7C RID: 2684
		Switches_TrunkingSwitchesPosition2_A9467_15,
		// Token: 0x04000A7D RID: 2685
		Switches_TrunkingSwitchesPosition2_A9467_16,
		// Token: 0x04000A7E RID: 2686
		Switches_TrunkingSwitchesPosition2_A9467_17,
		// Token: 0x04000A7F RID: 2687
		Switches_TrunkingSwitchesPosition2_A9467_18,
		// Token: 0x04000A80 RID: 2688
		Switches_TrunkingSwitchesPosition2_A9467_19,
		// Token: 0x04000A81 RID: 2689
		Switches_TrunkingSwitchesPosition2_A9467_20,
		// Token: 0x04000A82 RID: 2690
		Switches_TrunkingSwitchesPosition2_A9467_21,
		// Token: 0x04000A83 RID: 2691
		Switches_TrunkingSwitchesPosition3_A9468_1 = 115800901,
		// Token: 0x04000A84 RID: 2692
		Switches_TrunkingSwitchesPosition3_A9468_2,
		// Token: 0x04000A85 RID: 2693
		Switches_TrunkingSwitchesPosition3_A9468_3,
		// Token: 0x04000A86 RID: 2694
		Switches_TrunkingSwitchesPosition3_A9468_4,
		// Token: 0x04000A87 RID: 2695
		Switches_TrunkingSwitchesPosition3_A9468_5,
		// Token: 0x04000A88 RID: 2696
		Switches_TrunkingSwitchesPosition3_A9468_6,
		// Token: 0x04000A89 RID: 2697
		Switches_TrunkingSwitchesPosition3_A9468_7,
		// Token: 0x04000A8A RID: 2698
		Switches_TrunkingSwitchesPosition3_A9468_8,
		// Token: 0x04000A8B RID: 2699
		Switches_TrunkingSwitchesPosition3_A9468_9,
		// Token: 0x04000A8C RID: 2700
		Switches_TrunkingSwitchesPosition3_A9468_10,
		// Token: 0x04000A8D RID: 2701
		Switches_TrunkingSwitchesPosition3_A9468_11,
		// Token: 0x04000A8E RID: 2702
		Switches_TrunkingSwitchesPosition3_A9468_12,
		// Token: 0x04000A8F RID: 2703
		Switches_TrunkingSwitchesPosition3_A9468_13,
		// Token: 0x04000A90 RID: 2704
		Switches_TrunkingSwitchesPosition3_A9468_14,
		// Token: 0x04000A91 RID: 2705
		Switches_TrunkingSwitchesPosition3_A9468_15,
		// Token: 0x04000A92 RID: 2706
		Switches_TrunkingSwitchesPosition3_A9468_16,
		// Token: 0x04000A93 RID: 2707
		Switches_TrunkingSwitchesPosition3_A9468_17,
		// Token: 0x04000A94 RID: 2708
		Switches_TrunkingSwitchesPosition3_A9468_18,
		// Token: 0x04000A95 RID: 2709
		Switches_TrunkingSwitchesPosition3_A9468_19,
		// Token: 0x04000A96 RID: 2710
		Switches_TrunkingSwitchesPosition3_A9468_20,
		// Token: 0x04000A97 RID: 2711
		Switches_TrunkingSwitchesPosition3_A9468_21,
		// Token: 0x04000A98 RID: 2712
		Switches_TrunkingSwitchesPosition4_A21534_1 = 115801001,
		// Token: 0x04000A99 RID: 2713
		Switches_TrunkingSwitchesPosition4_A21534_2,
		// Token: 0x04000A9A RID: 2714
		Switches_TrunkingSwitchesPosition4_A21534_3,
		// Token: 0x04000A9B RID: 2715
		Switches_TrunkingSwitchesPosition4_A21534_4,
		// Token: 0x04000A9C RID: 2716
		Switches_TrunkingSwitchesPosition4_A21534_5,
		// Token: 0x04000A9D RID: 2717
		Switches_TrunkingSwitchesPosition4_A21534_6,
		// Token: 0x04000A9E RID: 2718
		Switches_TrunkingSwitchesPosition4_A21534_7,
		// Token: 0x04000A9F RID: 2719
		Switches_TrunkingSwitchesPosition4_A21534_8,
		// Token: 0x04000AA0 RID: 2720
		Switches_TrunkingSwitchesPosition4_A21534_9,
		// Token: 0x04000AA1 RID: 2721
		Switches_TrunkingSwitchesPosition4_A21534_10,
		// Token: 0x04000AA2 RID: 2722
		Switches_TrunkingSwitchesPosition4_A21534_11,
		// Token: 0x04000AA3 RID: 2723
		Switches_TrunkingSwitchesPosition4_A21534_12,
		// Token: 0x04000AA4 RID: 2724
		Switches_TrunkingSwitchesPosition4_A21534_13,
		// Token: 0x04000AA5 RID: 2725
		Switches_TrunkingSwitchesPosition4_A21534_14,
		// Token: 0x04000AA6 RID: 2726
		Switches_TrunkingSwitchesPosition4_A21534_15,
		// Token: 0x04000AA7 RID: 2727
		Switches_TrunkingSwitchesPosition4_A21534_16,
		// Token: 0x04000AA8 RID: 2728
		Switches_TrunkingSwitchesPosition4_A21534_17,
		// Token: 0x04000AA9 RID: 2729
		Switches_TrunkingSwitchesPosition4_A21534_18,
		// Token: 0x04000AAA RID: 2730
		Switches_TrunkingSwitchesPosition4_A21534_19,
		// Token: 0x04000AAB RID: 2731
		Switches_TrunkingSwitchesPosition4_A21534_20,
		// Token: 0x04000AAC RID: 2732
		Switches_TrunkingSwitchesPosition4_A21534_21,
		// Token: 0x04000AAD RID: 2733
		Switches_TrunkingSwitchesPosition5_A21535_1 = 115801101,
		// Token: 0x04000AAE RID: 2734
		Switches_TrunkingSwitchesPosition5_A21535_2,
		// Token: 0x04000AAF RID: 2735
		Switches_TrunkingSwitchesPosition5_A21535_3,
		// Token: 0x04000AB0 RID: 2736
		Switches_TrunkingSwitchesPosition5_A21535_4,
		// Token: 0x04000AB1 RID: 2737
		Switches_TrunkingSwitchesPosition5_A21535_5,
		// Token: 0x04000AB2 RID: 2738
		Switches_TrunkingSwitchesPosition5_A21535_6,
		// Token: 0x04000AB3 RID: 2739
		Switches_TrunkingSwitchesPosition5_A21535_7,
		// Token: 0x04000AB4 RID: 2740
		Switches_TrunkingSwitchesPosition5_A21535_8,
		// Token: 0x04000AB5 RID: 2741
		Switches_TrunkingSwitchesPosition5_A21535_9,
		// Token: 0x04000AB6 RID: 2742
		Switches_TrunkingSwitchesPosition5_A21535_10,
		// Token: 0x04000AB7 RID: 2743
		Switches_TrunkingSwitchesPosition5_A21535_11,
		// Token: 0x04000AB8 RID: 2744
		Switches_TrunkingSwitchesPosition5_A21535_12,
		// Token: 0x04000AB9 RID: 2745
		Switches_TrunkingSwitchesPosition5_A21535_13,
		// Token: 0x04000ABA RID: 2746
		Switches_TrunkingSwitchesPosition5_A21535_14,
		// Token: 0x04000ABB RID: 2747
		Switches_TrunkingSwitchesPosition5_A21535_15,
		// Token: 0x04000ABC RID: 2748
		Switches_TrunkingSwitchesPosition5_A21535_16,
		// Token: 0x04000ABD RID: 2749
		Switches_TrunkingSwitchesPosition5_A21535_17,
		// Token: 0x04000ABE RID: 2750
		Switches_TrunkingSwitchesPosition5_A21535_18,
		// Token: 0x04000ABF RID: 2751
		Switches_TrunkingSwitchesPosition5_A21535_19,
		// Token: 0x04000AC0 RID: 2752
		Switches_TrunkingSwitchesPosition5_A21535_20,
		// Token: 0x04000AC1 RID: 2753
		Switches_TrunkingSwitchesPosition5_A21535_21,
		// Token: 0x04000AC2 RID: 2754
		SwitchesMFKAssignmentCntrl_Feature_1 = 115900101,
		// Token: 0x04000AC3 RID: 2755
		SwitchesMFKAssignmentCntrl_Feature_2,
		// Token: 0x04000AC4 RID: 2756
		SwitchesMFKAssignmentCntrl_Feature_3,
		// Token: 0x04000AC5 RID: 2757
		SwitchesMFKAssignmentCntrl_Feature_4,
		// Token: 0x04000AC6 RID: 2758
		SwitchesMFKAssignmentCntrl_Feature_5,
		// Token: 0x04000AC7 RID: 2759
		TalkgroupTable_AstTlkgrpLstTalkgroupListKeySelectReference_A8366_1 = 116000101,
		// Token: 0x04000AC8 RID: 2760
		O9TopFuncPgmBtn_Index_1 = 116100101,
		// Token: 0x04000AC9 RID: 2761
		O9TopFuncPgmBtn_Index_2,
		// Token: 0x04000ACA RID: 2762
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_1,
		// Token: 0x04000ACB RID: 2763
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_2,
		// Token: 0x04000ACC RID: 2764
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_3,
		// Token: 0x04000ACD RID: 2765
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_4,
		// Token: 0x04000ACE RID: 2766
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_5,
		// Token: 0x04000ACF RID: 2767
		O9TopFunctionProgrammableButton_O9CHCnvTopFunctionButtonIndex_A36634_6,
		// Token: 0x04000AD0 RID: 2768
		O9TopFuncPgmBtn_Prepend_Index_1 = 116100201,
		// Token: 0x04000AD1 RID: 2769
		O9TopFunctionProgrammableButton_CHO9CnvTopFunctionButtonLabelLine1_A36626_1 = 116100301,
		// Token: 0x04000AD2 RID: 2770
		O9TopFunctionProgrammableButton_CHO9CnvTopFunctionButtonLabelLine2_A36627_1 = 116100401,
		// Token: 0x04000AD3 RID: 2771
		O9TopFunctionPgmmbleBtn_Feature_1 = 116100501,
		// Token: 0x04000AD4 RID: 2772
		O9TopFunctionPgmmbleBtn_Feature_2,
		// Token: 0x04000AD5 RID: 2773
		O9TopFunctionPgmmbleBtn_Feature_3,
		// Token: 0x04000AD6 RID: 2774
		O9TopFunctionPgmmbleBtn_Feature_4,
		// Token: 0x04000AD7 RID: 2775
		O9TopFunctionPgmmbleBtn_Feature_5,
		// Token: 0x04000AD8 RID: 2776
		O9TopFunctionPgmmbleBtn_Feature_6,
		// Token: 0x04000AD9 RID: 2777
		O9TopFunctionPgmmbleBtn_Feature_7,
		// Token: 0x04000ADA RID: 2778
		O9TopFunctionPgmmbleBtn_Feature_8,
		// Token: 0x04000ADB RID: 2779
		O9TopFunctionPgmmbleBtn_StsMsgIndex_1 = 116100601,
		// Token: 0x04000ADC RID: 2780
		O9TopFunctionPgmmbleBtn_StsMsgIndex_2,
		// Token: 0x04000ADD RID: 2781
		O9TopFunctionPgmmbleBtn_StsMsgIndex_3,
		// Token: 0x04000ADE RID: 2782
		O9TopFunctionPgmmbleBtn_StsMsgIndex_4,
		// Token: 0x04000ADF RID: 2783
		O9TopFunctionPgmmbleBtn_TrunkingZone_1 = 116100701,
		// Token: 0x04000AE0 RID: 2784
		O9TopFunctionProgrammableButton_TopFunctionBtnCnvZone_A36942_1 = 116100801,
		// Token: 0x04000AE1 RID: 2785
		TrunkingEmergencyProfiles_TrkEmerProfGeneralEmergencyOperation_A7926_1 = 116200101,
		// Token: 0x04000AE2 RID: 2786
		TrunkingEmergencyProfiles_TrkEmerProEmergencyAutoTransmitMode_A22567_1 = 116200201,
		// Token: 0x04000AE3 RID: 2787
		TrunkingEmergencyProfiles_TrkEmerProfGeneralVoiceSignalType_A7500_1 = 116200301,
		// Token: 0x04000AE4 RID: 2788
		TrunkingEmergencyToneList_TrkEmerTonePeriodSec_42110_1 = 116300101,
		// Token: 0x04000AE5 RID: 2789
		TrunkingEmergencyToneList_RadErgoAstroAlertingToneTableTone2Freq,
		// Token: 0x04000AE6 RID: 2790
		TrunkingGroupIDList_DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_1 = 116400001,
		// Token: 0x04000AE7 RID: 2791
		MobileTrunkingMenuItems_ConventionalSelectedMenuItem_1 = 1166600101,
		// Token: 0x04000AE8 RID: 2792
		PortTrunkingMenuItems_ConventionalSelectedMenuItem_1 = 116700101,
		// Token: 0x04000AE9 RID: 2793
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_1 = 117200101,
		// Token: 0x04000AEA RID: 2794
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_2,
		// Token: 0x04000AEB RID: 2795
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_3,
		// Token: 0x04000AEC RID: 2796
		RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_1 = 117200201,
		// Token: 0x04000AED RID: 2797
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_1 = 117300101,
		// Token: 0x04000AEE RID: 2798
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_2,
		// Token: 0x04000AEF RID: 2799
		RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_3,
		// Token: 0x04000AF0 RID: 2800
		RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_1 = 117300201,
		// Token: 0x04000AF1 RID: 2801
		RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_1 = 117300301,
		// Token: 0x04000AF2 RID: 2802
		RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_1 = 117300401,
		// Token: 0x04000AF3 RID: 2803
		TxPowerLevelsFieldDefaultValueMismatchOption = 117300501,
		// Token: 0x04000AF4 RID: 2804
		FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_1 = 117400101,
		// Token: 0x04000AF5 RID: 2805
		FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_2,
		// Token: 0x04000AF6 RID: 2806
		FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_1,
		// Token: 0x04000AF7 RID: 2807
		FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_2,
		// Token: 0x04000AF8 RID: 2808
		FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_1,
		// Token: 0x04000AF9 RID: 2809
		FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_2,
		// Token: 0x04000AFA RID: 2810
		FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_1 = 117500101,
		// Token: 0x04000AFB RID: 2811
		FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_2,
		// Token: 0x04000AFC RID: 2812
		UclT2TrkHotList_CallID_A00041_1 = 117700101,
		// Token: 0x04000AFD RID: 2813
		UclT2Trk_IndividualID_A00019_1 = 117900101,
		// Token: 0x04000AFE RID: 2814
		UclT2Trk_IndividualID_A00019_2,
		// Token: 0x04000AFF RID: 2815
		UclT2Trk_IndividualID_A00019_3,
		// Token: 0x04000B00 RID: 2816
		UclT2Trk_IndividualID_A00019_4,
		// Token: 0x04000B01 RID: 2817
		UclT2Trk_IndividualID_A00019_5,
		// Token: 0x04000B02 RID: 2818
		VoiceAnnouncementList_Record_Invalid = 118200101,
		// Token: 0x04000B03 RID: 2819
		VoiceAnnouncementList_VoiceFileName_A21220_Invalid = 118200200,
		// Token: 0x04000B04 RID: 2820
		Zones_ZnChanCfgFPPProtectionFPPEnable_A19562_1 = 118400101,
		// Token: 0x04000B05 RID: 2821
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_1 = 118400201,
		// Token: 0x04000B06 RID: 2822
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_2,
		// Token: 0x04000B07 RID: 2823
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_3,
		// Token: 0x04000B08 RID: 2824
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_4,
		// Token: 0x04000B09 RID: 2825
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_5,
		// Token: 0x04000B0A RID: 2826
		Zones_ZnChanCfgZoneDynamicZoneEnable_A41257_6,
		// Token: 0x04000B0B RID: 2827
		Zones_ZoneChannelAssignmentRSIMode_A41831_1 = 118400301,
		// Token: 0x04000B0C RID: 2828
		Zones_ZnChanCfgFPPProtectionProtectedZone_A8765_1 = 118400401,
		// Token: 0x04000B0D RID: 2829
		ASTRO__Warning_No_Reference_From_ZoneChannel = 118500000,
		// Token: 0x04000B0E RID: 2830
		Feature_NotPurchased_Enabled,
		// Token: 0x04000B0F RID: 2831
		Unable_to_Apply_36009600trunking_to_target_singletrunking,
		// Token: 0x04000B10 RID: 2832
		Radio_Configuration_ASKRule_Mismatch,
		// Token: 0x04000B11 RID: 2833
		ASTRO_TypeIINotAllowed,
		// Token: 0x04000B12 RID: 2834
		Feature_NotEnabled_ButPurchased,
		// Token: 0x04000B13 RID: 2835
		ASTRO_Warning_No_Reference_From_TrkPer,
		// Token: 0x04000B14 RID: 2836
		ASTRO_ForceLoadSetHasMoreThanOneReference_ASTROFNE,
		// Token: 0x04000B15 RID: 2837
		ASTRO_ForceLoadSetHasMoreThanOneReference_Channel,
		// Token: 0x04000B16 RID: 2838
		ASTRO_ForceLoadSetHasMoreThanOneReference_Contact,
		// Token: 0x04000B17 RID: 2839
		ASTRO_ForceLoadSetHasMoreThanOneReference_GlobalFreqOptions,
		// Token: 0x04000B18 RID: 2840
		ASTRO_ForceLoadSetHasMoreThanOneReference_TypeIIFNE,
		// Token: 0x04000B19 RID: 2841
		Zones_NoChannelPool = 118530000,
		// Token: 0x04000B1A RID: 2842
		Zones_NoCBZone,
		// Token: 0x04000B1B RID: 2843
		Zones_NoNormalZone,
		// Token: 0x04000B1C RID: 2844
		VoiceAnnouncement_Exceed_Max_Duration,
		// Token: 0x04000B1D RID: 2845
		VoiceAnnouncement_Exceed_SingleFile_Duration,
		// Token: 0x04000B1E RID: 2846
		EnhancedPrivacyKeys_Invalid,
		// Token: 0x04000B1F RID: 2847
		AESKeys_Invalid,
		// Token: 0x04000B20 RID: 2848
		OTAPAuthenticationKey_Invalid,
		// Token: 0x04000B21 RID: 2849
		RASKeys_Invalid,
		// Token: 0x04000B22 RID: 2850
		ConventionalPersonality_ChannelTypeUnsupported,
		// Token: 0x04000B23 RID: 2851
		TTSRuleSetData_TooLarge = 118530011,
		// Token: 0x04000B24 RID: 2852
		DMR3SelectSitesShouldHaveSameChannelPlan,
		// Token: 0x04000B25 RID: 2853
		IPSettings_SameSubnet_1,
		// Token: 0x04000B26 RID: 2854
		IPSettings_SameSubnet_2,
		// Token: 0x04000B27 RID: 2855
		IPSettings_SameSubnet_3,
		// Token: 0x04000B28 RID: 2856
		IPSettings_IPDifferent_1,
		// Token: 0x04000B29 RID: 2857
		IPSettings_IPDifferent_2,
		// Token: 0x04000B2A RID: 2858
		IPSettings_IPDifferent_3,
		// Token: 0x04000B2B RID: 2859
		IPSettings_UdpPortDifferent_1,
		// Token: 0x04000B2C RID: 2860
		IPSettings_MaskIpAddressOutOfRange_1,
		// Token: 0x04000B2D RID: 2861
		ConventionalPersonality_FirmwareShouldUpgrade,
		// Token: 0x04000B2E RID: 2862
		DMR3SiteSelection_ShouldHaveRecords,
		// Token: 0x04000B2F RID: 2863
		MNIS_Record_Invalid,
		// Token: 0x04000B30 RID: 2864
		DMR3SiteSelectionItem_Count_Invalid,
		// Token: 0x04000B31 RID: 2865
		DMR3SiteSelectionItem_Count_Warning,
		// Token: 0x04000B32 RID: 2866
		DMR3SiteSelectionSites_Count_Invalid,
		// Token: 0x04000B33 RID: 2867
		DMR3SiteSelectionSites_Count_Warning,
		// Token: 0x04000B34 RID: 2868
		DMR3SiteSelectionSites_RecordPar_Valid,
		// Token: 0x04000B35 RID: 2869
		DMR3SiteSelectionSites_Count0,
		// Token: 0x04000B36 RID: 2870
		DMR3FlexibleChannelPlanList_Count_Warning,
		// Token: 0x04000B37 RID: 2871
		DMR3FlexibleChannelPlanList_Record_Paradise,
		// Token: 0x04000B38 RID: 2872
		DMR3FlexibleChannelPlanList_Record_MNIS,
		// Token: 0x04000B39 RID: 2873
		DMR3SiteSelectionItem_PAR_ItemValid,
		// Token: 0x04000B3A RID: 2874
		Zones_NoOneChannelInNormalZone,
		// Token: 0x04000B3B RID: 2875
		DMR3SiteSelectionItem_SU1005_ItemValid,
		// Token: 0x04000B3C RID: 2876
		Radios_DataWideGeneralPeerIPAddress1_A8524_1 = 118900101,
		// Token: 0x04000B3D RID: 2877
		Radios_DataWideGeneralPeerIPAddress1_A8524_2,
		// Token: 0x04000B3E RID: 2878
		Radios_DataWideGeneralPeerIPAddress1_A8524_3,
		// Token: 0x04000B3F RID: 2879
		Radios_RadWideUserInformationandPasswordsSoftIDUsername_A9169_1 = 118900201,
		// Token: 0x04000B40 RID: 2880
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_1 = 118900301,
		// Token: 0x04000B41 RID: 2881
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_2,
		// Token: 0x04000B42 RID: 2882
		Radios_DataWideGeneralBTDUNPeerIPAddress_A41123_3,
		// Token: 0x04000B43 RID: 2883
		Radios_RadWideUserInformationandPINPassword_41303_1 = 118900401,
		// Token: 0x04000B44 RID: 2884
		Radios_RadWideUserInformationandPINPassword_41303_2,
		// Token: 0x04000B45 RID: 2885
		Radios_RadWideUserInformationandUserLoginUnitID_41306_1 = 118900501,
		// Token: 0x04000B46 RID: 2886
		Radios_RadWideUserInformationandUserLoginUnitID_41306_2,
		// Token: 0x04000B47 RID: 2887
		Radios_DataWideGeneralSubscriberIPAddress1_A9222_1 = 118900601,
		// Token: 0x04000B48 RID: 2888
		Radios_DataWideGeneralSubscriberIPAddress1_A9222_2,
		// Token: 0x04000B49 RID: 2889
		Radios_RadInfoGeneralSerialNumber_A9122_1 = 118900701,
		// Token: 0x04000B4A RID: 2890
		Radios_DataWideWiFiNetworkSSID_42519_1 = 118900801,
		// Token: 0x04000B4B RID: 2891
		Radios_DataWideWiFiNetworkSSID_42519_2,
		// Token: 0x04000B4C RID: 2892
		Radios_DataWideWiFiNetworkSSID_42519_3,
		// Token: 0x04000B4D RID: 2893
		Radios_DataWideWiFiNetworkEncryptedNetworkPassword_42517_1 = 118900901,
		// Token: 0x04000B4E RID: 2894
		Radios_DataWideWiFiNetworkEncryptedNetworkPassword_42517_2,
		// Token: 0x04000B4F RID: 2895
		Zone_Clone_Enable_Con_Sys_Full = 119200000,
		// Token: 0x04000B50 RID: 2896
		Zone_Clone_Enable_Astro_Talk_Group,
		// Token: 0x04000B51 RID: 2897
		Zone_Clone_Enable_Con_Per_Full,
		// Token: 0x04000B52 RID: 2898
		Zone_Clone_Enable_Channel_Full,
		// Token: 0x04000B53 RID: 2899
		Zone_Clone_Enable_NotContinuous,
		// Token: 0x04000B54 RID: 2900
		Tonga_Alias_Restricted_Characters = 200000000,
		// Token: 0x04000B55 RID: 2901
		Accessories_ACCY_DATARVTCHNL_1 = 200100101,
		// Token: 0x04000B56 RID: 2902
		Accessories_ACCY_DATARVTCHNL_2,
		// Token: 0x04000B57 RID: 2903
		Accessories_ACCY_DATARVTCHNL_3,
		// Token: 0x04000B58 RID: 2904
		Accessories_MBPTTCHANSELECTION_ITEM_1 = 200100201,
		// Token: 0x04000B59 RID: 2905
		Accessories_RC_EXTDIGFX_1 = 200100301,
		// Token: 0x04000B5A RID: 2906
		Accessories_RC_EXTANLGFX_1 = 200100401,
		// Token: 0x04000B5B RID: 2907
		Accessories_BR_ACCAUDIOEMPS_1 = 200100501,
		// Token: 0x04000B5C RID: 2908
		Accessories_BR_ACCAUDIOEMPS_2,
		// Token: 0x04000B5D RID: 2909
		Accessories_ACCY_RevertChannel_1 = 200100601,
		// Token: 0x04000B5E RID: 2910
		Accessories_ACCY_RevertChannel_2,
		// Token: 0x04000B5F RID: 2911
		Accessories_ACCY_RevertChannel_3,
		// Token: 0x04000B60 RID: 2912
		Accessories_ACCY_RevertChannel_4,
		// Token: 0x04000B61 RID: 2913
		ActionListItems_ALSF_CPV_1 = 200200101,
		// Token: 0x04000B62 RID: 2914
		ActionListItems_ALSF_CPV_2,
		// Token: 0x04000B63 RID: 2915
		AutoAcknowledges_S5AUTOACK_RVTCHNLITEM_1 = 200500101,
		// Token: 0x04000B64 RID: 2916
		AutoAcknowledges_S5AUTOACK_RVTCHNLITEM_2,
		// Token: 0x04000B65 RID: 2917
		CallList_DigitalCalls_1 = 200600101,
		// Token: 0x04000B66 RID: 2918
		CallList_DigitalCalls_SITECALL_1 = 200600103,
		// Token: 0x04000B67 RID: 2919
		CallList_DigitalCalls_MULTISITECALL_1,
		// Token: 0x04000B68 RID: 2920
		CallList_DigitalCalls_ROUTETYPE,
		// Token: 0x04000B69 RID: 2921
		CallList_MdcCalls_1 = 200600201,
		// Token: 0x04000B6A RID: 2922
		CallList_CapplusCalls_1 = 200600301,
		// Token: 0x04000B6B RID: 2923
		CallList_DigitalCalls_2 = 200600102,
		// Token: 0x04000B6C RID: 2924
		CallList_MdcCalls_2 = 200600202,
		// Token: 0x04000B6D RID: 2925
		CallList_CapplusCalls_2 = 200600302,
		// Token: 0x04000B6E RID: 2926
		CallList_QuikCallIICalls_1 = 200600401,
		// Token: 0x04000B6F RID: 2927
		CallList_PhoneCalls_1 = 200600501,
		// Token: 0x04000B70 RID: 2928
		CallList_AnalogCalls_1 = 200600601,
		// Token: 0x04000B71 RID: 2929
		CallList_FiveToneCalls_1 = 200600701,
		// Token: 0x04000B72 RID: 2930
		CapacityPlusCalls_CAPPLUSUCL_CONNECTTYPE_1 = 200800101,
		// Token: 0x04000B73 RID: 2931
		CapacityPlusDataListItems_InvalidPersonality = 201000001,
		// Token: 0x04000B74 RID: 2932
		CapacityPlusDataListItems_InvalidChannelType,
		// Token: 0x04000B75 RID: 2933
		CapacityPlusRXGroupListItems_CAPPLUS_RXTG_UCLCOMP_1 = 201300001,
		// Token: 0x04000B76 RID: 2934
		CapacityPlusRXGroupListItems_CAPPLUS_RXTG_UCLCOMP_2,
		// Token: 0x04000B77 RID: 2935
		CapacityPlusVoiceListItems_InvalidPersonality = 201700001,
		// Token: 0x04000B78 RID: 2936
		CapacityPlusVoiceListItems_InvalidChannelType,
		// Token: 0x04000B79 RID: 2937
		ControlButtons_LongPressDuration_ms = 201800001,
		// Token: 0x04000B7A RID: 2938
		ControlButtons_GPSONOFF,
		// Token: 0x04000B7B RID: 2939
		ControlButtons_PermanentDiscoverable,
		// Token: 0x04000B7C RID: 2940
		ControlButtons_PrivacyONOFF,
		// Token: 0x04000B7D RID: 2941
		ControlButtons_ReplayTexttoSpeechMessage,
		// Token: 0x04000B7E RID: 2942
		ControlButtons_wifi,
		// Token: 0x04000B7F RID: 2943
		ControlButtons_TGOPTBOARD,
		// Token: 0x04000B80 RID: 2944
		ConventionalPersonality_CP_ARTSMODETYPE_1 = 202000101,
		// Token: 0x04000B81 RID: 2945
		ConventionalPersonality_CP_EMPHASEL_1 = 202000201,
		// Token: 0x04000B82 RID: 2946
		ConventionalPersonality_CP_EMPHASEL_2,
		// Token: 0x04000B83 RID: 2947
		ConventionalPersonality_CP_EMPHASEL_3,
		// Token: 0x04000B84 RID: 2948
		ConventionalPersonality_CP_TXINHXPLEN_1 = 202000301,
		// Token: 0x04000B85 RID: 2949
		ConventionalPersonality_CP_TXINHXPLEN_2,
		// Token: 0x04000B86 RID: 2950
		ConventionalPersonality_CP_TXINHXPLEN_3,
		// Token: 0x04000B87 RID: 2951
		ConventionalPersonality_CP_TXINHXPLEN_4,
		// Token: 0x04000B88 RID: 2952
		ConventionalPersonality_CP_TXINHXPLEN_5,
		// Token: 0x04000B89 RID: 2953
		ConventionalPersonality_CP_TXINHXPLEN_6,
		// Token: 0x04000B8A RID: 2954
		ConventionalPersonality_CP_TXINHXPLEN_8 = 202000308,
		// Token: 0x04000B8B RID: 2955
		ConventionalPersonality_CP_TXINHXPLEN_9,
		// Token: 0x04000B8C RID: 2956
		ConventionalPersonality_CP_GPSRVRTPERSIT_1 = 202000401,
		// Token: 0x04000B8D RID: 2957
		ConventionalPersonality_CP_GPSRVRTPERSIT_2,
		// Token: 0x04000B8E RID: 2958
		ConventionalPersonality_CP_GPSRVRTPERSIT_3,
		// Token: 0x04000B8F RID: 2959
		ConventionalPersonality_CP_GPSRVRTPERSIT_4,
		// Token: 0x04000B90 RID: 2960
		ConventionalPersonality_CP_GPSRVRTPERSIT_5,
		// Token: 0x04000B91 RID: 2961
		ConventionalPersonality_CP_GPSRVRTPERSIT_6,
		// Token: 0x04000B92 RID: 2962
		ConventionalPersonality_CP_GPSRVRTPERSIT_7,
		// Token: 0x04000B93 RID: 2963
		ConventionalPersonality_CP_GPSRVRTPERSIT_8,
		// Token: 0x04000B94 RID: 2964
		ConventionalPersonality_CP_MYCALLADCRTR_1 = 202000501,
		// Token: 0x04000B95 RID: 2965
		ConventionalPersonality_CP_MYCALLADCRTR_2,
		// Token: 0x04000B96 RID: 2966
		ConventionalPersonality_CP_MYCALLADCRTR_3,
		// Token: 0x04000B97 RID: 2967
		ConventionalPersonality_CP_ENHCPRVCYIT_1 = 202000601,
		// Token: 0x04000B98 RID: 2968
		ConventionalPersonality_CP_TRUNKCHANLISTIT_1 = 202000701,
		// Token: 0x04000B99 RID: 2969
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_1 = 202000801,
		// Token: 0x04000B9A RID: 2970
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_2,
		// Token: 0x04000B9B RID: 2971
		ConventionalPersonality_CP_S1SCHGPSPRWDRSV_3,
		// Token: 0x04000B9C RID: 2972
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_1 = 202000901,
		// Token: 0x04000B9D RID: 2973
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_2,
		// Token: 0x04000B9E RID: 2974
		ConventionalPersonality_CP_S2SCHGPSPRWDRSV_3,
		// Token: 0x04000B9F RID: 2975
		ConventionalPersonality_CP_ARSPLUS_1 = 202001001,
		// Token: 0x04000BA0 RID: 2976
		ConventionalPersonality_CP_ARSPLUS_2,
		// Token: 0x04000BA1 RID: 2977
		ConventionalPersonality_CP_ARSPLUS_3,
		// Token: 0x04000BA2 RID: 2978
		ConventionalPersonality_CP_ARSPLUS_4,
		// Token: 0x04000BA3 RID: 2979
		ConventionalPersonality_CP_SQUELCHMODE_1 = 202001101,
		// Token: 0x04000BA4 RID: 2980
		ConventionalPersonality_CP_SCNROAMLISTIT_1 = 202001201,
		// Token: 0x04000BA5 RID: 2981
		ConventionalPersonality_CP_SCNROAMLISTIT_2,
		// Token: 0x04000BA6 RID: 2982
		ConventionalPersonality_CP_SCNROAMLISTIT_3,
		// Token: 0x04000BA7 RID: 2983
		ConventionalPersonality_CP_SCNROAMLISTIT_4,
		// Token: 0x04000BA8 RID: 2984
		ConventionalPersonality_CP_LONEWORKEN_1 = 202001301,
		// Token: 0x04000BA9 RID: 2985
		ConventionalPersonality_CP_TALKAROUNDEN_1 = 202001401,
		// Token: 0x04000BAA RID: 2986
		ConventionalPersonality_CP_TALKAROUNDEN_2,
		// Token: 0x04000BAB RID: 2987
		ConventionalPersonality_CP_TALKAROUNDEN_3,
		// Token: 0x04000BAC RID: 2988
		ConventionalPersonality_CP_TALKAROUNDEN_4,
		// Token: 0x04000BAD RID: 2989
		ConventionalPersonality_CP_TALKAROUNDEN_5,
		// Token: 0x04000BAE RID: 2990
		ConventionalPersonality_CP_TALKAROUNDEN_6,
		// Token: 0x04000BAF RID: 2991
		ConventionalPersonality_CP_TALKAROUNDEN_7,
		// Token: 0x04000BB0 RID: 2992
		ConventionalPersonality_CP_CHNLBWDTH_1 = 202001501,
		// Token: 0x04000BB1 RID: 2993
		ConventionalPersonality_CP_CHNLBWDTH_2,
		// Token: 0x04000BB2 RID: 2994
		ConventionalPersonality_CP_CHNLBWDTH_3,
		// Token: 0x04000BB3 RID: 2995
		ConventionalPersonality_CP_CHNLBWDTH_4,
		// Token: 0x04000BB4 RID: 2996
		ConventionalPersonality_CP_CHNLBWDTH_5,
		// Token: 0x04000BB5 RID: 2997
		ConventionalPersonality_CP_UKPPERS_1 = 202001601,
		// Token: 0x04000BB6 RID: 2998
		ConventionalPersonality_CP_UKPPERS_2,
		// Token: 0x04000BB7 RID: 2999
		ConventionalPersonality_CP_UKPPERS_3,
		// Token: 0x04000BB8 RID: 3000
		ConventionalPersonality_CP_UKPPERS_4,
		// Token: 0x04000BB9 RID: 3001
		ConventionalPersonality_NONMSIDMR3_MSAC_Confict,
		// Token: 0x04000BBA RID: 3002
		ConventionalPersonality_CP_TXTPLCODE_1 = 202001701,
		// Token: 0x04000BBB RID: 3003
		ConventionalPersonality_CP_RXTPLCODE_1 = 202001801,
		// Token: 0x04000BBC RID: 3004
		ConventionalPersonality_CP_TOCEN_1 = 202001901,
		// Token: 0x04000BBD RID: 3005
		ConventionalPersonality_CP_TXREFFREQ_1 = 202002001,
		// Token: 0x04000BBE RID: 3006
		ConventionalPersonality_CP_TXFREQ_1 = 202002101,
		// Token: 0x04000BBF RID: 3007
		ConventionalPersonality_CP_REVBURST_1 = 202002201,
		// Token: 0x04000BC0 RID: 3008
		ConventionalPersonality_CP_REVBURST_2,
		// Token: 0x04000BC1 RID: 3009
		ConventionalPersonality_CP_RXSIGSQL_1 = 202002301,
		// Token: 0x04000BC2 RID: 3010
		ConventionalPersonality_CP_RXSIGSQL_2,
		// Token: 0x04000BC3 RID: 3011
		ConventionalPersonality_CP_RXSIGSQL_3,
		// Token: 0x04000BC4 RID: 3012
		ConventionalPersonality_CP_MLTSTSLTEN_1 = 202002401,
		// Token: 0x04000BC5 RID: 3013
		ConventionalPersonality_CP_MLTSTSLTEN_2,
		// Token: 0x04000BC6 RID: 3014
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_1 = 202002501,
		// Token: 0x04000BC7 RID: 3015
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_2,
		// Token: 0x04000BC8 RID: 3016
		ConventionalPersonality_CP_SYSTEMCONTROLLERMODE_3,
		// Token: 0x04000BC9 RID: 3017
		ConventionalPersonality_CP_MANDOWNPROFILEITEM_1 = 202002601,
		// Token: 0x04000BCA RID: 3018
		ConventionalPersonality_CP_MANDOWNPROFILEITEM_2,
		// Token: 0x04000BCB RID: 3019
		ConventionalPersonality_CP_HCS_1 = 202002701,
		// Token: 0x04000BCC RID: 3020
		ConventionalPersonality_CP_HCS_2,
		// Token: 0x04000BCD RID: 3021
		ConventionalPersonality_CP_HCS_3,
		// Token: 0x04000BCE RID: 3022
		ConventionalPersonality_CP_PHONEGWEN_1 = 202002801,
		// Token: 0x04000BCF RID: 3023
		ConventionalPersonality_CP_PHONEGWEN_2,
		// Token: 0x04000BD0 RID: 3024
		ConventionalPersonality_CP_UTOSCANEN_1 = 202002901,
		// Token: 0x04000BD1 RID: 3025
		ConventionalPersonality_CP_MLTSTPSNLTIND_1 = 202003001,
		// Token: 0x04000BD2 RID: 3026
		ConventionalPersonality_CP_MLTSTPSNLTIND_2,
		// Token: 0x04000BD3 RID: 3027
		ConventionalPersonality_CP_MLTSTPSNLTIND_3,
		// Token: 0x04000BD4 RID: 3028
		ConventionalPersonality_CP_DUALSLOTDATAOPERATION_1 = 202003101,
		// Token: 0x04000BD5 RID: 3029
		ConventionalPersonality_CP_OTARMODE_1 = 202003201,
		// Token: 0x04000BD6 RID: 3030
		ConventionalPersonality_CP_RXFREQ_1 = 202003301,
		// Token: 0x04000BD7 RID: 3031
		ConventionalPersonality_CP_PHONESYSIT_1 = 202003401,
		// Token: 0x04000BD8 RID: 3032
		ConventionalPersonality_CP_625EDMEN_1 = 202003501,
		// Token: 0x04000BD9 RID: 3033
		ConventionalPersonality_CP_SCHGPSEN_1 = 202003601,
		// Token: 0x04000BDA RID: 3034
		ConventionalPersonality_CP_SCHGPSEN_2,
		// Token: 0x04000BDB RID: 3035
		ConventionalPersonality_CP_TRTEN_1 = 202003701,
		// Token: 0x04000BDC RID: 3036
		ConventionalPersonality_CP_SFRENABLE_1 = 202003801,
		// Token: 0x04000BDD RID: 3037
		ConventionalPersonality_CP_EMALRMINDEN_1 = 202004001,
		// Token: 0x04000BDE RID: 3038
		ConventionalPersonality_CP_EMALRMINDEN_2,
		// Token: 0x04000BDF RID: 3039
		ConventionalPersonality_CP_EMCALINDEN_1 = 202005001,
		// Token: 0x04000BE0 RID: 3040
		ConventionalPersonality_CP_AESPRVCYIT_1 = 202008001,
		// Token: 0x04000BE1 RID: 3041
		ConventionalPersonality_CP_VOXSTATE_1 = 202009001,
		// Token: 0x04000BE2 RID: 3042
		ConventionalPersonality_CP_VOICEPRIVACYEN_1 = 202010001,
		// Token: 0x04000BE3 RID: 3043
		ConventionalPersonality_CP_EMSYSIT_1 = 202011001,
		// Token: 0x04000BE4 RID: 3044
		ConventionalPersonality_CP_TGLISTIT_1 = 202012001,
		// Token: 0x04000BE5 RID: 3045
		ConventionalPersonality_CP_CNVPERSALIAS_1 = 202013001,
		// Token: 0x04000BE6 RID: 3046
		ConventionalPersonality_CP_CNVPERSALIAS_2,
		// Token: 0x04000BE7 RID: 3047
		ConventionalPersonality_ConventionalPersonality_1 = 202014001,
		// Token: 0x04000BE8 RID: 3048
		ConventionalPersonality_CP_OBTRUNKMODEy_1 = 202015001,
		// Token: 0x04000BE9 RID: 3049
		ConventionalPersonality_DMR3TRUNKING_1,
		// Token: 0x04000BEA RID: 3050
		ConventionalPersonality_DMR3CAPACITY_1,
		// Token: 0x04000BEB RID: 3051
		ConventionalPersonality_CBFREQUENCYNOTDISPLAYINSCANLIST,
		// Token: 0x04000BEC RID: 3052
		ConventionalPersonality_CP_LCPSTLSTIT_1 = 202016001,
		// Token: 0x04000BED RID: 3053
		ConventionalPersonality_DMR3,
		// Token: 0x04000BEE RID: 3054
		ConventionalPersonality_CP_TXCOMPUDPIPHEADEN_1 = 202017001,
		// Token: 0x04000BEF RID: 3055
		ConventionalPersonality_CP_PERSTYPE_1 = 202018001,
		// Token: 0x04000BF0 RID: 3056
		ConventionalPersonality_CP_PERSTYPE_2,
		// Token: 0x04000BF1 RID: 3057
		ConventionalPersonality_CP_PERSTYPE_3,
		// Token: 0x04000BF2 RID: 3058
		ConventionalPersonality_CBChannelValid_1 = 202020001,
		// Token: 0x04000BF3 RID: 3059
		ConventionalPersonality_CP_DMR3Sites_1 = 202021001,
		// Token: 0x04000BF4 RID: 3060
		ConventionalPersonality_CP_DMR3Sites_Invalid_2,
		// Token: 0x04000BF5 RID: 3061
		ConventionalPersonality_ChannelTypeForLinkTypeCheck = 202030001,
		// Token: 0x04000BF6 RID: 3062
		ConventionalPersonality_CP_DMR3System_Invalid,
		// Token: 0x04000BF7 RID: 3063
		ConventionalPersonality_CP_DMR3System_Invalid2,
		// Token: 0x04000BF8 RID: 3064
		ConventionalPersonality_CP_DMR3Channels_InValid,
		// Token: 0x04000BF9 RID: 3065
		ConventionalPersonality_DecoderDefinitionSelections_1 = 202031001,
		// Token: 0x04000BFA RID: 3066
		ConventionalPersonality_OTARMODE_1 = 202041001,
		// Token: 0x04000BFB RID: 3067
		DecoderDefinitions_S5DECODER_AUTOACKITEM_1 = 202200101,
		// Token: 0x04000BFC RID: 3068
		DecoderDefinitions_S5DECODER_DECSEQ1_1 = 202200201,
		// Token: 0x04000BFD RID: 3069
		DecoderDefinitions_S5DECODER_DECSEQ1_2,
		// Token: 0x04000BFE RID: 3070
		DecoderDefinitions_S5DECODER_DECSEQ1_3,
		// Token: 0x04000BFF RID: 3071
		DecoderDefinitions_S5DECSTSLDLL_5TSTSNUM_1 = 202200301,
		// Token: 0x04000C00 RID: 3072
		DecoderDefinitions_S5DECSTSLDLL_5TSTSNUM_2,
		// Token: 0x04000C01 RID: 3073
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_1 = 202300101,
		// Token: 0x04000C02 RID: 3074
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_2,
		// Token: 0x04000C03 RID: 3075
		DecoderStatusListItems_S5DECSTSLDLL_5TSTSNUM_3,
		// Token: 0x04000C04 RID: 3076
		DigitalCalls_DU_CONNECTTYPE_1 = 202400101,
		// Token: 0x04000C05 RID: 3077
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_1 = 202500101,
		// Token: 0x04000C06 RID: 3078
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_2,
		// Token: 0x04000C07 RID: 3079
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_3,
		// Token: 0x04000C08 RID: 3080
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_4,
		// Token: 0x04000C09 RID: 3081
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_5,
		// Token: 0x04000C0A RID: 3082
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_6,
		// Token: 0x04000C0B RID: 3083
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_7,
		// Token: 0x04000C0C RID: 3084
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_8,
		// Token: 0x04000C0D RID: 3085
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_9,
		// Token: 0x04000C0E RID: 3086
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_10,
		// Token: 0x04000C0F RID: 3087
		DigitalEmergencySystems_DESS_DIGITEMRVRTPERSIT_11,
		// Token: 0x04000C10 RID: 3088
		DigitalEmergencySystems_DESS_EMERGENCYGROUPIT_NonGroupCall = 202500200,
		// Token: 0x04000C11 RID: 3089
		DigitalEmergencySystems_DESS_EMERGENCYGROUPIT_NonDigitalCall,
		// Token: 0x04000C12 RID: 3090
		DigitalRXGroupListItems_RXTG_DGUCLCOMP_1 = 202700101,
		// Token: 0x04000C13 RID: 3091
		DigitalRXGroupListItems_RXTG_DGUCLCOMP_2,
		// Token: 0x04000C14 RID: 3092
		Encoder_RC_ADDRESSMANUALDIALRANGE1MAX_1 = 202800101,
		// Token: 0x04000C15 RID: 3093
		Encoder_RC_ADDRESSMANUALDIALRANGE1MIN_1 = 202800201,
		// Token: 0x04000C16 RID: 3094
		Encoder_RC_ADDRESSMANUALDIALRANGE2MAX_1 = 202800301,
		// Token: 0x04000C17 RID: 3095
		Encoder_RC_ADDRESSMANUALDIALRANGE2MIN_1 = 202800401,
		// Token: 0x04000C18 RID: 3096
		Encoder_RC_ADDRESSMANUALDIALRANGE3MAX_1 = 202800501,
		// Token: 0x04000C19 RID: 3097
		Encoder_RC_ADDRESSMANUALDIALRANGE3MIN_1 = 202800601,
		// Token: 0x04000C1A RID: 3098
		Encoder_RC_STATUSMANUALDIALRANGE1MAX_1 = 202800701,
		// Token: 0x04000C1B RID: 3099
		Encoder_RC_STATUSMANUALDIALRANGE1MIN_1 = 202800801,
		// Token: 0x04000C1C RID: 3100
		Encoder_RC_STATUSMANUALDIALRANGE2MAX_1 = 202800901,
		// Token: 0x04000C1D RID: 3101
		Encoder_RC_STATUSMANUALDIALRANGE2MIN_1 = 202801001,
		// Token: 0x04000C1E RID: 3102
		Encoder_RC_STATUSMANUALDIALRANGE3MAX_1 = 202801101,
		// Token: 0x04000C1F RID: 3103
		Encoder_RC_STATUSMANUALDIALRANGE3MIN_1 = 202801201,
		// Token: 0x04000C20 RID: 3104
		EncoderSequences_S5ENCSEQ_PRETIME_1 = 202900101,
		// Token: 0x04000C21 RID: 3105
		EncoderSequences_S5ENCSEQ_EXTFSTTDUR_1 = 202900201,
		// Token: 0x04000C22 RID: 3106
		EncoderSequences_S5ENCSEQ_SEQ_1 = 202900301,
		// Token: 0x04000C23 RID: 3107
		EncoderSequences_S5ENCSEQ_SEQ_2,
		// Token: 0x04000C24 RID: 3108
		EncoderSequences_S5ENCSEQ_SEQ_3,
		// Token: 0x04000C25 RID: 3109
		EncoderSequences_S5ENCSEQ_SEQ_4,
		// Token: 0x04000C26 RID: 3110
		EncoderSequences_S5ENCSEQ_SEQ_5,
		// Token: 0x04000C27 RID: 3111
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_1 = 203100101,
		// Token: 0x04000C28 RID: 3112
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_2,
		// Token: 0x04000C29 RID: 3113
		EncoderStatusListItems_S5ENCSTSLDLL_5TSTSNUM_3,
		// Token: 0x04000C2A RID: 3114
		FiveToneCalls = 203300000,
		// Token: 0x04000C2B RID: 3115
		FiveToneCalls_S5CLDLL_5TCALLADD_1 = 203300101,
		// Token: 0x04000C2C RID: 3116
		FiveToneCalls_S5CLDLL_5TCALLADD_2,
		// Token: 0x04000C2D RID: 3117
		FiveToneSystems_S5CLDLL_5TCALLADD_1 = 203400101,
		// Token: 0x04000C2E RID: 3118
		FiveToneSystems_S5SS_GRPTONE_1 = 203400201,
		// Token: 0x04000C2F RID: 3119
		FiveToneSystems_S5SS_RPTTONE_1 = 203400301,
		// Token: 0x04000C30 RID: 3120
		FlexibleCapacityPlusRXGroupListItems = 203600000,
		// Token: 0x04000C31 RID: 3121
		FlexibleCapacityPlusRXGroupListItems_FLEXIBLECAPPLUSRXTGDLL_LEDITEM_1 = 203600101,
		// Token: 0x04000C32 RID: 3122
		FlexibleCapacityPlusRXGroupListItems_FLEXIBLECAPPLUSRXTGDLL_LEDITEM_2,
		// Token: 0x04000C33 RID: 3123
		GeneralSettings_RC_TXHGHPWR1_1 = 203700101,
		// Token: 0x04000C34 RID: 3124
		GeneralSettings_RC_TXHGHPWR_1 = 203700201,
		// Token: 0x04000C35 RID: 3125
		GeneralSettings_RC_TXLOWPWR2_1 = 203700301,
		// Token: 0x04000C36 RID: 3126
		GeneralSettings_RC_TXHGHPWR2_1 = 203700401,
		// Token: 0x04000C37 RID: 3127
		GeneralSettings_BR_DCTXPWER_1 = 203700501,
		// Token: 0x04000C38 RID: 3128
		GeneralSettings_BR_DCTXPWER2_1 = 203700601,
		// Token: 0x04000C39 RID: 3129
		GeneralSettings_RC_IMBCVINDCT_1 = 203700701,
		// Token: 0x04000C3A RID: 3130
		GeneralSettings_BR_CWID_1 = 203700801,
		// Token: 0x04000C3B RID: 3131
		GeneralSettings_RC_INTANLGFX_1 = 203700901,
		// Token: 0x04000C3C RID: 3132
		GeneralSettings_GNSSCFGCMPBLK_USERSELECTION_1 = 203701001,
		// Token: 0x04000C3D RID: 3133
		GeneralSettings_RC_FPPPWD_1 = 203701101,
		// Token: 0x04000C3E RID: 3134
		GeneralSettings_RC_FPPPWD_2,
		// Token: 0x04000C3F RID: 3135
		GeneralSettings_RC_SEL5RADIOID0_1 = 203701201,
		// Token: 0x04000C40 RID: 3136
		GeneralSettings_RC_SEL5RADIOID0_2,
		// Token: 0x04000C41 RID: 3137
		GeneralSettings_RC_IXTDIGFX_1 = 203701301,
		// Token: 0x04000C42 RID: 3138
		GeneralSettings_RC_GRPCALLHT_1 = 203701401,
		// Token: 0x04000C43 RID: 3139
		GeneralSettings_RC_GRPCALLHT_2,
		// Token: 0x04000C44 RID: 3140
		GeneralSettings_PSWD_PSWDDATA_1 = 203701501,
		// Token: 0x04000C45 RID: 3141
		GeneralSettings_PSWD_PSWDDATA_2,
		// Token: 0x04000C46 RID: 3142
		GeneralSettings_PSWD_PSWDDATA_3,
		// Token: 0x04000C47 RID: 3143
		GeneralSettings_PSWD_PSWDDATA_4,
		// Token: 0x04000C48 RID: 3144
		GeneralSettings_PSWD_PSWDDATA_5,
		// Token: 0x04000C49 RID: 3145
		GeneralSettings_CHECKFORPASSWORD,
		// Token: 0x04000C4A RID: 3146
		GeneralSettings_RC_DSGPWRUPCHANITEM_Zone_1 = 203701601,
		// Token: 0x04000C4B RID: 3147
		GeneralSettings_RC_DSGPWRUPCHANITEM_1 = 203701701,
		// Token: 0x04000C4C RID: 3148
		GeneralSettings_BR_VOTINGMODE_1 = 203701801,
		// Token: 0x04000C4D RID: 3149
		GeneralSettings_BR_VOTINGMODE_2,
		// Token: 0x04000C4E RID: 3150
		GeneralSetting_RC_HOMECHANNELIT_Zone_1 = 203701901,
		// Token: 0x04000C4F RID: 3151
		JobTicketsListItems = 204500000,
		// Token: 0x04000C50 RID: 3152
		JobTicketsListItems_JTSO_ACTRSPTXT_1 = 204500101,
		// Token: 0x04000C51 RID: 3153
		JobTicketsTemplatesListItems_1,
		// Token: 0x04000C52 RID: 3154
		MDCSystems_MDCSYS_MDCEMGCYPERS_1 = 205100101,
		// Token: 0x04000C53 RID: 3155
		MDCSystems_MDCSYS_MDCEMGCYPERS_2,
		// Token: 0x04000C54 RID: 3156
		MDCSystems_MDCSYS_MDCEMGCYPERS_3,
		// Token: 0x04000C55 RID: 3157
		MDCSystems_MDCSYS_MDCEMGCYPERS_4,
		// Token: 0x04000C56 RID: 3158
		MDCSystems_MDCSYS_MDCEMGCYPERS_5,
		// Token: 0x04000C57 RID: 3159
		MDCSystems_MDCSYS_MDCEMGCYPERS_6,
		// Token: 0x04000C58 RID: 3160
		MDCSystems_MDCSYS_EMGCYTYPE_1 = 205100201,
		// Token: 0x04000C59 RID: 3161
		MDCSystems_MDCSYS_EMGCYATYPE_1 = 205100301,
		// Token: 0x04000C5A RID: 3162
		MDCSystems_MDCSYS_PRMID_1 = 205100401,
		// Token: 0x04000C5B RID: 3163
		MDCSystems_MDCSYS_PRMID_2,
		// Token: 0x04000C5C RID: 3164
		MDCSystems_MDCSYS_PRMID_3,
		// Token: 0x04000C5D RID: 3165
		MDCSystems_MDCSYS_GRPID_1 = 205100501,
		// Token: 0x04000C5E RID: 3166
		CnvSysGeneralMDCPrimaryID_A8744_1 = 205100601,
		// Token: 0x04000C5F RID: 3167
		Menu_GPS = 205200101,
		// Token: 0x04000C60 RID: 3168
		Menu_MENU_JBTKTMMNAME_1 = 205200201,
		// Token: 0x04000C61 RID: 3169
		Network_RC_BTPPFXPINHSP_1 = 205400101,
		// Token: 0x04000C62 RID: 3170
		Network_RC_RemoteHSPAddress,
		// Token: 0x04000C63 RID: 3171
		Network_ForwardtoPC,
		// Token: 0x04000C64 RID: 3172
		Network_DHCP,
		// Token: 0x04000C65 RID: 3173
		Network_WifiIP1,
		// Token: 0x04000C66 RID: 3174
		Network_WifiPasswordCannotBeEmpty,
		// Token: 0x04000C67 RID: 3175
		Network_WifiSSIDisTooLong,
		// Token: 0x04000C68 RID: 3176
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_1 = 205500101,
		// Token: 0x04000C69 RID: 3177
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_2,
		// Token: 0x04000C6A RID: 3178
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_3,
		// Token: 0x04000C6B RID: 3179
		NumberKeyQuickContactAccessItems_PGK_UCLITEM_4,
		// Token: 0x04000C6C RID: 3180
		OneTouchAccessItems_OTC_UCLITEM_1 = 205600101,
		// Token: 0x04000C6D RID: 3181
		OneTouchAccessItems_OTC_UCLITEM_2,
		// Token: 0x04000C6E RID: 3182
		OneTouchAccessItems_OTC_UCLITEM_3,
		// Token: 0x04000C6F RID: 3183
		OneTouchAccessItems_OTC_UCLITEM_4,
		// Token: 0x04000C70 RID: 3184
		OneTouchAccessItems_OTC_UCLITEM_5,
		// Token: 0x04000C71 RID: 3185
		OneTouchAccessItems_OTC_UCLITEM_6,
		// Token: 0x04000C72 RID: 3186
		OneTouchAccessItems_OTC_HMREVTITEM_1 = 205600201,
		// Token: 0x04000C73 RID: 3187
		OneTouchAccessItems_OTC_HMREVTITEM_2,
		// Token: 0x04000C74 RID: 3188
		OneTouchAccessItems_OTC_HMREVTITEM_3,
		// Token: 0x04000C75 RID: 3189
		OneTouchAccessItems_OTC_HMREVTITEM_Zone_1 = 205600301,
		// Token: 0x04000C76 RID: 3190
		OneTouchAccessItems_OTC_HMREVTITEM_Zone_2,
		// Token: 0x04000C77 RID: 3191
		OneTouchAccessItems_OTC_CALLTYPE_1 = 205600401,
		// Token: 0x04000C78 RID: 3192
		OneTouchAccessItems_OTC_CALLTYPE_2,
		// Token: 0x04000C79 RID: 3193
		OneTouchAccessItems_OTC_CALLTYPE_3,
		// Token: 0x04000C7A RID: 3194
		OneTouchAccessItems_OTC_CALLTYPE_4,
		// Token: 0x04000C7B RID: 3195
		OneTouchAccessItems_OTC_CALLTYPE_5,
		// Token: 0x04000C7C RID: 3196
		OneTouchAccessItems_OTC_CALLTYPE_6,
		// Token: 0x04000C7D RID: 3197
		OneTouchAccessItems_OTC_CALLTYPE_7,
		// Token: 0x04000C7E RID: 3198
		OneTouchAccessItems_OTC_CALLTYPE_8,
		// Token: 0x04000C7F RID: 3199
		OneTouchAccessItems_OTC_CALLTYPE_9,
		// Token: 0x04000C80 RID: 3200
		PCRLanguageList_Dup_LanguageID = 205800001,
		// Token: 0x04000C81 RID: 3201
		PCRLanguageList_Invalid_LanguageID,
		// Token: 0x04000C82 RID: 3202
		PhoneSystem_BRPC_DPPPRECFGCALLTYPE_1 = 206100101,
		// Token: 0x04000C83 RID: 3203
		PhoneSystem_DTMFCLELL_DEACCCODE_1 = 206100201,
		// Token: 0x04000C84 RID: 3204
		PhoneSystems_DTMFCLELL_ACCCODE_1 = 206200101,
		// Token: 0x04000C85 RID: 3205
		QuikCallIICalls_QU_RVRTPERS_1 = 206400101,
		// Token: 0x04000C86 RID: 3206
		QuikCallIICalls_QU_RVRTPERS_2,
		// Token: 0x04000C87 RID: 3207
		QuikCallIICalls_QU_RVRTPERS_3,
		// Token: 0x04000C88 RID: 3208
		QuikCallIICalls_QU_CODEA_1 = 206400201,
		// Token: 0x04000C89 RID: 3209
		QuikCallIICalls_QU_CODEB_1 = 206400301,
		// Token: 0x04000C8A RID: 3210
		QuikCallIISystems_QCIISYS_CODEA_1 = 206500101,
		// Token: 0x04000C8B RID: 3211
		RASKeysList_SecuritySet_1 = 206700001,
		// Token: 0x04000C8C RID: 3212
		RASKeys_AliasLength2,
		// Token: 0x04000C8D RID: 3213
		RASKeys_AliasValid3,
		// Token: 0x04000C8E RID: 3214
		RoamList_SSP_CNVPERCOMP_1 = 206900101,
		// Token: 0x04000C8F RID: 3215
		Scan_StartVoteRSSIThreshold_dBm = 207100101,
		// Token: 0x04000C90 RID: 3216
		ScanItems_SP_DSGTXMEM_Trunking3600_1 = 207200101,
		// Token: 0x04000C91 RID: 3217
		ScanItems_SP_DSGTXMEM_Trunking3600_2,
		// Token: 0x04000C92 RID: 3218
		ScanItems_SP_DSGTXMEM_Trunking3600_3,
		// Token: 0x04000C93 RID: 3219
		ScanItems_SP_DSGTXMEM_Trunking3600_4,
		// Token: 0x04000C94 RID: 3220
		ScanItems_SP_DSGTXMEM_1 = 207200201,
		// Token: 0x04000C95 RID: 3221
		ScanItems_SP_DSGTXMEM_2,
		// Token: 0x04000C96 RID: 3222
		ScanItems_SP_DSGTXMEM_3,
		// Token: 0x04000C97 RID: 3223
		ScanItems_SP_PR2MEM_1 = 207200301,
		// Token: 0x04000C98 RID: 3224
		ScanItems_Valid_Record_1 = 207200401,
		// Token: 0x04000C99 RID: 3225
		ScanListItems_SP_CNVPERCOMP_1 = 207300101,
		// Token: 0x04000C9A RID: 3226
		ScanListItems_SP_CNVPERCOMP_2,
		// Token: 0x04000C9B RID: 3227
		ScanListItems_SP_CNVPERCOMP_3,
		// Token: 0x04000C9C RID: 3228
		Security_RC_PRVCYSVCTP_1 = 207400101,
		// Token: 0x04000C9D RID: 3229
		Security_RC_PRVCYSVCTP_2,
		// Token: 0x04000C9E RID: 3230
		Security_RC_OTARUKEK_HIDDEN_STRING_BUT_NOT_TEK = 207400201,
		// Token: 0x04000C9F RID: 3231
		Security_RC_OTARUKEK_DEFINED_BUT_NOT_TEK,
		// Token: 0x04000CA0 RID: 3232
		SignalingSystems_RC_EMERGENCYREVERTCHAN_1 = 207500101,
		// Token: 0x04000CA1 RID: 3233
		SignalingSystems_RC_EMERGENCYREVERTCHAN_2,
		// Token: 0x04000CA2 RID: 3234
		SignalingSystems_RC_EMERGENCYREVERTCHAN_3,
		// Token: 0x04000CA3 RID: 3235
		SignalingSystems_DSS_AUTHENTICATIONPASSPHRASE_1 = 207500201,
		// Token: 0x04000CA4 RID: 3236
		SitesListItems_Neighbor1_1 = 207800101,
		// Token: 0x04000CA5 RID: 3237
		SitesListItems_Neighbor1_2,
		// Token: 0x04000CA6 RID: 3238
		TalkgroupsListItems = 208200000,
		// Token: 0x04000CA7 RID: 3239
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_1 = 208200101,
		// Token: 0x04000CA8 RID: 3240
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_2,
		// Token: 0x04000CA9 RID: 3241
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_3,
		// Token: 0x04000CAA RID: 3242
		TalkgroupsListItems_WIFILISTDLL_PASSWORD_4,
		// Token: 0x04000CAB RID: 3243
		Telegrams_RC_POWERUPAUTOTELGRAM_1 = 208300101,
		// Token: 0x04000CAC RID: 3244
		Telegrams_RC_POWERUPAUTOTELGRAMREVERTCHAN_1 = 208300201,
		// Token: 0x04000CAD RID: 3245
		TelemetryListItems_TEL_IOCONFIG_1 = 208600101,
		// Token: 0x04000CAE RID: 3246
		TelemetryListItems_TEL_IOCONFIG_2,
		// Token: 0x04000CAF RID: 3247
		TelemetryListItems_TEL_IOCONFIG_3,
		// Token: 0x04000CB0 RID: 3248
		TelemetryListItems_TEL_OTTRPIT_1 = 208600201,
		// Token: 0x04000CB1 RID: 3249
		TelemetryListItems_TEL_OTTRPIT_2,
		// Token: 0x04000CB2 RID: 3250
		TelemetryListItems_TEL_OTTRPIT_3,
		// Token: 0x04000CB3 RID: 3251
		TelemetryListItems_TEL_OTTRPITZone_1,
		// Token: 0x04000CB4 RID: 3252
		TelemetryListItems_TEL_DUCLITEM_1 = 208600301,
		// Token: 0x04000CB5 RID: 3253
		TelemetryListItems_TEL_DUCLITEM_2,
		// Token: 0x04000CB6 RID: 3254
		TelemetryListItems_TEL_DUCLITEM_3,
		// Token: 0x04000CB7 RID: 3255
		TelemetryListItems_TEL_DUCLITEM_4,
		// Token: 0x04000CB8 RID: 3256
		TelemetryListItems_TEL_MODETYPE_1 = 208600401,
		// Token: 0x04000CB9 RID: 3257
		TelemetryListItems_TEL_TGTVIO_1 = 208600501,
		// Token: 0x04000CBA RID: 3258
		TelemetryListItems_TEL_TGTVIO_2,
		// Token: 0x04000CBB RID: 3259
		TextMessagesListItems_QTMSG_QCKTXTMSG_1 = 208700001,
		// Token: 0x04000CBC RID: 3260
		TextMessages_CTMSG_MESSAGEMAXSENTLENGTH_1 = 208700101,
		// Token: 0x04000CBD RID: 3261
		VoiceAnnouncement_TTS_1 = 209500001,
		// Token: 0x04000CBE RID: 3262
		Zone_Zone_1 = 209700101,
		// Token: 0x04000CBF RID: 3263
		Zone_Zone_2,
		// Token: 0x04000CC0 RID: 3264
		Zone_Zone_3,
		// Token: 0x04000CC1 RID: 3265
		Zone_Zone_4,
		// Token: 0x04000CC2 RID: 3266
		Zone_Zone_5,
		// Token: 0x04000CC3 RID: 3267
		Zone_Zone_6,
		// Token: 0x04000CC4 RID: 3268
		Zone_ZP_ZONEALIAS_1 = 209700201,
		// Token: 0x04000CC5 RID: 3269
		Zone_ZP_ZONEALIAS_2,
		// Token: 0x04000CC6 RID: 3270
		Zone_ZP_ZONEALIAS_3,
		// Token: 0x04000CC7 RID: 3271
		ZoneItems_ZoneItems_1 = 209800101,
		// Token: 0x04000CC8 RID: 3272
		ZoneItems_NotConventionalPersonality,
		// Token: 0x04000CC9 RID: 3273
		Radios_RadioIP_1 = 209900001,
		// Token: 0x04000CCA RID: 3274
		Radios_RadioIP_2,
		// Token: 0x04000CCB RID: 3275
		Radios_RC_RADIOALIAS_1 = 209900101,
		// Token: 0x04000CCC RID: 3276
		Radios_RC_RadioID_CAI_IP_Dep_1 = 209900201,
		// Token: 0x04000CCD RID: 3277
		WelcomeBitmap_WelcomeBitmapContent_1 = 210100101,
		// Token: 0x04000CCE RID: 3278
		JobTicketsTemplatesListItems = 210200000,
		// Token: 0x04000CCF RID: 3279
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_1 = 210200101,
		// Token: 0x04000CD0 RID: 3280
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_2,
		// Token: 0x04000CD1 RID: 3281
		JobTicketsTemplatesListItems_JTTDLL_ORIGINALTEXT_3,
		// Token: 0x04000CD2 RID: 3282
		JobTicketsTemplatesListItems_JTTDLL_ITEMTAG_1 = 210200201,
		// Token: 0x04000CD3 RID: 3283
		JobTicketsTemplatesListItems_JTTDLL_OPTIONLISTIT_1 = 210200301,
		// Token: 0x04000CD4 RID: 3284
		JobTicketsTemplates = 210300000,
		// Token: 0x04000CD5 RID: 3285
		JobTicketsTemplates_JTTDLH_TEMPLATETAG_1 = 210300101,
		// Token: 0x04000CD6 RID: 3286
		FlexibleDMR3RXGroupListItems = 210500000,
		// Token: 0x04000CD7 RID: 3287
		FlexibleDMR3RXGroupListItems_FLEXIBLEDMR3RXTGDLL_LEDITEM_1 = 210500101,
		// Token: 0x04000CD8 RID: 3288
		FlexibleDMR3RXGroupListItems_FLEXIBLEDMR3RXTGDLL_LEDITEM_2,
		// Token: 0x04000CD9 RID: 3289
		DMR3Channels = 210600000,
		// Token: 0x04000CDA RID: 3290
		DMR3Channels_Voice_1,
		// Token: 0x04000CDB RID: 3291
		DMR3Channels_Control_1,
		// Token: 0x04000CDC RID: 3292
		DMR3Channels_Revert_1,
		// Token: 0x04000CDD RID: 3293
		DMR3Channels_Invalid_1,
		// Token: 0x04000CDE RID: 3294
		DMR3Channels_ChannelName_1 = 210600101,
		// Token: 0x04000CDF RID: 3295
		DMR3Channels_ChannelName_2,
		// Token: 0x04000CE0 RID: 3296
		DMR3Channels_ChannelName_3,
		// Token: 0x04000CE1 RID: 3297
		DMR3Channels_ChannelID_1 = 210600301,
		// Token: 0x04000CE2 RID: 3298
		DMR3Channels_ChannelID_2,
		// Token: 0x04000CE3 RID: 3299
		DMR3Channels_ChannelID_3,
		// Token: 0x04000CE4 RID: 3300
		DMR3Channels_Type_1 = 210600401,
		// Token: 0x04000CE5 RID: 3301
		DMR3Systems = 210700000,
		// Token: 0x04000CE6 RID: 3302
		DMR3Systems_NetworkID_5 = 210700105,
		// Token: 0x04000CE7 RID: 3303
		DMR3Systems_DMR3SYS_DMRLA_1 = 210700301,
		// Token: 0x04000CE8 RID: 3304
		DMR3Systems_DMR3SYS_DMRLA_2,
		// Token: 0x04000CE9 RID: 3305
		DMR3Systems_DMR3SYS_DMRLA_3,
		// Token: 0x04000CEA RID: 3306
		DMR3Systems_DMR3SYS_DMRLA_4,
		// Token: 0x04000CEB RID: 3307
		DMR3Systems_FixedChannelPlan_1 = 210700401,
		// Token: 0x04000CEC RID: 3308
		DMR3Systems_MasterKey_1 = 210700501,
		// Token: 0x04000CED RID: 3309
		DMR3Systems_ControllerIP_1 = 210700701,
		// Token: 0x04000CEE RID: 3310
		DMR3Systems_Recset_Valid = 210700801,
		// Token: 0x04000CEF RID: 3311
		DMR3Sites = 210800000,
		// Token: 0x04000CF0 RID: 3312
		DMR3Sites_Invalid_1,
		// Token: 0x04000CF1 RID: 3313
		DMR3Sites_Invalid_2,
		// Token: 0x04000CF2 RID: 3314
		DMR3Sites_Invalid_3,
		// Token: 0x04000CF3 RID: 3315
		DMR3Sites_SiteName_1 = 210800101,
		// Token: 0x04000CF4 RID: 3316
		DMR3Sites_SiteName_2,
		// Token: 0x04000CF5 RID: 3317
		DMR3Sites_SiteName_3,
		// Token: 0x04000CF6 RID: 3318
		DMR3Sites_SiteID_1 = 210800201,
		// Token: 0x04000CF7 RID: 3319
		DMR3Sites_SiteID_2,
		// Token: 0x04000CF8 RID: 3320
		DMR3Sites_SiteID_3,
		// Token: 0x04000CF9 RID: 3321
		DMR3Sites_SiteID_4,
		// Token: 0x04000CFA RID: 3322
		DMR3Sites_SiteID_5,
		// Token: 0x04000CFB RID: 3323
		DMR3Sites_ChannPlan_1 = 210800401,
		// Token: 0x04000CFC RID: 3324
		DMR3Sites_ChannPlan_2,
		// Token: 0x04000CFD RID: 3325
		DMR3Sites_BaseIP_OutMaxRang,
		// Token: 0x04000CFE RID: 3326
		DMR3EmergencySystems = 211000000,
		// Token: 0x04000CFF RID: 3327
		DMR3EmergencySystems_Call_1 = 211000101,
		// Token: 0x04000D00 RID: 3328
		DMR3EmergencySystems_Call_2,
		// Token: 0x04000D01 RID: 3329
		LinkEstablishment = 211100000,
		// Token: 0x04000D02 RID: 3330
		LinkEstablishment_MTST_REPEATERTYPE_1 = 211100101,
		// Token: 0x04000D03 RID: 3331
		LinkEstablishment_MTST_REPEATERTYPE_2,
		// Token: 0x04000D04 RID: 3332
		AdjacentSites = 211200000,
		// Token: 0x04000D05 RID: 3333
		AdjacentSite_Site_Set_Self_1 = 211200101,
		// Token: 0x04000D06 RID: 3334
		AdjacentSite_Site_Duplicated_1,
		// Token: 0x04000D07 RID: 3335
		AdjacentSite_Site_Overflow_1,
		// Token: 0x04000D08 RID: 3336
		AdjacentSite_Site_Set_Invalid_4,
		// Token: 0x04000D09 RID: 3337
		MNISSystem_MNISSYS_ENHANCED_PRIVACY_KEY_Invalid1 = 211300201,
		// Token: 0x04000D0A RID: 3338
		MNISSites = 211400000,
		// Token: 0x04000D0B RID: 3339
		MNISSites_MNISSITE_SITE_1 = 211400101,
		// Token: 0x04000D0C RID: 3340
		TGSASites = 211500000,
		// Token: 0x04000D0D RID: 3341
		MNISSitesList = 211600000,
		// Token: 0x04000D0E RID: 3342
		MNISSitesList_DMR3SYSTEM_1 = 211600101,
		// Token: 0x04000D0F RID: 3343
		MNISForwardingRules = 211700000,
		// Token: 0x04000D10 RID: 3344
		MNISForwardingRules_MNISFWDR_UDP_PORT_1 = 211700101,
		// Token: 0x04000D11 RID: 3345
		MNISForwardingRules_Record_1 = 211700201,
		// Token: 0x04000D12 RID: 3346
		MNISAppOverrideRules = 211800000,
		// Token: 0x04000D13 RID: 3347
		MNISAppOverrideRules_MNISAOR_UDP_PORT_1 = 211800101,
		// Token: 0x04000D14 RID: 3348
		OTARKeys_OPC_OTARACTIVETEKKID_AboveMax = 211900100,
		// Token: 0x04000D15 RID: 3349
		OTARKeys_OPC_OTARACTIVETEKKID_BelowMin,
		// Token: 0x04000D16 RID: 3350
		OTARKeys_OPC_OTARACTIVETEKKID_HiddenString,
		// Token: 0x04000D17 RID: 3351
		HomeChannel_RC_HOMECHANNELIT_ChannelInvalid = 212000100,
		// Token: 0x04000D18 RID: 3352
		HomeChannel_RC_HOMECHANNELIT_ChannelNotDigital,
		// Token: 0x04000D19 RID: 3353
		HomeChannel_RC_HOMECHANNELIT_InvalidChannelFields,
		// Token: 0x04000D1A RID: 3354
		MNISNetwork_MNISNW_BM_UDP_PORT_ID_Valid = 212100100,
		// Token: 0x04000D1B RID: 3355
		MNISNetwork_MNISNW_LRRP_SERVER_PORT_Valid = 212100200,
		// Token: 0x04000D1C RID: 3356
		Indoor_Location_Anchor_UUID_Length_Error = 212200100,
		// Token: 0x04000D1D RID: 3357
		SiteAnnouncement_Valid_1 = 212300000,
		// Token: 0x04000D1E RID: 3358
		SiteAnnouncement_Valid_2,
		// Token: 0x04000D1F RID: 3359
		SiteAnnouncement_SA_SITEID_Valid_1 = 212300101,
		// Token: 0x04000D20 RID: 3360
		SiteAnnouncement_SA_SITEID_Valid_2,
		// Token: 0x04000D21 RID: 3361
		Hostname_DNSAddressHostname_Invalid = 212500001,
		// Token: 0x04000D22 RID: 3362
		DMR3StatusMessageListItems_DMR3SMLDLL_DMR3STATUSALIAS_1 = 212600101,
		// Token: 0x04000D23 RID: 3363
		DMR3AuthDataList_DMR3SAC_DOMAIN_ID_1 = 212700101,
		// Token: 0x04000D24 RID: 3364
		PBBWiFiSSID_1 = 300000000,
		// Token: 0x04000D25 RID: 3365
		PBBWiFiSSID_2,
		// Token: 0x04000D26 RID: 3366
		PBBWiFiSSID_3,
		// Token: 0x04000D27 RID: 3367
		PBBWiFiSSID_4,
		// Token: 0x04000D28 RID: 3368
		PBBWiFiEncryption_1,
		// Token: 0x04000D29 RID: 3369
		PBBWiFiEncryption_2,
		// Token: 0x04000D2A RID: 3370
		PBBWiFiEncryption_3,
		// Token: 0x04000D2B RID: 3371
		Si500IsMandatory,
		// Token: 0x04000D2C RID: 3372
		WhiteList_Already_Exists,
		// Token: 0x04000D2D RID: 3373
		PBBWhiteListFields_Invalid,
		// Token: 0x04000D2E RID: 3374
		ID_FusionConfiguration_Audio_Recording_Is_Inapplicable = 300010001,
		// Token: 0x04000D2F RID: 3375
		ID_FusionConfiguration_Covert_Mode_Is_Inapplicable,
		// Token: 0x04000D30 RID: 3376
		ID_FusionConfiguration_Photo_Capture_Is_Inapplicable,
		// Token: 0x04000D31 RID: 3377
		ID_FusionConfiguration_PairedRadioConnectionTypeSelectable_Is_InValid,
		// Token: 0x04000D32 RID: 3378
		ID_FusionConfiguration_Wired_Is_Inapplicable,
		// Token: 0x04000D33 RID: 3379
		ID_FusionConfiguration_Bluetooth_Is_Inapplicable,
		// Token: 0x04000D34 RID: 3380
		ID_FusionConfiguration_Standalone_Is_Inapplicable,
		// Token: 0x04000D35 RID: 3381
		CommonTypeIIFNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_1,
		// Token: 0x04000D36 RID: 3382
		CommonTypeIIFNEControlChannel_TrkSysControlChannelsTxFrequencyMHz_A9535_2,
		// Token: 0x04000D37 RID: 3383
		CommonTypeIITrunkingOneTouch_FeatureNotEnabled = 600100200,
		// Token: 0x04000D38 RID: 3384
		CommonTypeIITrunkingOneTouch_IndexOutofRange,
		// Token: 0x04000D39 RID: 3385
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_1 = 600200101,
		// Token: 0x04000D3A RID: 3386
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_2,
		// Token: 0x04000D3B RID: 3387
		CommonTypeIITrunkingSystem_TrkSysFeaturesChannel_A7647_3,
		// Token: 0x04000D3C RID: 3388
		CommonTypeIITrunkingSystem_TrkSysSiteAliasSiteAliasEnable_A9148_1 = 600200201,
		// Token: 0x04000D3D RID: 3389
		CommonTypeIITrunkingSystem_TrkSysFeaturesZone_A9717_1 = 600200301,
		// Token: 0x04000D3E RID: 3390
		CommonTypeIITrunkingSystem_TrkSysFeaturesZone_A9717_2,
		// Token: 0x04000D3F RID: 3391
		CommonTypeIITrunkingSystem_TrkSysFeaturesHearClear_A36422_1 = 600200401,
		// Token: 0x04000D40 RID: 3392
		CommonTypeIITrunkingSystem_TrkSysFeaturesRadioInhibit_A8833_1 = 600200501,
		// Token: 0x04000D41 RID: 3393
		TrunkingSystemTalkgroupIsEmpty = 600200601,
		// Token: 0x04000D42 RID: 3394
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralSystemID_A9239_1 = 600300101,
		// Token: 0x04000D43 RID: 3395
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_1,
		// Token: 0x04000D44 RID: 3396
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_2,
		// Token: 0x04000D45 RID: 3397
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_3,
		// Token: 0x04000D46 RID: 3398
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_4,
		// Token: 0x04000D47 RID: 3399
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_5,
		// Token: 0x04000D48 RID: 3400
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralTypeIIFrequencyBand_A12491_6,
		// Token: 0x04000D49 RID: 3401
		CommonTypeIIFixedNetworkEquipment_TrkSysGeneralUnitID_A12651_1,
		// Token: 0x04000D4A RID: 3402
		CommonTypeIIFixedNetworkEquipment_ChannelBandwidthkHz,
		// Token: 0x04000D4B RID: 3403
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_1 = 600300201,
		// Token: 0x04000D4C RID: 3404
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_2,
		// Token: 0x04000D4D RID: 3405
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_1 = 600300301,
		// Token: 0x04000D4E RID: 3406
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_2,
		// Token: 0x04000D4F RID: 3407
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_1 = 600300401,
		// Token: 0x04000D50 RID: 3408
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_2,
		// Token: 0x04000D51 RID: 3409
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_1 = 600300501,
		// Token: 0x04000D52 RID: 3410
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_2,
		// Token: 0x04000D53 RID: 3411
		CommonTypeIIFixedNetworkEquipment_TrkPerTalkgroupSecureClearStrapping_A9095_1 = 600300601,
		// Token: 0x04000D54 RID: 3412
		CommonTypeIITrkPreferredSite_TrkPerPreferredSitesSiteID_A9151_1 = 600400101,
		// Token: 0x04000D55 RID: 3413
		CommonTypeIITrkPreferredSite_TrkPerPreferredSitesSystemID_A19466_1 = 600400201,
		// Token: 0x04000D56 RID: 3414
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryRxFrequencyMHz_A8904_1 = 600500101,
		// Token: 0x04000D57 RID: 3415
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryRxFrequencyMHz_A8904_2,
		// Token: 0x04000D58 RID: 3416
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryTxFrequencyMHz_A12902_1 = 600500201,
		// Token: 0x04000D59 RID: 3417
		CommonTypeIITrunkingPersonality_TrkPerGeneralSecondaryTxFrequencyMHz_A12902_2,
		// Token: 0x04000D5A RID: 3418
		CommonTypeIITrunkingPersonality_TrkPerGeneralTxFrequencyMHz_A9413_1 = 600500301,
		// Token: 0x04000D5B RID: 3419
		CommonTypeIITrunkingPersonality_TrkPerGeneralTxFrequencyMHz_A9413_2,
		// Token: 0x04000D5C RID: 3420
		CommonTypeIITrunkingPersonality_TrkEmerProfGeneralTalkgroup_A8969_1 = 600500401,
		// Token: 0x04000D5D RID: 3421
		CommonTypeIITrunkingPersonality_TrkEmerProfGeneralSecureClearStrapping_A9092_1 = 600500501,
		// Token: 0x04000D5E RID: 3422
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertZone_A41916_1 = 600500601,
		// Token: 0x04000D5F RID: 3423
		CommonTypeIITrunkingPersonality_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_1 = 600500701,
		// Token: 0x04000D60 RID: 3424
		CommonTypeIITrunkingPersonality_TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_2,
		// Token: 0x04000D61 RID: 3425
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_1 = 600500801,
		// Token: 0x04000D62 RID: 3426
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_2,
		// Token: 0x04000D63 RID: 3427
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_3,
		// Token: 0x04000D64 RID: 3428
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_4,
		// Token: 0x04000D65 RID: 3429
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_5,
		// Token: 0x04000D66 RID: 3430
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_6,
		// Token: 0x04000D67 RID: 3431
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_7,
		// Token: 0x04000D68 RID: 3432
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_8,
		// Token: 0x04000D69 RID: 3433
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_9,
		// Token: 0x04000D6A RID: 3434
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_10,
		// Token: 0x04000D6B RID: 3435
		CommonTypeIITrunkingPersonality_TrkPerGeneralRevertChannel_A41917_11,
		// Token: 0x04000D6C RID: 3436
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_1 = 600500901,
		// Token: 0x04000D6D RID: 3437
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_2,
		// Token: 0x04000D6E RID: 3438
		CommonTypeIITrunkingPersonality_TrkPerGeneralRxFrequencyMHz_A8910_1 = 600501001,
		// Token: 0x04000D6F RID: 3439
		CommonTypeIITrunkingPersonality_TrkPerGeneralRxFrequencyMHz_A8910_2,
		// Token: 0x04000D70 RID: 3440
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_1 = 600501101,
		// Token: 0x04000D71 RID: 3441
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_2,
		// Token: 0x04000D72 RID: 3442
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_1 = 600501201,
		// Token: 0x04000D73 RID: 3443
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_2,
		// Token: 0x04000D74 RID: 3444
		CommonTypeIITrunkingPersonality_TrkPerCallPageCallAlertPageOperation_A7597_1 = 600501301,
		// Token: 0x04000D75 RID: 3445
		CommonTypeIITrunkingPersonality_TrkPerCallPagePrivateCallOperation_A8759_1 = 600501401,
		// Token: 0x04000D76 RID: 3446
		CommonTypeIITrunkingPersonality_TrkPerFeaturesScanListSelection_A9053_1 = 600501501,
		// Token: 0x04000D77 RID: 3447
		CommonTypeIITrunkingPersonality_TrkPerFeaturesScanListSelection_A9053_2,
		// Token: 0x04000D78 RID: 3448
		CommonTypeIITrunkingPersonality_TrkPerFeaturesStatusEnable_A9188_1 = 600501601,
		// Token: 0x04000D79 RID: 3449
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAnnouncementGroup_A7444_1 = 600501701,
		// Token: 0x04000D7A RID: 3450
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAnnouncementGroup_A7444_2,
		// Token: 0x04000D7B RID: 3451
		CommonTypeIITrunkingPersonality_TrkPerTalkgroupTalkgroup_A9274_1 = 600501801,
		// Token: 0x04000D7C RID: 3452
		CommonTypeIITrunkingPersonality_TrkPerTalkgroupTalkgroup_A9274_2,
		// Token: 0x04000D7D RID: 3453
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_1 = 600501901,
		// Token: 0x04000D7E RID: 3454
		CommonTypeIITrunkingPersonality_TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_2,
		// Token: 0x04000D7F RID: 3455
		CommonTypeIITrunkingPersonality_TrkPerGeneralTimeOutTimersec_A9379_1 = 600502001,
		// Token: 0x04000D80 RID: 3456
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_1 = 600600101,
		// Token: 0x04000D81 RID: 3457
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_2,
		// Token: 0x04000D82 RID: 3458
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_3,
		// Token: 0x04000D83 RID: 3459
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_4,
		// Token: 0x04000D84 RID: 3460
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_5,
		// Token: 0x04000D85 RID: 3461
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_6,
		// Token: 0x04000D86 RID: 3462
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_1 = 600600201,
		// Token: 0x04000D87 RID: 3463
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_2,
		// Token: 0x04000D88 RID: 3464
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_3,
		// Token: 0x04000D89 RID: 3465
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_1 = 600600301,
		// Token: 0x04000D8A RID: 3466
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_2,
		// Token: 0x04000D8B RID: 3467
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_1 = 600600401,
		// Token: 0x04000D8C RID: 3468
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_2,
		// Token: 0x04000D8D RID: 3469
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEnable_A9001_1 = 600600501,
		// Token: 0x04000D8E RID: 3470
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListRxEnable_A9001_2,
		// Token: 0x04000D8F RID: 3471
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEnable_A9517_1 = 600600601,
		// Token: 0x04000D90 RID: 3472
		CommonTypeIIFNEOBTChanAssign_TrkSysOBTChannelAssignmentListTxEnable_A9517_2,
		// Token: 0x04000D91 RID: 3473
		CommonTypeIIFNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_1 = 600800101,
		// Token: 0x04000D92 RID: 3474
		CommonTypeIIFNEStatusAlias_TrkSysStatusAliasStatusAliasNumber_A9190_2,
		// Token: 0x04000D93 RID: 3475
		CommonTypeIIFNEMessageAlias_TrkSysMessageAliasMessageAliasNumber_A8500_1 = 600900101,
		// Token: 0x04000D94 RID: 3476
		CommonTypeIITrunkingTalkgroup_TrkPerTalkgroup_42163_1 = 601000101,
		// Token: 0x04000D95 RID: 3477
		CommonTypeIITrunkingTalkgroup_TrkPerTalkgroupTxVoiceSignalType_A9575_1 = 601000201,
		// Token: 0x04000D96 RID: 3478
		BLLCore_General = 700100000,
		// Token: 0x04000D97 RID: 3479
		BLCoreElement_RecSet_MandantorySetIsZero = 700100100,
		// Token: 0x04000D98 RID: 3480
		BLCoreElement_RecSet_TotalNumOutOfRangeBySharedSet,
		// Token: 0x04000D99 RID: 3481
		BLCoreElement_RecSet_TotalNumOutOfRangeByEmWeakTypePool,
		// Token: 0x04000D9A RID: 3482
		BLCoreElement_RecSet_TotalNumOutOfRangeByEmMaxpoolNum,
		// Token: 0x04000D9B RID: 3483
		BLCoreElement_RecSet_TotalNumOutOfMaxLimitation,
		// Token: 0x04000D9C RID: 3484
		BLCoreElement_RecSet_TotalNumOutOfMinLimitation,
		// Token: 0x04000D9D RID: 3485
		BLLCoreElement_Record_InvalidType = 700100200,
		// Token: 0x04000D9E RID: 3486
		BLLCoreElement_NumericField_ValueOutOfRange = 700100300,
		// Token: 0x04000D9F RID: 3487
		BLLCoreElement_NumericField_ValueOutOfRange_Rollback,
		// Token: 0x04000DA0 RID: 3488
		BLLCoreElement_ListField_ValueOutOfRange = 700100400,
		// Token: 0x04000DA1 RID: 3489
		BLLCoreElement_ListField_ValueOutTiredOut,
		// Token: 0x04000DA2 RID: 3490
		BLLCoreElement_ListField_RangeSectionMissed,
		// Token: 0x04000DA3 RID: 3491
		BLLCoreElement_StringField_ValueOutOfRange = 700100500,
		// Token: 0x04000DA4 RID: 3492
		BLLCoreElement_StringField_KeyFieldValueIsNullOrEmpty,
		// Token: 0x04000DA5 RID: 3493
		BLLCoreElement_StringField_KeyFieldValueIsNullOrEmptyOrWhiteSpace_Rollback,
		// Token: 0x04000DA6 RID: 3494
		BLLCoreElement_StringField_SetNameDuplicate_Rollback,
		// Token: 0x04000DA7 RID: 3495
		BLLCoreElement_ReferField_ValueIsNull = 700100600,
		// Token: 0x04000DA8 RID: 3496
		BLLCoreElement_ReferField_AviReferSetIsNull,
		// Token: 0x04000DA9 RID: 3497
		BLLCoreElement_ReferField_CurSetTypeError,
		// Token: 0x04000DAA RID: 3498
		BLLCoreElement_ReferField_ReferRecSetNotAvailable,
		// Token: 0x04000DAB RID: 3499
		BLLCoreElement_ReferField_ReferRecordNotLoad,
		// Token: 0x04000DAC RID: 3500
		BLLCoreElement_ReferField_ReferRecordNotInMasterSelectRecord,
		// Token: 0x04000DAD RID: 3501
		BLLCoreElement_ReferField_ReferRecordNotAvailableFromMasterField,
		// Token: 0x04000DAE RID: 3502
		BLLCoreElement_ReferField_ReferRecordTieredOut,
		// Token: 0x04000DAF RID: 3503
		BLLCoreElement_ReferField_PrependValueOutTieredOut,
		// Token: 0x04000DB0 RID: 3504
		BLLCoreElement_Field_KeyFieldValueDuplicate = 700101000,
		// Token: 0x04000DB1 RID: 3505
		BLLCoreElement_Field_KeyFieldValueIsEmpty,
		// Token: 0x04000DB2 RID: 3506
		BLLCoreElement_Field_TiredOutField_ModelVersionSensitive = 700101100,
		// Token: 0x04000DB3 RID: 3507
		BLLCoreElement_Field_TiredOutField_ProductFamilyTiredOut,
		// Token: 0x04000DB4 RID: 3508
		SpellCheck_General = 700600000,
		// Token: 0x04000DB5 RID: 3509
		SpellCheck_Packing_Fixup_Error,
		// Token: 0x04000DB6 RID: 3510
		SpellCheck_Unpacking_Fixup_Error,
		// Token: 0x04000DB7 RID: 3511
		SpellCheck_Compile_Valition_Failed
	}
}
