using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000020 RID: 32
	public interface IMemoryUnit
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D4 RID: 212
		string Address { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D5 RID: 213
		uint Size { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D6 RID: 214
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
		byte[] Data { get; }

		// Token: 0x060000D7 RID: 215
		void ChargeUnit(string address, byte[] data, byte stuff, uint alignment);

		// Token: 0x060000D8 RID: 216
		void ChargeUnit(string address, byte[] data);

		// Token: 0x060000D9 RID: 217
		bool IsOverlaped(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit otherUnit);

		// Token: 0x060000DA RID: 218
		global::Motorola.Common.Communication.CommonUtil.IMemoryUnit Clone();

		// Token: 0x060000DB RID: 219
		bool GetData(uint addr, uint size, out byte[] buffer);
	}
}
