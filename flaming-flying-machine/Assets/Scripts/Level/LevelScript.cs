﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class LevelScript : MonoBehaviour
{
		public MonoBehaviour[] enemies;
		public GameObject player;
		public Camera levelCamera;
		private const float tick = 2 * 117.1875f;
		private Queue spawnSequence;
		private float timer;

		void Start ()
		{
				Screen.showCursor = false;
				timer = 0.0f;
				Spawn.instance.StraightMovingPawn (new Vector2 (0, 30), new Vector2 (0, 15), 5);
				Spawn.instance.AnchoringPawn (new Vector2 (0, 30), new Vector2 (0, 15), 5);
		}

		// Update is called once per frame
		void Update ()
		{
				timer += Time.deltaTime;
				if (!player) {
						Application.LoadLevel (0);		
				}
		}	
	
}
