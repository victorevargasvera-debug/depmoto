using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000008 RID: 8
	public class ContentSyncer<T>
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000410D File Offset: 0x0000230D
		public ContentSyncer(global::Motorola.Common.Communication.IshHandler.IContentHelper<T> helper)
		{
			if (helper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.contentHelper = helper;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004128 File Offset: 0x00002328
		public void Excute(global::System.Collections.Generic.IList<T> sourceContent, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			if (sourceContent == null)
			{
				return;
			}
			try
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(0.0);
				}
				global::System.Collections.Generic.IList<T> targetContent = this.contentHelper.ListCurrent();
				double num = 1.0;
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(0.1);
					num -= 0.1;
				}
				global::System.Collections.Generic.IList<T> list;
				global::System.Collections.Generic.IList<T> list2;
				this.CompareContent(sourceContent, targetContent, out list, out list2);
				if (list.Count != 0 || list2.Count != 0)
				{
					this.contentHelper.PreSync();
					double num2 = (list.Count == 0) ? 0.1 : (0.1 / (double)list.Count);
					foreach (T content in list)
					{
						this.contentHelper.Delete(content);
						if (progressIndicator != null)
						{
							progressIndicator.IncreaseProcess(num2);
							num -= num2;
						}
					}
					num2 = ((list2.Count == 0) ? num : (num / (double)list2.Count));
					foreach (T content2 in list2)
					{
						this.contentHelper.Write(content2, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, num2));
					}
				}
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000042D0 File Offset: 0x000024D0
		private void CompareContent(global::System.Collections.Generic.IList<T> sourceContent, global::System.Collections.Generic.IList<T> targetContent, out global::System.Collections.Generic.IList<T> toDelContent, out global::System.Collections.Generic.IList<T> toWriteContent)
		{
			if (targetContent == null)
			{
				toDelContent = new global::System.Collections.Generic.List<T>();
				toWriteContent = sourceContent;
				return;
			}
			if (this.contentHelper.DeleteComparer == null)
			{
				toDelContent = targetContent.Except(sourceContent).ToList<T>();
			}
			else
			{
				toDelContent = targetContent.Except(sourceContent, this.contentHelper.DeleteComparer).ToList<T>();
			}
			if (this.contentHelper.WriteComparer == null)
			{
				toWriteContent = sourceContent.Except(targetContent).ToList<T>();
				return;
			}
			toWriteContent = sourceContent.Except(targetContent, this.contentHelper.WriteComparer).ToList<T>();
		}

		// Token: 0x0400000B RID: 11
		private global::Motorola.Common.Communication.IshHandler.IContentHelper<T> contentHelper;
	}
}
