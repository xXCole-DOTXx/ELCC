using System;
using System.Collections.Generic;

#nullable disable

namespace EnvApp.Models.DB
{
    public partial class TypeOne
    {
        public long Id { get; set; }
        public long StateProjectId { get; set; }
        public string FederalProjectNumber { get; set; }
        public string Name { get; set; }
        public string RouteNumber { get; set; }
        public string County { get; set; }
        public string WorkType { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string ProjectDescription { get; set; }
        public bool? FederalAid { get; set; }
        public string CeCategory { get; set; }
        public bool? EnvGisScreen { get; set; }
        public bool? PceProjectVerification { get; set; }
        public bool? ThroughLanes { get; set; }
        public bool? CloseRoad { get; set; }
        public bool? RowAcquisition { get; set; }
        public bool? AccessControl { get; set; }
        public bool? _50YearStructure { get; set; }
        public bool? AgencyCoordination { get; set; }
        public bool? GisScreen { get; set; }
        public bool? Section404Permit { get; set; }
        public bool? GroundDisturbance { get; set; }
        public bool? Waterway { get; set; }
        public bool? SpecialUsePermit { get; set; }
        public bool? Floodplain { get; set; }
        public string PreparedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string Adduser { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual ProjectScreen StateProject { get; set; }
    }
}
