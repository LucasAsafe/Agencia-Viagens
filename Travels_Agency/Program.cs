using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels_Agency
{
    class Program
    {

        static void Main(string[] args)
        {


            Cliente Cliente1 = new Cliente("Luiz Gonzaga", "3469-1245", "Rua Lata de coca nº 010", "72.356.907", "453.617.573-25");
            Cliente Cliente2 = new Cliente("Silvio Santos", "9874-2341", "Rua Batons nº 001", "23.54.211", "348.978.092-7");
            Cliente Cliente3 = new Cliente("Roberto Carlos", "9080-0257", "Edificio Morada do Samsunga nº 0101 ", "45.678.194", "234.567.195-2");
            Cliente Cliente4 = new Cliente("Luciano Do Vale", "3412-6725", "Rua 2º Lua nº 110 ", "3.424.637", "231.124.355-54");
            Cliente Cliente5 = new Cliente("Fleur Vontreau Paci", "2247-3489", "Rua A Da Esperança nº 1000", "23.151.343", "123.954.764-57");
            Cliente Cliente6 = new Cliente("José Campos Braga Leitão ", "2132-7861", "Edificio Gringosos nº 0001", "12.854.64", "123.386.935-9");
            Cliente Cliente7 = new Cliente("Ana Maria Comooro", "3498-2312", "Rua Flauta de João Grilo nº 7894", "11.010.352", "241.423.523-12");
            Cliente Cliente8 = new Cliente("Mauricio Barcelos Alcantara", "2312-7654", "Edificio BigBang nº 111 ", "10.020.234", "342.324.55-89");
            Cliente Cliente9 = new Cliente("Franciscreito Alcantara de Pinto", "8803-4512", "Edificio Hogsmeade nº 010", "34.623.342", "23.535.974-45");
            Cliente Cliente10 = new Cliente("Antonio Camara Panibalde ", "2151-2357", "Edificio Hogsmeade nº 010", "49.302.465", "37.020.349-90");




            String Searchar = "Buscar";
            String Logar = "Login";
            String Cadastrinho = "Cadastrar";

            Console.WriteLine("                        " +
                "CVC agencia de viagens" + "\n\n\nPara entrar no sistema de busca digite: Buscar;"
                + "\nPara entrar com sua conta digite: Login; "
                + "\nSe ainda não for cliente digite para ser já um cliente Cadastrar.");

            String Entrada = Console.ReadLine();



            if (Entrada == Cadastrinho)
            {
                Console.Beep(1056, 250); Console.Beep(2080, 500);
                Console.WriteLine("                        " + "Você está no sistema de criação de conta!");
                Console.WriteLine("Digite nome de usuario *(campo obrigatorio).");
                String nome = Console.ReadLine();
                Console.WriteLine(nome +" Digite seu telefone *(campo obrigatorio).");
                String telefone = Console.ReadLine();
                Console.WriteLine(nome +" Digite seu endereço *(campo obrigatorio).");
                String endereço = Console.ReadLine();
                Console.WriteLine(nome +" Digite seu RG *(campo obrigatorio).");
                String RG = Console.ReadLine();
                Console.WriteLine(nome + " Digite seu CPF *(campo obrigatorio).");
                String CPF = Console.ReadLine();
                Cliente usuario = new Cliente(nome, telefone, endereço, RG, CPF);
                Console.WriteLine("Confira seus dados " + nome + endereço + RG + CPF);
                DateTime usuariando = DateTime.Now;
                Console.WriteLine(usuariando);
                Console.WriteLine("Digite voltar para voltar para o menu principal  ");
                String Voltando = Console.ReadLine();
                String voltar = "voltar";

                
                
                if (Voltando == voltar)
                {
                    Console.Clear();
                }
            }

            if (Entrada == Logar)
            {
                Console.Beep(1056, 250);
                Console.WriteLine("                        " + "Você está no sistema de login!");
                Console.WriteLine("Digite seu nome de usuario.");
                String nome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF.");
                String CPF = Console.ReadLine();
                if (true)
                {

                }


            }

            if (Entrada == Searchar)
            {
                Console.WriteLine("Estamos carregando o sistema,aguarde um pouco");
                Console.Beep(658, 125); Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500);
                

                Console.WriteLine("                        " + "Você está no sistema de busca!" +
                    "\n\nDigite agora o que você deseja buscar." +
                    "\nViagens para buscar por viagens e para clientes digite Clientes.");

                string Searchar1 = "Viagens";
                String Searchar2 = "Clientes";
                String Palavrachave = Console.ReadLine();

                if (Palavrachave == Searchar1)
                {
                    int opc = 0;
                    Console.WriteLine("Bem vindo a agência de viagens e turismos CVC");

                    Console.WriteLine("Para onde você deseja viajar? Prossiga clicando ENTER para ver suas opções!");

                    Console.WriteLine("1- Cancún");

                    Console.WriteLine("2- Aspen");

                    Console.WriteLine("3- San Andres");

                    Console.WriteLine("4- Pequim");

                    Console.WriteLine("5- Tel Aviv");

                    Console.WriteLine("6- Bahamas");

                    Console.WriteLine("7- Viena");

                    Console.WriteLine("8- Machu Picchu");

                    Console.WriteLine("Qual o destino escolhido? ");

                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu Cancún, um dos principais destinos do mundo, une o melhor do México com a beleza incomparável do Caribe. Dispõe de excelente localização geográfica, clima agradável o ano todo e paisagens extasiantes.");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aerea + Hospedagem + passeios turísticos,TOTAL:R$6,700,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu  Aspen,Considerada um dos principais destinos de inverno do mundo, Aspen, no centro-oeste americano, está rodeada de montanhas. Mas ao contrário do que muitos imaginam, a região não faz sucesso apenas durante as nevascas.");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aerea + Hospedagem + passeios turísticos,TOTAL:R$8.880,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;

                        case 3:
                            Console.WriteLine("Você escolheu San Andres,Praias paradisíacas, temperatura agradável, águas cristalinas e atmosfera festiva. Seja bem-vindo a San Andrés! Não bastasse ser banhada pelo magnífico mar caribenho, a cidade colombiana reserva programas e passeios convidativos, contagiando o turista.");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem de Navio + Hospedagem + passeios turísticos,TOTAL:R$7.550,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu Pequim,Poucos minutos percorrendo as ruas de Pequim proporcionam uma empolgante viagem no tempo. A capital e maior cidade da China foi totalmente remodelada para os Jogos Olímpicos de 2008, abrindo caminho ao progresso, sem perder suas raízes.");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aera + Hospedagem + passeios turísticos,TOTAL:R$6.890,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 5:
                            Console.WriteLine("Você escolheu Tel Aviv,Não são apenas Nova York e São Paulo as donas do título de regiões que nunca dormem. Tel Aviv também integra tal lista. Sem grandes templos religiosos, comum em Israel, tornou-se referência cultural graças as suas cobiçadas atrações noturnas disputadas por turistas de todo o mundo.");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aerea + Hospedagem + passeios turísticos,TOTAL:R$5.789,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 6:
                            Console.WriteLine("Você escolheu Bahamas,O arquipélago responsável pela formação das Bahamas abriga ao longo de seu extenso litoral algumas das águas mais transparentes do Caribe. Tal privilégio rendeu o título de Meca do mergulho, atividade preferida dos milhares de turistas interessados em descobrir os encantos do oceano. ");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagens de Navio + Hospedagem + passeios turísticos,TOTAL:R$8.958,80");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 7:
                            Console.WriteLine("Você escolheu Viena, um dos pólos culturais mais importantes da Europa e do mundo, é o berço de renomados compositores e maestros da música erudita, entre eles Mozart, Beethoven e Schubert. E não para por aí! A majestosa arquitetura dos palácios, igrejas e edifícios históricos espraiados pelas ruas vienenses, tornam esse destino turístico ainda mais cativante. ");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aerea + Hospedagem + passeios turísticos,TOTAL:R$10.769,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                        case 8:
                            Console.WriteLine("Você escolheu  Machu Picchu, no coração dos Andes peruano está a cidade mais enigmática de todo o mundo. Cercada de teorias e incertezas, Machu Picchu atrai milhões de aventureiros todos os anos em busca de vibrações positivas, arquitetura intrigante e beleza natural ");
                            Console.ReadLine();
                            Console.WriteLine("Se você deseja saber o orçamento para esta viagem,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Orçamento: Passagem Aerea + Hospedagem + passeios turísticos,TOTAL:R$8.990,00");
                            Console.WriteLine("Deseja comprar o pacote?Se sim,click ENTER");
                            Console.ReadLine();
                            Console.WriteLine("Obrigado por sua preferência!Boa Viagem!");
                            break;
                }

                if (Palavrachave == Searchar2)
                {
                    
                    Console.Beep();
                    Console.WriteLine("                    " +
                        "Você está no sistema de busca por clientes cadastrados!" + "\nPor favor digite agora o CPF de usuario.");

                    string Acharcliente = Console.ReadLine();
                    switch (Acharcliente)
                    {
                        case "453.617.573-25":
                            Console.WriteLine("\nNome: " + Cliente1.nome + "\nFone: " + Cliente1.telefone +
                                "\nEndereço: " + Cliente1.endereço + "\nRG: " + Cliente1.RG  + ".");
                            break;
                        case "348.978.092-7":
                            Console.WriteLine("\nNome: " + Cliente2.nome + "\nFone: " + Cliente2.telefone +
                                "\nEndereço: " + Cliente2.endereço + "\nRG: " + Cliente2.RG  + ".");
                            break;
                        case "234.567.195-2":
                            Console.WriteLine("\nNome: " + Cliente3.nome + "\nFone: " + Cliente3.telefone +
                                "\nEndereço: " + Cliente3.endereço + "\nRG: " + Cliente3.RG + ".");
                            break;
                        case "231.124.355-54":
                            Console.WriteLine("\nNome: " + Cliente4.nome + "\nFone: " + Cliente4.telefone +
                                "\nEndereço: " + Cliente4.endereço + "\nRG: " + Cliente4.RG  + ".");
                            break;
                        case "123.954.764-57":
                            Console.WriteLine("\nNome: " + Cliente5.nome + "\nFone: " + Cliente5.telefone +
                                "\nEndereço: " + Cliente5.endereço + "\nRG: " + Cliente5.RG  + ".");
                            break;
                        case "123.386.935-9":
                            Console.WriteLine("\nNome: " + Cliente6.nome + "\nFone: " + Cliente6.telefone +
                                "\nEndereço: " + Cliente6.endereço + "\nRG: " + Cliente6.RG  + ".");
                            break;
                        case "241.423.523-12":
                            Console.WriteLine("\nNome: " + Cliente7.nome + "\nFone: " + Cliente7.telefone +
                                "\nEndereço: " + Cliente7.endereço + "\nRG: " + Cliente7.RG + ".");
                            break;
                        case "342.324.55-89":
                            Console.WriteLine("\nNome: " + Cliente8.nome + "\nFone: " + Cliente8.telefone +
                                "\nEndereço: " + Cliente8.endereço + "\nRG: " + Cliente8.RG  + ".");
                            break;
                        case "23.535.974-45":
                            Console.WriteLine("\nNome: " + Cliente9.nome + "\nFone: " + Cliente9.telefone +
                                "\nEndereço: " + Cliente9.endereço + "\nRG: " + Cliente9.RG  + ".");
                            break;
                        case "37.020.349-90":
                            Console.WriteLine("\nNome: " + Cliente10.nome + "\nFone: " + Cliente10.telefone +
                                "\nEndereço: " + Cliente10.endereço + "\nRG: " + Cliente10.RG  + ".");
                            break;
                        default:
                            Console.WriteLine("\nAviso: Usuario não cadastrado.");
                            break;
                    }
                }

                



                }

            }
        }
    }
}
