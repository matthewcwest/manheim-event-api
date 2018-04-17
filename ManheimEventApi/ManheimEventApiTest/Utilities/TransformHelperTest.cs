using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Models.Units;
using ManheimEventApi.Utilities;
using ManheimEventApiTest.Helpers;
using Xunit;
using Assert = Xunit.Assert;

namespace ManheimEventApiTest.Utilities
{
    public class TransformHelperTest : TestBase<TransformHelper>
   {
        public TransformHelperTest()
        {
            InstantiateClassUnderTest();
        }

        [Fact]
        public void TransformHelper_Transform_WithOfferingEvent_ReturnsOffering()
        {
            var offeringEvent = EventHelper.GetOfferingEvent();

            var offering = ClassUnderTest.Transform(offeringEvent);

            AssertTransformOffering(offeringEvent, offering);
        }

        [Fact]
        public void TransformHelper_Transform_WithUnitEvent_ReturnsUnit()
        {
            var unitEvent = EventHelper.GetUnitEvent();

            var unit = ClassUnderTest.Transform(unitEvent);

            AssertTransformUnit(unitEvent, unit);
        }

        private static void AssertTransformOffering(OfferingEvent offeringEvent, Offering offering)
        {
            Assert.Equal(offeringEvent.eventType, offering.eventType);
            Assert.Equal(offeringEvent.resource, offering.resource);
            Assert.Equal(offeringEvent.body.unit.href, offering.unitHref);
            Assert.Equal(offeringEvent.body.unit.customer.href, offering.customerHref);
            Assert.Equal(offeringEvent.body.unit.account.href, offering.accountHref);
            Assert.Equal(offeringEvent.body.consignment.href, offering.consignmentHref);
            Assert.Equal(offeringEvent.body.customerId, offering.customerID);
            Assert.Equal(offeringEvent.body.channel, offering.channel);
            Assert.Equal(offeringEvent.body.floorPrice, offering.floorPrice);
            Assert.Equal(offeringEvent.body.laneNumber.ToString(), offering.laneNumber);
            Assert.Equal(offeringEvent.body.physicalLaneNumber.ToString(), offering.physicalLaneNumber);
            Assert.Equal(offeringEvent.body.redLight.ToString(), offering.redLight);
            Assert.Equal(offeringEvent.body.registrationDate, offering.registrationDate);
            Assert.Equal(offeringEvent.body.runNumber.ToString(), offering.runNumber);
            Assert.Equal(offeringEvent.body.saleLocation.href, offering.saleLocationHref);
            Assert.Equal(offeringEvent.body.saleNumber, offering.saleNumber);
            Assert.Equal(offeringEvent.body.saleYear.ToString(), offering.saleYear);
            Assert.Equal(offeringEvent.body.status, offering.status);
            Assert.Equal(offeringEvent.body.unitSnapshots.completed.href, offering.unitSnapshotsCompleted);
            Assert.Equal(offeringEvent.body.virtualLaneNumber.ToString(), offering.virtualLaneNumber);
            Assert.Equal(offeringEvent.body.updatedOn, offering.updatedOn);
            Assert.Equal(offeringEvent.body.createdOn, offering.createdOn);
            Assert.Equal(offeringEvent.body.buyerAccount.href, offering.buyerAccountHref);
            Assert.Equal(offeringEvent.body.blueLight.ToString(), offering.blueLight);
            Assert.Equal(offeringEvent.body.greenLight.ToString(), offering.greenLight);
            Assert.Equal(offeringEvent.body.yellowLight.ToString(), offering.yellowLight);
            Assert.Equal(offeringEvent.body.manheimAccountNumber, offering.manheimAccountNumber);
            Assert.Equal(offeringEvent.body.href, offering.href);
            Assert.Equal(offeringEvent.body.notes.href, offering.notesHref);
        }

        private static void AssertTransformUnit(UnitEvent unitEvent, Unit unit)
        {
            Assert.Equal(unitEvent.eventType, unit.eventType);
            Assert.Equal(unitEvent.resource, unit.resource);
            Assert.Equal(unitEvent.body.href, unit.href);
            Assert.Equal(unitEvent.body.vin, unit.vin);
            Assert.Equal(unitEvent.body.type, unit.type);
            Assert.Equal(unitEvent.body.active.ToString(), unit.active);
            Assert.Equal(unitEvent.body.subtype, unit.subtype);
            Assert.Equal(unitEvent.body.updatedOn, unit.updatedOn);
            Assert.Equal(unitEvent.body.createdOn, unit.createdOn);
            Assert.Equal(unitEvent.body.contact.customerId, unit.customerID);
            Assert.Equal(unitEvent.body.contact.accountId, unit.accountID);
            Assert.Equal(unitEvent.body.contact.companyName, unit.companyName);
            Assert.Equal(unitEvent.body.contact.manheimAccountNumber, unit.manheimAccountNumber);
            Assert.Equal(unitEvent.body.vehicle.href, unit.vehicleHref);
            Assert.Equal(unitEvent.body.description.modelYear.ToString(), unit.modelYear);
            Assert.Equal(unitEvent.body.description.make, unit.make);
            Assert.Equal(unitEvent.body.description.model, unit.model);
            Assert.Equal(unitEvent.body.description.trim, unit.trim);
            Assert.Equal(unitEvent.body.description.transmission, unit.transmission);
            Assert.Equal(unitEvent.body.description.doorCount.ToString(), unit.doorCount);
            Assert.Equal(unitEvent.body.description.engine.type, unit.engineType);
            Assert.Equal(unitEvent.body.description.engine.horsepower.ToString(), unit.engineHorsepower);
            Assert.Equal(unitEvent.body.description.engine.displacement.ToString(), unit.engineDisplacement);
            Assert.Equal(unitEvent.body.description.engine.fuel, unit.engineFuel);
            Assert.Equal(unitEvent.body.odometer.digits.ToString(), unit.odometerDigits);
            Assert.Equal(unitEvent.body.odometer.reading.ToString(), unit.odometerReading);
            Assert.Equal(unitEvent.body.odometer.type, unit.odometerType);
            Assert.Equal(unitEvent.body.odometer.units, unit.odometerUnits);
            Assert.Equal(unitEvent.body.title.operatingLocation.href, unit.titleOperatingLocationHref);
            Assert.Equal(unitEvent.body.customer.href, unit.customerHref);
            Assert.Equal(unitEvent.body.account.href, unit.accountHref);
            Assert.Equal(unitEvent.body.owner.manheimAccountNumber, unit.ownerManheimAccountNumber);
            Assert.Equal(unitEvent.body.owner.account.href, unit.ownerAccountHref);
            Assert.Equal(unitEvent.body.owner.company.href, unit.ownerCompanyHref);
            Assert.Equal(unitEvent.body.orders.href, unit.ordersHref);
            Assert.Equal(unitEvent.body.offerings.href, unit.offeringsHref);
            Assert.Equal(unitEvent.body.notes.href, unit.notesHref);
            Assert.Equal(unitEvent.body.subscriptions.href, unit.subscriptionHref);
            Assert.Equal(unitEvent.body.consignments.href, unit.consignmentsHref);
        }
    }
}
