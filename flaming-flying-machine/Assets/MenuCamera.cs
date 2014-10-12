using UnityEngine;
using System.Collections;

public class MenuCamera : MonoBehaviour
{

		public int state = 0;
		public float lerpSpeed;
		public Vector3 mainMenu;
		public Vector3 levelSelect;

		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (state == 0) {
						transform.position = Vector3.Lerp (transform.position, mainMenu, lerpSpeed);
				}
				if (state == 1) {
						transform.position = Vector3.Lerp (transform.position, levelSelect, lerpSpeed);
				}
		}
}
