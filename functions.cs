using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagradniZadatak
{
    class functions
    {


        public static void Up(string [,]polje, int i,int j,string rijec,string [,]poljecopy,int x, int y)
        {
            string check = "";
            int m;
            int c=0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i - m < 0)
                    break;
                check += polje[i - m, j];
                if (check == rijec)
                {
                    c = rijec.Length - (m+1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i - m < 0)
                        break;
                    poljecopy[i - m, j] = "0";
         
                }
            }
        }
        public static void UpRight(string[,] polje, int i, int j, string rijec, string[,] poljecopy,int x,int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i - m < 0 || j + m > y - 1)
                    break;
                check += polje[i - m, j+m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i - m < 0 || j + m > y - 1)
                        break;
                    poljecopy[i - m, j+m] = "0";

                }
            }
        }

        public static void UpLeft(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i - m < 0 || j - m < 0)
                    break;
                check += polje[i - m, j-m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i - m < 0 || j - m < 0)
                        break;
                    poljecopy[i - m, j-m] = "0";

                }
            }
        }

        public static void Left(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (j - m < 0)
                    break;
                check += polje[i, j-m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (j - m < 0)
                        break;
                    poljecopy[i, j-m] = "0";

                }
            }
        }

        public static void Right(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length-c; m++)
            {
                if (j + m > y-1)
                    break;
                check += polje[i, j+m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (j + m > y - 1)
                        break;
                    poljecopy[i, j+m] = "0";

                }
            }
        }

        public static void DownLeft(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i + m >x-1 || j - m < 0)
                    break;
                check += polje[i + m, j-m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i + m > x - 1 || j - m < 0)
                        break;
                    poljecopy[i + m, j-m] = "0";

                }
            }
        }

        public static void DownRight(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i + m > x-1 || j + m > y-1)
                    break;
                check += polje[i + m, j+m];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i + m > x - 1 || j + m > y - 1)
                        break;
                    poljecopy[i + m, j+m] = "0";

                }
            }
        }

        public static void Down(string[,] polje, int i, int j, string rijec, string[,] poljecopy, int x, int y)
        {
            string check = "";
            int m;
            int c = 0;

            for (m = 0; m < rijec.Length; m++)
            {
                if (i + m >x-1 )
                    break;
                check += polje[i + m, j];
                if (check == rijec)
                {
                    c = rijec.Length - (m + 1);
                    break;
                }
            }

            if (check == rijec)
            {
                for (m = 0; m < rijec.Length-c; m++)
                {
                    if (i + m > x - 1)
                        break;
                    poljecopy[i + m, j] = "0";

                }
            }
        }

    }
}
