using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PIM.ListadeEquipamentos;
using PIM.ListadeFuncionarios;
using PIM.ListadeSalas;
using PIM.Funcionarios;
using PIM.Cadastros;
using PIM.Locais;
using PIM.Notebooks;
using PIM.Projetores;
using PIM.Tablets;

namespace PIM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var funfun = new BasedeDadosFuncionarios();
            var cadastro = new Cadastro();
            var listasalas = new BasedeDadosSalas();
            var listaequipamentos = new BasedeDadosEquips();
            Console.WriteLine("Bem vindo ao sistema de agendamento do Colégio Vencer Sempre");
            Console.WriteLine("Informe o seu usuario: ");
            string user = Console.ReadLine();
            Console.WriteLine("Informe a sua senha: ");
            string password = Console.ReadLine();
            bool log = cadastro.Login(user, password);
            if (log == true)
            {
                int resposta1 = 0;
                while (resposta1 != 6)
                {

                    Console.WriteLine("Seja bem vindo!");
                    Console.WriteLine("");
                    Console.WriteLine("O que deseja fazer? 1 - Reservar Sala 2 - Reservar Equipamento 3 - Devolver Sala 4 - Devolver Equipamento 5 - Cadastros 6 - Sair");
                    resposta1 = int.Parse(Console.ReadLine());

                    switch (resposta1)
                    {
                        case 1:
                            if (listasalas.SalasLiberadas() >= 1)
                            {
                                var salas = listasalas.SalasdaEscola;
                                Console.WriteLine("Qual sala deseja reserva?");
                                Console.WriteLine(salas);
                                var sala1 = listasalas.SalasdaEscola.First(x => x.Id == 1);
                                Console.WriteLine(sala1.Id + " " + sala1.Sala);
                                Console.WriteLine("");
                                var sala2 = listasalas.SalasdaEscola.First(x => x.Id == 2);
                                Console.WriteLine(sala2.Id + " " + sala2.Sala);
                                Console.WriteLine("");
                                var sala3 = listasalas.SalasdaEscola.First(x => x.Id == 3);                               
                                Console.WriteLine(sala3.Id + " " + sala3.Sala);                               
                                Console.WriteLine("");
                                Console.WriteLine("4 Voltar");
                                int reservsala = int.Parse(Console.ReadLine());
                                switch (reservsala)
                                {
                                    case 1:
                                        var Sala1 = listasalas.SalasdaEscola.First(x => x.Id == 1);
                                        Sala1.Ocupada = true;
                                        listasalas.SalasdaEscola.Remove(Sala1);
                                        Console.WriteLine(Sala1.Sala + " agora está alugada!");
                                        break;

                                    case 2:
                                        var Sala2 = listasalas.SalasdaEscola.First(x => x.Id == 2);
                                        Sala2.Ocupada = true;
                                        listasalas.SalasdaEscola.Remove(Sala2);
                                        Console.WriteLine(Sala2.Sala + " agora está alugada!");
                                        break;

                                    case 3:
                                        var Sala3 = listasalas.SalasdaEscola.First(x => x.Id == 3);
                                        Sala3.Ocupada = true;
                                        listasalas.SalasdaEscola.Remove(Sala3);
                                        Console.WriteLine(Sala3.Sala + " agora está alugada!");
                                        break;

                                    case 4:
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lamento, mas todas as salas estão ocupadas... Aguarde algum professor desocupar");
                                break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Qual Equipamento deseja alugar? 1 - Notebooks 2 - Projetores 3 - Tablets 4 - Sair");
                            int resequips = int.Parse(Console.ReadLine());
                            switch (resequips)
                            {
                                case 1:
                                    if (listaequipamentos.EstoqueNotebooksLiberados() >= 1)
                                    {
                                        var notebook = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual notebook deseja reserva?");
                                        var notebook1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 1);
                                        Console.WriteLine(notebook1.Id + " " + notebook1.Modelo);
                                        var notebook2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 2);
                                        Console.WriteLine(notebook2.Id + " " + notebook2.Modelo);
                                        var notebook3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 3);
                                        Console.WriteLine(notebook3.Id + " " + notebook3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int reservnote = int.Parse(Console.ReadLine());
                                        switch (reservnote)
                                        {
                                            case 1:
                                                var Note1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 1);
                                                Note1.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(Note1);
                                                Console.WriteLine(Note1.Modelo + " agora está alugado!");
                                                break;

                                            case 2:
                                                var Note2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 2);
                                                Note2.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(Note2);
                                                Console.WriteLine(Note2.Modelo + " agora está alugado!");
                                                break;

                                            case 3:
                                                var Note3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 3);
                                                Note3.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(Note3);
                                                Console.WriteLine(Note3.Modelo + " agora está alugado!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lamento, mas todos os notebooks estão sendo usados... Aguarde algum professor desocupar");
                                        break;
                                    }
                                    break;

                                case 2:
                                    if (listaequipamentos.EstoqueProjetoresLiberados() >= 1)
                                    {
                                        var projetor = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual notebook deseja reserva?");
                                        var projetor1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 1);
                                        Console.WriteLine(projetor1.Id + " " + projetor1.Modelo);
                                        var projetor2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 2);
                                        Console.WriteLine(projetor2.Id + " " + projetor2.Modelo);
                                        var projetor3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 3);
                                        Console.WriteLine(projetor3.Id + " " + projetor3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int reservproj = int.Parse(Console.ReadLine());
                                        switch (reservproj)
                                        {
                                            case 1:
                                                var proj1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 1);
                                                proj1.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(proj1);
                                                Console.WriteLine(proj1.Modelo + " agora está alugado!");
                                                break;

                                            case 2:
                                                var proj2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 2);
                                                proj2.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(proj2);
                                                Console.WriteLine(proj2.Modelo + " agora está alugado!");
                                                break;

                                            case 3:
                                                var proj3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 3);
                                                proj3.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(proj3);
                                                Console.WriteLine(proj3.Modelo + " agora está alugado!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lamento, mas todos os projetores estão sendo usados... Aguarde algum professor desocupar");
                                        break;
                                    }
                                    break;

                                case 3:
                                    if (listaequipamentos.EstoqueTabletsLiberados() >= 1)
                                    {
                                        var tablet = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual tablet deseja reserva?");
                                        var tablet1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 1);
                                        Console.WriteLine(tablet1.Id + " " + tablet1.Modelo);
                                        var tablet2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 2);
                                        Console.WriteLine(tablet2.Id + " " + tablet2.Modelo);
                                        var tablet3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 3);
                                        Console.WriteLine(tablet3.Id + " " + tablet3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int reservtabl = int.Parse(Console.ReadLine());
                                        switch (reservtabl)
                                        {
                                            case 1:
                                                var tabl1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 1);
                                                tabl1.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(tabl1);
                                                Console.WriteLine(tabl1.Modelo + " agora está alugado!");
                                                break;

                                            case 2:
                                                var tabl2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 2);
                                                tabl2.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(tabl2);
                                                Console.WriteLine(tabl2.Modelo + " agora está alugado!");
                                                break;

                                            case 3:
                                                var tabl3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 3);
                                                tabl3.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Remove(tabl3);
                                                Console.WriteLine(tabl3.Modelo + " agora está alugado!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lamento, mas todos os tablets estão sendo usados... Aguarde algum professor desocupar");
                                        break;
                                    }
                                    break;


                                case 4:
                                    break;
                            }
                            break;

                        case 3:
                            if (listasalas.SalasOcupadas() >= 1)
                            {
                                var salas = listasalas.SalasdaEscola;
                                Console.WriteLine("Qual sala deseja devolver?");
                                var sala1 = listasalas.SalasdaEscola.First(x => x.Id == 1);
                                Console.WriteLine(sala1.Id + " " + sala1.Sala);
                                var sala2 = listasalas.SalasdaEscola.First(x => x.Id == 2);
                                Console.WriteLine(sala2.Id + " " + sala2.Sala);
                                var sala3 = listasalas.SalasdaEscola.First(x => x.Id == 3);
                                Console.WriteLine(sala3.Id + " " + sala3.Sala);
                                Console.WriteLine("4 Voltar");
                                int devolsala = int.Parse(Console.ReadLine());
                                switch (devolsala)
                                {
                                    case 1:
                                        var Sala1 = listasalas.SalasdaEscola.First(x => x.Id == 1);
                                        Sala1.Ocupada = false;
                                        listasalas.SalasdaEscola.Add(Sala1);
                                        Console.WriteLine(Sala1.Sala + " agora está devolvida!");
                                        break;

                                    case 2:
                                        var Sala2 = listasalas.SalasdaEscola.First(x => x.Id == 2);
                                        Sala2.Ocupada = false;
                                        listasalas.SalasdaEscola.Add(Sala2);
                                        Console.WriteLine(Sala2.Sala + " agora está devolvida!");
                                        break;

                                    case 3:
                                        var Sala3 = listasalas.SalasdaEscola.First(x => x.Id == 3);
                                        Sala3.Ocupada = false;
                                        listasalas.SalasdaEscola.Add(Sala3);
                                        Console.WriteLine(Sala3.Sala + " agora está devolvida!");
                                        break;

                                    case 4:
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não há sala para devolver");
                                break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("Qual Equipamento deseja devolver? 1 - Notebooks 2 - Projetores 3 - Tablets 4 - Sair");
                            int devolequips = int.Parse(Console.ReadLine());
                            switch (devolequips)
                            {
                                case 1:
                                    if (listaequipamentos.EstoqueNotebooksAlugados() >= 1)
                                    {
                                        var notebook = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual notebook deseja devolver?");
                                        var notebook1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 1);
                                        Console.WriteLine(notebook1.Id + " " + notebook1.Modelo);
                                        var notebook2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 2);
                                        Console.WriteLine(notebook2.Id + " " + notebook2.Modelo);
                                        var notebook3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 3);
                                        Console.WriteLine(notebook3.Id + " " + notebook3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int devolvnote = int.Parse(Console.ReadLine());
                                        switch (devolvnote)
                                        {
                                            case 1:
                                                var Note1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 1);
                                                Note1.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(Note1);
                                                Console.WriteLine(Note1.Modelo + " agora está devolvido!");
                                                break;

                                            case 2:
                                                var Note2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 2);
                                                Note2.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(Note2);
                                                Console.WriteLine(Note2.Modelo + " agora está devolvido!");
                                                break;

                                            case 3:
                                                var Note3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Notebook>().First(x => x.Id == 3);
                                                Note3.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(Note3);
                                                Console.WriteLine(Note3.Modelo + " agora está devolvido!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Todos os notebooks estão no estoque, não há nenhum para devolver");
                                        break;
                                    }
                                    break;

                                case 2:
                                    if (listaequipamentos.EstoqueProjetoresAlugados() >= 1)
                                    {
                                        var projetor = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual projetor deseja devolver?");
                                        var projetor1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 1);
                                        Console.WriteLine(projetor1.Id + " " + projetor1.Modelo);
                                        var projetor2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 2);
                                        Console.WriteLine(projetor2.Id + " " + projetor2.Modelo);
                                        var projetor3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 3);
                                        Console.WriteLine(projetor3.Id + " " + projetor3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int devolproj = int.Parse(Console.ReadLine());
                                        switch (devolproj)
                                        {
                                            case 1:
                                                var proj1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 1);
                                                proj1.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(proj1);
                                                Console.WriteLine(proj1.Modelo + " agora está devolvido!");
                                                break;

                                            case 2:
                                                var proj2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 2);
                                                proj2.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(proj2);
                                                Console.WriteLine(proj2.Modelo + " agora está devolvido!");
                                                break;

                                            case 3:
                                                var proj3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Projetor>().First(x => x.Id == 3);
                                                proj3.Alugado = false;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(proj3);
                                                Console.WriteLine(proj3.Modelo + " agora está devolvido!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Todos os projetores estão no estoque, não há nenhum para devolver");
                                        break;
                                    }
                                    break;

                                case 3:
                                    if (listaequipamentos.EstoqueTabletsAlugados() >= 1)
                                    {
                                        var tablet = listaequipamentos.EstoqueDeEquipamentos;
                                        Console.WriteLine("Qual tablet deseja devolver?");
                                        var tablet1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 1);
                                        Console.WriteLine(tablet1.Id + " " + tablet1.Modelo);
                                        var tablet2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 2);
                                        Console.WriteLine(tablet2.Id + " " + tablet2.Modelo);
                                        var tablet3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 3);
                                        Console.WriteLine(tablet3.Id + " " + tablet3.Modelo);
                                        Console.WriteLine("4 Voltar");
                                        int reservtabl = int.Parse(Console.ReadLine());
                                        switch (reservtabl)
                                        {
                                            case 1:
                                                var tabl1 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 1);
                                                tabl1.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(tabl1);
                                                Console.WriteLine(tabl1.Modelo + " agora está devolvido!");
                                                break;

                                            case 2:
                                                var tabl2 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 2);
                                                tabl2.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(tabl2);
                                                Console.WriteLine(tabl2.Modelo + " agora está devolvido!");
                                                break;

                                            case 3:
                                                var tabl3 = listaequipamentos.EstoqueDeEquipamentos.OfType<Tablet>().First(x => x.Id == 3);
                                                tabl3.Alugado = true;
                                                listaequipamentos.EstoqueDeEquipamentos.Add(tabl3);
                                                Console.WriteLine(tabl3.Modelo + " agora está devolvido!");
                                                break;

                                            case 4:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Todos os projetores estão no estoque, não há nenhum para devolver");
                                        break;
                                    }
                                    break;

                                case 4:
                                    break;
                            }
                            break;

                        case 5:
                            Console.WriteLine("Informe o seu código de função");
                            int codego = int.Parse(Console.ReadLine());
                            if (cadastro.TentativaAcesso(codego) == true)
                            {
                                Console.WriteLine("O que deseja fazer? 1 - Cadastrar 2 - Excluir 3 - Sair");
                                int cadastrar = int.Parse(Console.ReadLine());
                                switch (cadastrar)
                                {
                                    case 1:
                                        Console.WriteLine("Informe o usuario: ");
                                        string newuser = Console.ReadLine();
                                        Console.WriteLine("Informe a senha: ");
                                        string newpass = Console.ReadLine();
                                        var cadastramento = cadastro.Cadastrar(newuser, newpass);
                                        Console.WriteLine("Novo funcionário cadastrado com sucesso!");
                                        break;


                                    case 2:
                                        Console.WriteLine("Informe o usuario: ");
                                        string olduser = Console.ReadLine();
                                        var retirada = cadastro.Retirar(olduser);
                                        Console.WriteLine("Funcionário retirado com sucesso!");
                                        break;

                                    case 3:
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Você não tem acesso a essa função");
                                break;
                            }
                            break;
                    }
                };
            }
            else
                {
                    Console.WriteLine("Desculpa, você não é funcionário! Entre em contato com os Administradores.");
                    Console.ReadLine();
                }
        }
    }
}