using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6ex2
{
    public class Autoturism
    {
        private string marca;
        private string numarDeInmatriculare;
        private int capacitateCilindrica;

        /// <summary>
        /// Constructorul Autoturism creeaza un obiect nou de tipul autoturism
        /// initializand campurile asociate
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="numarDeInmatriculare"></param>
        /// <param name="capacitateCilindrica"></param>
        public Autoturism(string marca, string numarDeInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeInmatriculare = numarDeInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        /// <summary>
        /// Returneaza valoarea campului marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return marca;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului marca
        /// </summary>
        /// <param name="marca"></param>
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Returneaza valoarea campului numarDeInmatriculare
        /// </summary>
        /// <returns></returns>
        public string GetNumarDeInmatriculare()
        {
            return numarDeInmatriculare;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului numarDeInmatriculare
        /// </summary>
        /// <param name="numarDeInmatriculare"></param>
        public void SetNumarDeInmatriculare(string numarDeInmatriculare)
        {
            this.numarDeInmatriculare = numarDeInmatriculare;
        }


        /// <summary>
        /// Returneaza valoarea campului capacitateCilindrica
        /// </summary>
        /// <returns></returns>
        public int GetCapacitateCilindrica()
        {
            return capacitateCilindrica;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului capacitateCilindrica
        /// </summary>
        /// <param name="capacitateCilindrica"></param>
        public void SetCapacitateCilindrica(int capacitateCilindrica)
        {
            this.capacitateCilindrica = capacitateCilindrica;
        }

        /// <summary>
        /// Returneaza o forma printabila a campurilor obiectului.
        /// </summary>
        /// <returns></returns>
        public string Tipareste()
        {
            return $"{marca},{numarDeInmatriculare},{capacitateCilindrica}";

        }


    }
}
