using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace lab2Api.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Course = new HashSet<Course>();
        }

        [Key]
        [Column("Top_Id")]
        public int TopId { get; set; }
        [Column("Top_Name")]
        [StringLength(50)]
        public string TopName { get; set; }

        [InverseProperty("Top")]
       // [JsonIgnore]
        public virtual ICollection<Course> Course { get; set; }
    }
}
