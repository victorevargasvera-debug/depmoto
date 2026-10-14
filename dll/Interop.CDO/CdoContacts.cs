using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000020 RID: 32
	public abstract class CdoContacts
	{
		// Token: 0x04000133 RID: 307
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoAccount = "urn:schemas:contacts:account";

		// Token: 0x04000134 RID: 308
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoBirthday = "urn:schemas:contacts:bday";

		// Token: 0x04000135 RID: 309
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCallbackPhone = "urn:schemas:contacts:callbackphone";

		// Token: 0x04000136 RID: 310
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoChildrensNames = "urn:schemas:contacts:childrensnames";

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCommonName = "urn:schemas:contacts:cn";

		// Token: 0x04000138 RID: 312
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoComputerNetworkName = "urn:schemas:contacts:computernetworkname";

		// Token: 0x04000139 RID: 313
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoCustomerId = "urn:schemas:contacts:customerid";

		// Token: 0x0400013A RID: 314
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDepartment = "urn:schemas:contacts:department";

		// Token: 0x0400013B RID: 315
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoDistinguishedName = "urn:schemas:contacts:dn";

		// Token: 0x0400013C RID: 316
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoEmail1Address = "urn:schemas:contacts:email1";

		// Token: 0x0400013D RID: 317
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoEmail2Address = "urn:schemas:contacts:email2";

		// Token: 0x0400013E RID: 318
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoEmail3Address = "urn:schemas:contacts:email3";

		// Token: 0x0400013F RID: 319
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoEmployeeNumber = "urn:schemas:contacts:employeenumber";

		// Token: 0x04000140 RID: 320
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFileAs = "urn:schemas:contacts:fileas";

		// Token: 0x04000141 RID: 321
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFileAsId = "urn:schemas:contacts:fileasid";

		// Token: 0x04000142 RID: 322
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFirstName = "urn:schemas:contacts:givenName";

		// Token: 0x04000143 RID: 323
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoFtpSite = "urn:schemas:contacts:ftpsite";

		// Token: 0x04000144 RID: 324
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGender = "urn:schemas:contacts:gender";

		// Token: 0x04000145 RID: 325
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoGovernmentId = "urn:schemas:contacts:governmentid";

		// Token: 0x04000146 RID: 326
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHobbies = "urn:schemas:contacts:hobbies";

		// Token: 0x04000147 RID: 327
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeCity = "urn:schemas:contacts:homeCity";

		// Token: 0x04000148 RID: 328
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeCountry = "urn:schemas:contacts:homeCountry";

		// Token: 0x04000149 RID: 329
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeFax = "urn:schemas:contacts:homefax";

		// Token: 0x0400014A RID: 330
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeLatitude = "urn:schemas:contacts:homelatitude";

		// Token: 0x0400014B RID: 331
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeLongitude = "urn:schemas:contacts:homelongitude";

		// Token: 0x0400014C RID: 332
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomePhone = "urn:schemas:contacts:homePhone";

		// Token: 0x0400014D RID: 333
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomePhone2 = "urn:schemas:contacts:homephone2";

		// Token: 0x0400014E RID: 334
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomePostalAddress = "urn:schemas:contacts:homepostaladdress";

		// Token: 0x0400014F RID: 335
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomePostalCode = "urn:schemas:contacts:homePostalCode";

		// Token: 0x04000150 RID: 336
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomePostOfficeBox = "urn:schemas:contacts:homepostofficebox";

		// Token: 0x04000151 RID: 337
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeState = "urn:schemas:contacts:homeState";

		// Token: 0x04000152 RID: 338
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeStreet = "urn:schemas:contacts:homeStreet";

		// Token: 0x04000153 RID: 339
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoHomeTimeZone = "urn:schemas:contacts:hometimezone";

		// Token: 0x04000154 RID: 340
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoInitials = "urn:schemas:contacts:initials";

		// Token: 0x04000155 RID: 341
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoInternationalISDNNumber = "urn:schemas:contacts:internationalisdnnumber";

		// Token: 0x04000156 RID: 342
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLanguage = "urn:schemas:contacts:language";

		// Token: 0x04000157 RID: 343
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoLastName = "urn:schemas:contacts:sn";

		// Token: 0x04000158 RID: 344
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingAddressId = "urn:schemas:contacts:mailingaddressid";

		// Token: 0x04000159 RID: 345
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingCity = "urn:schemas:contacts:mailingcity";

		// Token: 0x0400015A RID: 346
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingCountry = "urn:schemas:contacts:mailingcountry";

		// Token: 0x0400015B RID: 347
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingPostalAddress = "urn:schemas:contacts:mailingpostaladdress";

		// Token: 0x0400015C RID: 348
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingPostalCode = "urn:schemas:contacts:mailingpostalcode";

		// Token: 0x0400015D RID: 349
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingPostOfficeBox = "urn:schemas:contacts:mailingpostofficebox";

		// Token: 0x0400015E RID: 350
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingState = "urn:schemas:contacts:mailingstate";

		// Token: 0x0400015F RID: 351
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMailingStreet = "urn:schemas:contacts:mailingstreet";

		// Token: 0x04000160 RID: 352
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoManager = "urn:schemas:contacts:manager";

		// Token: 0x04000161 RID: 353
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMapURL = "urn:schemas:contacts:mapurl";

		// Token: 0x04000162 RID: 354
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoMiddleName = "urn:schemas:contacts:middlename";

		// Token: 0x04000163 RID: 355
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNamePrefix = "urn:schemas:contacts:personaltitle";

		// Token: 0x04000164 RID: 356
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNameSuffix = "urn:schemas:contacts:namesuffix";

		// Token: 0x04000165 RID: 357
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoNickname = "urn:schemas:contacts:nickname";

		// Token: 0x04000166 RID: 358
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOrganizationName = "urn:schemas:contacts:o";

		// Token: 0x04000167 RID: 359
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOriginalAuthor = "urn:schemas:contacts:authorig";

		// Token: 0x04000168 RID: 360
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherCity = "urn:schemas:contacts:othercity";

		// Token: 0x04000169 RID: 361
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherCountry = "urn:schemas:contacts:othercountry";

		// Token: 0x0400016A RID: 362
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherCountryCode = "urn:schemas:contacts:othercountrycode";

		// Token: 0x0400016B RID: 363
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherFax = "urn:schemas:contacts:otherfax";

		// Token: 0x0400016C RID: 364
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherMobile = "urn:schemas:contacts:othermobile";

		// Token: 0x0400016D RID: 365
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherPager = "urn:schemas:contacts:otherpager";

		// Token: 0x0400016E RID: 366
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherPostalAddress = "urn:schemas:contacts:otherpostaladdress";

		// Token: 0x0400016F RID: 367
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherPostalCode = "urn:schemas:contacts:otherpostalcode";

		// Token: 0x04000170 RID: 368
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherPostOfficeBox = "urn:schemas:contacts:otherpostofficebox";

		// Token: 0x04000171 RID: 369
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherState = "urn:schemas:contacts:otherstate";

		// Token: 0x04000172 RID: 370
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherStreet = "urn:schemas:contacts:otherstreet";

		// Token: 0x04000173 RID: 371
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherTimeZone = "urn:schemas:contacts:othertimezone";

		// Token: 0x04000174 RID: 372
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoOtherWorkPhone = "urn:schemas:contacts:otherTelephone";

		// Token: 0x04000175 RID: 373
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoPersonalURL = "urn:schemas:contacts:personalHomePage";

		// Token: 0x04000176 RID: 374
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoProfession = "urn:schemas:contacts:profession";

		// Token: 0x04000177 RID: 375
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoProxyAddresses = "urn:schemas:contacts:proxyaddresses";

		// Token: 0x04000178 RID: 376
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoRoomNumber = "urn:schemas:contacts:roomnumber";

		// Token: 0x04000179 RID: 377
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSecretary = "urn:schemas:contacts:secretary";

		// Token: 0x0400017A RID: 378
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSecretaryCommonName = "urn:schemas:contacts:secretarycn";

		// Token: 0x0400017B RID: 379
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSecretaryURL = "urn:schemas:contacts:secretaryurl";

		// Token: 0x0400017C RID: 380
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSourceURL = "urn:schemas:contacts:sourceurl";

		// Token: 0x0400017D RID: 381
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSpouseCommonName = "urn:schemas:contacts:spousecn";

		// Token: 0x0400017E RID: 382
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoSubmissionContLength = "urn:schemas:contacts:submissioncontlength";

		// Token: 0x0400017F RID: 383
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTelexNumber = "urn:schemas:contacts:telexnumber";

		// Token: 0x04000180 RID: 384
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoTitle = "urn:schemas:contacts:title";

		// Token: 0x04000181 RID: 385
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoUserCertificate = "urn:schemas:contacts:usercertificate";

		// Token: 0x04000182 RID: 386
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWeddingAnniversary = "urn:schemas:contacts:weddinganniversary";

		// Token: 0x04000183 RID: 387
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkAddress = "urn:schemas:contacts:workaddress";

		// Token: 0x04000184 RID: 388
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkCity = "urn:schemas:contacts:l";

		// Token: 0x04000185 RID: 389
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkCountry = "urn:schemas:contacts:co";

		// Token: 0x04000186 RID: 390
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkCountryAbbreviation = "urn:schemas:contacts:c";

		// Token: 0x04000187 RID: 391
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkFax = "urn:schemas:contacts:facsimiletelephonenumber";

		// Token: 0x04000188 RID: 392
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkMobilePhone = "urn:schemas:contacts:mobile";

		// Token: 0x04000189 RID: 393
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkPager = "urn:schemas:contacts:pager";

		// Token: 0x0400018A RID: 394
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkPhone = "urn:schemas:contacts:telephoneNumber";

		// Token: 0x0400018B RID: 395
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkPhone2 = "urn:schemas:contacts:telephonenumber2";

		// Token: 0x0400018C RID: 396
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkPostalCode = "urn:schemas:contacts:postalcode";

		// Token: 0x0400018D RID: 397
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkPostOfficeBox = "urn:schemas:contacts:postofficebox";

		// Token: 0x0400018E RID: 398
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkState = "urn:schemas:contacts:st";

		// Token: 0x0400018F RID: 399
		[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		public const string cdoWorkStreet = "urn:schemas:contacts:street";
	}
}
