using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace lab2Api.Models
{
    public partial class Course
    {
        [Key]
        [Column("Crs_Id")]
        public int CrsId { get; set; }
        [Column("Crs_Name")]
        [StringLength(50)]
        public string CrsName { get; set; }
        [Column("Crs_Duration")]
        public int? CrsDuration { get; set; }
        [Column("Top_Id")]
        public int? TopId { get; set; }

        [ForeignKey(nameof(TopId))]
        [InverseProperty(nameof(Topic.Course))]
        public virtual Topic Top { get; set; }
    }
}
