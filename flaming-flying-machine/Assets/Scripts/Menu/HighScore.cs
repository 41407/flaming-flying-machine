using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour
{
		public string defaultText;
		public string highScore;
	
		void Start ()
		{
				if (GameStats.highScore ()) {
						gameObject.GetComponent<TextMesh> ().text = highScore;		
				} else {
						gameObject.GetComponent<TextMesh> ().text = defaultText;		
				}
		}
}
