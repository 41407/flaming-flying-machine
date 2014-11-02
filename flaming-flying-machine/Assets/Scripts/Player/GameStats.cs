using UnityEngine;
using System.Collections;

public class GameStats : MonoBehaviour
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
				return addScore (playerLevel * 200);
		}

		public static int getScore ()
		{
				return score;
		}

		public static void setPlayerLevel (int level)
		{
				playerLevel = level;
		}

		public static void checkHighScore ()
		{
				if (PlayerPrefs.HasKey ("Level " + gameLevel + " score")) {
						print ("PlayerPrefs did have score for Level " + gameLevel + ". Comparing scores.");
						if (PlayerPrefs.GetInt ("Level " + gameLevel + " score") < score) {
								PlayerPrefs.SetInt ("Level " + gameLevel + " score", score);
								print ("Score was higher than before. High score updated.");
						} else {
								print ("Score was lower than before. High score unchanged.");
						}
				} else {
						print ("PlayerPrefs didn't have score for Level " + gameLevel + ". Creating entry.");
						PlayerPrefs.SetInt ("Level " + gameLevel + " score", score);
				}

				if (PlayerPrefs.HasKey ("Level " + gameLevel + " time")) {
						print ("PlayerPrefs did have time for Level " + gameLevel + ". Comparing times.");
						if (PlayerPrefs.GetFloat ("Level " + gameLevel + " time") > time) {
								PlayerPrefs.SetFloat ("Level " + gameLevel + " time", time);
								print ("Time was faster than before. Record time updated.");
						} else {
								print ("Time was slower than before. Record time unchanged.");
						}
				} else {
						print ("PlayerPrefs didn't have time for Level " + gameLevel + ". Creating entry.");
						PlayerPrefs.SetFloat ("Level " + gameLevel + " time", time);
				}
		}

	#endregion
}
