using UnityEngine;
using System.Collections;

public class GameStats // : MonoBehaviour
{

		static int score;
		static int playerLevel;
		static int gameLevel;

		public static void setGameLevel (int level)
		{
				gameLevel = level;
		}

		public static int getGameLevel ()
		{
				return gameLevel;
		}

	#region score

		public static int resetScore ()
		{
				return score = 0;
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
