using UnityEngine;
using System.Collections;

public class MenuCamera : MonoBehaviour
{
		public Color backgroundColor;
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
				camera.backgroundColor = backgroundColor;
				if (state == 0) {
						transform.position = Vector3.Lerp (transform.position, mainMenu, lerpSpeed);
				}
				if (state == 1) {
						transform.position = Vector3.Lerp (transform.position, levelSelect, lerpSpeed);
				}
				if (state == -1) {
						transform.position = Vector3.Lerp (transform.position, new Vector3 (transform.position.x, transform.position.y, 10), lerpSpeed);
				}
				if (state == -1 && transform.position.z >= 9) {
						MenuLogic.LoadLevel ();
				}
				if (transform.position.z > -20) {
						backgroundColor = new Color (backgroundColor.r - 0.01f, backgroundColor.g - 0.01f, backgroundColor.b - 0.01f);
				}
		}
}
