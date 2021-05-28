using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class RatePlan
    {
        public object EffectiveDate { get; set; }
        public object ExpireDate { get; set; }
        public string RatePlanName { get; set; }
        public Guarantee[] Guarantees { get; set; }
        public CancelPenalty[] CancelPenalties { get; set; }
        public RatePlanInclusion[] RatePlanInclusions { get; set; }
        public MealsIncluded MealsIncluded { get; set; }
        public long RatePlanId { get; set; }
        public TaxPolicy[] TaxPolicies { get; set; }
        public Description RatePlanDescription { get; set; }
        public AdditionalDetailsType AdditionalDetailsType { get; set; }
        public Offer[] Offers { get; set; }
        public PaymentPolicies PaymentPolicies { get; set; }
        public Commission Commission { get; set; }
        public long CurrencyCode { get; set; }
        public long RatePlanTypeCode { get; set; }
        public long? SortOrder { get; set; }
        public bool PriceViewableInd { get; set; }
        public object TpaExtensions { get; set; }
    }
}
