using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{

        public partial class HotelAvailRS
        {
            public object MaxResponses { get; set; }
            public object PageNumber { get; set; }
            public string EchoToken { get; set; }
            public DateTimeOffset TimeStamp { get; set; }
            public long Target { get; set; }
            public double Version { get; set; }
            public object PrimaryLangId { get; set; }
            public object Pos { get; set; }
            public object WarningsType { get; set; }
            public Success Success { get; set; }
            public object ErrorsType { get; set; }
            public HotelStaysType HotelStaysType { get; set; }
            public Criteria Criteria { get; set; }
            public RoomStaysType RoomStaysType { get; set; }
            public Service[] Services { get; set; }
            public object TpaExtensions { get; set; }
        }

        public partial class Criteria
        {
            public object AvailableOnlyIndicator { get; set; }
            public Criterion Criterion { get; set; }
        }

        public partial class Criterion
        {
            public object Position { get; set; }
            public Address Address { get; set; }
            public object HotelRefs { get; set; }
            public object Radius { get; set; }
            public object HotelAmenity { get; set; }
            public object RoomAmenity { get; set; }
            public object Award { get; set; }
            public object ProfilesType { get; set; }
            public object RateRanges { get; set; }
            public StayDateRange StayDateRange { get; set; }
            public RoomStayCandidatesType RoomStayCandidatesType { get; set; }
            public object RatePlanCandidatesType { get; set; }
            public object Location { get; set; }
            public bool GetPricesPerGuest { get; set; }
            public object TpaExtensions { get; set; }
            public object InfoSource { get; set; }
        }

        public partial class Address
        {
            public long? CountryCode { get; set; }
            public long? StateProvCode { get; set; }
            public long? CityCode { get; set; }
            public string AddressLine { get; set; }
            public object CityName { get; set; }
            public object PostalCode { get; set; }
            public object StateProv { get; set; }
            public object CountryName { get; set; }
            public object ZoneCode { get; set; }
            public object ZoneName { get; set; }
        }

        public partial class RoomStayCandidatesType
        {
            public RoomStayCandidate[] RoomStayCandidates { get; set; }
        }

        public partial class RoomStayCandidate
        {
            public GuestCountsType GuestCountsType { get; set; }
            public object RoomId { get; set; }
            public long Quantity { get; set; }
            public long Rph { get; set; }
            public object BookingCode { get; set; }
        }

        public partial class GuestCountsType
        {
            public GuestCount[] GuestCounts { get; set; }
        }

        public partial class GuestCount
        {
            public object Age { get; set; }
            public long AgeQualifyCode { get; set; }
            public long Count { get; set; }
            public object ResGuestRph { get; set; }
        }

        public partial class StayDateRange
        {
            public DateTimeOffset Start { get; set; }
            public object Duration { get; set; }
            public DateTimeOffset End { get; set; }
        }

        public partial class HotelStaysType
        {
            public HotelStay[] HotelStays { get; set; }
        }

        public partial class HotelStay
        {
            public string Status { get; set; }
            public long RoomStayRph { get; set; }
            public object Availability { get; set; }
            public BasicPropertyInfo BasicPropertyInfo { get; set; }
            public Price Price { get; set; }
            public HotelStayTpaExtensions TpaExtensions { get; set; }
        }

        public partial class BasicPropertyInfo
        {
            public long CurrencyCode { get; set; }
            public Position Position { get; set; }
            public Address Address { get; set; }
            public object ContactNumbersType { get; set; }
            public Award Award { get; set; }
            public object HotelAmenities { get; set; }
            public object Policy { get; set; }
            public HotelRef HotelRef { get; set; }
            public object VendorMessagesType { get; set; }
            public Uri ImageUrl { get; set; }
        }

        public partial class Award
        {
            public long Rating { get; set; }
            public object Name { get; set; }
        }

        public partial class HotelRef
        {
            public long HotelCode { get; set; }
            public long ChainCode { get; set; }
            public string HotelName { get; set; }
            public object BrandName { get; set; }
            public string ChainName { get; set; }
        }

        public partial class Position
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
        }

        public partial class Price
        {
            public DateTimeOffset? Start { get; set; }
            public object Duration { get; set; }
            public DateTimeOffset? End { get; set; }
            public long AmountBeforeTax { get; set; }
            public long AmountAfterTax { get; set; }
            public long CurrencyCode { get; set; }
        }

        public partial class HotelStayTpaExtensions
        {
            public string SupplierCode { get; set; }
        }

        public partial class RoomStaysType
        {
            public RoomStay[] RoomStays { get; set; }
            public bool MoreIndicator { get; set; }
        }

        public partial class RoomStay
        {
            public long Rph { get; set; }
            public RoomType[] RoomTypes { get; set; }
            public RatePlan[] RatePlans { get; set; }
            public RoomRate[] RoomRates { get; set; }
            public Total Total { get; set; }
            public object GuestCountsType { get; set; }
            public BasicPropertyInfo BasicPropertyInfo { get; set; }
            public object Reference { get; set; }
            public object CommentsType { get; set; }
            public object SpecialRequestsType { get; set; }
            public object IndexNumber { get; set; }
            public object RoomStayStatus { get; set; }
            public TotalTpaExtensions TpaExtensions { get; set; }
            public object Guarantees { get; set; }
            public object RoomStayCandidateRph { get; set; }
            public object AvailabilityStatus { get; set; }
            public object WarningRph { get; set; }
            public object RoomStayLanguage { get; set; }
        }

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

        public partial class AdditionalDetailsType
        {
            public AdditionalDetail[] AdditionalDetails { get; set; }
        }

        public partial class AdditionalDetail
        {
            public Iption DetailDescription { get; set; }
        }

        public partial class Iption
        {
            public string Name { get; set; }
            public object Language { get; set; }
            public string Description { get; set; }
            public Uri ImageUrl { get; set; }
        }

        public partial class PenaltyDescription
        {
            public string Name { get; set; }
            public object Language { get; set; }
            public string Description { get; set; }
        }

        public partial class CancelPenalty
        {
            public bool NonRefundable { get; set; }
            public DeadLine DeadLine { get; set; }
            public AmountPercent AmountPercent { get; set; }
            public PenaltyDescription PenaltyDescription { get; set; }
        }

        public partial class AmountPercent
        {
            public long NmbrOfNights { get; set; }
            public long Amount { get; set; }
            public long Percent { get; set; }
            public long CurrencyCode { get; set; }
        }

        public partial class DeadLine
        {
            public long OffsetUnitMultiplier { get; set; }
            public long TimeUnitType { get; set; }
            public long OffsetDropTime { get; set; }
        }

        public partial class Commission
        {
            public long Percent { get; set; }
        }

        public partial class Guarantee
        {
            public DateTimeOffset? Start { get; set; }
            public object Duration { get; set; }
            public DateTimeOffset? End { get; set; }
            public Iption GuaranteeDescription { get; set; }
            public GuaranteesAcceptedType GuaranteesAcceptedType { get; set; }
            public DeadLine DeadLine { get; set; }
            public AmountPercent AmountPercent { get; set; }
            public long GuaranteeCode { get; set; }
        }

        public partial class GuaranteesAcceptedType
        {
            public AcceptedPayment[] GuaranteesAccepted { get; set; }
        }

        public partial class AcceptedPayment
        {
            public long Rph { get; set; }
            public long GuaranteeTypeCode { get; set; }
            public object PaymentCard { get; set; }
            public object GuaranteeId { get; set; }
        }

        public partial class MealsIncluded
        {
            public bool Breakfast { get; set; }
            public bool Lunch { get; set; }
            public bool Dinner { get; set; }
            public bool MealPlanIndicator { get; set; }
            public long MealPlanCode { get; set; }
            public long Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public partial class Offer
        {
            public string OfferCode { get; set; }
            public string Rph { get; set; }
            public Description Description { get; set; }
            public OfferRule[] OfferRules { get; set; }
            public Discount Discount { get; set; }
            public object CompatibleOffer { get; set; }
        }

        public partial class Description
        {
            public object Language { get; set; }
            public string DescriptionDescription { get; set; }
        }

        public partial class Discount
        {
            public object NightsRequired { get; set; }
            public object NightsDiscounted { get; set; }
            public object DiscountPattern { get; set; }
            public long? Percent { get; set; }
            public long? ChargeUnitCode { get; set; }
            public object AmountBeforeTax { get; set; }
            public object DiscountReason { get; set; }
            public object DiscountCode { get; set; }
        }

        public partial class OfferRule
        {
            public long? MaxAdvancedBookingOffset { get; set; }
            public object MinAdvancedBookingOffset { get; set; }
            public object DateRestriction { get; set; }
            public object LengthsOfStay { get; set; }
        }

        public partial class PaymentPolicies
        {
            public AcceptedPayment[] AcceptedPayments { get; set; }
        }

        public partial class RatePlanInclusion
        {
            public Iption RatePlanInclusionDesciption { get; set; }
            public object Start { get; set; }
            public object Duration { get; set; }
            public object End { get; set; }
            public long Id { get; set; }
        }

        public partial class TaxPolicy
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsPerNight { get; set; }
            public bool IsPerStay { get; set; }
            public bool IsPerPerson { get; set; }
            public bool IsPerRoom { get; set; }
            public double Value { get; set; }
            public bool IsValuePercentage { get; set; }
            public long CurrencyCode { get; set; }
            public long Id { get; set; }
        }

        public partial class RoomRate
        {
            public long RoomStayCandidateRph { get; set; }
            public DateTimeOffset EffectiveDate { get; set; }
            public DateTimeOffset ExpireDate { get; set; }
            public long RatePlanId { get; set; }
            public long RoomId { get; set; }
            public RatesType RatesType { get; set; }
            public Total Total { get; set; }
            public object AdvanceBookingRestriction { get; set; }
            public ServiceRph[] ServiceRpHs { get; set; }
            public object Discount { get; set; }
            public object PromotionCode { get; set; }
            public object GroupCode { get; set; }
            public object TpaExtensions { get; set; }
            public Availability[] Availability { get; set; }
        }

        public partial class Availability
        {
            public AvailabilityStatus AvailabilityStatus { get; set; }
            public object WarningRph { get; set; }
        }

        public partial class RatesType
        {
            public Rate[] Rates { get; set; }
        }

        public partial class GuestsTotalRate
        {
            public long AgeQualifyingCode { get; set; }
            public Total Total { get; set; }
        }

        public partial class TotalTpaExtensions
        {
            public object ApprovalInvoiced { get; set; }
            public object Services { get; set; }
            public GuestsTotalRate[] GuestsTotalRate { get; set; }
            public Rate[] Rates { get; set; }
            public long? TotalDiscountValue { get; set; }
            public object IsPreferredHotel { get; set; }
            public string SupplierCode { get; set; }
        }

        public partial class Total
        {
            public double AmountBeforeTax { get; set; }
            public double AmountAfterTax { get; set; }
            public long? CurrencyCode { get; set; }
            public bool AmountIncludingMarkup { get; set; }
            public bool AmountIsPackage { get; set; }
            public long ChargeType { get; set; }
            public TotalTpaExtensions TpaExtensions { get; set; }
        }

        public partial class Rate
        {
            public DateTimeOffset EffectiveDate { get; set; }
            public object MinLos { get; set; }
            public object MaxLos { get; set; }
            public Total Total { get; set; }
            public long? AgeQualifyingCode { get; set; }
            public object MinAge { get; set; }
            public object MaxAge { get; set; }
            public long? MinGuestApplicable { get; set; }
            public long? MaxGuestApplicable { get; set; }
            public object Status { get; set; }
            public long? NumberOfUnits { get; set; }
            public object MinAdvancedBookingOffset { get; set; }
            public object StayThrough { get; set; }
            public object Duration { get; set; }
            public object Fplos { get; set; }
        }

        public partial class ServiceRph
        {
            public long Rph { get; set; }
            public bool IsPerRoom { get; set; }
        }

        public partial class RoomType
        {
            public long RoomId { get; set; }
            public string RoomName { get; set; }
            public Description RoomDescription { get; set; }
            public object AmenitiesType { get; set; }
            public Occupancy[] Occupancies { get; set; }
            public long NumberOfUnits { get; set; }
            public object MaxOccupancy { get; set; }
        }

        public partial class Occupancy
        {
            public long MinOccupancy { get; set; }
            public long MaxOccupancy { get; set; }
            public long AgeQualifyingCode { get; set; }
            public object MinAge { get; set; }
            public object MaxAge { get; set; }
        }

        public partial class Service
        {
            public long ServicePricingType { get; set; }
            public long ServiceRph { get; set; }
            public object RatePlanCode { get; set; }
            public long Quantity { get; set; }
            public bool RequestIndicator { get; set; }
            public long Id { get; set; }
            public Iption ServiceDescription { get; set; }
            public Price[] Price { get; set; }
            public long? ServiceCategoryCode { get; set; }
            public ServiceTpaExtensions TpaExtensions { get; set; }
        }

        public partial class ServiceTpaExtensions
        {
            public object Schedules { get; set; }
            public long? SortOrder { get; set; }
        }

        public partial class Success
        {
        }

        public enum AvailabilityStatus { AvailableForSale };
    }




