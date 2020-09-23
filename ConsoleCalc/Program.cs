using System;

namespace ConsoleCalc {
    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Welcome to Console Calc");

            bool keepLooping = true;

            do {
                double numberA = AskUserForNumber ();
                string operation = AskUserFor ("one of the following math operators + - * / ");
                double numberB = AskUserForNumber ();

                switch (operation) {
                    case "+":
                        Console.WriteLine ($"{numberA} + {numberB} = { Addition( numberA, numberB ) }");
                        break;
                    case "-":
                        Console.WriteLine ($"{numberA} - {numberB} = { Subtraction(numberA, numberB) }");
                        break;
                    case "*":
                        Console.WriteLine ($"{numberA} * {numberB} = { Multiplactation(numberA, numberB) }");
                        break;
                    case "/":
                        Console.WriteLine ($"{numberA} / {numberB} = { Divison(numberA, numberB)} ");
                        break;
                    default:
                        Console.WriteLine ("Not a supported math operator.");
                        break;
                }

                Console.WriteLine ("If you want to stop calculation type quit otherwise just hit enter.");
                if (Console.ReadLine ().Equals ("quit")) {
                    keepLooping = false;
                }
                /* one key press version
                Console.WriteLine ("If you want to stop calculation press q otherwise just hit another key.");
                if (Console.ReadKey(true).KeyChar == 'q') {
                    keepLooping = false;
                }
                */
            } while (keepLooping);
        }

        public static double Addition (double numA, double numB) {
            return numA + numB;
        }

        public static double Subtraction (double numA, double numB) {
            return numA - numB;
        }

        public static double Multiplactation (double numA, double numB) {
            return numA * numB;
        }

        public static double Divison (double numA, double numB) {
            if (numA == 0 || numB == 0) {
                Console.WriteLine ("This calculator dose not divide with Zero numbers.\nResult will be shown as 0.");
                return 0;
            } else {
                return numA / numB;
            }
        }

        static string AskUserFor (string what) {
            Console.Write ($"Please enter {what}: ");

            return Console.ReadLine ();
        }

        static double AskUserForNumber () {
            double number = 0;
            bool noNumber;

            do {
                noNumber = true;
                try {
                    number = double.Parse (AskUserFor ("a number"));
                    //number = Convert.ToDouble ( AskUserFor ("a number"));

                    noNumber = false; //we will only get to this if double.Parse dose not make a Exception.

                } catch (ArgumentNullException) {
                    Console.WriteLine ("Did not get any input.");
                } catch (OverflowException) {
                    Console.WriteLine ("The number is too big.");
                } catch (FormatException) {
                    Console.WriteLine ("Was unable to read the number.");
                }

            } while (noNumber);

            return number;
        }
    }
}