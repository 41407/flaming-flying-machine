using UnityEngine;
using System.Collections;

public class EnemyBasicShooting : MonoBehaviour
{

		public GameObject bulletSpawner;
		private bool readyToFire;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (readyToFire && Metronome.beat % 2 == 1) {
						Fire.instance.AtAngle (transform.position, 0, 20);
						readyToFire = false;
				}
				if (Metronome.beat % 2 == 0) {
						readyToFire = true;
				}

		}
}
