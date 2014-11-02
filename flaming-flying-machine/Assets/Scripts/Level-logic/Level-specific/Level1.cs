using UnityEngine;
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
		private float totalTime;
		private int stageWave;
		private bool stagecomplete = true;

		void Awake ()
		{
				stage = 0;
				totalTime = 0;
				GameStats.reset ();
		}

		void Start ()
		{
				stage = 0;
				totalTime = 0;
				GameStats.reset ();
		}

		// Update is called once per frame
		void Update ()
		{
				totalTime += Time.deltaTime;
				if (aliveEnemies <= 0 && stagecomplete) {
						stage++;
						timer = 0;
						stageWave = 0;
						stagecomplete = false;
				}
				UpdateStage (stage);
				if (!player) {
						Application.LoadLevel ("Game Over");
				}
		}

		void UpdateStage (int stage)
		{
				if (stage == 1) {
						if (timer == 0) {
								Spawn.the.AnchoringPawn (new Vector2 (-10, 30), new Vector2 (-10, 25), 5);
								stageWave++;
						}
						if (timer > 0.5f && stageWave == 1) {
								Spawn.the.AnchoringPawn (new Vector2 (-3, 30), new Vector2 (-3, 25), 5);
								stageWave++;
						}
						if (timer > 1f && stageWave == 2) {
								Spawn.the.AnchoringPawn (new Vector2 (3, 30), new Vector2 (3, 25), 5);
								stageWave++;
						}
						if (timer > 1.5f && stageWave == 3) {
								Spawn.the.AnchoringPawn (new Vector2 (10, 30), new Vector2 (10, 25), 5);
								stageWave++;
								stagecomplete = true;
						}
				} else if (stage == 2) {
						if (timer == 0) {
								Spawn.the.StraightMovingPawn (new Vector2 (10f, 30), new Vector2 (10, 20), 5);
								Spawn.the.AnchoringPawn (new Vector2 (13f, 30), new Vector2 (13, 20), 5);
								stageWave++;
						}
						if (timer > 1f && stageWave == 1) {
								Spawn.the.StraightMovingPawn (new Vector2 (5f, 30), new Vector2 (5, 20), 5);
								Spawn.the.AnchoringPawn (new Vector2 (8, 30), new Vector2 (8, 20), 5);
								stageWave++;
						}
						if (timer > 2f && stageWave == 2) {
								Spawn.the.StraightMovingPawn (new Vector2 (-1, 30), new Vector2 (-1, 20), 5);
								Spawn.the.AnchoringPawn (new Vector2 (1, 30), new Vector2 (1, 20), 5);
								stageWave++;
						}
						if (timer > 3f && stageWave == 3) {
								Spawn.the.StraightMovingPawn (new Vector2 (-5, 30), new Vector2 (-5, 20), 5);
								Spawn.the.AnchoringPawn (new Vector2 (-8, 30), new Vector2 (-8, 20), 5);
								stageWave++;
						}
						if (timer > 4f && stageWave == 4) {
								Spawn.the.StraightMovingPawn (new Vector2 (-10, 30), new Vector2 (-10, 20), 5);
								Spawn.the.AnchoringPawn (new Vector2 (-13, 30), new Vector2 (-13, 20), 5);
								stageWave++;
								stagecomplete = true;
						}
				} else if (stage == 3) {
						float speed = 4;
						if (timer == 0) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 7), new Vector2 (0, 7), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 9), new Vector2 (0, 9), speed);
								stageWave++;
						}
						if (timer > 1 && stageWave == 1) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 11), new Vector2 (0, 11), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 13), new Vector2 (0, 13), speed);
								stageWave++;
						}
						if (timer > 2 && stageWave == 2) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 15), new Vector2 (0, 15), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 17), new Vector2 (0, 17), speed);
								stageWave++;
						}
						if (timer > 3 && stageWave == 3) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 19), new Vector2 (0, 19), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 21), new Vector2 (0, 21), speed);
								stageWave++;
						}
						if (timer > 4 && stageWave == 4) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 23), new Vector2 (0, 23), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 25), new Vector2 (0, 25), speed);
								stageWave++;
						}
						if (timer > 5 && stageWave == 5) {
								Spawn.the.StraightMovingPawn (new Vector2 (-16, 27), new Vector2 (0, 27), speed);
								Spawn.the.StraightMovingPawn (new Vector2 (16, 29), new Vector2 (0, 29), speed);
								stageWave++;
								stagecomplete = true;
						}
				} else if (stage == 4) {
						if (timer > 1f && stageWave == 0) {
								Spawn.the.Elite (new Vector2 (0, 35), new Vector2 (0, 15));
								stageWave++;
								stagecomplete = true;
						}
				} else if (stage == 5) {
						if (timer > 1f && stageWave == 0) {
								Spawn.the.Elite (new Vector2 (0, 35), new Vector2 (0, 15));
								stageWave++;
						}
						if (timer > 1.5f && stageWave == 1) {
								Spawn.the.Elite (new Vector2 (-10, 35), new Vector2 (-10, 15));
								stageWave++;
						}
						if (timer > 2f && stageWave == 2) {
								Spawn.the.Elite (new Vector2 (10, 35), new Vector2 (10, 15));
								stageWave++;
								stagecomplete = true;
						}
				} else {
						GameStats.setTime (totalTime);
						GameStats.checkRecord ();
						Application.LoadLevel ("Level Passed");
						
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
