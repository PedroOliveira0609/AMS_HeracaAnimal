using AMS_HerancaAnimal;
using System;

namespace AMS_HerancaAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.gravarDados("PitBul", "Rex", 3, "lati"); 
            cachorro.mostrarDados();      
            Gato gato = new Gato();
            gato.gravarDados("Munchkin", "Tom", 7, "Mia"); 
            gato.mostrarDados(); 
        }

    }
}

