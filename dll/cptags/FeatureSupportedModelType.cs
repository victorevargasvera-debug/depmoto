using System;

namespace constants
{
	// Token: 0x02000008 RID: 8
	[global::System.Flags]
	public enum FeatureSupportedModelType : long
	{
		// Token: 0x0400197D RID: 6525
		None = 0L,
		// Token: 0x0400197E RID: 6526
		MatrixSubscriber = 1L,
		// Token: 0x0400197F RID: 6527
		ParadiseSubscriberNormal = 2L,
		// Token: 0x04001980 RID: 6528
		ParadisePA = 4L,
		// Token: 0x04001981 RID: 6529
		ParadisePL = 8L,
		// Token: 0x04001982 RID: 6530
		ParadiseSubscriber = 14L,
		// Token: 0x04001983 RID: 6531
		AllSubscriber = 15L,
		// Token: 0x04001984 RID: 6532
		MatrixRepeater = 16L,
		// Token: 0x04001985 RID: 6533
		BanditRepeater = 32L,
		// Token: 0x04001986 RID: 6534
		AllRepeater = 48L,
		// Token: 0x04001987 RID: 6535
		AllModels = 4294967295L
	}
}
