using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;
using EnvApp.Models.DB;

namespace EnvApp.DTOs
{
    public class TypeTwoDTO
    {
        [Key]
        public long ID { get; set; }
        [MaxLength(50), Required]
        public string State_Project_Number { get; set; }
        [MaxLength(50)]
        public string Federal_Project_Number { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Route_Number { get; set; }
        public string County { get; set; }
        [Required]
        public string Category { get; set; }
        public int ADT_Existing { get; set; }
        public int ADT_Projected { get; set; }
        [MaxLength(100)]
        public string Coordinates { get; set; }
        [Required]
        public bool Federal_Nexus { get; set; }
        public string Existing_Conditions { get; set; }
        public string Preferred_Alternatives { get; set; }
        public string Other_Alternatives { get; set; }
        public string Public_Involvement { get; set; }
        public bool Right_of_Way { get; set; }
        [MaxLength(100)]
        public string Right_of_Way_Comments { get; set; }
        public bool Federal_Land { get; set; }
        [MaxLength(100)]
        public string Federal_Land_Comments { get; set; }
        public bool Maintenance_of_Traffic { get; set; }
        [MaxLength(100)]
        public string Maintenance_of_Traffic_Comment { get; set; }
        public bool Public_Controversy { get; set; }
        [MaxLength(100)]
        public string Public_Controversy_Comment { get; set; }
        public bool History { get; set; }
        [MaxLength(100)]
        public string History_Comment { get; set; }
        public bool H_Adverse_Effect { get; set; }
        [MaxLength(100)]
        public string H_Adverse_Effect_Comment { get; set; }
        public bool Archaeology { get; set; }
        [MaxLength(100)]
        public string Archaeology_Comment { get; set; }
        public bool A_Adverse_Effect { get; set; }
        [MaxLength(100)]
        public string A_Adverse_Effect_Comment { get; set; }
        public bool US_Forest_Service { get; set; }
        [MaxLength(100)]
        public string US_Forest_Service_Comment { get; set; }
        public bool US_Army_Corps_Eng { get; set; }
        [MaxLength(100)]
        public string US_Army_Corps_Eng_Comment { get; set; }
        public bool National_Park_Service { get; set; }
        [MaxLength(100)]
        public string National_Park_Service_Comment { get; set; }
        public bool Wild_Scenic_River { get; set; }
        [MaxLength(100)]
        public string Wild_Scenic_River_Comment { get; set; }
        public bool National_River { get; set; }
        [MaxLength(100)]
        public string National_River_Comment { get; set; }
        public bool National_Wildlife_Refuge { get; set; }
        [MaxLength(100)]
        public string National_Wildlife_Refuge_Comment { get; set; }
        public bool State_Park { get; set; }
        [MaxLength(100)]
        public string State_Park_Comment { get; set; }
        public bool State_Wildlife_Management_Area { get; set; }
        [MaxLength(100)]
        public string State_Wildlife_Management_Area_Comment { get; set; }
        public bool Other_Park { get; set; }
        [MaxLength(100)]
        public string Other_Park_Comment { get; set; }
        public bool Historic_Property { get; set; }
        [MaxLength(100)]
        public string Historic_Property_Comment { get; set; }
        public bool Park_Recreational { get; set; }
        [MaxLength(100)]
        public string Park_Recreational_Comment { get; set; }
        public bool DE_Minimis { get; set; }
        [MaxLength(100)]
        public string DE_Minimis_Comment { get; set; }
        public bool Programmatic { get; set; }
        [MaxLength(100)]
        public string Prog_Comment { get; set; }
        public bool D_Individual { get; set; }
        [MaxLength(100)]
        public string D_Individual_Comment { get; set; }
        public bool LWCFA { get; set; }
        [MaxLength(100)]
        public string LWCFA_Comment { get; set; }
        public bool Temp_Change { get; set; }
        [MaxLength(100)]
        public string Temp_Change_Comment { get; set; }
        public bool Conversion_of_Property { get; set; }
        [MaxLength(100)]
        public string Conversion_of_Property_Comment { get; set; }
        public bool US_Fish_Wildlife { get; set; }
        [MaxLength(100)]
        public string US_Fish_Wildlife_Comment { get; set; }
        public bool Formal_Consultation { get; set; }
        [MaxLength(100)]
        public string Formal_Consultation_Comment { get; set; }
        public bool Division_Natural_Resources { get; set; }
        [MaxLength(100)]
        public string Division_Natural_Resources_Comment { get; set; }
        public bool Floodplain_Enchroachment { get; set; }
        [MaxLength(100)]
        public string Floodplain_Enchroachment_Comment { get; set; }
        public bool Farmland_Involvment { get; set; }
        [MaxLength(100)]
        public string Farmland_Involvment_Comment { get; set; }
        public bool FourZeroFour { get; set; }
        [MaxLength(100)]
        public string FourZeroFour_Comment { get; set; }
        public bool Nationwide { get; set; }
        [MaxLength(100)]
        public string Nationwide_Comment { get; set; }
        public bool F_Individual { get; set; }
        [MaxLength(100)]
        public string F_Individual_Comment { get; set; }
        public bool USCG_Sec_9 { get; set; }
        [MaxLength(100)]
        public string USCG_Sec_9_Comment { get; set; }
        public bool USCG_Sec_10 { get; set; }
        [MaxLength(100)]
        public string USCG_Sec_10_Comment { get; set; }
        public bool Fed_Special_Use_Permit { get; set; }
        [MaxLength(100)]
        public string Fed_Special_Use_Permit_Comment { get; set; }
        public bool Noise { get; set; }
        [MaxLength(100)]
        public string Noise_Comment { get; set; }
        public bool Air_Quality { get; set; }
        [MaxLength(100)]
        public string Air_Quality_Comment { get; set; }
        public bool Haz_Waste { get; set; }
        [MaxLength(100)]
        public string Haz_Waste_Comment { get; set; }
        public bool Airport { get; set; }
        [MaxLength(100)]
        public string Airport_Comment { get; set; }
        public bool Mussel_Survey { get; set; }
        [MaxLength(100)]
        public string Mussel_Survey_Comment { get; set; }
        public bool Mussel_Relocation { get; set; }
        [MaxLength(100)]
        public string Mussel_Relocation_Comment { get; set; }
        public bool WVDOH_Special_Prov { get; set; }
        [MaxLength(100)]
        public string WVDOH_Special_Prov_Comment { get; set; }
        [MaxLength(20)]
        public string Perepared_By { get; set; }
        [MaxLength(20)]
        public string WV_DOH_Approved_By { get; set; }
        [Required]
        public bool FHWA_Approval { get; set; }
        [MaxLength(20)]
        public string FHWA_Approved_By { get; set; }
        [MaxLength(20)]
        public string Add_User { get; set; }
        public DateTime Date_Added { get; set; }

        public TypeTwo ToCompletedTypeTwo()
        {
            return new TypeTwo
            {
                ID = this.ID,
                State_Project_Number = this.State_Project_Number,
                Federal_Project_Number = this.Federal_Project_Number,
                Name = this.Name,
                Route_Number = this.Route_Number,
                County = this.County,
                Category = this.Category,
                ADT_Existing = this.ADT_Existing,
                ADT_Projected = this.ADT_Projected,
                Coordinates = this.Coordinates,
                Federal_Nexus = this.Federal_Nexus,
                Existing_Conditions = this.Existing_Conditions,
                Preferred_Alternatives = this.Preferred_Alternatives,
                Other_Alternatives = this.Other_Alternatives,
                Public_Involvement = this.Public_Involvement,
                Right_of_Way = this.Right_of_Way,
                Right_of_Way_Comments = this.Right_of_Way_Comments,
                Federal_Land = this.Federal_Land,
                Federal_Land_Comments = this.Federal_Land_Comments,
                Maintenance_of_Traffic = this.Maintenance_of_Traffic,
                Maintenance_of_Traffic_Comment = this.Maintenance_of_Traffic_Comment,
                Public_Controversy = this.Public_Controversy,
                Public_Controversy_Comment = this.Public_Controversy_Comment,
                History = this.History,
                History_Comment = this.History_Comment,
                H_Adverse_Effect = this.H_Adverse_Effect,
                H_Adverse_Effect_Comment = this.H_Adverse_Effect_Comment,
                Archaeology = this.Archaeology,
                Archaeology_Comment = this.Archaeology_Comment,
                A_Adverse_Effect = this.A_Adverse_Effect,
                A_Adverse_Effect_Comment = this.A_Adverse_Effect_Comment,
                US_Forest_Service = this.US_Forest_Service,
                US_Forest_Service_Comment = this.US_Forest_Service_Comment,
                US_Army_Corps_Eng = this.US_Army_Corps_Eng,
                US_Army_Corps_Eng_Comment = this.US_Army_Corps_Eng_Comment,
                National_Park_Service = this.National_Park_Service,
                National_Park_Service_Comment = this.US_Army_Corps_Eng_Comment,
                Wild_Scenic_River = this.Wild_Scenic_River,
                Wild_Scenic_River_Comment = this.Wild_Scenic_River_Comment,
                National_River = this.National_River,
                National_River_Comment = this.National_River_Comment,
                National_Wildlife_Refuge = this.National_Wildlife_Refuge,
                National_Wildlife_Refuge_Comment = this.National_Wildlife_Refuge_Comment,
                State_Park = this.State_Park,
                State_Park_Comment = this.State_Park_Comment,
                State_Wildlife_Management_Area = this.State_Wildlife_Management_Area,
                Other_Park = this.Other_Park,
                Other_Park_Comment = this.Other_Park_Comment,
                Historic_Property = this.Historic_Property,
                Historic_Property_Comment = this.Historic_Property_Comment,
                Park_Recreational = this.Park_Recreational,
                Park_Recreational_Comment = this.Park_Recreational_Comment,
                DE_Minimis = this.DE_Minimis,
                DE_Minimis_Comment = this.DE_Minimis_Comment,
                Programmatic = this.Programmatic,
                Prog_Comment = this.Prog_Comment,
                D_Individual = this.D_Individual,
                D_Individual_Comment = this.D_Individual_Comment,
                LWCFA = this.LWCFA,
                LWCFA_Comment = this.LWCFA_Comment,
                Temp_Change = this.Temp_Change,
                Temp_Change_Comment = this.Temp_Change_Comment,
                Conversion_of_Property = this.Conversion_of_Property,
                Conversion_of_Property_Comment = this.Conversion_of_Property_Comment,
                US_Fish_Wildlife = this.US_Fish_Wildlife,
                US_Fish_Wildlife_Comment = this.US_Fish_Wildlife_Comment,
                Formal_Consultation = this.Formal_Consultation,
                Formal_Consultation_Comment = this.Formal_Consultation_Comment,
                Division_Natural_Resources = this.Division_Natural_Resources,
                Division_Natural_Resources_Comment = this.Division_Natural_Resources_Comment,
                Floodplain_Enchroachment = this.Floodplain_Enchroachment,
                Floodplain_Enchroachment_Comment = this.Floodplain_Enchroachment_Comment,
                Farmland_Involvment = this.Farmland_Involvment,
                Farmland_Involvment_Comment = this.Farmland_Involvment_Comment,
                FourZeroFour = this.FourZeroFour,
                FourZeroFour_Comment = this.FourZeroFour_Comment,
                Nationwide = this.Nationwide,
                Nationwide_Comment = this.Nationwide_Comment,
                F_Individual = this.F_Individual,
                F_Individual_Comment = this.F_Individual_Comment,
                USCG_Sec_9 = this.USCG_Sec_9,
                USCG_Sec_9_Comment = this.USCG_Sec_9_Comment,
                USCG_Sec_10 = this.USCG_Sec_10,
                USCG_Sec_10_Comment = this.USCG_Sec_10_Comment,
                Fed_Special_Use_Permit = this.Fed_Special_Use_Permit,
                Fed_Special_Use_Permit_Comment = this.Fed_Special_Use_Permit_Comment,
                Noise = this.Noise,
                Noise_Comment = this.Noise_Comment,
                Air_Quality = this.Air_Quality,
                Haz_Waste = this.Haz_Waste,
                Haz_Waste_Comment = this.Haz_Waste_Comment,
                Airport = this.Airport,
                Airport_Comment = this.Airport_Comment,
                Mussel_Survey = this.Mussel_Survey,
                Mussel_Survey_Comment = this.Mussel_Survey_Comment,
                Mussel_Relocation = this.Mussel_Relocation,
                Mussel_Relocation_Comment = this.Mussel_Relocation_Comment,
                WVDOH_Special_Prov = this.WVDOH_Special_Prov,
                WVDOH_Special_Prov_Comment = this.WVDOH_Special_Prov_Comment,
                Perepared_By = this.Perepared_By,
                WV_DOH_Approved_By = this.WV_DOH_Approved_By,
                FHWA_Approval = this.FHWA_Approval,
                FHWA_Approved_By = this.FHWA_Approved_By,
                Add_User = this.Add_User,
                Date_Added = this.Date_Added,
            };
        }
    }
}
