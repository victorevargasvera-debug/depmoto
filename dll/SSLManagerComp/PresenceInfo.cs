using System;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x0200003C RID: 60
	public sealed class PresenceInfo
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000192 RID: 402 RVA: 0x00007DB8 File Offset: 0x00005FB8
		// (remove) Token: 0x06000193 RID: 403 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public event global::SSLMangrComp.PresenceInfo_CallBack PresenceCallBack;

		// Token: 0x06000194 RID: 404 RVA: 0x00007E25 File Offset: 0x00006025
		public PresenceInfo()
		{
			this.PresenceCallBack += this.CallPresenceInfoCallback;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00007E3F File Offset: 0x0000603F
		public static global::SSLMangrComp.PresenceInfo Instance
		{
			get
			{
				return global::SSLMangrComp.PresenceInfo.PIInstance;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007E46 File Offset: 0x00006046
		public void SendPresenceInfo(global::SSLMangrComp.PresenceInfo_CallBack Cb)
		{
			new global::SSLMangrComp.PresenceNotification();
			if (Cb != null)
			{
				this.PNcb = Cb;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007E58 File Offset: 0x00006058
		public void ResetPresenceNotification()
		{
			global::SSLMangrComp.PresenceNotification presenceNotification = new global::SSLMangrComp.PresenceNotification();
			presenceNotification.DeviceId = string.Empty;
			presenceNotification.EntityType = string.Empty;
			presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
			presenceNotification.IPAddr = string.Empty;
			presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
			presenceNotification.SubscriptionState = string.Empty;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007EA8 File Offset: 0x000060A8
		public global::SSLMangrComp.PresenceNotification SendPresenceNotification(global::SSLMangrComp.Packets.PacketBase packet)
		{
			global::SSLMangrComp.PresenceNotification presenceNotification = new global::SSLMangrComp.PresenceNotification();
			if (packet != null)
			{
				string[,] allParameters = packet.GetAllParameters();
				for (int i = 0; i < allParameters.Length / 2; i++)
				{
					string a;
					if ((a = allParameters[i, 0]) != null)
					{
						if (!(a == "Subscription State"))
						{
							if (!(a == "Entity Type"))
							{
								if (!(a == "Entity"))
								{
									if (!(a == "Attribute(IPv4)"))
									{
										if (!(a == "Event"))
										{
											if (a == "Attribute(Presence)")
											{
												if (allParameters[i, 1] == "0")
												{
													presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
												}
												else if (allParameters[i, 1] == "1")
												{
													presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Present;
												}
												else
												{
													presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Absent;
												}
											}
										}
										else if (allParameters[i, 1] == "Ack")
										{
											presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Ack;
										}
										else if (allParameters[i, 1] == "Presence")
										{
											presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Presence;
										}
										else
										{
											presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Absence;
										}
									}
									else
									{
										presenceNotification.IPAddr = allParameters[i, 1];
									}
								}
								else
								{
									presenceNotification.DeviceId = allParameters[i, 1];
								}
							}
							else
							{
								presenceNotification.EntityType = allParameters[i, 1];
							}
						}
						else
						{
							presenceNotification.SubscriptionState = allParameters[i, 1];
						}
					}
				}
			}
			return presenceNotification;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008017 File Offset: 0x00006217
		public void CallPresenceInfoCallback(ref global::SSLMangrComp.PresenceNotification Pn)
		{
			if (this.PNcb != null)
			{
				this.PNcb(ref Pn);
			}
		}

		// Token: 0x0400011B RID: 283
		private static readonly global::SSLMangrComp.PresenceInfo PIInstance = new global::SSLMangrComp.PresenceInfo();

		// Token: 0x0400011C RID: 284
		private global::SSLMangrComp.PresenceInfo_CallBack PNcb;
	}
}
