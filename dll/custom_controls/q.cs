using System;
using System.Collections;
using System.Windows.Forms.Design;

namespace custom_controls
{
	// Token: 0x02000099 RID: 153
	internal class q : global::System.Windows.Forms.Design.ControlDesigner
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x0005D620 File Offset: 0x0005B820
		protected override void PostFilterProperties(global::System.Collections.IDictionary Properties)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			Properties.Remove("AllowDrop");
			Properties.Remove("BackgroundImage");
			Properties.Remove("ContextMenu");
			Properties.Remove("FlatStyle");
			Properties.Remove("Image");
			Properties.Remove("ImageAlign");
			Properties.Remove("ImageIndex");
			Properties.Remove("ImageList");
			Properties.Remove("Text");
			Properties.Remove("TextAlign");
			Properties.Remove("BackColor");
			Properties.Remove("Font");
			Properties.Remove("ForeColor");
			Properties.Remove("Cursor");
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0005D6F8 File Offset: 0x0005B8F8
		protected override void PostFilterEvents(global::System.Collections.IDictionary events)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			events.Remove("Click");
			events.Remove("DoubleClick");
			events.Remove("Paint");
			events.Remove("ChangeUICues");
			events.Remove("ImeModeChanged");
			events.Remove("QueryAccessibilityHelp");
			events.Remove("StyleChanged");
			events.Remove("SystemColorsChanged");
			events.Remove("DragDrop");
			events.Remove("DragEnter");
			events.Remove("DragLeave");
			events.Remove("DragOver");
			events.Remove("GiveFeedback");
			events.Remove("QueryContinueDrag");
			events.Remove("DragDrop");
			events.Remove("Layout");
			events.Remove("Move");
			events.Remove("Resize");
			events.Remove("BackColorChanged");
			events.Remove("BackgroundImageChanged");
			events.Remove("BindingContextChanged");
			events.Remove("CausesValidationChanged");
			events.Remove("CursorChanged");
			events.Remove("FontChanged");
			events.Remove("ForeColorChanged");
			events.Remove("RightToLeftChanged");
			events.Remove("SizeChanged");
			events.Remove("TextChanged");
			base.PostFilterEvents(events);
		}
	}
}
