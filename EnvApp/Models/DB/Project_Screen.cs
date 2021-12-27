using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

#nullable disable

namespace EnvApp.Models.DB
{
    public partial class Project_Screen
    {
        [Key]
        public long ID { get; set; }
        [MaxLength(50)]
        public string State_Project_Number { get; set; }
        [MaxLength(50)]
        public string? Federal_Project_Number { get; set; }
        [MaxLength(50)]
        public string Project_Name { get; set; }
        public string County { get; set; }
        public DateTime? Memo_Date { get; set; }
        [MaxLength(50)]
        public string From { get; set; }
        [MaxLength(50)]
        public string? Authorization { get; set; }
        [MaxLength(50)]
        public string DSN_PM { get; set; }
        public string? History { get; set; }
        public string History_PM { get; set; }
        public bool Review_Exempt_H { get; set; }
        public bool SHPO_Approval_H { get; set; }
        public string? Archaeology { get; set; }
        public string Archaeology_PM { get; set; }
        public bool Review_Exempt_A { get; set; }
        public bool SHPO_Approval_A { get; set; }
        public bool ESA_Key { get; set; }
        public bool Crayfish { get; set; }
        public bool Crayfish_Habitat_Assessment { get; set; }
        public bool NLEB_4D { get; set; }
        public bool USFWS { get; set; }
        [RequiredIf("USFWS == true", ErrorMessage = "USFWS Type is required.")]
        public string USFWS_Type { get; set; }
        public bool Mussel_Habitat { get; set; }
        public bool Mussel_Stream { get; set; }
        [MaxLength(100)]
        public string Within_Airport { get; set; }
        [MaxLength(100)]
        public string? ToPo_Quad_Name { get; set; }
        public bool Bat_Habitat { get; set; }
        [MaxLength(6)]
        public string? Bars { get; set; }
        [MaxLength(100)]
        public string Coordinates { get; set; }
        public string? Natural_Resources_Notes { get; set; }
        [MaxLength(20)]
        public string Adduser { get; set; }
        public DateTime? Date_Added { get; set; }
        public string Crayfish_Notes { get; set; }
        public string Mussel_Notes { get; set; }

    }
}
