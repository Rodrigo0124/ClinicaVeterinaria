using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVeterinaria
{
    public class Dono
    {
        public string Nome { get; set; }
        public int Idade { get; private set; }
        public string Genero { get; private set; }

        public Dono(string nome, int idade, string genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"Seja bem-vindo(a) {Nome} á nossa clínica Aumigão!";
        }
    }
}