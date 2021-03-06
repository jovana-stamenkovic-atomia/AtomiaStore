﻿using Atomia.Store.AspNetMvc.Ports;
using Atomia.Store.Core;
using System;

namespace Atomia.Store.Payment.WorldPay
{
    public sealed class WorldPayGuiPlugin : PaymentMethodGuiPlugin
    {
        private readonly IResourceProvider resourceProvider;

        public WorldPayGuiPlugin(IResourceProvider resourceProvider)
        {
            if (resourceProvider == null)
            {
                throw new ArgumentNullException("resourceProvider");
            }

            this.resourceProvider = resourceProvider;
        }

        public override string Id
        {
            get { return "WorldPayRedirect"; }
        }

        public override string Name
        {
            get 
            {
                return resourceProvider.GetResource("WorldPayRedirectName");
            }
        }

        public override string Description
        {
            get
            {
                return resourceProvider.GetResource("WorldPayRedirectDescription");
            }
        }

        public override bool SupportsPaymentProfile
        {
            get { return true; }
        }
    }
}
