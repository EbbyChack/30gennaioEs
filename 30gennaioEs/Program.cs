using System;

namespace _30gennaioEs {
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.nome = "Ebby";
            persona1.cognome = "Chakkungal";
            persona1.età = 23;

            Console.WriteLine(persona1.getDettagli());
            Console.ReadLine();
        }
    }
}

