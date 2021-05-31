using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace Hoteles.RateGain.HotelProductListGet
{
	[XmlRoot(ElementName = "HotelProductListGetRS", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelProductListGetRS
	{
		[XmlElement(ElementName = "Errors", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public Errors Errors { get; set; }
		[XmlElement(ElementName = "HotelProducts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public HotelProducts HotelProducts { get; set; }
		[XmlElement(ElementName = "Success", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string Success { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
		[XmlAttribute(AttributeName = "TimeStamp")]
		public string TimeStamp { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}


	[XmlRoot(ElementName = "Error", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class Error
	{
		[XmlAttribute(AttributeName = "Code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
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
	public class ProductReference
	{
		[XmlAttribute(AttributeName = "InvTypeCode")]
		public string InvTypeCode { get; set; }
		[XmlAttribute(AttributeName = "RatePlanCode")]
		public string RatePlanCode { get; set; }
	}

	[XmlRoot(ElementName = "HotelProduct", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelProduct
	{
		[XmlElement(ElementName = "ProductReference", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public ProductReference ProductReference { get; set; }
		[XmlElement(ElementName = "RoomTypeName", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string RoomTypeName { get; set; }
		[XmlElement(ElementName = "RateTypeName", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public string RateTypeName { get; set; }
	}

	[XmlRoot(ElementName = "HotelProducts", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
	public class HotelProducts
	{
		[XmlElement(ElementName = "HotelProduct", Namespace = "http://cgbridge.rategain.com/OTA/2012/05")]
		public List<HotelProduct> HotelProduct { get; set; }
		[XmlAttribute(AttributeName = "HotelCode")]
		public string HotelCode { get; set; }
	}

	
}
