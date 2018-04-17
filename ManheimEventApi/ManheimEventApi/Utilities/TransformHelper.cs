using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Models.Units;
using System.Collections.Generic;
using System;

namespace ManheimEventApi.Utilities
{
    public class TransformHelper : ITransformHelper
    {
        public Unit Transform(UnitEvent unitEvent)
        {
            var newUnit = GetUnitLists(unitEvent); 
          
            newUnit.vin = unitEvent.body.vin;
            newUnit.date = DateTime.Now;
            newUnit.eventType = unitEvent.eventType;
            newUnit.resource = unitEvent.resource;
            newUnit.href = unitEvent.body.href;
            newUnit.type = unitEvent.body.type;
            newUnit.active = unitEvent.body.active.ToString();
            newUnit.contactName = unitEvent.body.contact?.contactName;
            newUnit.contactEmail = unitEvent.body.contact?.email;
            newUnit.customerReferenceID = unitEvent.body.customerReferenceID;
            newUnit.interiorColorCode = unitEvent.body.description?.interiorColor?.code;
            newUnit.interiorColorDescription = unitEvent.body.description?.interiorColor?.description;
            newUnit.exteriorColorCode = unitEvent.body.description?.exteriorColor?.code;
            newUnit.exteriorColorDescription = unitEvent.body.description?.exteriorColor?.description;
            newUnit.interiorType = unitEvent.body.description?.interiorType;
            newUnit.roofType = unitEvent.body.description?.roofType;
            newUnit.driveType = unitEvent.body.description?.driveType;
            newUnit.physicalLocationType = unitEvent.body.physicalLocation?.type;
            newUnit.physicalLocationOperatingLocationHref = unitEvent.body.physicalLocation?.operatingLocation?.href;
            newUnit.physicalLocationAddress = unitEvent.body.physicalLocation?.address;
            newUnit.physicalLocationCity = unitEvent.body.physicalLocation?.city;
            newUnit.physicalLocationState = unitEvent.body.physicalLocation?.state;
            newUnit.physicalLocationZip = unitEvent.body.physicalLocation?.zip;
            newUnit.contactPhone = unitEvent.body.contact?.phone;
            newUnit.titleNumber = unitEvent.body.title?.number;
            newUnit.titleState = unitEvent.body.title?.state;
            newUnit.titleLocation = unitEvent.body.title?.location;
            newUnit.titleBranding = unitEvent.body.title?.branding;
            newUnit.titleProblem = unitEvent.body.title?.problem;
            newUnit.subtype = unitEvent.body.subtype;
            newUnit.updatedOn = unitEvent.body.updatedOn;
            newUnit.createdOn = unitEvent.body.createdOn;
            newUnit.customerID = unitEvent.body.contact?.customerId;
            newUnit.accountID = unitEvent.body.contact?.accountId;
            newUnit.companyName = unitEvent.body.contact?.companyName;
            newUnit.manheimAccountNumber = unitEvent.body.contact?.manheimAccountNumber;
            newUnit.vehicleHref = unitEvent.body.vehicle?.href;
            newUnit.modelYear = unitEvent.body.description?.modelYear.ToString();
            newUnit.make = unitEvent.body.description?.make;
            newUnit.model = unitEvent.body.description?.model;
            newUnit.trim = unitEvent.body.description?.trim;
            newUnit.transmission = unitEvent.body.description?.transmission;
            newUnit.doorCount = unitEvent.body.description?.doorCount.ToString();
            newUnit.engineType = unitEvent.body.description?.engine?.type;
            newUnit.engineHorsepower = unitEvent.body.description?.engine?.horsepower.ToString();
            newUnit.engineDisplacement = unitEvent.body.description?.engine?.displacement.ToString();
            newUnit.engineFuel = unitEvent.body.description?.engine?.fuel;
            newUnit.odometerDigits = unitEvent.body.odometer?.digits.ToString();
            newUnit.odometerReading = unitEvent.body.odometer?.reading.ToString();
            newUnit.odometerType = unitEvent.body.odometer?.type;
            newUnit.odometerUnits = unitEvent.body.odometer?.units;
            newUnit.titleOperatingLocationHref = unitEvent.body.title?.operatingLocation?.href;
            newUnit.customerHref = unitEvent.body.customer?.href;
            newUnit.accountHref = unitEvent.body.account?.href;   
            newUnit.ownerManheimAccountNumber = unitEvent.body.owner?.manheimAccountNumber;
            newUnit.ownerAccountHref = unitEvent.body.owner?.account?.href;
            newUnit.ownerCompanyHref = unitEvent.body.owner?.company?.href;
            newUnit.ordersHref = unitEvent.body.orders?.href;
            newUnit.offeringsHref = unitEvent.body.offerings?.href;
            newUnit.notesHref = unitEvent.body.notes?.href;
            newUnit.subscriptionHref = unitEvent.body.subscriptions?.href;
            newUnit.consignmentsHref = unitEvent.body.consignments?.href;

            return newUnit;
        }

