﻿using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PayWithAmazon.RecurringPaymentRequests
{
    /// <summary>
    /// Request class to set the CreateOrderReferenceForId API call parameters
    /// </summary>
    public class CreateOrderReferenceForIdRequest
    {
        
        private string merchant_id;
        private string id_type;
        private bool inherit_shipping_address;
        private bool confirm_now;
        private decimal amount;
        private string currency_code;
        private string platform_id;
        private string seller_note;
        private string seller_order_id;
        private string store_name;
        private string custom_information;
        private string amazon_billing_agreement_id;
        private string mws_auth_token;
        private string action;
        private ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CreateOrderReferenceForIdRequest()
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("METHOD__CreateOrderReferenceForIdRequest Constructor | MESSAGE__Constructor Initiate");
            this.action = Constants.CreateOrderReferenceForId;
            log.Debug("METHOD__CreateOrderReferenceForIdRequest | MESSAGE__Action: " + this.action);
        }
        public string GetAction()
        {
            return this.action;
        }
        /// <summary>
        /// Sets the Merchant ID
        /// </summary>
        /// <param name="merchant_id"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithMerchantId(string merchant_id)
        {
            this.merchant_id = merchant_id;
            log.Debug("METHOD__WithMerchantId | MESSAGE__merchant_id: " + this.merchant_id);
            return this;
        }
        public string GetMerchantId()
        {
            return this.merchant_id;
        }

        /// <summary>
        /// Sets the Amazon Billing Agreement ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithId(string id)
        {
            this.amazon_billing_agreement_id = id;
            log.Debug("METHOD__WithId | MESSAGE__amazon_billing_agreement_id: " + this.amazon_billing_agreement_id);
            return this;
        }
        public string GetId()
        {
            return this.amazon_billing_agreement_id;
        }

        /// <summary>
        /// Sets the ID Type
        /// </summary>
        /// <param name="id_type"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithIdType(string id_type)
        {
            this.id_type = id_type;
            log.Debug("METHOD__WithIdType | MESSAGE__id_type: " + this.id_type);
            return this;
        }
        public string GetIdType()
        {
            return this.id_type;
        }

        /// <summary>
        /// Sets the Inherit Shipping Address Boolean value
        /// </summary>
        /// <param name="inherit_shipping_address"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithInheritShippingAddress(bool inherit_shipping_address)
        {
            this.inherit_shipping_address = inherit_shipping_address;
            log.Debug("METHOD__WithInheritShippingAddress | MESSAGE__inherit_shipping_address: " + this.inherit_shipping_address);
            return this;
        }
        public string GetInheritShippingAddress()
        {
            return this.inherit_shipping_address.ToString().ToLower();
        }

        /// <summary>
        /// Sets the Confirm Now Boolean value
        /// </summary>
        /// <param name="confirm_now"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithConfirmNow(bool confirm_now)
        {
            this.confirm_now = confirm_now;
            log.Debug("METHOD__WithConfirmNow | MESSAGE__confirm_now: " + this.confirm_now);
            return this;
        }
        public string GetConfirmNow()
        {
            return this.confirm_now.ToString().ToLower();
        }

        /// <summary>
        /// Sets the Amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>AuthorizeOnBillingAgreementRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithAmount(decimal amount)
        {
            this.amount = amount;
            log.Debug("METHOD__WithAmount | MESSAGE__amount: " + this.amount);
            return this;
        }
        public decimal GetAmount()
        {
            return this.amount;
        }

        /// <summary>
        /// Sets the Currency Code
        /// </summary>
        /// <param name="currency_code"></param>
        /// <returns>AuthorizeOnBillingAgreementRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithCurrencyCode(string currency_code)
        {
            this.currency_code = currency_code.ToUpper();
            log.Debug("METHOD__WithCurrencyCode | MESSAGE__currency_code: " + this.currency_code);
            return this;
        }
        public string GetCurrencyCode()
        {
            return this.currency_code;
        }

        /// <summary>
        /// Sets the Platform ID
        /// </summary>
        /// <param name="platform_id"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithPlatformId(string platform_id)
        {
            this.platform_id = platform_id;
            log.Debug("METHOD__WithPlatformId | MESSAGE__platform_id: " + this.platform_id);
            return this;
        }
        public string GetPlatformId()
        {
            return this.platform_id;
        }

        /// <summary>
        /// Sets the Seller Note
        /// </summary>
        /// <param name="seller_note"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithSellerNote(string seller_note)
        {
            this.seller_note = seller_note;
            log.Debug("METHOD__WithSellerNote | MESSAGE__seller_note: " + this.seller_note);
            return this;
        }
        public string GetSellerNote()
        {
            return this.seller_note;
        }

        /// <summary>
        /// Sets the Seller Order ID
        /// </summary>
        /// <param name="seller_order_id"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithSellerOrderId(string seller_order_id)
        {
            this.seller_order_id = seller_order_id;
            log.Debug("METHOD__WithSellerOrderId | MESSAGE__seller_order_id: " + this.seller_order_id);
            return this;
        }
        public string GetSellerOrderId()
        {
            return this.seller_order_id;
        }

        /// <summary>
        /// Sets the Store Name
        /// </summary>
        /// <param name="store_name"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithStoreName(string store_name)
        {
            this.store_name = store_name;
            log.Debug("METHOD__WithStoreName | MESSAGE__store_name: " + this.store_name);
            return this;
        }
        public string GetStoreName()
        {
            return this.store_name;
        }
        /// <summary>
        /// Sets the Custom Information
        /// </summary>
        /// <param name="custom_information"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithCustomInformation(string custom_information)
        {
            this.custom_information = custom_information;
            log.Debug("METHOD__WithCustomInformation | MESSAGE__custom_information: " + this.custom_information);
            return this;
        }
        public string GetCustomInformation()
        {
            return this.custom_information;
        }

        /// <summary>
        /// Sets the MWS Auth Token
        /// </summary>
        /// <param name="mws_auth_token"></param>
        /// <returns>CreateOrderReferenceForIdRequest Object</returns>
        public CreateOrderReferenceForIdRequest WithMWSAuthToken(string mws_auth_token)
        {
            this.mws_auth_token = mws_auth_token;
            log.Debug("METHOD__WithMWSAuthToken | MESSAGE__mws_auth_token: " + this.mws_auth_token);
            return this;
        }
        public string GetMWSAuthToken()
        {
            return this.mws_auth_token;
        }
    }
}
