using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.Data
{
    public class EscolaDatabase
    {
        public List<Escola> Escolas { get; set; }

        public EscolaDatabase()
        {
            Escolas = new List<Escola>();
        }

    }
}
