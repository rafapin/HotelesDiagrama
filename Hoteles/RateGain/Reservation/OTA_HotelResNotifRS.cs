using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Hoteles.RateGain.Reservation
{
	[XmlRoot(ElementName = "Error", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Error
	{
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "ShortText")]
		public string ShortText { get; set; }
		[XmlAttribute(AttributeName = "Status")]
		public string Status { get; set; }
	}

	[XmlRoot(ElementName = "Errors", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class Errors
	{
		[XmlElement(ElementName = "Error", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Error Error { get; set; }
	}

	[XmlRoot(ElementName = "OTA_HotelResNotifRS", Namespace = "http://www.opentravel.org/OTA/2003/05")]
	public class OTA_HotelResNotifRS
	{
		[XmlElement(ElementName = "Success", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public string Success { get; set; }
		[XmlElement(ElementName = "Errors", Namespace = "http://www.opentravel.org/OTA/2003/05")]
		public Errors Errors { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "EchoToken")]
		public string EchoToken { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

}