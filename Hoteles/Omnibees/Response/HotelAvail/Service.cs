using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class Service
    {
        public long ServicePricingType { get; set; }
        public long ServiceRph { get; set; }
        public object RatePlanCode { get; set; }
        public long Quantity { get; set; }
        public bool RequestIndicator { get; set; }
        public long Id { get; set; }
        public Iption ServiceDescription { get; set; }
        public Price[] Price { get; set; }
        public long? ServiceCategoryCode { get; set; }
        public ServiceTpaExtensions TpaExtensions { get; set; }
    }
}
