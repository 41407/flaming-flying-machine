using UnityEngine;
using System.Collections;

public class GameStats // : MonoBehaviour
{

		static int score;
		static int playerLevel;
		static int gameLevel;
		static float time;

	#region time
	
		public static void setTime (float gametime)
		{
				time = gametime;
		}
	
		public static float getTime ()
		{
				return time;
		}
	
	#endregion

	#region level

		public static void setGameLevel (int level)
		{
				gameLevel = level;
		}

		public static int getGameLevel ()
		{
				return gameLevel;
		}

	#endregion

	#region score

		public static void resetScore ()
		{
				score = 0;
				time = 0;
		}

		public static int addScore (int amount)
		{
				score += amount;
				return score;
		}
		
		public static int addScore ()
		{
				return addScore (playerLevel);
		}

		public static int getScore ()
		{
				return score;
		}

		public static void setPlayerLevel (int level)
		{
				playerLevel = level;
		}

	#endregion
}
