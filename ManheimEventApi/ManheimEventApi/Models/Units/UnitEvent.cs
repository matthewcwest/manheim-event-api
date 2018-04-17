using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManheimEventApi.Models.Units
{
    public class UnitEvent
    {  

        public string eventType { get; set; }

        public string resource { get; set; }


        public Body body { get; set; }

        public List<string> relatedResources { get; set; }

        public class Contact
        {
            public string customerId { get; set; }
            public string accountId { get; set; }
            public string companyName { get; set; }
      
            public string manheimAccountNumber { get; set; }

            public string contactName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
        }

        public class Vehicle
        {
            public string href { get; set; }
        }

        public class Engine
        {
            public string type { get; set; }
            public double? horsepower { get; set; }
            public double? displacement { get; set; }
            public string fuel { get; set; }
        }

        public class ExteriorColor
        {
            public string description { get; set; }
            public string code { get; set; }
        }

        public class InteriorColor
        {
            public string description { get; set; }
            public string code { get; set; }
        }

        public class Description
        {
            public int? modelYear { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string trim { get; set; }
            public string transmission { get; set; }
            public int? doorCount { get; set; }
            public string roofType { get; set; }
            public string driveType { get; set; }
            public string interiorType { get; set; }
            public ExteriorColor exteriorColor { get; set; }
            public InteriorColor interiorColor { get; set; }
            public Engine engine { get; set; }
            public List<string> audio { get; set; }
            public List<string> options { get; set; }
        }

        public class Odometer
        {
            public double? digits { get; set; }
            public double? reading { get; set; }
            public string type { get; set; }
            public string units { get; set; }
        }

        public class OperatingLocation
        {
            public string href { get; set; }
        }

        public class PhysicalLocation
        {
            public string type { get; set; }
            public OperatingLocation operatingLocation { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
        }

        public class Title
        {
            public OperatingLocation operatingLocation { get; set; }
            public string number { get; set; }
            public string state { get; set; }
            public string location { get; set; }
            public string branding { get; set; }
            public string problem { get; set; }
        }

        public class Customer
        {
            public string href { get; set; }
        }

        public class Account
        {
            public string href { get; set; }
        }

        public class Account2
        {
            public string href { get; set; }
        }

        public class Company
        {
            public string href { get; set; }
        }

        public class Owner
        {
            public string manheimAccountNumber { get; set; }
            public Account2 account { get; set; }
            public Company company { get; set; }
        }

        public class Orders
        {
            public string href { get; set; }
        }

        public class Offerings
        {
            public string href { get; set; }
        }

        public class Notes
        {
            public string href { get; set; }
        }

        public class Subscriptions
        {
            public string href { get; set; }
        }

        public class Consignments
        {
            public string href { get; set; }
        }

        public class Images
        {
            public string type { get; set; }
            public string href { get; set; }
        }

        public class ConditionReport
        {
            public string source { get; set; }
            public string href { get; set; }
        }

        public class Condition
        {
            public bool? frameDamage { get; set; }
            public List<PriorPaint> priorPaint { get; set; }
        }

        public class PriorPaint
        {
            public string description { get; set; }
            public string condition { get; set; }
        }

        public class Body
        {
            public string href { get; set; }


            public string vin { get; set; }


            public string type { get; set; }
            public bool? active { get; set; }
            public string subtype { get; set; }
            public string updatedOn { get; set; }
            public string createdOn { get; set; }
            public string customerReferenceID { get; set; }
            public PhysicalLocation physicalLocation { get; set; }
            public Contact contact { get; set; }
            public Vehicle vehicle { get; set; }
            public Description description { get; set; }
            public Odometer odometer { get; set; }
            public Title title { get; set; }
            public Customer customer { get; set; }
            public Account account { get; set; }
            public Owner owner { get; set; }
            public Orders orders { get; set; }
            public Offerings offerings { get; set; }
            public Notes notes { get; set; }
            public Subscriptions subscriptions { get; set; }
            public Consignments consignments { get; set; }
            public List<Images> images { get; set; }
            public List<ConditionReport> conditionReports { get; set; }
            public Condition condition { get; set; }
        }

    }
}