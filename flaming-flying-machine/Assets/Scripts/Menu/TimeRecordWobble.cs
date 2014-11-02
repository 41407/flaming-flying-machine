using UnityEngine;
using System.Collections;

public class TimeRecordWobble : MonoBehaviour
{

		void Update ()
		{
				if (GameStats.recordTime ()) {
						transform.localScale = (Vector3.one + 0.1f * Vector3.one * Mathf.Sin (Time.realtimeSinceStartup * 4)); 
				}
		}
}
