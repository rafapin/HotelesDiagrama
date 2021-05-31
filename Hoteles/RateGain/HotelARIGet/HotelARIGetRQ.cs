using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hoteles.RateGain.HotelARIGet
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
	}

	[XmlRoot(ElementName = "HotelARIGetRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIGetRequest
	{
		[XmlElement(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ProductReference ProductReference { get; set; }
		[XmlElement(ElementName = "ApplicationControl", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ApplicationControl ApplicationControl { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIGetRequests", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIGetRequests
	{
		[XmlElement(ElementName = "HotelARIGetRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelARIGetRequest HotelARIGetRequest { get; set; }
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
	}

	[XmlRoot(ElementName = "HotelARIGetRQ", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelARIGetRQ
	{
		[XmlElement(ElementName = "Authentication", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Authentication Authentication { get; set; }
		[XmlElement(ElementName = "HotelARIGetRequests", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelARIGetRequests HotelARIGetRequests { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