        public Offering Transform(OfferingEvent offering)
        {
            string offeringKey = GetOfferingKey(offering);
            var newOffering = new Offering();

            newOffering.offeringID = offeringKey;
            newOffering.eventType = offering.eventType;
            newOffering.date = DateTime.Now;
            newOffering.resource = offering.resource;
            newOffering.unitHref = offering.body.unit?.href;
            newOffering.customerHref = offering.body.unit?.customer?.href;
            newOffering.accountHref = offering.body.unit?.account?.href;
            newOffering.consignmentHref = offering.body.consignment?.href;
            newOffering.customerID = offering.body.customerId;
            newOffering.channel = offering.body.channel;
            newOffering.floorPrice = offering.body.floorPrice;
            newOffering.bidIncrement = offering.body.bidIncrement;
            newOffering.buyNowPrice = offering.body.buyNowPrice;
            newOffering.currency = offering.body.currency;
            newOffering.listingType = offering.body.listingType;
            newOffering.oveListingId = offering.body.oveListingId;
            newOffering.saleType = offering.body.saleType;
            newOffering.salePrice = offering.body.salePrice;
            newOffering.facilitatingLocationHref = offering.body.facilitatingLocation?.href;
            newOffering.listingEndDate = offering.body.listingEndDate;
            newOffering.listingStartDate = offering.body.listingStartDate;
            newOffering.laneNumber = offering.body.laneNumber.ToString();
            newOffering.physicalLaneNumber = offering.body.physicalLaneNumber.ToString();
            newOffering.redLight = offering.body.redLight.ToString();
            newOffering.registrationDate = offering.body.registrationDate;
            newOffering.runNumber = offering.body.runNumber.ToString();
            newOffering.saleLocationHref = offering.body.saleLocation?.href;
            newOffering.saleNumber = offering.body.saleNumber;
            newOffering.saleYear = offering.body.saleYear.ToString();
            newOffering.status = offering.body.status;
            newOffering.unitSnapshotsCompleted = offering.body.unitSnapshots?.completed?.href;
            newOffering.virtualLaneNumber = offering.body.virtualLaneNumber.ToString();
            newOffering.updatedOn = offering.body.updatedOn;
            newOffering.createdOn = offering.body.createdOn;
            newOffering.buyerAccountHref = offering.body.buyerAccount?.href;
            newOffering.blueLight = offering.body.blueLight.ToString();
            newOffering.greenLight = offering.body.greenLight.ToString();
            newOffering.yellowLight = offering.body.yellowLight.ToString();
            newOffering.manheimAccountNumber = offering.body.manheimAccountNumber;
            newOffering.href = offering.body.href;
            newOffering.notesHref = offering.body.notes?.href;
            newOffering.sellerInvoiceHref = offering.body.sellerInvoice?.href;

            return newOffering;
        }

        private string GetOfferingKey(OfferingEvent offering)
        {
            var splitHref = offering.body.href.Split('/');
            string offeringKey = "";

            for (int i =0; i<splitHref.Length; i++)
            {
                if (splitHref[i] == "id")
                {
                    offeringKey = splitHref[i + 1];
                    break;
                }
            }

            return offeringKey;
        }

        private Unit GetUnitLists(UnitEvent unitEvent)
        {
            var conditionReportList = new List<ConditionReport>();
            var priorPaintList = new List<PriorPaint>();
            var imagesList = new List<Images>();
            var audioList = new List<Audio>();
            var optionList = new List<Options>();
            var newUnit = new Unit();

            if (unitEvent.body.conditionReports != null)
            {
                foreach (var x in unitEvent.body.conditionReports)
                {
                    var entity = new ConditionReport
                    {
                        href = x.href,
                        source = x.source
                    };

                    conditionReportList.Add(entity);
                }

                newUnit.conditionReports = conditionReportList;
            }

            if (unitEvent.body.condition != null && unitEvent.body.condition.priorPaint != null)
            {
                foreach (var x in unitEvent.body.condition.priorPaint)
                {
                    var entity = new PriorPaint
                    {
                        condition = x.condition,
                        description = x.description
                    };

                    priorPaintList.Add(entity);
                }

                newUnit.priorPaint = priorPaintList;
            }

            if (unitEvent.body.images != null)
            {
                foreach (var x in unitEvent.body.images)
                {
                    var entity = new Images
                    {
                        type = x.type,
                        href = x.href
                    };

                    imagesList.Add(entity);
                }

                newUnit.images = imagesList;
            }

            if (unitEvent.body.description != null && unitEvent.body.description.audio != null)
            {
                foreach (var x in unitEvent.body.description.audio)
                {
                    var entity = new Audio
                    {
                        type = x
                    };

                    audioList.Add(entity);
                }

                newUnit.audio = audioList;
            }

            if (unitEvent.body.description != null && unitEvent.body.description.options != null)
            {
                foreach (var x in unitEvent.body.description.options)
                {
                    var entity = new Options
                    {
                        type = x
                    };

                    optionList.Add(entity);
                }

                newUnit.options = optionList;
            }

            return newUnit;
        }
    }
}