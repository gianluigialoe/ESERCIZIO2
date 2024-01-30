namespace ESERCIZIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FORMATTATORE PRESONA:");
            Console.WriteLine("Nome:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Surname;");
            string inputSting = Console.ReadLine();
            Console.WriteLine("Age");
            int inputEta = int.Parse(Console.ReadLine());

            Persone myPersona1 = new Persone(inputString, inputSting, inputEta);
            Console.WriteLine(myPersona1.GeneratoreDiPersone());
        }
    }



    public class Persone
    {
        private string _name;
        private string _surname;
        private int _Age;

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value; 

                if (value <= 18)
                {
                    Console.WriteLine("Sei minorenne");
                }
                else
                {
                    Console.WriteLine("Sei maggiorenne");
                }
            }
        }

        public Persone(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age; 
        }

        public string GeneratoreDiPersone()
        {
            return $"Ciao {Name} {Surname}, la tua età è {Age}";
        }
    }
}