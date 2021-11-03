using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EnvApp.Models.DB
{
    [Table("Type_One")]
    public partial class TypeOne
    {
        [Key]
        public long ID { get; set; }
        public string State_Project_Number { get; set; }
        public string Federal_Project_Number { get; set; }
        public string Name { get; set; }
        public string Route_Number { get; set; }
        public string County { get; set; }
        public string Work_Type { get; set; }
        public string Coordinates { get; set; }
        public string Project_Description { get; set; }
        public bool? Federal_Aid { get; set; }
        public bool? Minimal_Project_Verification { get; set; }
        public string CE_Category { get; set; }
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
        public string? Prepared_By { get; set; }
        public string Approved_By { get; set; }
        public string Adduser { get; set; }
        public DateTime? Date_Added { get; set; }
    }
}
