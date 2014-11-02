using UnityEngine;
using System.Collections;

public class GameStats : MonoBehaviour
{
		static int score;
		static int playerLevel;
		static int gameLevel;
		static float time;
		static bool newHighScore = false;
		static bool newRecordTime = false;
	
		public static void reset ()
		{
				score = 0;
				time = 0;
				newHighScore = false;
				newRecordTime = false;
		}

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

	#endregion

	#region highscores

		public static bool highScore ()
		{
				return newHighScore;
		}

		public static bool recordTime ()
		{
				return newRecordTime;
		}

		public static void checkRecord ()
		{
				if (PlayerPrefs.HasKey ("Level " + gameLevel + " score")) {
						if (PlayerPrefs.GetInt ("Level " + gameLevel + " score") < score) {
								PlayerPrefs.SetInt ("Level " + gameLevel + " score", score);
								newHighScore = true;
						} else {
								newHighScore = false;
						}
				} else {
						PlayerPrefs.SetInt ("Level " + gameLevel + " score", score);
						newHighScore = true;
				}
				if (PlayerPrefs.HasKey ("Level " + gameLevel + " time")) {
						if (PlayerPrefs.GetFloat ("Level " + gameLevel + " time") > time) {
								PlayerPrefs.SetFloat ("Level " + gameLevel + " time", time);
								newRecordTime = true;
						} else {
								newRecordTime = false;
						}
				} else {
						PlayerPrefs.SetFloat ("Level " + gameLevel + " time", time);
						newRecordTime = true;
				}
		}

	#endregion
}
