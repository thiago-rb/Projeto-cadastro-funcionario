using CadastroDeFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaRegistro sistema = new SistemaRegistro();

            Console.WriteLine("Bem vindo ao sistema de registros de funcionarios");

            while (true)
            {
                Console.WriteLine("1 - Registrar funcionario");
                Console.WriteLine("2 - Remover registro");
                Console.WriteLine("3 - Listar registros");
                Console.WriteLine("4 - Fechar programa");
                Console.Write("Escolha a opção: ");
                string escolha = Console.ReadLine();
                Console.WriteLine();

                switch (escolha)
                {
                    case "1":
                        sistema.AdicionarRegistro();
                        break;

                    case "2":
                        sistema.RemoverRegistro();
                        break;

                    case "3":
                        sistema.ListaRegistro();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
