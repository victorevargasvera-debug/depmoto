using System;
using System.Windows.Forms;
using CommunicationController;
using constants;
using Controller;
using cpservices;
using custom_controls;
using custom_exception;
using DeviceUpdate;
using LdapAuthenticationInterfaceController;
using RegistryAccess;
using resource_handler;
using xml_handler;

namespace mototrbodepottool
{
	// Token: 0x02000007 RID: 7
	public class d
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000452C File Offset: 0x0000352C
		public static void a()
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
			global::custom_controls.DotfDetection.custom_controls_Detect();
			global::xml_handler.DotfDetection.xml_handler_Detect();
			global::Controller.DotfDetection.Controller_Detect();
			global::RegistryAccess.DotfDetection.RegistryAccess_Detect();
			global::cpservices.DotfDetection.cpservices_Detect();
			global::CommunicationController.DotfDetection.CommunicationController_Detect();
			global::constants.DotfDetection.constants_Detect();
			global::custom_exception.DotfDetection.custom_exception_Detect();
			global::DeviceUpdate.b.a();
			global::resource_handler.DotfDetection.resource_handler_Detect();
			global::LdapAuthenticationInterfaceController.DotfDetection.LdapAuthenticationInterfaceController_Detect();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000045A0 File Offset: 0x000035A0
		public static void a(bool A_0)
		{
			for (;;)
			{
				if (A_0)
				{
					try
					{
						for (;;)
						{
							global::System.Windows.Forms.MessageBox.Show("Some files are corrupted. Please un-install and re-install the application.", "Depottool", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
							int num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									global::System.Windows.Forms.Application.Exit();
									num = 3;
									continue;
								case 1:
									goto IL_68;
								case 2:
									if (global::System.Windows.Forms.Application.MessageLoop)
									{
										num = 0;
										continue;
									}
									goto IL_60;
								case 3:
									if (true)
									{
									}
									goto IL_60;
								}
								break;
								IL_60:
								num = 1;
							}
						}
						IL_68:;
					}
					finally
					{
						global::System.Environment.Exit(1);
					}
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			IL_87:
			if (false)
			{
			}
		}
	}
}
