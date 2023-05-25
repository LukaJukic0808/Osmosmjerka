using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagradniZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int i, j;
            int k;
            int z;
            bool flag = false;
            string dimensions = "";
            Console.WriteLine("Unesi dimenzije osmosmjerke (nijedna dim. manja od 2 i veca od 100!) (razmak dimenzija razmak dimenzija).");
            do
            {
                dimensions = Console.ReadLine();
                string[] dimensionsplit = dimensions.Split(' ');
                m = Convert.ToInt32(dimensionsplit[1]);
                n= Convert.ToInt32(dimensionsplit[2]);

                if (m < 2 || m > 100 || n < 2 || n > 100)
                    Console.WriteLine("Neispravan unos, ponovi unos obje vrijednosti!");




            } while (m < 2 || m > 100 || n < 2 || n > 100);

           
            

            string[,] polje = new string[m, n];
            string[,] poljecopy = new string[m, n];
            string []Entry = new string[m];
           
            Console.WriteLine("Unesi polje po pravilu:SLOVO RAZMAK SLOVO RAZMAK SLOVO RAZMAK... ENTER(kraj retka)");
            for (i = 0; i < m; i++)
            {
                Entry[i] = Console.ReadLine();
                string [] Dividor = Entry[i].Split(' ');

                for (j = 0; j < n; j++)
                {
                    if (j > (Dividor.Length - 1))
                        break;
                    polje[i,j] = Dividor[j];
                    poljecopy[i, j] = polje[i, j];
                }
            }
            

            Console.WriteLine("Unesi broj rijeci.");
            do
            {
                k = Convert.ToInt32(Console.ReadLine());
            } while (k < 1 || k > 100);
            string[]rijeci = new string[k];

            Console.WriteLine("Unesi rijeci.");
            for (i = 0; i < k; i++) 
                rijeci[i] = Console.ReadLine();

            
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (z = 0; z < k; z++)
                    {
                        functions.Up(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.UpRight(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.UpLeft(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.Right(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.Left(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.DownLeft(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.DownRight(polje, i, j, rijeci[z], poljecopy,m,n);
                        functions.Down(polje, i, j, rijeci[z], poljecopy,m,n);
                    }
                    
                }
            }

            Console.WriteLine("");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (poljecopy[i, j] != "0")
                    {
                        flag = true;
                        Console.Write(polje[i, j]);
                        
                    }
                }
            }

            if (!flag) {
                Console.WriteLine("-");
            }

            Console.ReadLine();
        }
    }
}
