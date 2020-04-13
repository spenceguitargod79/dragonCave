//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//Class: player
//Author: Spencer Healy
//This class will construct the player.
//Some methods may accomplish the following:
//1)moving the player depending on what key they pressed
//2)update location
//3)get/set methods

using System;
namespace DragonCave_SH
{
	public class player
	{
		//Member variables
		private Boolean alive;
		private int health;
		private int lives;
		private int gold;
		private int arrows;
		private int x;//the player's x coordinate on the game board
		private int y;//the player's y coordinate on the game board 

		//Default constructor -----------------------------------------------------
		public player ()
		{
			alive = true;
			health = 100;
			lives = 3;
			gold = 0;
			arrows = 1;
			x = 0;
			y = 0;
		}
		//3 arg constructor -----------------------------------------------------
		public player (int hel, int x2, int y2, int lvs)
		{
			alive = true;
			health = hel;
			lives = lvs;
			x = x2;
			y = y2;
		}

		//Setters----------------------------------------------------------------
		public void setAliveFalse()
		{
			alive = false;
		}

		public void setAliveTrue()
		{
			alive = true;
		}

		public void setHealth(int h)
		{
			health = h;
		}

		public void subtractHealth(int h)
		{
			health = health - h;
		}

		public void addHealth(int h)
		{
			health = health + h;
		}

		public void setGold(int g)
		{
			gold = g;
		}

		public void setArrows(int a)
		{
			arrows = a;
		}
		
		public void setX(int x2)
		{
			x = x2;
		}

		public void setY(int y2)
		{
			y = y2;
		}

		public void setXandY(int x2, int y2)
		{
			x = x2;
			y = y2;
		}

		public void setLives(int l)
		{
			lives = l;
		}

		public void subtractLives(int l)
		{
			lives = lives - l;
		}

		public void addLives(int l)
		{
			lives = lives + l;
		}

		public void addGold(int g)
		{
			gold = gold + g;
		}

		public void subtractGold(int g)
		{
			gold = gold - g;
		}

		public void addArrows(int a)
		{
			arrows = arrows + a;
		}

		public void subtractArrows(int a)
		{
			arrows = arrows - a;
		}

		//Getters-----------------------------------------------------------
		public Boolean getAlive()
		{
			return alive;
		}

		public int getHealth()
		{
			return health;
		}

		public int getLives()
		{
			return lives;
		}

		public int getGold()
		{
			return gold;
		}

		public int getArrows()
		{
			return arrows;
		}

		public int getX()
		{
			return x;
		}

		public int getY()
		{
			return y;
		}

		//other methods---------------------------------------------
		//If player moves, update location coodinates
		public void updateLocation(int x, int y)
		{
			//Update x and y variables
		}
		
		public void printPlayerStats()
		{
			Console.WriteLine ("\nPlayer Stats and Equipment\n" +
							   "Health: " + getHealth() +
			                   "\nLives: " + getLives() +
			                   "\nGold: " + getGold() +
			                   "\nArrows: " + getArrows());
		}

		public Boolean checkPlayerInput(string input)
		{
			//Convert playerInput to lowercase, in the case that the player enters an uppercase letter.
			input = input.ToLower();
		
			if (input == "l" || input == "r" || input == "g" || input == "s" ||
			    input == "c" || input == "q" || input == "x") 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
	
	}
}
