using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Hoteles.RateGain.HotelPropertyListGet
{
	[XmlRoot(ElementName = "HotelPropertyListGetRS", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelPropertyListGetRS
	{
		[XmlElement(ElementName = "Errors", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Errors Errors { get; set; }
		[XmlElement(ElementName = "Success", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string Success { get; set; }
		[XmlElement(ElementName = "Hotels", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<Hotels> Hotels { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "TransactionIdentifier")]
		public string TransactionIdentifier { get; set; }
	}

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

	[XmlRoot(ElementName = "Hotel", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Hotel
	{
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "Hotels", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Hotels
	{
		[XmlElement(ElementName = "Hotel", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<Hotel> Hotel { get; set; }
		[XmlAttribute(AttributeName = "ChainCode")]
		public string ChainCode { get; set; }
	}

	

}
