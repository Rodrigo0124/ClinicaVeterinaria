using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaVeterinaria
{
    public class Pet
    {


        public string NomePet
        {
            get; set;
        }
        public string Especie
        {
            get; private set;
        }
        public string Raca
        {
            get; private set;
        }
        public int Idade { get; private set; }

        public Pet(string nomepet, string especie, string raca, int idade)
        {

            NomePet = nomepet;
            Especie = especie;
            Raca = raca;
            Idade = idade;
        }



        public override string ToString()
        {
            return $"Conforme os dados solicitados, você tem um(a) {Especie} chamado {NomePet} da Raça {Raca} de {Idade} anos.";
        }
    }
}