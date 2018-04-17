using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Models.Units;
using System;

namespace ManheimEventApiTest.Helpers
{
    public static class EntityHelper
    {
        public static Offering GetOffering()
        {
            var newOffering = new Offering();

            newOffering.offeringID = "offeringID";
            newOffering.eventType = "eventType";
            newOffering.date = DateTime.Now;
            newOffering.resource = "resource";
            newOffering.unitHref = "unitHref";
            newOffering.customerHref = "customerHref";
            newOffering.accountHref = "accountHref";
            newOffering.consignmentHref = "consignmentHref";
            newOffering.customerID = "customerID";
            newOffering.channel = "channel";
            newOffering.floorPrice = 1;
            newOffering.bidIncrement = 1;
            newOffering.buyNowPrice = 1;
            newOffering.currency = "currency";
            newOffering.listingType = "listingType";
            newOffering.oveListingId = "oveListingId";
            newOffering.saleType = "saleType";
            newOffering.salePrice = 1;
            newOffering.facilitatingLocationHref = "facilitatingLocationHref";
            newOffering.listingEndDate = "listingEndDate";
            newOffering.listingStartDate = "listingStartDate";
            newOffering.laneNumber = "laneNumber";
            newOffering.physicalLaneNumber = "physicalLaneNumber";
            newOffering.redLight = "redLight";
            newOffering.registrationDate = "registrationDate";
            newOffering.runNumber = "runNumber";
            newOffering.saleLocationHref = "saleLocationHref";
            newOffering.saleNumber = 1;
            newOffering.saleYear = "saleYear";
            newOffering.status = "status";
            newOffering.unitSnapshotsCompleted = "unitSnapshotsCompleted";
            newOffering.virtualLaneNumber = "virtualLaneNumber";
            newOffering.updatedOn = "updatedOn";
            newOffering.createdOn = "createdOn";
            newOffering.buyerAccountHref = "buyerAccountHref";
            newOffering.blueLight = "blueLight";
            newOffering.greenLight = "greenLight";
            newOffering.yellowLight = "yellowLight";
            newOffering.manheimAccountNumber = "manheimAccountNumber";
            newOffering.href = "href";
            newOffering.notesHref = "notesHref";

            return newOffering;
        }

        public static Unit GetUnit()
        {
            var newUnit = new Unit();

            newUnit.vin = "vin";
            newUnit.date = DateTime.Now;
            newUnit.eventType = "eventType";
            newUnit.resource = "resource";
            newUnit.href = "href";
            newUnit.type = "type";
            newUnit.active = "active";
            newUnit.contactName = "contactName";
            newUnit.contactEmail = "contactEmail";
            newUnit.customerReferenceID = "customerReferenceID";
            newUnit.interiorColorCode = "interiorColorCode";
            newUnit.interiorColorDescription = "interiorColorDescription";
            newUnit.exteriorColorCode = "exteriorColorCode";
            newUnit.exteriorColorDescription = "exteriorColorDescription";
            newUnit.interiorType = "interiorType";
            newUnit.roofType = "roofType";
            newUnit.driveType = "driveType";
            newUnit.physicalLocationType = "physicalLocationType";
            newUnit.physicalLocationOperatingLocationHref = "operatingLocationHref";
            newUnit.physicalLocationAddress = "physicalLocationAddress";
            newUnit.physicalLocationCity = "physicalLocationCity";
            newUnit.physicalLocationState = "physicalLocationState";
            newUnit.physicalLocationZip = "physicalLocationZip";
            newUnit.contactPhone = "contactPhone";
            newUnit.titleNumber = "titleNumber";
            newUnit.titleState = "titleState";
            newUnit.titleLocation = "titleLocation";
            newUnit.titleBranding = "titleBranding";
            newUnit.titleProblem = "titleProblem";
            newUnit.subtype = "subType";
            newUnit.updatedOn = "updatedOn";
            newUnit.createdOn = "createdOn";
            newUnit.customerID = "customerID";
            newUnit.accountID = "accountID";
            newUnit.companyName = "companyName";
            newUnit.manheimAccountNumber = "manheimAccountNumber";
            newUnit.vehicleHref = "vehicleHref";
            newUnit.modelYear = "modelYear";
            newUnit.make = "make";
            newUnit.model = "model";
            newUnit.trim = "trim";
            newUnit.transmission = "transmission";
            newUnit.doorCount = "doorCount";
            newUnit.engineType = "engineType";
            newUnit.engineHorsepower = "engineHorsepower";
            newUnit.engineDisplacement = "engineDisplacement";
            newUnit.engineFuel = "engineFuel";
            newUnit.odometerDigits = "odometerDigits";
            newUnit.odometerReading = "odometerReading";
            newUnit.odometerType = "odometerType";
            newUnit.odometerUnits = "odometerUnits";
            newUnit.titleOperatingLocationHref = "operatingLocationHref";
            newUnit.customerHref = "customerHref";
            newUnit.accountHref = "accountHref";
            newUnit.ownerManheimAccountNumber = "manheimAccountNumber";
            newUnit.ownerAccountHref = "ownerAccountHref";
            newUnit.ownerCompanyHref = "ownerCompanyHref";
            newUnit.ordersHref = "ordersHref";
            newUnit.offeringsHref = "offeringsHref";
            newUnit.notesHref = "notesHref";
            newUnit.subscriptionHref = "subscriptionHref";
            newUnit.consignmentsHref = "consignmentHref";

            return newUnit;

        }
    }
}
