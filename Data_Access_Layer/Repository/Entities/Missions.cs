﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository.Entities
{

    public class MissionApplication
    {
        public int Id { get; set; }
        public string MissionTitle { get; set; }
        public int MissionId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? AppliedDate { get; set; }
        public int Sheet { get; set; }
        public String Status { get; set; }
  
    }
    public class Missions
    {
        public int Id { get; set; }
        public string MissionTitle { get; set; }
        public string MissionDescription { get; set; }
        public string MissionOrganizationName { get; set; }
        public string MissionOrganizationDetail { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        public string MissionType { get; set; }
        public int? TotalSheets { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegistrationDeadLine { get; set; }
        public string MissionThemeId { get; set; }
        public string MissionSkillId { get; set; }
        public string MissionImages { get; set; }
        public string MissionDocuments { get; set; }
        public string MissionAvilability { get; set; }
        public string MissionVideoUrl { get; set; }

        [NotMapped]
        public string CountryName { get; set; }
        [NotMapped]
        public string CityName { get; set; }
        [NotMapped]
        public string MissionThemeName { get; set; }
        [NotMapped]
        public string MissioSkillName { get; set; }
        [NotMapped]
        public string MissionStatus { get; set; }
        [NotMapped]
        public string MissionApplyStatus { get; set; }
        [NotMapped]
        public string MissionApproveStatus { get; set; }
        [NotMapped]
        public string MissionDateStatus { get; set; }
        [NotMapped]
        public string MissionDeadLineStatus { get; set; }
        [NotMapped]
        public string MissionFavouriteStatus { get; set; }

    }

    public class SortestData
    {
        public int UserId { get; set; }
        public string SortestValue { get; set; }
        public int MissionId { get; set; }
    }
}
