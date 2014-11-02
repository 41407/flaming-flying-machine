using UnityEngine;
using System.Collections;

public class GameStats // : MonoBehaviour
{

		static int score;

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
				return addScore (1);
		}

		public static int getScore ()
		{
				return score;
		}
}
