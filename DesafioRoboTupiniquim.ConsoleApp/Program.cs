namespace DesafioRoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  ROBÔ TUPINIQUIM ");
            Console.ResetColor();
            Console.WriteLine();


            Console.WriteLine("Digte a posição inicial de x: ");

            int gridx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição inicial de y: ");

            int gridy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digte a posição inicial de x: ");

            int posinicialx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digte a posição inicial de y: ");

            int posinicialy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a direção do robô em (N) (S) (L) (O): ");

            char direcao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira instruções: ");

            string comando = Console.ReadLine();

            char[] comandochar = comando.ToCharArray();

            for (int i = 0; i < comando.Length; i++)
            {
                if (comandochar[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posinicialy++;
                    }
                    else if (direcao == 'S')
                    {
                        posinicialy--;
                    }
                    else if (direcao == 'L')
                    {
                        posinicialx++;
                    }
                    else if (direcao == 'O')
                    {
                        posinicialx--;
                    }
                }
                else if (comandochar[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }
                else if (comandochar[i] == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"POSIÇÃO INICIAL X {posinicialx} , POSIÇÃO INICIAL Y {posinicialy} , DIREÇÃO {direcao}\n");

            //ROBO 2

            Console.WriteLine("Digte a posição inicial de x: ");

            int posinicialx2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digte a posição inicial de y: ");

            int posinicialy2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a direção do robô em (N) (S) (L) (O): ");

            char direcao2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira instruções");

            string comando2 = Console.ReadLine();

            char[] comandochar2 = comando2.ToCharArray();

            for (int i = 0; i < comando2.Length; i++)
            {
                if (comandochar2[i] == 'M')
                {
                    if (direcao2 == 'N')
                    {
                        posinicialy2++;
                    }
                    else if (direcao2 == 'S')
                    {
                        posinicialy2--;
                    }
                    else if (direcao2 == 'L')
                    {
                        posinicialx2++;
                    }
                    else if (direcao2 == 'O')
                    {
                        posinicialx2--;
                    }
                }
                else if (comandochar2[i] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }
                }

                else if (comandochar2[i] == 'D')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"POSIÇÃO INICIAL X {posinicialx2} , POSIÇÃO INICIAL Y {posinicialy2} , DIREÇÃO {direcao2}");
            Console.ReadLine();
        }
    }
}