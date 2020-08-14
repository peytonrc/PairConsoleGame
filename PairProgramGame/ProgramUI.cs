using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    public class ProgramUI
    {
        private bool _isRunning = true;
        public void Start()
        {
            StartMenu();
        }
        private void StartMenu()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome! Pick a Madlib to begin.\n" +
                      "1. The Forest\n" +
                      "2. The Cat\n" +
                      "3. The Wizard\n" +
                      "4. The Hole\n" +
                      "5. The Recipe\n" +
                      "6. Nevermind");
                OpenMenuItem();
            }
        }
        private void OpenMenuItem()
        {
            Mlibs libs = new Mlibs();
            while (true)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        libs.TheForest();
                        return;
                    case "2":
                        libs.TheCat();
                        return;
                    case "3":
                        libs.TheWizard();
                        return;
                    case "4":
                        libs.TheHole();
                        return;
                    case "5":
                        libs.TheRecipe();
                        return;
                    case "6":
                        //Nevermind
                        _isRunning = false;
                        return;
                    default:
                        Console.WriteLine("Please pick a valid number.");
                        break;
                }
            }
        }
    }
}
