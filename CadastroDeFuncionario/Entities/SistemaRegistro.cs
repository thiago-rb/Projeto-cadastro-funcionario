using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CadastroDeFuncionario.Entities
{
    internal class SistemaRegistro
    {
        static List<Funcionario> funcionarios = new List<Funcionario> ();

        public void AdicionarRegistro()
        {
            Console.Write("Insira o nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.Write($"Insira a idade do funcionario {nome}: ");
            int idade;
            if (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Idade inválida. Cadastro não adicionado.");
                return;
            }
            Console.Write($"Insira o cargo do funcionario {nome}: ");
            string cargo = Console.ReadLine();
            Console.Write($"Insira o salário do funcionario {nome}: ");
            double salario = double.Parse(Console.ReadLine());

            Funcionario novofuncionario = new Funcionario { Nome = nome, Idade = idade, Cargo = cargo, Salario = salario };
            funcionarios.Add(novofuncionario);

            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine();
        }

        public void RemoverRegistro()
        {
            Console.Write("Insira o nome do funcionario que deseja remover: ");
            string nomeRemove = Console.ReadLine();

            Funcionario funcionarioRemove = funcionarios.Find(c => c.Nome == nomeRemove);

            if (funcionarioRemove != null)
            {
                funcionarios.Remove(funcionarioRemove);
                Console.WriteLine($"Registro do funcionario {nomeRemove} removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Registro {nomeRemove} não encontrado");
            }
        }

        public void ListaRegistro()
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum registro encontrado");
            }
            else
            {
                Console.WriteLine("Lista de registros: ");
                foreach (Funcionario func in funcionarios)
                {
                    Console.WriteLine(func);
                }

            }
            Console.WriteLine();
        }
    }
}
