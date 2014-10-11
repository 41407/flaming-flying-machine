using UnityEngine;
using System.Collections;

public class Level1Boss1 : MonoBehaviour
{

		public GameObject[] bulletSpawners;
		private bool readyToFire = true;
		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (readyToFire && Metronome.beat == 1) {
						GameObject spawner = (GameObject)Instantiate (bulletSpawners [0], transform.position, Quaternion.identity);
						Vector2 start = gameObject.transform.position;
						Vector2 end = new Vector2 (gameObject.transform.position.x + 4, transform.position.y + 4);
						spawner.GetComponent<BulletSpawner> ().startPosition = start;
						spawner.GetComponent<BulletSpawner> ().endPosition = end;
						spawner.GetComponent<BulletSpawner> ().startAngle = -10;
						spawner.GetComponent<BulletSpawner> ().endAngle = 40;
						spawner.GetComponent<BulletSpawner> ().speed = 5;
						
			spawner.GetComponent<BulletSpawner> ().shots = 10;
			spawner.GetComponent<BulletSpawner> ().rateOfFire = 0.2f;

						readyToFire = false;
				}
				if (readyToFire && Metronome.beat == 3) {
						GameObject spawner = (GameObject)Instantiate (bulletSpawners [0], transform.position, Quaternion.identity);
						Vector2 start = gameObject.transform.position;
						Vector2 end = new Vector2 (transform.position.x - 4, transform.position.y - 4);
						spawner.GetComponent<BulletSpawner> ().startPosition = start;
						spawner.GetComponent<BulletSpawner> ().endPosition = end;
						spawner.GetComponent<BulletSpawner> ().startAngle = 10;
						spawner.GetComponent<BulletSpawner> ().endAngle = -40;
			spawner.GetComponent<BulletSpawner> ().speed = 5;
			spawner.GetComponent<BulletSpawner> ().shots = 10;
			spawner.GetComponent<BulletSpawner> ().rateOfFire = 0.2f;
						readyToFire = false;
				}
				if (Metronome.beat == 2) {
						readyToFire = true;	
				}
				if (Metronome.beat == 4) {
						readyToFire = true;	
				}
		}
}
