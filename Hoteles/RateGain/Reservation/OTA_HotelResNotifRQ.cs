using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Hoteles.RateGain.Reservation
{
	[XmlRoot(ElementName = "RequestorID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RequestorID
	{
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "ID")]
		public string ID { get; set; }
	}

	[XmlRoot(ElementName = "CompanyName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class CompanyName
	{
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName = "TravelSector")]
		public string TravelSector { get; set; }
		[XmlAttribute(AttributeName = "CompanyShortName")]
		public string CompanyShortName { get; set; }
	}

	[XmlRoot(ElementName = "BookingChannel", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class BookingChannel
	{
		[XmlElement(ElementName = "CompanyName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public CompanyName CompanyName { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "Primary")]
		public string Primary { get; set; }
	}

	[XmlRoot(ElementName = "Source", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Source
	{
		[XmlElement(ElementName = "RequestorID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RequestorID RequestorID { get; set; }
		[XmlElement(ElementName = "BookingChannel", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public BookingChannel BookingChannel { get; set; }
	}

	[XmlRoot(ElementName = "POS", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class POS
	{
		[XmlElement(ElementName = "Source", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Source Source { get; set; }
	}

	[XmlRoot(ElementName = "RoomDescription", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomDescription
	{
		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "RoomType", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomType
	{
		[XmlElement(ElementName = "RoomDescription", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomDescription RoomDescription { get; set; }
		[XmlAttribute(AttributeName = "NumberOfUnits")]
		public string NumberOfUnits { get; set; }
		[XmlAttribute(AttributeName = "RoomTypeCode")]
		public string RoomTypeCode { get; set; }
		[XmlAttribute(AttributeName = "PromotionVendorCode")]
		public string PromotionVendorCode { get; set; }
		[XmlAttribute(AttributeName = "BedTypeCode")]
		public string BedTypeCode { get; set; }
	}

	[XmlRoot(ElementName = "RoomTypes", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomTypes
	{
		[XmlElement(ElementName = "RoomType", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomType RoomType { get; set; }
	}

	[XmlRoot(ElementName = "RatePlan", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RatePlan
	{
		[XmlAttribute(AttributeName = "RatePlanCode")]
		public string RatePlanCode { get; set; }
	}

	[XmlRoot(ElementName = "CommissionPayableAmount", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class CommissionPayableAmount
	{
		[XmlAttribute(AttributeName = "CurrencyCode")]
		public string CurrencyCode { get; set; }
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
	}

	[XmlRoot(ElementName = "Commission", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Commission
	{
		[XmlElement(ElementName = "CommissionPayableAmount", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public CommissionPayableAmount CommissionPayableAmount { get; set; }
	}

	[XmlRoot(ElementName = "RatePlans", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RatePlans
	{
		[XmlElement(ElementName = "RatePlan", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RatePlan RatePlan { get; set; }
		[XmlElement(ElementName = "Commission", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Commission Commission { get; set; }
	}

	[XmlRoot(ElementName = "Base", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Base
	{
		[XmlAttribute(AttributeName = "AmountBeforeTax")]
		public string AmountBeforeTax { get; set; }
		[XmlAttribute(AttributeName = "AmountAfterTax")]
		public string AmountAfterTax { get; set; }
		[XmlAttribute(AttributeName = "CurrencyCode")]
		public string CurrencyCode { get; set; }
	}

	[XmlRoot(ElementName = "Rate", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Rate
	{
		[XmlElement(ElementName = "Base", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Base Base { get; set; }
		[XmlAttribute(AttributeName = "EffectiveDate")]
		public string EffectiveDate { get; set; }
		[XmlAttribute(AttributeName = "ExpireDate")]
		public string ExpireDate { get; set; }
	}

	[XmlRoot(ElementName = "Rates", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Rates
	{
		[XmlElement(ElementName = "Rate", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Rate Rate { get; set; }
	}

	[XmlRoot(ElementName = "RoomRate", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomRate
	{
		[XmlElement(ElementName = "Rates", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Rates Rates { get; set; }
		[XmlAttribute(AttributeName = "RoomTypeCode")]
		public string RoomTypeCode { get; set; }
		[XmlAttribute(AttributeName = "NumberOfUnits")]
		public string NumberOfUnits { get; set; }
		[XmlAttribute(AttributeName = "RatePlanCode")]
		public string RatePlanCode { get; set; }
		[XmlAttribute(AttributeName = "PromotionVendorCode")]
		public string PromotionVendorCode { get; set; }
	}

	[XmlRoot(ElementName = "RoomRates", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomRates
	{
		[XmlElement(ElementName = "RoomRate", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomRate RoomRate { get; set; }
	}

	[XmlRoot(ElementName = "GuestCount", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class GuestCount
	{
		[XmlAttribute(AttributeName = "AgeQualifyingCode")]
		public string AgeQualifyingCode { get; set; }
		[XmlAttribute(AttributeName = "Count")]
		public string Count { get; set; }
	}

	[XmlRoot(ElementName = "GuestCounts", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class GuestCounts
	{
		[XmlElement(ElementName = "GuestCount", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public GuestCount GuestCount { get; set; }
	}

	[XmlRoot(ElementName = "TimeSpan", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class TimeSpan
	{
		[XmlAttribute(AttributeName = "Start")]
		public string Start { get; set; }
		[XmlAttribute(AttributeName = "End")]
		public string End { get; set; }
		[XmlAttribute(AttributeName = "Duration")]
		public string Duration { get; set; }
	}

	[XmlRoot(ElementName = "Tax", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Tax
	{
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
		[XmlAttribute(AttributeName = "CurrencyCode")]
		public string CurrencyCode { get; set; }
	}

	[XmlRoot(ElementName = "Taxes", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Taxes
	{
		[XmlElement(ElementName = "Tax", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Tax Tax { get; set; }
	}

	[XmlRoot(ElementName = "Total", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Total
	{
		[XmlElement(ElementName = "Taxes", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Taxes Taxes { get; set; }
		[XmlAttribute(AttributeName = "AmountBeforeTax")]
		public string AmountBeforeTax { get; set; }
		[XmlAttribute(AttributeName = "AmountAfterTax")]
		public string AmountAfterTax { get; set; }
		[XmlAttribute(AttributeName = "CurrencyCode")]
		public string CurrencyCode { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "BasicPropertyInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class BasicPropertyInfo
	{
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
		[XmlAttribute(AttributeName = "HotelName")]
		public string HotelName { get; set; }
	}

	[XmlRoot(ElementName = "RoomStay", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomStay
	{
		[XmlElement(ElementName = "RoomTypes", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomTypes RoomTypes { get; set; }
		[XmlElement(ElementName = "RatePlans", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RatePlans RatePlans { get; set; }
		[XmlElement(ElementName = "RoomRates", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomRates RoomRates { get; set; }
		[XmlElement(ElementName = "GuestCounts", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public GuestCounts GuestCounts { get; set; }
		[XmlElement(ElementName = "TimeSpan", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public TimeSpan TimeSpan { get; set; }
		[XmlElement(ElementName = "Total", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Total Total { get; set; }
		[XmlElement(ElementName = "BasicPropertyInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public BasicPropertyInfo BasicPropertyInfo { get; set; }
		[XmlAttribute(AttributeName = "PromotionVendorCode")]
		public string PromotionVendorCode { get; set; }
		[XmlAttribute(AttributeName = "WarningRPH")]
		public string WarningRPH { get; set; }
	}

	[XmlRoot(ElementName = "RoomStays", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class RoomStays
	{
		[XmlElement(ElementName = "RoomStay", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomStay RoomStay { get; set; }
	}

	[XmlRoot(ElementName = "PersonName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class PersonName
	{
		[XmlElement(ElementName = "NamePrefix", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string NamePrefix { get; set; }
		[XmlElement(ElementName = "GivenName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string GivenName { get; set; }
		[XmlElement(ElementName = "Surname", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string Surname { get; set; }
	}

	[XmlRoot(ElementName = "Telephone", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Telephone
	{
		[XmlAttribute(AttributeName = "PhoneTechType")]
		public string PhoneTechType { get; set; }
		[XmlAttribute(AttributeName = "PhoneNumber")]
		public string PhoneNumber { get; set; }
		[XmlAttribute(AttributeName = "FormattedInd")]
		public string FormattedInd { get; set; }
		[XmlAttribute(AttributeName = "DefaultInd")]
		public string DefaultInd { get; set; }
	}

	[XmlRoot(ElementName = "Email", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Email
	{
		[XmlAttribute(AttributeName = "DefaultInd")]
		public string DefaultInd { get; set; }
		[XmlAttribute(AttributeName = "EmailType")]
		public string EmailType { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "CountryName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class CountryName
	{
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Address", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Address
	{
		[XmlElement(ElementName = "AddressLine", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string AddressLine { get; set; }
		[XmlElement(ElementName = "CityName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string CityName { get; set; }
		[XmlElement(ElementName = "PostalCode", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string PostalCode { get; set; }
		[XmlElement(ElementName = "CountryName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public CountryName CountryName { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "Customer", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Customer
	{
		[XmlElement(ElementName = "PersonName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public PersonName PersonName { get; set; }
		[XmlElement(ElementName = "Telephone", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Telephone Telephone { get; set; }
		[XmlElement(ElementName = "Email", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Email Email { get; set; }
		[XmlElement(ElementName = "Address", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "Profile", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Profile
	{
		[XmlElement(ElementName = "Customer", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Customer Customer { get; set; }
		[XmlAttribute(AttributeName = "ProfileType")]
		public string ProfileType { get; set; }
		[XmlAttribute(AttributeName = "StatusCode")]
		public string StatusCode { get; set; }
		[XmlElement(ElementName = "CompanyInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public CompanyInfo CompanyInfo { get; set; }
	}

	[XmlRoot(ElementName = "ProfileInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class ProfileInfo
	{
		[XmlElement(ElementName = "Profile", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Profile Profile { get; set; }
		[XmlElement(ElementName = "UniqueID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public UniqueID UniqueID { get; set; }
	}

	[XmlRoot(ElementName = "Profiles", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Profiles
	{
		[XmlElement(ElementName = "ProfileInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public ProfileInfo ProfileInfo { get; set; }
	}

	[XmlRoot(ElementName = "ResGuest", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class ResGuest
	{
		[XmlElement(ElementName = "Profiles", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Profiles Profiles { get; set; }
		[XmlAttribute(AttributeName = "AgeQualifyingCode")]
		public string AgeQualifyingCode { get; set; }
		[XmlAttribute(AttributeName = "PrimaryIndicator")]
		public string PrimaryIndicator { get; set; }
	}

	[XmlRoot(ElementName = "UniqueID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class UniqueID
	{
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "ID")]
		public string ID { get; set; }
		[XmlAttribute(AttributeName = "ID_Context")]
		public string ID_Context { get; set; }
	}

	[XmlRoot(ElementName = "TelephoneInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class TelephoneInfo
	{
		[XmlAttribute(AttributeName = "PhoneUseType")]
		public string PhoneUseType { get; set; }
		[XmlAttribute(AttributeName = "PhoneNumber")]
		public string PhoneNumber { get; set; }
		[XmlAttribute(AttributeName = "PhoneTechType")]
		public string PhoneTechType { get; set; }
		[XmlAttribute(AttributeName = "FormattedInd")]
		public string FormattedInd { get; set; }
	}

	[XmlRoot(ElementName = "BusinessLocale", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class BusinessLocale
	{
		[XmlElement(ElementName = "AddressLine", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string AddressLine { get; set; }
		[XmlElement(ElementName = "CityName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string CityName { get; set; }
		[XmlElement(ElementName = "PostalCode", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string PostalCode { get; set; }
		[XmlElement(ElementName = "StateProv", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string StateProv { get; set; }
		[XmlElement(ElementName = "CountryName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string CountryName { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "FormattedInd")]
		public string FormattedInd { get; set; }
		[XmlAttribute(AttributeName = "DefaultInd")]
		public string DefaultInd { get; set; }
	}

	[XmlRoot(ElementName = "CompanyInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class CompanyInfo
	{
		[XmlElement(ElementName = "CompanyName", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public CompanyName CompanyName { get; set; }
		[XmlElement(ElementName = "TelephoneInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public TelephoneInfo TelephoneInfo { get; set; }
		[XmlElement(ElementName = "Email", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string Email { get; set; }
		[XmlElement(ElementName = "BusinessLocale", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public BusinessLocale BusinessLocale { get; set; }
	}

	[XmlRoot(ElementName = "ResGuests", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class ResGuests
	{
		[XmlElement(ElementName = "ResGuest", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public List<ResGuest> ResGuest { get; set; }
	}

	[XmlRoot(ElementName = "HotelReservationID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class HotelReservationID
	{
		[XmlAttribute(AttributeName = "ResID_Type")]
		public string ResID_Type { get; set; }
		[XmlAttribute(AttributeName = "ResID_Value")]
		public string ResID_Value { get; set; }
	}

	[XmlRoot(ElementName = "HotelReservationIDs", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class HotelReservationIDs
	{
		[XmlElement(ElementName = "HotelReservationID", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public HotelReservationID HotelReservationID { get; set; }
	}

	[XmlRoot(ElementName = "AcceptableGuarantee", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class AcceptableGuarantee
	{
		[XmlAttribute(AttributeName = "PaymentType")]
		public string PaymentType { get; set; }
	}

	[XmlRoot(ElementName = "AcceptableGuarantees", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class AcceptableGuarantees
	{
		[XmlElement(ElementName = "AcceptableGuarantee", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public AcceptableGuarantee AcceptableGuarantee { get; set; }
	}

	[XmlRoot(ElementName = "BookingRule", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class BookingRule
	{
		[XmlElement(ElementName = "AcceptableGuarantees", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public AcceptableGuarantees AcceptableGuarantees { get; set; }
	}

	[XmlRoot(ElementName = "BookingRules", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class BookingRules
	{
		[XmlElement(ElementName = "BookingRule", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public BookingRule BookingRule { get; set; }
	}

	[XmlRoot(ElementName = "ResGlobalInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class ResGlobalInfo
	{
		[XmlElement(ElementName = "TimeSpan", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public TimeSpan TimeSpan { get; set; }
		[XmlElement(ElementName = "Total", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Total Total { get; set; }
		[XmlElement(ElementName = "HotelReservationIDs", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public HotelReservationIDs HotelReservationIDs { get; set; }
		[XmlElement(ElementName = "BookingRules", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public BookingRules BookingRules { get; set; }
	}

	[XmlRoot(ElementName = "HotelReservation", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class HotelReservation
	{
		[XmlElement(ElementName = "RoomStays", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public RoomStays RoomStays { get; set; }
		[XmlElement(ElementName = "ResGuests", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public ResGuests ResGuests { get; set; }
		[XmlElement(ElementName = "ResGlobalInfo", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public ResGlobalInfo ResGlobalInfo { get; set; }
		[XmlAttribute(AttributeName = "CreateDateTime")]
		public string CreateDateTime { get; set; }
		[XmlAttribute(AttributeName = "LastModifyDateTime")]
		public string LastModifyDateTime { get; set; }
		[XmlAttribute(AttributeName = "ResStatus")]
		public string ResStatus { get; set; }
	}

	[XmlRoot(ElementName = "HotelReservations", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class HotelReservations
	{
		[XmlElement(ElementName = "HotelReservation", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public HotelReservation HotelReservation { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "OTA_HotelResNotifRQ", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class OTA_HotelResNotifRQ
	{
		[XmlElement(ElementName = "POS", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public POS POS { get; set; }
		[XmlElement(ElementName = "HotelReservations", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public HotelReservations HotelReservations { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "ResStatus")]
		public string ResStatus { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}
