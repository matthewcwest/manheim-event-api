using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Offerings
{
    [Table("Offering")]
    public class Offering
    {
        [Key]
        public string offeringID { get; set; }

        public DateTime date { get; set; }

        [MaxLength(500)]
        public string eventType { get; set; }

        [MaxLength(500)]
        public string resource { get; set; }

        [MaxLength(500)]
        public string unitHref { get; set; }

        [MaxLength(500)]
        public string customerHref { get; set; }

        [MaxLength(500)]
        public string accountHref { get; set; }

        [MaxLength(500)]
        public string consignmentHref { get; set; }

        [MaxLength(500)]
        public string customerID { get; set; }

        [MaxLength(500)]
        public string channel { get; set; }

        public double? floorPrice { get; set; }

        public double? bidIncrement { get; set; }

        public double? buyNowPrice { get; set; }

        public double? salePrice { get; set; }

        [MaxLength(500)]
        public string currency { get; set; }

        [MaxLength(500)]
        public string listingType { get; set; }

        [MaxLength(500)]
        public string oveListingId { get; set; }

        [MaxLength(500)]
        public string saleType { get; set; }

        [MaxLength(500)]
        public string facilitatingLocationHref { get; set; }

        [MaxLength(500)]
        public string listingStartDate { get; set; }

        [MaxLength(500)]
        public string listingEndDate { get; set; }

        [MaxLength(500)]
        public string laneNumber { get; set; }

        [MaxLength(500)]
        public string physicalLaneNumber { get; set; }

        [MaxLength(500)]
        public string redLight { get; set; }

        [MaxLength(500)]
        public string registrationDate { get; set; }

        [MaxLength(500)]
        public string runNumber { get; set; }

        [MaxLength(500)]
        public string saleLocationHref { get; set; }

        public int? saleNumber { get; set; }

        [MaxLength(500)]
        public string saleYear { get; set; }

        [MaxLength(500)]
        public string status { get; set; }

        [MaxLength(500)]
        public string unitSnapshotsCompleted { get; set; }

        [MaxLength(500)]
        public string virtualLaneNumber { get; set; }

        [MaxLength(500)]
        public string updatedOn { get; set; }

        [MaxLength(500)]
        public string createdOn { get; set; }

        [MaxLength(500)]
        public string buyerAccountHref { get; set; }

        [MaxLength(500)]
        public string blueLight { get; set; }

        [MaxLength(500)]
        public string greenLight { get; set; }

        [MaxLength(500)]
        public string yellowLight { get; set; }

        [MaxLength(500)]
        public string manheimAccountNumber { get; set; }

        [MaxLength(500)]
        public string href { get; set; }

        [MaxLength(500)]
        public string notesHref { get; set; }

        [MaxLength(500)]
        public string sellerInvoiceHref { get; set; }
    }
}