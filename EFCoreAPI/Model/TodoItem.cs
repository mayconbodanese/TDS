using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAPI.Model
{
    public class TodoItemModel
    {
        [Key]
        public long TodoItemID { get; set; }
        public string? Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}