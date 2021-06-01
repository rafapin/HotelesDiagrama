using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hoteles.RateGain.HotelARIUpdate
{
	[XmlRoot(ElementName = "Authentication", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Authentication
	{
		[XmlAttribute(AttributeName = "UserName")]
		public string UserName { get; set; }
		[XmlAttribute(AttributeName = "Password")]
		public string Password { get; set; }
	}

	[XmlRoot(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class ProductReference
	{
		[XmlAttribute(AttributeName = "InvTypeCode")]
		public string InvTypeCode { get; set; }
		[XmlAttribute(AttributeName = "RatePlanCode")]
		public string RatePlanCode { get; set; }
	}

	[XmlRoot(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class ApplicationControl
	{
		[XmlAttribute(AttributeName = "Start")]
		public string Start { get; set; }
		[XmlAttribute(AttributeName = "End")]
		public string End { get; set; }
		[XmlAttribute(AttributeName = "Mon")]
		public string Mon { get; set; }
		[XmlAttribute(AttributeName = "Tue")]
		public string Tue { get; set; }
		[XmlAttribute(AttributeName = "Wed")]
		public string Wed { get; set; }
		[XmlAttribute(AttributeName = "Thu")]
		public string Thu { get; set; }
		[XmlAttribute(AttributeName = "Fri")]
		public string Fri { get; set; }
		[XmlAttribute(AttributeName = "Sat")]
		public string Sat { get; set; }
		[XmlAttribute(AttributeName = "Sun")]
		public string Sun { get; set; }
	}

	[XmlRoot(ElementName = "MealPlan", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class MealPlan
	{
		[XmlAttribute(AttributeName = "MealPlanCode")]
		public string MealPlanCode { get; set; }
	}

	[XmlRoot(ElementName = "MealPlans", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class MealPlans
	{
		[XmlElement(ElementName = "MealPlan", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public MealPlan MealPlan { get; set; }
	}

	[XmlRoot(ElementName = "RateAmounts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class RateAmounts
	{
		[XmlElement(ElementName = "MealPlans", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public MealPlans MealPlans { get; set; }
		[XmlElement(ElementName = "Base", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<Base> Base { get; set; }
		[XmlAttribute(AttributeName = "Currency")]
		public string Currency { get; set; }
		[XmlElement(ElementName = "Additional", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<Additional> Additional { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIData", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIData
	{
		[XmlElement(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ProductReference ProductReference { get; set; }
		[XmlElement(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ApplicationControl ApplicationControl { get; set; }
		[XmlElement(ElementName = "RateAmounts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public RateAmounts RateAmounts { get; set; }
		[XmlAttribute(AttributeName = "ItemIdentifier")]
		public string ItemIdentifier { get; set; }
		[XmlElement(ElementName = "BookingLimit", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public BookingLimit BookingLimit { get; set; }
		[XmlElement(ElementName = "Availability", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Availability Availability { get; set; }
		[XmlElement(ElementName = "BookingRules", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public BookingRules BookingRules { get; set; }
	}

	[XmlRoot(ElementName = "BookingLimit", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class BookingLimit
	{
		[XmlAttribute(AttributeName = "FreeSale")]
		public string FreeSale { get; set; }
		[XmlElement(ElementName = "TransientAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public TransientAllotment TransientAllotment { get; set; }
	}

	[XmlRoot(ElementName = "Availability", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Availability
	{
		[XmlAttribute(AttributeName = "Master")]
		public string Master { get; set; }
		[XmlAttribute(AttributeName = "Arrival")]
		public string Arrival { get; set; }
		[XmlAttribute(AttributeName = "Departure")]
		public string Departure { get; set; }
	}

	[XmlRoot(ElementName = "Base", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Base
	{
		[XmlAttribute(AttributeName = "OccupancyCode")]
		public string OccupancyCode { get; set; }
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
	}

	[XmlRoot(ElementName = "Additional", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Additional
	{
		[XmlAttribute(AttributeName = "OccupancyCode")]
		public string OccupancyCode { get; set; }
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
	}

	[XmlRoot(ElementName = "BookingRules", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class BookingRules
	{
		[XmlElement(ElementName = "MaxAdvancedBookingOffset", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxAdvancedBookingOffset { get; set; }
		[XmlElement(ElementName = "MaxLoSOnArrival", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxLoSOnArrival { get; set; }
		[XmlElement(ElementName = "MaxLoSThrough", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxLoSThrough { get; set; }
		[XmlElement(ElementName = "MinAdvancedBookingOffset", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinAdvancedBookingOffset { get; set; }
		[XmlElement(ElementName = "MinLoSOnArrival", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinLoSOnArrival { get; set; }
		[XmlElement(ElementName = "MinLoSThrough", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinLoSThrough { get; set; }
	}

	[XmlRoot(ElementName = "TransientAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class TransientAllotment
	{
		[XmlAttribute(AttributeName = "Allotment")]
		public string Allotment { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIUpdateRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIUpdateRequest
	{
		[XmlElement(ElementName = "HotelARIData", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<HotelARIData> HotelARIData { get; set; }
		[XmlAttribute(AttributeName = "UpdateType")]
		public string UpdateType { get; set; }
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIUpdateRQ", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIUpdateRQ
	{
		[XmlElement(ElementName = "Authentication", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Authentication Authentication { get; set; }
		[XmlElement(ElementName = "HotelARIUpdateRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelARIUpdateRequest HotelARIUpdateRequest { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
