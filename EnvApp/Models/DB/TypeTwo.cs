using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EnvApp.Models.DB
{
    [Table("Type_Two")]
    public class TypeTwo
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
    }
}
