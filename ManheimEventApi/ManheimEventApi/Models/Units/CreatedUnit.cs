using System.Collections.Generic;

namespace ManheimEventApi.Models.Units
{
    public class CreatedUnit
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
        }

        public class Vehicle
        {
            public string href { get; set; }
        }

        public class Engine
        {
            public string type { get; set; }
            public int horsepower { get; set; }
            public double displacement { get; set; }
            public string fuel { get; set; }
        }

        public class Description
        {
            public int modelYear { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string trim { get; set; }
            public string transmission { get; set; }
            public int doorCount { get; set; }
            public Engine engine { get; set; }
        }

        public class Odometer
        {
            public int digits { get; set; }
            public int reading { get; set; }
            public string type { get; set; }
            public string units { get; set; }
        }

        public class OperatingLocation
        {
            public string href { get; set; }
        }

        public class Title
        {
            public OperatingLocation operatingLocation { get; set; }
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

        public class Body
        {
            public string href { get; set; }
            public string vin { get; set; }
            public string type { get; set; }
            public bool active { get; set; }
            public string subtype { get; set; }
            public string updatedOn { get; set; }
            public string createdOn { get; set; }
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
        }

    }
}