using UnityEngine;
using System.Collections;

public class TimeDisplay : MonoBehaviour
{
		void Update ()
		{
				float decimalTime = GameStats.getTime ();
				int seconds = (int)decimalTime;
				int hundredths = (int)(decimalTime * 100) - seconds * 100;
				int minutes = seconds / 60;
				seconds = seconds - 60 * minutes;
				string secondsLeadingZero = "";
				if (seconds < 10) {
						secondsLeadingZero += "0";
				}
				string hundredthsLeadingZero = "";
				if (hundredths < 10) {
						hundredthsLeadingZero += "0";
				}
				string parsedTime = minutes + ":" + secondsLeadingZero + seconds + "." + hundredthsLeadingZero + hundredths; 
				GetComponent<TextMesh> ().text = parsedTime;
		}
}
