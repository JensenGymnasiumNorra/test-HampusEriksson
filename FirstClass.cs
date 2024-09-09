using System;

namespace FirstClass
{
    // Skapa din första klass
    public class ClassName
    {
        // Attribut (egenskaper)
        public string Attribute1 { get; set; }
        public int Attribute2 { get; set; }
        public bool Attribute3 { get; set; }

        // Konstruktor
        public ClassName(string attribute1, int attribute2, bool attribute3)
        {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
        }

        // ToString-metod
        public override string ToString()
        {
            return $"Attribute1: {Attribute1}, Attribute2: {Attribute2}, Attribute3: {Attribute3}";
        }

        // En valfri metod
        public void AnotherMethod()
        {
            // Implementera metodens funktionalitet här
            Console.WriteLine("Denna metod gör något!");
        }
    }

    // Huvudprogrammet där klassen används
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa ett objekt av klassen ClassName
            ClassName obj = new ClassName("Värde1", 42, true);

            // Anropa ToString-metoden
            Console.WriteLine(obj.ToString());

            // Anropa den valfria metoden
            obj.AnotherMethod();
        }
    }
}
