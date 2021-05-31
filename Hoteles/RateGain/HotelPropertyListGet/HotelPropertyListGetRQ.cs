using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hoteles.RateGain.HotelPropertyListGet
{
	[XmlRoot(ElementName = "HotelPropertyListGetRQ", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelPropertyListGetRQ
	{
		[XmlElement(ElementName = "Authentication", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Authentication Authentication { get; set; }
		[XmlElement(ElementName = "HotelPropertyListRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelPropertyListRequest HotelPropertyListRequest { get; set; }
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

	[XmlRoot(ElementName = "Authentication", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Authentication
	{
		[XmlAttribute(AttributeName = "UserName")]
		public string UserName { get; set; }
		[XmlAttribute(AttributeName = "Password")]
		public string Password { get; set; }
	}

	[XmlRoot(ElementName = "HotelPropertyListRequest", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelPropertyListRequest
	{
		[XmlAttribute(AttributeName = "ChainCode")]
		public string ChainCode { get; set; }
	}

	
}
