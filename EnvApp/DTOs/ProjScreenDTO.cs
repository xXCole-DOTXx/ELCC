using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;
using EnvApp.Models.DB;

namespace EnvApp.DTOs
{
    public class ProjScreenDTO
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

        public Project_Screen ToCompletedProjScreen()
        {
            return new Project_Screen 
            { 
                ID = this.ID,
                State_Project_Number = this.State_Project_Number,
                Federal_Project_Number=this.Federal_Project_Number,
                Project_Name = this.Project_Name,
                County = this.County,
                Memo_Date = this.Memo_Date,
                From = this.From,
                Authorization = this.Authorization,
                DSN_PM = this.DSN_PM,
                History = this.History,
                History_PM = this.History_PM,
                Review_Exempt_H = this.Review_Exempt_H,
                SHPO_Approval_H = this.SHPO_Approval_H,
                Archaeology = this.Archaeology,
                Archaeology_PM = this.Archaeology_PM,
                Review_Exempt_A = this.Review_Exempt_A,
                SHPO_Approval_A = this.SHPO_Approval_A,
                ESA_Key = this.ESA_Key, 
                Crayfish = this.Crayfish,
                Crayfish_Habitat_Assessment = this.Crayfish_Habitat_Assessment,
                NLEB_4D = this.NLEB_4D,
                USFWS = this.USFWS,
                USFWS_Type = this.USFWS_Type,
                Mussel_Habitat = this.Mussel_Habitat,
                Mussel_Stream = this.Mussel_Stream,
                Within_Airport = this.Within_Airport,
                ToPo_Quad_Name = this.ToPo_Quad_Name,
                Bat_Habitat = this.Bat_Habitat,
                Bars = this.Bars,
                Coordinates = this.Coordinates,
                Natural_Resources_Notes = this.Natural_Resources_Notes,
                Adduser = this.Adduser,
                Date_Added = this.Date_Added,
                Crayfish_Notes = this.Crayfish_Notes,
                Mussel_Notes = this.Mussel_Notes,
            };

        }
    }
}
