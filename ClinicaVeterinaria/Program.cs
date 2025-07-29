using ClinicaVeterinaria;
using System;

namespace ClinicaVeterinaria
{

    class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo a nossa clinica veterinaria! Por favor, insira os seus dados e o de seu pet!");
            Console.Write("Nome do tutor: ");
            string nome = Console.ReadLine();

            Console.Write("Idade do tutor: ");
            string entrada = Console.ReadLine();
            int idade;
            while (!(int.TryParse(entrada, out idade)) || idade < 18 || idade > 110)
            {
                if (idade < 18)
                {
                    Console.WriteLine("Não podemos cadastrar menor de idade, por favor chamar um responsável!");
                    Environment.Exit(0);

                }
                Console.WriteLine("Dados inválidos! Por favor inserir a sua idade corretamente: ");

                entrada = Console.ReadLine();
            }
            Console.Write("Gênero do tutor: ");
            string genero = Console.ReadLine();

            Dono tutor = new Dono(nome, idade, genero);

            Console.Write("Nome do pet: ");
            string nomePet = Console.ReadLine();
            Console.Write("Animal: ");
            string animal = Console.ReadLine();
            Console.Write("Raça: ");
            string raca = Console.ReadLine();
            Console.Write("Idade: ");
            entrada = Console.ReadLine();

            while (!(int.TryParse(entrada, out idade)))
            {
                Console.Write("Dados inválidos! Por favor inserir a idade do seu pet corretamente: ");
                entrada = Console.ReadLine();
            }

            Pet ani = new Pet(nomePet, animal, raca, idade);
            Console.WriteLine();
            Console.WriteLine($"{tutor}\n{ani}");

            Veterinario vet = new Veterinario("Rogerio", "Cachorro");
            Veterinario vet2 = new Veterinario("Flávio", "Gato");

            if (ani.Especie.Equals("cachorro", StringComparison.OrdinalIgnoreCase))
            {
                Consulta con = new Consulta(tutor, ani, vet);
                con.DetalhesConsulta();
            }
            else if (ani.Especie.Equals("gato", StringComparison.OrdinalIgnoreCase))
            {
                Consulta con = new Consulta(tutor, ani, vet2);
                con.DetalhesConsulta();
            }
            else
            {
                Console.WriteLine("\nPerdão, mas não temos profissionais especializados para o seu/sua " + ani.Especie);
            }



        }

    }



}