using System;

namespace _30gennaioEs {
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            Console.WriteLine("Inserisci nome:");
            persona1.nome = Console.ReadLine();

            Console.WriteLine("Inserisci cognome:");
            persona1.cognome = Console.ReadLine();

            Console.WriteLine("Inserisci età:");
            persona1.età = Convert.ToInt16(Console.ReadLine());



            Console.WriteLine(persona1.getDettagli());
            Console.ReadLine();
        }
    }
}

