using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Models.Units;
using static ManheimEventApi.Models.Units.UnitEvent;

namespace ManheimEventApiTest.Helpers
{
    public static class EventHelper
    {
        public static OfferingEvent GetOfferingEvent()
        {
            return new OfferingEvent
            {
                eventType = "eventType",
                resource = "resource",
                body = new OfferingEvent.Body
                {
                    unit = new OfferingEvent.Unit
                    {
                        href = "unitHref",
                        customer = new OfferingEvent.Customer { href = "customerHref" },
                        account = new OfferingEvent.Account { href = "accountHref" }
                    },
                    consignment = new OfferingEvent.Consignment { href = "consignmentHref" },
                    customerId = "customerID",
                    channel = "channel",
                    floorPrice = 10000,
                    listingType = "listingType",
                    saleType = "saleType",
                    currency = "currency",
                    facilitatingLocation = new OfferingEvent.FacilitatingLocation { href = "facilitatingLocationHref" },
                    buyNowPrice = 12000,
                    bidIncrement = 10,
                    salePrice = 12000,
                    listingStartDate = "listingStartDate",
                    listingEndDate = "listingEndDate",
                    laneNumber = 1,
                    physicalLaneNumber = 2,
                    redLight = true,
                    registrationDate = "1/1/2010",
                    runNumber = 12,
                    saleLocation = new OfferingEvent.SaleLocation { href = "saleLocationHref" },
                    saleNumber = 12,
                    saleYear = 2012,
                    status = "status",
                    unitSnapshots = new OfferingEvent.UnitSnapshots { completed = new OfferingEvent.Completed { href = "href" } },
                    virtualLaneNumber = 1,
                    updatedOn = "updatedOn",
                    createdOn = "createdOn",
                    buyerAccount = new OfferingEvent.BuyerAccount { href = "buyerAccountHref" },
                    blueLight = true,
                    greenLight = true,
                    yellowLight = true,
                    manheimAccountNumber = "manheimAccountNumber",
                    href = "href",
                    notes = new OfferingEvent.Notes { href = "notesHref" }
                }
            };
        }

        public static UnitEvent GetUnitEvent()
        {
            return new UnitEvent
            {
                eventType = "eventType",
                resource = "resource",
                body = new Body
                {
                    href = "href",
                    vin = "vin",
                    type = "type",
                    active = true,
                    subtype = "subtype",
                    customerReferenceID = "customerReferenceID",
                    physicalLocation = new PhysicalLocation
                    {
                        type = "type",
                        operatingLocation = new OperatingLocation { href = "href" },
                        address = "address",
                        city = "city",
                        state = "state",
                        zip = "zip"
                    },

                    updatedOn = "updatedOn",
                    createdOn = "createdOn",
                    contact = new Contact
                    {
                        customerId = "customerId",
                        accountId = "accountId",
                        companyName = "companyName",
                        manheimAccountNumber = "manheimAccountNumber",
                        contactName = "contactName",
                        email = "contactEmail",
                        phone = "contactPhone"
                    },
                    vehicle = new Vehicle { href = "vehicleHref" },
                    description = new Description
                    {
                        modelYear = 1,
                        make = "make",
                        model = "model",
                        trim = "trim",
                        transmission = "tramnsmission",
                        doorCount = 2,
                        interiorColor = new InteriorColor { code = "code", description = "description" },
                        exteriorColor = new ExteriorColor { code = "code", description = "description" },
                        interiorType = "interiorType",
                        roofType = "roofType",
                        driveType = "driveType",
                        engine = new Engine
                        {
                            type = "type",
                            horsepower = 200,
                            displacement = 2,
                            fuel = "fuel"
                        }
                    },
                    odometer = new Odometer
                    {
                        digits = 2,
                        reading = 3,
                        type = "type",
                        units = "units"
                    },
                    title = new Title
                    {
                        number = "1",
                        state = "state",
                        location = "location",
                        branding = "branding",
                        problem = "problem",
                        operatingLocation = new OperatingLocation { href = "operatingLocationHref" }
                    },
                    customer = new Customer { href = "customerHref" },
                    account = new Account { href = "accountHref" },
                    owner = new Owner
                    {
                        manheimAccountNumber = "manheimAccountNumber",
                        account = new Account2 { href = "accountHref" },
                        company = new Company { href = "companyHref" }
                    },
                    orders = new Orders { href = "ordersHref" },
                    offerings = new Offerings { href = "offeringsHref" },
                    notes = new Notes { href = "notesHref" },
                    subscriptions = new Subscriptions { href = "subscriptionsHref" },
                    consignments = new Consignments { href = "consignmentsHref" }
                }
            };
        }
    }
}
