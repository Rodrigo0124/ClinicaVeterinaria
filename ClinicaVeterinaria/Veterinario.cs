using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVeterinaria
{
    public class Veterinario
    {
        public string Nome { get; set; }
        public string Especialidade { get; private set; }

        public Veterinario(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}