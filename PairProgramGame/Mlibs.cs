using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    public class Mlibs
    {
        public void TheForest()
        {
            Console.Clear();
            string[] prompts = { "Type a Name: ", "Type an Adjective: ", "Type a Verb: ", "Type an Adverb: ", "Type a Plural Noun: ", "Type an Adjective: ", "Type an Animal: ", "Type a Word You Made Up! (Noun): ", "Type a Verb (Past Tense): ", "Type in a Piece of Advice You'd Like to Share: " };
            string[] input = new string[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($" There once was a boy in The Forest named {input[0]}. {input[0]} was very {input[1]}.\n" +
                $" One day, while he was searching for {input[4]}, he heard a noise from deep in the Forest.\n" +
                $" It sounded like some kind of {input[5]} {input[6]}. {input[0]} stood up {input[3]} and looked around.\n" +
                $" Suddenly a great creature bounded out of the bushes. \"Ahh! The {input[7]}!\" he shouted.\n" +
                $" He tried to {input[2]}, but before he could, the {input[7]} {input[8]}. \n" +
                $" This surprised the boy, as he was not expecting that. \n" +
                $" Luckily, {input[0]} got home safely that night. Somehow.\n" +
                $" He learned a valuable lesson that day: {input[9]}");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }


        public void TheCat()
        {
            Console.Clear();
            string[] prompts = { "Type a Name: ", "Type an Adjective: ", "Type a Noun: ", "Type a Noun: ", "Type a Noun: ", "Type an Adjective: ", "Type a Verb: ", "Type an Adverb: ", "Type a Verb (Past Tense): ", "Type an Adjective: ", "Type a Verb (Past Tense): " };

            string[] input = new string[11];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine($" A cat named {input[0]} was as {input[1]} as a {input[2]}. {input[0]} the cat was hungry and wanted\n" +
                $" to eat a bowl of {input[3]} and drink some {input[4]}. When {input[0]} was done eating, his {input[5]}\n" +
                $" owners arrived home and told him it was time to go {input[6]}. {input[0]} was not happy about this and {input[7]} {input[8]} away.\n" +
                $" When the {input[9]} owners found him, {input[0]} {input[10]} on them and began to scratch. Now {input[0]} the cat does\n" +
                $" whatever he pleases all day long.");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }



        public void TheWizard()
        {
            Console.Clear();
            string[] prompts = { "Type an Adjective: ", "Type a Noun: ", "Type a Plural Noun: ", "Type a Verb: ", "Type a Number: ", "Type a Plural Noun: ", "Type a Noun: ", "Make up a Phrase!: ", "Type a Sound Effect!: ", "Type the Name of a Place: " };
            string[] input = new string[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($" You are a mighty Wizard!\n" +
                $" With just a wave of the {input[1]}, you can cast {input[0]} Magic!\n" +
                $" When angry, you can shoot projectile {input[2]} from your trustworthy, magical {input[6]}!\n" +
                $" When frightened, you can shout your Incantation, \"{input[7]}!\" and your problems disappear!\n" +
                $" When you wish to go to {input[9]}, you can simply {input[3]} your fingers and {input[8]}! You're there!\n" +
                $" And you have {input[4]} more Spells at your disposal!\n" +
                $" You would be a God, if it weren't for your one weakness: {input[5]}.");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }



        public void TheHole()
        {
            Console.Clear();
            string[] prompts = { "Type an Adjective: ", "Type an Adjective: ", "Type a Noun: ", "Type a Verb (Past Tense): ", "Type a Verb (Past Tense): " };

            String[] input = new string[5];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine($" One day, a little girl, who loved to play outside, found a {input[0]} hole in her backyard.\n" +
                $" She ran to grab a {input[1]} shovel. She began to dig and pulled out a huge {input[2]}.\n" +
                $" She called for her mom to inspect what she had found. The girl’s mom immediately {input[3]} to the phone to call someone.\n" +
                $" The mom told the little girl to stay put, but the girl was curious and picked up the {input[2]}. As soon as she\n" +
                $" did the mom {input[4]} at her and grabbed the {input[2]}. Although the girl didn’t understand,\n" +
                $" the mom said the {input[2]} was very valuable and they would make a lot of money from it.");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }




        public void TheRecipe()
        {
            Console.Clear();
            string[] prompts = { "Type an Adjective: ", "Type a Noun: ", "Type an Adverb: ", "Type a Number: ", "Type a Plural Noun: ", "Type a Number: ", "Type a Plural Noun: ", "Type a Number: ", "Type a Noun: ", "Type a Number: ", "Type a Noun: ", "Type a Number: ", "Type a Noun: ", "Type Anything!: " };
            string[] input = new string[14];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($" Recipe for {input[13]}:\n" +
                $" \n" +
                $" Step 1. Start with {input[3]} {input[6]}... \n" +
                $" Step 2. Mix in container with {input[7]} pounds of {input[4]}... \n" +
                $" Step 3. Fry mixture over high heat. Sprinkle {input[5]} tbsp of {input[10]} juice on top... \n" +
                $" Step 4. Let sit for {input[11]} minutes while you prep the {input[12]}... \n" +
                $" Step 5. Throw the {input[12]} into the mixture and add {input[9]} pinches of {input[8]} salt... \n" +
                $" Step 6. Finally, garnish with a single {input[1]}... \n" +
                $" \n" +
                $" Stir until {input[0]}. Best served {input[2]}.");
            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
