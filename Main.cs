using System;

//Class: MainClass
//Author: Spencer Healy
//This class will run the game

namespace DragonCave_SH
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Display the game rules
			rules rule = new rules ();//declare and instantiate the rule object.
			rule.printRules ();//call the printRules method on the rule object.

			//Create the cave
			cave c = new cave ();

			//Create the player
			player p1 = new player ();
			p1.printPlayerStats ();

			//fill the array with items
			c.populateArray ();
			c.printArray ();//for testing purposes


			//Accept user input if input is one of the valid keys (use a do while?)
			Console.WriteLine ("\nYou are facing east, which direction do you wish to travel?");
			string playerInput = "";
			playerInput = Console.ReadLine ();
			Console.WriteLine ("You entered: " + playerInput);
			//Convert playerInput to lowercase, in the case that the player enters an uppercase letter.
			playerInput = playerInput.ToLower();

			//Call the method that checks the players input,
			//then send that input to the method that takes the next steps. 
			//If the input is of invalid form, then let the player enter input again.
			while (p1.checkPlayerInput (playerInput) != true)
			{
				Console.WriteLine ("Enter a VALID direction to move...");
				playerInput = Console.ReadLine ();

			}

			//If the user's input passes the above while loop, send the input to the next function.
			c.acceptUserInput (playerInput);

			//let the player move 1 spot
			//if they move into a wall, tell the player to make another move. 
			//if they hit an exit or dragon, give praise and end game, or punish and end game.
			//(this should be accomplished in one of the classes)
		}
	}
}
