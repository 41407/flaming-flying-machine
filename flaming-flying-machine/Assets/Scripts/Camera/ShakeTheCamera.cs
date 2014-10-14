using UnityEngine;
using System.Collections;

public class ShakeTheCamera : MonoBehaviour
{

		public float onDestroy;

		void OnDestroy ()
		{
				if (Camera.main) {	
						Camera.main.GetComponent<Shake> ().set (onDestroy);
				}
		}
}
