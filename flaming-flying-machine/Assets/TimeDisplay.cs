using UnityEngine;
using System.Collections;

public class TimeDisplay : MonoBehaviour
{
		void Update ()
		{
				GetComponent<TextMesh> ().text = "" + GameStats.getTime ();
		}
}
