using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Task.Data.Models
{
    public class Task : IAuditableFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public DateTime CreatedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
