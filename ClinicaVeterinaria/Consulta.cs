using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVeterinaria
{
    public class Consulta
    {
        public Dono Tutor { get; set; }
        public Pet Mascote { get; set; }
        public Veterinario Veterinario { get; set; }

        public Consulta(Dono tut, Pet mas, Veterinario vet)
        {
            Tutor = tut;
            Mascote = mas;
            Veterinario = vet;
        }

        public void DetalhesConsulta()
        {
            Console.WriteLine("\nDetalhes da consulta: \n");
            Console.WriteLine($" Nome do tutor: {Tutor.Nome}\n Nome do pet: {Mascote.NomePet}\n Espécie: {Mascote.Especie}\n Raça: {Mascote.Raca}\n Idade: {Mascote.Idade}\n");
            Console.Write("Veterinário responsável: " + Veterinario.Nome);
            Console.WriteLine($"\nEspecialidade: {Veterinario.Especialidade}");

        }
    }
}