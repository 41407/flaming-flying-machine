﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Level1 : MonoBehaviour
{
		public int stage = 0;
		public Component[] stages;
		public GameObject player;
		public Camera levelCamera;
		public static int aliveEnemies = 0;
		private float timer;
		private int stageWave;

		void Awake ()
		{
				stage = 0;
		}

		void Start ()
		{
				stage = 0;
		}

		// Update is called once per frame
		void Update ()
		{
				print (aliveEnemies);
				if (aliveEnemies <= 0) {
						stage++;
						timer = 0;
						stageWave = 0;
				}
				UpdateStage (stage);
				if (!player) {
						Application.LoadLevel (0);
				}
		}

		void UpdateStage (int stage)
		{
				if (stage == 1) {
						if (timer == 0) {
								Spawn.the.AnchoringPawn (new Vector2 (5, 30), new Vector2 (5, 15), 5);
								Spawn.the.AnchoringPawn (new Vector2 (10, 30), new Vector2 (10, 15), 5);
								Spawn.the.AnchoringPawn (new Vector2 (-5, 30), new Vector2 (-5, 15), 5);
								Spawn.the.AnchoringPawn (new Vector2 (-10, 30), new Vector2 (-10, 15), 5);
						}
				} else if (stage == 2) {
						if (timer == 0) {
								Spawn.the.StraightMovingPawn (new Vector2 (2.5f, 30), new Vector2 (5, 15), 5);
								Spawn.the.StraightMovingPawn (new Vector2 (7.5f, 30), new Vector2 (10, 15), 5);
								stageWave++;
						}
						if (timer > 1 && stageWave == 1) {
								Spawn.the.StraightMovingPawn (new Vector2 (-2.5f, 30), new Vector2 (-5, 15), 5);
								Spawn.the.StraightMovingPawn (new Vector2 (-7.5f, 30), new Vector2 (-10, 15), 5);
								stageWave++;
						}
				} else if (stage == 3) {
						if (timer == 0) {
								Spawn.the.Elite (new Vector2 (0, 30), new Vector2 (0, 15), 5);
								stageWave++;
						}
						if (timer > 1 && stageWave == 1) {
								Spawn.the.Elite (new Vector2 (0, 30), new Vector2 (10, 15), 5);
								stageWave++;
						}
						if (timer > 2 && stageWave == 2) {
								Spawn.the.Elite (new Vector2 (0, 30), new Vector2 (-10, 15), 5);
								stageWave++;
						}
				}
				timer += Time.deltaTime;
		}

		public static void enemyDied ()
		{
				aliveEnemies -= 1;
		}

		public static void enemySpawned ()
		{
				aliveEnemies += 1;
		}
}
