using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{

		public float brutality;

		void OnDestroy ()
		{
				if (Camera.main) {	
						Camera.main.GetComponent<Shake> ().set (brutality);
				}
		}
}
