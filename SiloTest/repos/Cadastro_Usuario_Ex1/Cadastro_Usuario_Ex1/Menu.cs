using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Cadastro_Usuario_Ex1
{
    class Menu
    {
        public static void MontaMenu()
        {
            //cabeçalho
            Cabeçalho();
            //opções
            opcoes();
            //rodape
            rodape();
            //escoha
            escolha();
        }

        private static void escolha()
        {
           
            int opcao = 0;
            do
            {
                opcao = Validacao.ValidaInteiros();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau\nAperte qualquer botão para sair ");
                        Console.ReadLine();
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios = new List<Usuario>();
                        do
                        {
                            Console.WriteLine("Digite seu nome");
                            string nome = Validacao.ValidaStringEmBranco();
                            Console.WriteLine("Digite seu sobrenome");
                            string sobrenome = Validacao.ValidaStringEmBranco();
                            Console.WriteLine("Digite sua idade");
                            int idade = Validacao.ValidaInteiros();
                            Console.WriteLine("Digite seu e-mail");
                            string email = Validacao.ValidaStringEmBranco();
                            Console.WriteLine("digite seu endereço");
                            string endereco = Validacao.ValidaStringEmBranco();
                            
                            Usuario user = new Usuario(nome, sobrenome, idade, email, endereco);
                            Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                            resposta = Console.ReadLine();
                            usuarios.Add(user);
                        } while (resposta == "y");

                        //Usuario userSelect1 = usuarios.FirstOrDefault(u => u.nome.Equals("Chimbinha"));
                        //Usuario userSelect2 = (from u in usuarios where u.nome == "Chimbinha" select u).FirstOrDefault();
                        
                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($"Seus dados são:\n nome: {item.Nome.ToLower()}\n sobrenome: {item.Sobrenome.ToLower()}\n idade: {item.Idade}\n email: {item.Email.ToLower()}\n endereço: {item.Endereco.ToLower()}\n");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Em implementação (falta dev)\nAperte qualquer botão para sair");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção invalida! Digite 0,1,2");
                        break;

                }
            } while (opcao < 0 || opcao > 2);

        }

        private static void rodape()
        {
            Console.WriteLine("\n********************************************");
            Console.WriteLine("Escolha um das opções no menu.");
            Console.WriteLine("********************************************");
        }

        private static void opcoes()
        {

            Console.WriteLine("1-Cadastrar Usuário");
            Console.WriteLine("2-Editar Usuário");
            Console.WriteLine("0-Sair do programa");
        }

        private static void Cabeçalho()
        {
            Console.WriteLine("**************** Havan Labs ****************");
            Console.WriteLine("**************** Bem vindo *****************\n");
        }
    }
}
