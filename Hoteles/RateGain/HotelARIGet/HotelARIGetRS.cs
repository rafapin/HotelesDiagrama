using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hoteles.RateGain.HotelARIGet
{
	[XmlRoot(ElementName = "Error", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Error
	{
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Errors", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Errors
	{
		[XmlElement(ElementName = "Error", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Error Error { get; set; }
	}

	[XmlRoot(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class ProductReferenceRS
	{
		[XmlAttribute(AttributeName = "InvTypeCode")]
		public string InvTypeCode { get; set; }
		[XmlAttribute(AttributeName = "RatePlanCode")]
		public string RatePlanCode { get; set; }
	}

	[XmlRoot(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class ApplicationControlRS
	{
		[XmlAttribute(AttributeName = "Start")]
		public string Start { get; set; }
		[XmlAttribute(AttributeName = "End")]
		public string End { get; set; }
		[XmlAttribute(AttributeName = "Sun")]
		public string Sun { get; set; }
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
	}

	[XmlRoot(ElementName = "Discount", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Discount
	{
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
	}

	[XmlRoot(ElementName = "Base", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Base
	{
		[XmlAttribute(AttributeName = "OccupancyCode")]
		public string OccupancyCode { get; set; }
		[XmlAttribute(AttributeName = "Amount")]
		public string Amount { get; set; }
	}

	[XmlRoot(ElementName = "RateAmounts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class RateAmounts
	{
		[XmlElement(ElementName = "Discount", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Discount Discount { get; set; }
		[XmlElement(ElementName = "Base", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Base Base { get; set; }
		[XmlAttribute(AttributeName = "Currency")]
		public string Currency { get; set; }
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

	[XmlRoot(ElementName = "BaseAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class BaseAllotment
	{
		[XmlAttribute(AttributeName = "Allotment")]
		public string Allotment { get; set; }
		[XmlAttribute(AttributeName = "ReleaseDays")]
		public string ReleaseDays { get; set; }
		[XmlAttribute(AttributeName = "Sold")]
		public string Sold { get; set; }
	}

	[XmlRoot(ElementName = "TransientAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class TransientAllotment
	{
		[XmlAttribute(AttributeName = "Allotment")]
		public string Allotment { get; set; }
		[XmlAttribute(AttributeName = "ReleaseDays")]
		public string ReleaseDays { get; set; }
		[XmlAttribute(AttributeName = "Sold")]
		public string Sold { get; set; }
	}

	[XmlRoot(ElementName = "BookingLimit", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class BookingLimit
	{
		[XmlElement(ElementName = "BaseAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public BaseAllotment BaseAllotment { get; set; }
		[XmlElement(ElementName = "TransientAllotment", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public TransientAllotment TransientAllotment { get; set; }
	}

	[XmlRoot(ElementName = "BookingRules", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class BookingRules
	{
		[XmlElement(ElementName = "MinAdvancedBookingOffset", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinAdvancedBookingOffset { get; set; }
		[XmlElement(ElementName = "MaxAdvancedBookingOffset", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxAdvancedBookingOffset { get; set; }
		[XmlElement(ElementName = "MinLoSOnArrival", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinLoSOnArrival { get; set; }
		[XmlElement(ElementName = "MaxLoSOnArrival", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxLoSOnArrival { get; set; }
		[XmlElement(ElementName = "MinLoSThrough", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MinLoSThrough { get; set; }
		[XmlElement(ElementName = "MaxLoSThrough", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string MaxLoSThrough { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIData", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIData
	{
		[XmlElement(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ProductReferenceRS ProductReference { get; set; }
		[XmlElement(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ApplicationControlRS ApplicationControl { get; set; }
		[XmlElement(ElementName = "RateAmounts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public RateAmounts RateAmounts { get; set; }
		[XmlElement(ElementName = "Availability", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Availability Availability { get; set; }
		[XmlElement(ElementName = "BookingLimit", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public BookingLimit BookingLimit { get; set; }
		[XmlElement(ElementName = "BookingRules", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public BookingRules BookingRules { get; set; }
		[XmlAttribute(AttributeName = "ItemIdentifier")]
		public string ItemIdentifier { get; set; }
	}

	[XmlRoot(ElementName = "Status", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Status
	{
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIStatus", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIStatus
	{
		[XmlElement(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ProductReferenceRS ProductReference { get; set; }
		[XmlElement(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ApplicationControlRS ApplicationControl { get; set; }
		[XmlElement(ElementName = "Status", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Status Status { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIDataSet", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIDataSet
	{
		[XmlElement(ElementName = "HotelARIData", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<HotelARIData> HotelARIData { get; set; }
		[XmlElement(ElementName = "HotelARIStatus", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<HotelARIStatus> HotelARIStatus { get; set; }
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIGetRS", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIGetRS
	{
		[XmlElement(ElementName = "Errors", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Errors Errors { get; set; }
		[XmlElement(ElementName = "Success", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string Success { get; set; }
		[XmlElement(ElementName = "HotelARIDataSet", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelARIDataSet HotelARIDataSet { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "TransactionIdentifier")]
		public string TransactionIdentifier { get; set; }
	}
}
