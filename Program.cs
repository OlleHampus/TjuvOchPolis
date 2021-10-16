using System;
using System.Collections.Generic;
using System.Threading;

namespace TjuvOchPolis
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IPerson> personer = new List<IPerson>();
            Console.WriteLine(Var.stad_bredd);
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            personer.Add(new Tjuv(10, 5, 0, -1, "T"));
            personer.Add(new Medborgare(10, 3, 0, 0, "M"));
            personer.Add(new Medborgare(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), -1, -1, "M"));
            personer.Add(new Medborgare(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), -1, -1, "M"));
            personer.Add(new Medborgare(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), 0, 1, "M"));
            personer.Add(new Tjuv(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), 0, 1, "T"));
            personer.Add(new Tjuv(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), 1, 1, "T"));
            personer.Add(new Polis(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), 1, 1, "P"));
            personer.Add(new Polis(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), -1, -1, "P"));
            personer.Add(new Polis(rnd.Next(1, Var.stad_bredd), rnd.Next(1, Var.stad_hojd), -1, -1, "P"));
           
            for (int i = 0; i < 50; i++)
            {
                //vi nollställer rutnätet 
                for (int n = 0; n < Var.stad_hojd; n++)
                {
                    for (int m = 0; m < Var.stad_bredd; m++)
                    {
                        Var.Rutnat[m, n] = "  ";
                    }

                }
                foreach (IPerson person in personer)
                {
                    person.DoMove();

                }
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine(i);
                Console.WriteLine("-------------------------------------------------------------");

                for (int n = 0; n < Var.stad_hojd; n++)
                {
                    //string output = n.ToString();
                    string output = "";

                    for (int m = 0; m < Var.stad_bredd; m++)
                    {
                        output += Var.Rutnat[m, n];
                    }
                    Console.WriteLine(output);

                }
                foreach (IPerson Tjuv in personer)
                {
                    if (Tjuv.CheckSort() == "T") 
                    {
                          foreach (IPerson Medborgare in personer)
                        {
                              if (Medborgare.CheckSort() == "M")
                            {
                                if (Tjuv.Comparexy(Medborgare))
                                {
                                    Console.WriteLine("Tjuv snor från Medborgare");
                                }
                            }
                        }
                    }


                    //En loop som gåra igenom alla personer 
                    //
                    //if (this.comparexy(Medborgarex))
                    //{
                    //Tjuven tar en sak från medborgaren
                    //}

                }
                foreach (IPerson Tjuv in personer)
                {
                    if (Tjuv.CheckSort() == "T")
                    {
                        foreach (IPerson Medborgare in personer)
                        {
                            if (Medborgare.CheckSort() == "M")
                            {
                                if (Tjuv.Comparexy(Medborgare))
                                {
                                    Console.WriteLine("Tjuv snor från Medborgare");
                                }
                            }
                        }
                    }

                    //En loop som gåra igenom alla personer 
                    //
                    //if (this.comparexy(Medborgarex))
                    //{
                    //Tjuven tar en sak från medborgaren
                    //}

                }
                //Thread.Sleep(0);
            }
            {

            }
        }
    }
}
