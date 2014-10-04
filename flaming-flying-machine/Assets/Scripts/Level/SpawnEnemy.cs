﻿using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{

		public GameObject enemyType;
		public float xCooridnate;
		public float bar = 1;
		public float beat = 1;
		private float ms;
		private GameObject player;

		void Start ()
		{
				player = gameObject.GetComponent<LevelScript> ().player;
		}

		// Update is called once per frame
		void Update ()
		{
				if (Metronome.bar == bar && 
						Metronome.beat == beat) {
						Spawn ();
						Destroy (this);
				}
		}

		void Spawn ()
		{
				Vector3 spawnPosition = new Vector3 (Random.Range (xCooridnate, xCooridnate), 0f, 0f);
				GameObject newEnemy = (GameObject)Instantiate (enemyType, spawnPosition, Quaternion.identity);
				newEnemy.GetComponent<EnemyShooting> ().player = player;
				if (newEnemy.GetComponent<CreateRotatorChilds> ()) {
						newEnemy.GetComponent<CreateRotatorChilds> ().player = player;
				}
		}
}