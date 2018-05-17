﻿using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Web.Models.Common
{
    public partial class CookieConsentModel : ModelBase
    {
		public string BadgeText { get; set; }
	}

	public partial class FormDataProcessingConsentModel : ModelBase
	{
		public bool DataProcessingConsent { get; set; }
	}
}