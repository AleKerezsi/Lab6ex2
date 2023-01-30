using System;

namespace Lab6ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va modela un autoturism.
             * Un autoturism va avea o marca (string), un numar de inmatriculare (string), precum si o capacitate cilindrica(int).
               Autoturismul va avea:
                 Campurile corespunzatoare caracteristicilor autoturismului.
                 Un constructor care va initializa campurile acestuia
                 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,numarDeInmatriculare, capacitateCilindrica”.
                Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml pentru metodele publice.
                Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le metodele “Tipareste”*/

            Autoturism auto = new Autoturism("seat", "SM18ADK", 1500);
            Console.WriteLine(auto.Tipareste());

            Autoturism auto2 = new Autoturism("bmw", "CJ13IDM", 1840);
            Console.WriteLine(auto2.Tipareste());

        }
    }
}
