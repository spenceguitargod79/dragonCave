//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//Class: rules
//Author: Spencer Healy
//This class contains a method that just prints out game rules to the player
using System;
namespace DragonCave_SH
{
	public class rules
	{
		//member variables
		private string instructions;

		//constructer
		public rules ()
		{
			instructions = "Welcome to DragonCave!\n" +
						   "Try to find the gold and return here to climb back out.\n" +
						   "You have 1 arrow that you can shoot!\n" +
						   "Try the following commands:\n" +
						   "Move <F>orward, Turn <L>eft, Turn <R>ight,\n" +
						   "<G>rab the gold, <S>hoot the arrow, <C>limb out," +
						   "\n<Q>uit the game, Use <x> to cheat.";
		}

		public void printRules()
		{
			Console.WriteLine (instructions);
		}


	}
}

