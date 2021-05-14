using System;

namespace _13._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoArrays = 2;
            string[] nome = new string[tamanhoArrays];
            double[] preco = new double[tamanhoArrays];
            bool[] promocao = new bool[tamanhoArrays];
            bool menu = false;
            bool novprod = false;
            int c = 0;

            do
            {
                Console.WriteLine($@"
|-------------------------------------------------------------------------------|
|                                Meunu Principal                                |
|-------------------------------------------------------------------------------|
|                                                                               |
|      1- Cadastrar Produto        2- Listar Produtos          0- Sair          |  
|-------------------------------------------------------------------------------|

Escolha uma opção:");

                int menus = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (menus)
                {
                    case 1:
                        if (c < tamanhoArrays)
                        {
                            do
                            {
                                Console.Write("Qual é o nome do Produto: ");
                                nome[c] = Console.ReadLine().ToUpper();

                                Console.Write("Qual é o Preço: ");
                                preco[c] = double.Parse(Console.ReadLine());

                                Console.Write("O produto esta em promoção? (S/N) ");
                                string prom = Console.ReadLine().ToUpper();

                                if (prom == "S")
                                {
                                    Console.WriteLine("Seu produto está em promoçao");
                                    promocao[c] = true;
                                }
                                else
                                {
                                    Console.WriteLine("Não está em promoçao");
                                    promocao[c] = false;
                                }

                                c++;

                                Console.WriteLine("Gostaria de cadastrar uma nova produto?(S/N) Maximo 10 Produto");
                                string cotpas = Console.ReadLine().ToUpper();
                                if (cotpas == "S")
                                {
                                    novprod = false;
                                }
                                else
                                {
                                    novprod = true;
                                }


                            } while (novprod == false);

                            Console.WriteLine("Aperte 'M' para voltar ao Menu");
                            string voltmenu = Console.ReadLine().ToUpper();

                            if (voltmenu == "M")
                            {
                                menu = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ja foram cadastrado os 10 produtos");
                            menu = false;
                        }

                        break;

                    case 2:
                        Console.WriteLine($@"
|--------------------------------------------------------------|
|        1-Nome           2-Preço          3-Promoção          |
|--------------------------------------------------------------|");
                        for (var i = 0; i < c; i++)
                        {
                            Console.WriteLine($@"|    {i + 1}º    {nome[i]}    -    {preco[i]}    -    {promocao[i]}    |");
                        }
                        Console.WriteLine("|--------------------------------------------------------------|");

                        Console.WriteLine("Aperte 'M' para voltar ao Menu");
                        string voltmen = Console.ReadLine().ToUpper();

                        if (voltmen == "M")
                        {
                            menu = false;
                        }
                        break;

                    case 0:
                        Console.WriteLine("Você saiu :)");
                        menu = true;
                        break;

                    default:
                        Console.WriteLine("Opção não esta valida, tente novamente:");
                        menu = false;
                        break;

                }


            } while (menu == false);

        }
    }
}
