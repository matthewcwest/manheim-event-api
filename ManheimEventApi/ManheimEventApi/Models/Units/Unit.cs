using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Units
{
    [Table("Unit")]
    public class Unit
    {
        [Key, Column(Order = 0)]
        public string vin { get; set; }

        [Key, Column(Order = 1)]
        public string manheimAccountNumber { get; set; }

        public DateTime date { get; set; }

        [MaxLength(500)]
        public string eventType { get; set; }

        [MaxLength(500)]
        public string resource { get; set; }

        [MaxLength(500)]
        public string href { get; set; }

        [MaxLength(500)]
        public string type { get; set; }

        [MaxLength(500)]
        public string active { get; set; }

        [MaxLength(500)]
        public string subtype { get; set; }

        [MaxLength(500)]
        public string frameDamage { get; set; }

        [MaxLength(500)]
        public string contactName { get; set; }

        [MaxLength(500)]
        public string contactEmail { get; set; }

        [MaxLength(500)]
        public string customerReferenceID { get; set; }

        [MaxLength(500)]
        public string interiorColorCode { get; set; }

        [MaxLength(500)]
        public string interiorColorDescription { get; set; }

        [MaxLength(500)]
        public string exteriorColorCode { get; set; }

        [MaxLength(500)]
        public string exteriorColorDescription { get; set; }

        [MaxLength(500)]
        public string interiorType { get; set; }

        [MaxLength(500)]
        public string roofType { get; set; }

        [MaxLength(500)]
        public string driveType { get; set; }

        [MaxLength(500)]
        public string physicalLocationType { get; set; }

        [MaxLength(500)]
        public string physicalLocationOperatingLocationHref { get; set; }

        [MaxLength(500)]
        public string physicalLocationAddress { get; set; }

        [MaxLength(500)]
        public string physicalLocationCity { get; set; }

        [MaxLength(500)]
        public string physicalLocationState { get; set; }

        [MaxLength(500)]
        public string physicalLocationZip { get; set; }

        [MaxLength(500)]
        public string titleNumber { get; set; }

        [MaxLength(500)]
        public string titleState { get; set; }

        [MaxLength(500)]
        public string titleLocation { get; set; }

        [MaxLength(500)]
        public string titleBranding { get; set; }

        [MaxLength(500)]
        public string titleProblem { get; set; }

        [MaxLength(500)]
        public string updatedOn { get; set; }

        [MaxLength(500)]
        public string createdOn { get; set; }

        [MaxLength(500)]
        public string customerID { get; set; }

        [MaxLength(500)]
        public string contactPhone { get; set; }

        public List<Audio> audio { get; set; }

        public List<Options> options { get; set; }

        public List<Images> images { get; set; }

        public List<ConditionReport> conditionReports { get; set; }

        public List<PriorPaint> priorPaint { get; set; }

        [MaxLength(500)]
        public string accountID { get; set; }

        [MaxLength(500)]
        public string companyName { get; set; }

        [MaxLength(500)]
        public string vehicleHref { get; set; }

        [MaxLength(500)]
        public string modelYear { get; set; }

        [MaxLength(500)]
        public string make { get; set; }

        [MaxLength(500)]
        public string model { get; set; }

        [MaxLength(500)]
        public string trim { get; set; }

        [MaxLength(500)]
        public string transmission { get; set; }

        [MaxLength(500)]
        public string doorCount { get; set; }

        [MaxLength(500)]
        public string engineType { get; set; }

        [MaxLength(500)]
        public string engineHorsepower { get; set; }

        [MaxLength(500)]
        public string engineDisplacement { get; set; }

        [MaxLength(500)]
        public string engineFuel { get; set; }

        [MaxLength(500)]
        public string odometerDigits { get; set; }

        [MaxLength(500)]
        public string odometerReading { get; set; }

        [MaxLength(500)]
        public string odometerType { get; set; }

        [MaxLength(500)]
        public string odometerUnits { get; set; }

        [MaxLength(500)]
        public string titleOperatingLocationHref { get; set; }

        [MaxLength(500)]
        public string customerHref { get; set; }

        [MaxLength(500)]
        public string accountHref { get; set; }

        [MaxLength(500)]
        public string ownerManheimAccountNumber { get; set; }

        [MaxLength(500)]
        public string ownerAccountHref { get; set; }

        [MaxLength(500)]
        public string ownerCompanyHref { get; set; }

        [MaxLength(500)]
        public string ordersHref { get; set; }

        [MaxLength(500)]
        public string offeringsHref { get; set; }

        [MaxLength(500)]
        public string notesHref { get; set; }

        [MaxLength(500)]
        public string subscriptionHref { get; set; }

        [MaxLength(500)]
        public string consignmentsHref { get; set; }
    }
}