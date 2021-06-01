using Hoteles.Response.AV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelRes
{
    public class ResStatus
    {
        public string TransactionActionType { get; set; }
    }

    public class Total
    {
        public decimal AmountBeforeTax { get; set; }
        public decimal AmountAfterTax { get; set; }
        public int CurrencyCode { get; set; }
        public bool AmountIncludingMarkup { get; set; }
        public bool AmountIsPackage { get; set; }
        public string ChargeType { get; set; }
    }

    public class Rate
    {
        public DateTime EffectiveDate { get; set; }
        public Total Total { get; set; }
    }

    public class RatesType
    {
        public IList<Rate> Rates { get; set; }
    }

    public class RoomRate
    {
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int RatePlanID { get; set; }
        public long RoomID { get; set; }
        public int RoomStayCandidateRPH { get; set; }
        public RatesType RatesType { get; set; }
        public Total total { get; set; }
    }

    public class GuestCount
    {
        public int? Age { get; set; }
        public string AgeQualifyCode { get; set; }
        public int Count { get; set; }
        public IList<int> ResGuestRPH { get; set; }
    }

    public class GuestCountsType
    {
        public IList<GuestCount> GuestCounts { get; set; }
    }

    public class HotelRef
    {
        public int HotelCode { get; set; }
    }

    public class BasicPropertyInfo
    {
        public HotelRef HotelRef { get; set; }
    }

    public class Comment
    {
        public string Description { get; set; }
    }

    public class CommentsType
    {
        public IList<Comment> Comments { get; set; }
    }

    public class RoomStay
    {
        public int RPH { get; set; }
        public IList<RoomType> RoomTypes { get; set; }
        public IList<object> RatePlans { get; set; }
        public RoomRate[] RoomRates { get; set; }
        public Total total { get; set; }
        public GuestCountsType GuestCountsType { get; set; }
        public BasicPropertyInfo BasicPropertyInfo { get; set; }
        public CommentsType CommentsType { get; set; }
        public string IndexNumber { get; set; }
    }



    public class RoomStaysType
    {
        public RoomStay[] RoomStays { get; set; }
    }

    public class PersonName
    {
        public string GivenName { get; set; }
    }

    public class Customer
    {
        public PersonName PersonName { get; set; }
        public string Email { get; set; }
    }

    public class Profile
    {
        public Customer Customer { get; set; }
    }

    public class ProfileInfo
    {
        public Profile Profile { get; set; }
    }

    public class Profiles
    {
        public List<ProfileInfo> ProfileInfos { get; set; }
    }

    public class ResGuest
    {
        public int ResGuestRPH { get; set; }
        public string AgeQualifyingCode { get; set; }
        public int Age { get; set; }
        public bool PrimaryIndicator { get; set; }
        public Profiles Profiles { get; set; }
    }

    public class ResGuestsType
    {
        public List<ResGuest> ResGuests { get; set; }
    }

    public class TimeSpan
    {
        public DateTime Start { get; set; }
        public string Duration { get; set; }
        public DateTime End { get; set; }
    }

    public class HotelReservationID
    {
        public string ResID_Type { get; set; }
        public string ResID_Value { get; set; }
    }

    public class HotelReservationsIDsType
    {
        public IList<HotelReservationID> HotelReservationIDs { get; set; }
    }

    public class PaymentCard
    {
        public DateTime? ExpireDate { get; set; }
        public string CardCode { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string SeriesCode { get; set; }
    }

    public class GuaranteesAccepted
    {
        public string GuaranteeTypeCode { get; set; }
        public PaymentCard PaymentCard { get; set; }
    }

    public class GuaranteesAcceptedType
    {
        public IList<GuaranteesAccepted> GuaranteesAccepted { get; set; }
    }

    public class DeadLine
    {
        public DateTime AbsoluteDeadline { get; set; }
        public int OffsetUnitMultiplier { get; set; }
        public string TimeUnitType { get; set; }
        public string OffsetDropTime { get; set; }
    }

    public class AmountPercent
    {
        public int NmbrOfNights { get; set; }
        public int Amount { get; set; }
        public int Percent { get; set; }
        public string CurrencyCode { get; set; }
    }

    public class Guarantee
    {
        public GuaranteesAcceptedType GuaranteesAcceptedType { get; set; }
        public DeadLine DeadLine { get; set; }
        public AmountPercent AmountPercent { get; set; }
        public int? GuaranteeCode { get; set; }
    }

    public class TPA_Extensions
    {
        public string SupplierCode { get; set; }
    }

    public class Warnings
    {
        public string ShortText { get; set; }
        public int Code { get; set; }
    }

    public class WarningsType
    {
        public List<Warnings> Warnings { get; set; }
    }

    public class ResGlobalInfo
    {
        public TimeSpan TimeSpan { get; set; }
        public Total total { get; set; }
        public HotelReservationsIDsType HotelReservationsIDsType { get; set; }
        public Guarantee Guarantee { get; set; }
    }

    public class UniqueID
    {
        public string ID { get; set; }
        public string Type { get; set; }
    }

    public class HotelReservation
    {
        public ResStatus ResStatus { get; set; }
        public RoomStaysType RoomStaysType { get; set; }
        public ResGuestsType ResGuestsType { get; set; }
        public ResGlobalInfo ResGlobalInfo { get; set; }
        public TPA_Extensions TPA_Extensions { get; set; }
        public UniqueID UniqueID { get; set; }
        public POSType POS { get; set; }
    }

    public class POSType
    {
        public Source[] Sources { get; set; }
    }

    public class Source
    {
        public string PseudoCityCode { get; set; }
        public string ISOCountry { get; set; }
    }

    public class HotelReservationsType
    {
        public IList<HotelReservation> HotelReservations { get; set; }
        public HotelDescriptiveInfo.HotelInfo infoHotelDetails { get; set; }
        public HotelDescriptiveInfo.HotelRef hotelRefDetails { get; set; }
        public HabitacionConTarifasAV[] HabitacionesDisponibles { get; set; }
        public string TransactionIdentifier { get; set; }
    }

    public class HotelResRQ
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Target { get; set; }
        public double Version { get; set; }
        public string PrimaryLangID { get; set; }
        public HotelReservationsType HotelReservationsType { get; set; }
        public WarningsType WarningsType { get; set; }
        public string TransactionIdentifier { get; set; }

    }
}
