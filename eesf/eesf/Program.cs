using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eesf
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int v = 0;
                string s;

                bool moreBook = true;
                int iPage;
                string sAuthor, sName;
                //A létrehozott új típussal inicializálunk egy objektumot
                Excersise ex = new Excersise("Gál Arnold");

                ex.Name = "Gál Arnold";

                Console.WriteLine(ex.Name);

                ex.PrintName();

                Console.WriteLine(ex.getName());

                ///Ciklusok
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Ciklus:<Változó hivatkozás I.>" + i);
                    Console.WriteLine("Ciklus:<Változó hivatkozás II.> {0}", i);
                }
                v = 2;
                while (v > 0)
                {
                    Console.WriteLine("While ciklus");
                    v--;

                }

                v = 2;
                do
                {
                    Console.WriteLine("Do while ciklus");
                    v--;
                } while (v > 0);

                v = 2;
                if (v == 2)
                {
                    Console.WriteLine("A v értéke egyenlő 2vel");
                }
                else if (v == 3)
                {
                    Console.WriteLine("A v értéke egyenlő 3val");
                }
                else
                {
                    Console.WriteLine("V nem 2 és nem 3, hanem:" + v);
                }
                v = 5;
                switch (v)
                {
                    case 0:
                        Console.WriteLine("Switch:" + v);
                        break;
                    case 5:
                        Console.WriteLine("Switch:" + v);
                        break;
                    default:
                        Console.WriteLine("Switch default:" + v);
                        break;


                }

                s = Console.ReadLine();
                //Beolvas egy karaktert a konzolról
                Console.ReadKey();
                Console.WriteLine("Beolvasás a konzolról:" + s);

                int[] szamok = new int[5];
                string[] szovegek = new string[10];

                ///Tömb inicializálása
                int[] iNums = new int[] { 1, 2, 3, 4, 5 };

                string[] sFruit = new string[] { "alma", "körte", "banán", "narancs" };
                Console.WriteLine("iNums első eleme: {0} sFruit első eleme:{1}", iNums[0], sFruit[0]);
                Console.WriteLine("iNums első eleme:" + iNums[0] + "sFruit első eleme:" + sFruit[0]);

                ///Tipusos listák
                ///Lista elem
                var Lista = new List<Book>();

                ///Új elemek hozzáadása a listához
                ///Ctrl-'.' hívhatjuk segítségül
                Lista.Add(new Book() { Name = "Oroszlánkölyök", Author = "Irwin Shaw", Page = 100 });
                Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
                Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1000 });
                ///Lista kiiratása
                foreach (Book book in Lista)
                {
                    Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
                }
                Console.WriteLine("*****************************************************************");

                Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));


                foreach (Book book in Lista)
                {
                    Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
                }


                //Console.WriteLine("Keressük az Oroszlánkölykök könyvet: " +  Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);



                ///Feladat: Egészítsük ki úgy a programot hogy a felhasználó lehetőséget kapjon interaktív módona a könyvtár  elemére modósítására
                ///u betűvel bekéri a könyv címét és oldalszámát t betűvel törlés, l lista.



                do
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Lehetőság [u]:új könyv [l]:listázás [t]:könyv törlése [k]:kilépés");
                    Console.WriteLine("**********************************");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case 'u':
                            Console.Write("Kérem a könyv címét:");
                            sName = Console.ReadLine();
                            Console.Write("Kérem a könyv szerzőjét:");
                            sAuthor = Console.ReadLine();
                            Console.Write("Kérem a lapszámot:");
                            iPage = int.Parse(Console.ReadLine());
                            Lista.Add(new Book { Name = sName, Author = sAuthor, Page = iPage });
                            break;
                        case 'k':
                            moreBook = false;
                            break;
                        case 't':
                            Console.Write("Kérem a könyv címét:");
                            foreach (Book book in Lista)
                            {
                                Console.WriteLine("->" + book.Name + " " + book.Author + " " + book.Page);
                            }


                            break;





                    }
                } while (moreBook);


            }

        
    




