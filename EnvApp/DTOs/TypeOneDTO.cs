using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;
using EnvApp.Models.DB;

namespace EnvApp.DTOs
{
    public class TypeOneDTO
    {
        [Key]
        public long ID { get; set; }
        [MaxLength(50)]
        public string State_Project_Number { get; set; }
        [MaxLength(50)]
        public string Federal_Project_Number { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Route_Number { get; set; }
        public string County { get; set; }
        [MaxLength(50)]
        public string Work_Type { get; set; }
        [MaxLength(100)]
        public string Coordinates { get; set; }
        public string Project_Description { get; set; }
        public bool? Federal_Aid { get; set; }
        public bool? Minimal_Project_Verification { get; set; }
        [MaxLength(3)]
        public string CE_Category { get; set; }
        [MaxLength(10)]
        public string Amms { get; set; }
        public bool Activities_Agreement { get; set; }
        public string Arch_RE { get; set; }
        public string Hist_RE { get; set; }
        public DateTime? Arch_RE_Date { get; set; }
        public DateTime? Hist_RE_Date { get; set; }
        public bool? Through_Lanes { get; set; }
        public bool? Close_Road { get; set; }
        public bool? ROW_Acquisition { get; set; }
        public bool? Access_Control { get; set; }
        public bool? Fifty_Year_Structure { get; set; }
        public bool? Agency_Coordination { get; set; }
        public bool? IPAC_Screening_Zone { get; set; }
        public bool? Section_404_Permit { get; set; }
        public bool? Ground_Disturbance { get; set; }
        public bool? Waterway { get; set; }
        public bool? Special_Use_Permit { get; set; }
        public bool? Floodplain { get; set; }
        public string Prepared_By { get; set; }
        public string Approved_By { get; set; }
        public string Adduser { get; set; }
        public DateTime? Date_Added { get; set; }

        public TypeOne ToCompletedTypeOne()
        {
            return new TypeOne
            {
                ID = this.ID,
                State_Project_Number = this.State_Project_Number,
                Federal_Project_Number = this.Federal_Project_Number,
                Name = this.Name,
                Route_Number = this.Route_Number,
                County = this.County,
                Work_Type = this.Work_Type,
                Coordinates = this.Coordinates,
                Project_Description = this.Project_Description,
                Federal_Aid = this.Federal_Aid,
                Minimal_Project_Verification = this.Minimal_Project_Verification,
                CE_Category = this.CE_Category,
                Amms = this.Amms,
                Activities_Agreement = this.Activities_Agreement,
                Arch_RE = this.Arch_RE,
                Hist_RE = this.Hist_RE,
                Arch_RE_Date = this.Arch_RE_Date,
                Hist_RE_Date = this.Hist_RE_Date,
                Through_Lanes = this.Through_Lanes,
                Close_Road = this.Close_Road,
                ROW_Acquisition = this.ROW_Acquisition,
                Access_Control = this.Access_Control,
                Agency_Coordination = this.Agency_Coordination,
                IPAC_Screening_Zone = this.IPAC_Screening_Zone,
                Section_404_Permit = this.Section_404_Permit,
                Ground_Disturbance = this.Ground_Disturbance,
                Waterway = this.Waterway,
                Special_Use_Permit = this.Special_Use_Permit,
                Floodplain = this.Floodplain,
                Prepared_By = this.Prepared_By,
                Approved_By = this.Approved_By,
                Adduser = this.Adduser,
                Date_Added = this.Date_Added,
                Fifty_Year_Structure = this.Fifty_Year_Structure,
            };
        }
    }
}
