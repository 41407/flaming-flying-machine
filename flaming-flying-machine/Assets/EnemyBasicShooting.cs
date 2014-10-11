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
				if (readyToFire && Metronome.beat == 1) {
						GameObject spawner = (GameObject)Instantiate (bulletSpawner, transform.position, Quaternion.identity);
						spawner.GetComponent<BulletSpawner> ().startPosition = transform.position;
						spawner.GetComponent<BulletSpawner> ().endPosition = transform.position;
			spawner.GetComponent<BulletSpawner> ().shots = 1;
			spawner.GetComponent<BulletSpawner> ().speed = 10;
						readyToFire = false;
				}
				if (Metronome.beat == 2) {
						readyToFire = true;
				}
		}
}
