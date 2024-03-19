using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAPI.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

        }

        public DbSet<TodoItemModel> TodoItems { get; set; }// = null!;
    }
}