using UnityEngine;
using System.Collections;

public class RecordTime : MonoBehaviour
{
		public string defaultText;
		public string recordTime;

		void Start ()
		{
				if (GameStats.recordTime ()) {
						gameObject.GetComponent<TextMesh> ().text = recordTime;		
				} else {
						gameObject.GetComponent<TextMesh> ().text = defaultText;		
				}
		}
}
