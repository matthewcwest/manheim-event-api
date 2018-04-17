using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManheimEventApi.Models.Offerings
{
    public class OfferingEvent 
    {


        public string eventType { get; set; }

        public string resource { get; set; }

        public Body body { get; set; }

        public List<string> relatedResources { get; set; }

        public class Customer
        {
            public string href { get; set; }
        }

        public class Account
        {
            public string href { get; set; }
        }

        public class Unit
        {
            public string href { get; set; }

            public Customer customer { get; set; }

            public Account account { get; set; }
        }

        public class FacilitatingLocation
        {
            public string href { get; set; }
        }

        public class Consignment
        {
            public string href { get; set; }
        }

        public class SaleLocation
        {
            public string href { get; set; }
        }

        public class Completed
        {
            public string href { get; set; }
        }

        public class UnitSnapshots
        {
            public Completed completed { get; set; }
        }

        public class BuyerAccount
        {
            public string href { get; set; }
        }

        public class Notes
        {
            public string href { get; set; }
        }

        public class SellerInvoice
        {
            public string href { get; set; }
        }

        public class Body
        {
            public double? salePrice { get; set; }

            public Unit unit { get; set; }

            public Consignment consignment { get; set; }

            public double? bidIncrement { get; set;}

            public double? buyNowPrice { get; set; }

            public string currency { get; set; }

            public string listingType { get; set; }

            public string oveListingId { get; set; }

            public string saleType { get; set; }

            public FacilitatingLocation facilitatingLocation { get; set; }

            public string listingStartDate { get; set; }

            public string listingEndDate { get; set; }

            public string customerId { get; set; }

            public string channel { get; set; }

            public double? floorPrice { get; set; }

            public int? laneNumber { get; set; }

            public int? physicalLaneNumber { get; set; }

            public bool? redLight { get; set; }

            public string registrationDate { get; set; }

            public int? runNumber { get; set; }

            public SaleLocation saleLocation { get; set; }

            public int? saleNumber { get; set; }

            public int? saleYear { get; set; }

            public string status { get; set; }

            public UnitSnapshots unitSnapshots { get; set; }

            public int? virtualLaneNumber { get; set; }

            public string updatedOn { get; set; }

            public string createdOn { get; set; }

            public BuyerAccount buyerAccount { get; set; }
 
            public bool? blueLight { get; set; }

            public bool? greenLight { get; set; }

            public bool? yellowLight { get; set; }

            public string manheimAccountNumber { get; set; }


            public string href { get; set; }

            public Notes notes { get; set; }

            public SellerInvoice sellerInvoice { get; set; }

            public string announcements { get; set; }

            public double highBid { get; set; }                            
        }
    }

}