﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atomia.Store.PublicBillingApi.Handlers;
using Atomia.Web.Plugin.OrderServiceReferences.AtomiaBillingPublicService;
using Atomia.Store.Core;

namespace Atomia.Store.Payment.WorldPayXml
{
    public class WorldPayXmlHandler : PaymentDataHandler
    {
        private readonly PaymentUrlProvider urlProvider;

        public WorldPayXmlHandler(PaymentUrlProvider urlProvider)
        {
            if (urlProvider == null)
            {
                throw new ArgumentNullException("urlProvider");
            }

            this.urlProvider = urlProvider;
        }

        public override string Id
        {
            get { return "WorldPayXmlRedirect"; }
        }

        public override PaymentMethodEnum PaymentMethodType
        {
            get { return PaymentMethodEnum.PayByCard; }
        }

        public override PublicPaymentTransaction AmendPaymentTransaction(PublicPaymentTransaction transaction, PaymentData paymentData)
        {
            transaction.ReturnUrl = urlProvider.DefaultPaymentRedirectUrl;
            transaction = SetCancelUrl(transaction, urlProvider.CancelUrl);

            return transaction;
        }
    }
}