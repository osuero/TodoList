using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Task.Data.Models
{
    public interface IAuditableFields
    {
       DateTime CreatedTime { get; set; }
       DateTime UpdatedTime { get; set; } 
    }
}
