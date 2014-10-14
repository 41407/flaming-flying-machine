using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
		public bool playOnDestroy = true;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnDestroy ()
		{
				if (playOnDestroy) {
						audio.Play ();
				}
		}
}
