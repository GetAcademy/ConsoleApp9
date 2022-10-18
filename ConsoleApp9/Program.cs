namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("Hva heter du?");
            var place = MyConsole.Ask("Hvor bor du?");
            var birthYear = MyConsole.AskForInt("I hvilket år ble du født?");
            //var birthYearStr = MyConsole.Ask("I hvilket år ble du født?");
            //var birthYear = Convert.ToInt32(birthYearStr);
            var age = DateTime.Now.Year - birthYear;

            //Console.Write("Hva heter du? ");
            //var name = Console.ReadLine();

            //Console.Write("Hvor bor du? ");
            //var place = Console.ReadLine();

            Console.WriteLine($"Hei, {name} - håper du har det bra i {place}!");
            Console.WriteLine($"Du er {age} år gammel.");
            /*
                DRY-prinsippet => Don't Repeat Yourself

                De viktigste Refactoring-teknikkene
                 1: introduce variable
                 2: extract method
                 3: introduce class
             */

            // Demo1(args);
        }

        //static string Ask(string question)
        //{
        //    Console.Write(question + " ");
        //    return Console.ReadLine();
        //}

        static void Demo1(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (var a in args)
            {
                Console.WriteLine(a);
            }

            int n = 5;
            bool b = true;
            char c = 'a';
            float f = 1.1f;
            double d = 5.5;
            string s = "Terje";

            var n2 = 5;
            var b2 = true;
            var c2 = 'a';
            var f2 = 1.1f;
            var d2 = 5.5;
            var s2 = "Terje";

            Console.WriteLine("Hello, World!");
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        /*
         function Main(args) {
            console.log('Hello, World!');
         }

         function plus(a,b) {
            return a+b;
         }
         */
    }
}