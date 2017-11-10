using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Voxus.Teste.Models
{
    public class tarefas
    {
        [Key]
        public int Codigo
        {
            get; set;
        }
        public string Nome_da_task
        {
            get; set;
        }
        public string Descricao
        {
            get; set;
        }
        public string Nome_do_usuario
        {
            get; set;
        }
        public int Prioridade
        {
            get; set;
        }
        public bool Concluido
        {
            get; set;
        }
        public string Concluido_por
        {
            get; set;
        }
    }
}