using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Voxus.Teste.Models
{
    public class contexto : DbContext
    {
        public DbSet<tarefas> Tasks
        {
            get; set;
        }
    }
}