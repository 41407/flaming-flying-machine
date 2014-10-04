using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{

		public GameObject enemyType;
		public float xCooridnate;
		public float bar;
		public float beat;
		private float ms;
		private GameObject player;

		void Start ()
		{
				player = gameObject.GetComponent<LevelScript> ().player;
		}

		// Update is called once per frame
		void Update ()
		{
				if (gameObject.GetComponent<Metronome> ().bar == bar && 
						gameObject.GetComponent<Metronome> ().beat == beat) {
						Spawn ();
				}
		}

		void Spawn ()
		{
				Vector3 spawnPosition = new Vector3 (Random.Range (xCooridnate, xCooridnate), 16f, 0f);
				GameObject newEnemy = (GameObject)Instantiate (enemyType, spawnPosition, Quaternion.identity);
				newEnemy.GetComponent<EnemyShooting> ().player = player;
				if (newEnemy.GetComponent<CreateRotatorChilds> ()) {
						newEnemy.GetComponent<CreateRotatorChilds> ().player = player;
				}
		}
}
