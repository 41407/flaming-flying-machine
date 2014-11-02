using UnityEngine;
using System.Collections;

public class RecordWobble : MonoBehaviour
{
		void Update ()
		{
				if (GameStats.highScore ()) {
						transform.localScale = (Vector3.one + 0.1f * Vector3.one * Mathf.Sin (Time.realtimeSinceStartup * 4)); 
				}
		}
}
