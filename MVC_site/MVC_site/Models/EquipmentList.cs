using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_site.Models
{
    [Table("EquipmentList")]
    public class EquipmentList
    {
        [Key]
        public string equipmentId { get; set; }
        [StringLength(150)]
        public string EquipmentType { get; set; }
        [StringLength(150)]
        public string EquipmentLocation { get; set; }
        [StringLength(150)]
        public string EquipmentCondition { get; set; }
    }
}