﻿using Grand.Domain.Common;
using Grand.Infrastructure.Validators;
using Grand.Business.Core.Interfaces.Common.Directory;
using Grand.Business.Core.Interfaces.Common.Localization;
using Grand.Web.Models.Checkout;
using Grand.Web.Validators.Common;

namespace Grand.Web.Validators.Customer
{
    public class CheckoutBillingAddressValidator : BaseGrandValidator<CheckoutBillingAddressModel>
    {
        public CheckoutBillingAddressValidator(
            IEnumerable<IValidatorConsumer<CheckoutBillingAddressModel>> validators,
            IEnumerable<IValidatorConsumer<Models.Common.AddressModel>> addressValidators,
            ITranslationService translationService,
            ICountryService countryService,
            AddressSettings addressSettings)
            : base(validators)
        {
            RuleFor(x => x.BillingNewAddress).SetValidator(new AddressValidator(addressValidators, translationService, countryService, addressSettings));
        }
    }
}
