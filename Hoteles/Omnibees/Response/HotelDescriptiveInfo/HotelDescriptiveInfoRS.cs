using Hoteles.Omnibees.Response.HotelAvail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelDescriptiveInfo
{
    public class Success
    {
    }

    public class HotelRef
    {
        public int HotelCode { get; set; }
        public int ChainCode { get; set; }
        public string HotelName { get; set; }
        public object BrandName { get; set; }
        public string ChainName { get; set; }
    }

    public class RoomAmenityOB
    {
        public string RoomAmenity { get; set; }
        public string Code { get; set; }
    }

    public class AmenitiesType
    {
        public List<RoomAmenityOB> RoomAmenities { get; set; }
    }

    public class TextItem
    {
        public object Name { get; set; }
        public object Language { get; set; }
        public string Description { get; set; }
    }

    public class TextItemsType
    {
        public List<TextItem> TextItems { get; set; }
    }

    public class MultimediaDescription
    {
        public int InfoCode { get; set; }
        public int AdditionalDetailCode { get; set; }
        public object VideoItemsType { get; set; }
        public ImageItemsType ImageItemsType { get; set; }
        public TextItemsType TextItemsType { get; set; }
        public object ID { get; set; }
    }

    public class ImageItemsType
    {
        public List<ImageItems> ImageItems { get; set; }
    }

    public class ImageItems
    {
        public URLImage URL { get; set; }
    }

    public class URLImage
    {
        public string Address { get; set; }
    }

    public class MultimediaDescriptionsType
    {
        public List<MultimediaDescription> MultimediaDescriptions { get; set; }
    }

    public class GuestRoom
    {
        public int Quantity { get; set; }
        public int MaxOccupancy { get; set; }
        public int MaxAdultOccupancy { get; set; }
        public int MinAdultOccupancy { get; set; }
        public int ID { get; set; }
        public int MaxChildOccupancy { get; set; }
        public int? MaxFreeChildOccupancy { get; set; }
        public AmenitiesType AmenitiesType { get; set; }
        public MultimediaDescriptionsType MultimediaDescriptionsType { get; set; }
        public string DescriptiveText { get; set; }
        public object TypeRoom { get; set; }
        public RoomRate[] roomRate { get; set; }
    }

    public class GuestRoomsType
    {
        public List<GuestRoom> GuestRooms { get; set; }
    }

    public class FacilityInfo
    {
        public bool SendGuestRooms { get; set; }
        public GuestRoomsType GuestRoomsType { get; set; }
    }

    public class TPAExtensions
    {
        public string SupplierCode { get; set; }
    }

    public class Descriptions
    {
        public string DescriptiveText { get; set; }
        public MultimediaDescriptionsType MultimediaDescriptionsType { get; set; }

    }


    public class Position
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }


    public class CheckInHours
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class HotelAmenities
    {
        public int Code { get; set; }
        public string HotelAmenity { get; set; }
    }

    public class HotelInfo
    {
        public Position Position { get; set; }
        public Descriptions Descriptions { get; set; }
        public CheckInHours CheckInHours { get; set; }
        public HotelAmenities[] HotelAmenities { get; set; }

    }


    public class HotelDescriptiveContent
    {
        public object CurrencyCode { get; set; }
        public object TimeZone { get; set; }
        public HotelRef HotelRef { get; set; }
        public HotelInfo HotelInfo { get; set; }
        public ContactInfosType ContactInfosType { get; set; }
        public object AffiliationInfo { get; set; }
        public object AreaInfo { get; set; }
        public FacilityInfo FacilityInfo { get; set; }
        public object Policies { get; set; }
        public object PrimaryLangID { get; set; }
        public TPAExtensions TPA_Extensions { get; set; }
    }

    public class ContactInfosType
    {
        public ContactInfos[] ContactInfos { get; set; }
    }

    public class ContactInfos
    {
        public AddressesType AddressesType { get; set; }
    }

    public class AddressesType
    {
        public Address[] Addresses { get; set; }
    }

    public class HotelDescriptiveContentsType
    {
        public List<HotelDescriptiveContent> HotelDescriptiveContents { get; set; }
    }

    public class HotelDescriptiveInfoRS
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Target { get; set; }
        public double Version { get; set; }
        public int PrimaryLangID { get; set; }
        public object POS { get; set; }
        public object WarningsType { get; set; }
        public Success Success { get; set; }
        public object ErrorsType { get; set; }
        public HotelDescriptiveContentsType HotelDescriptiveContentsType { get; set; }
    }
}
