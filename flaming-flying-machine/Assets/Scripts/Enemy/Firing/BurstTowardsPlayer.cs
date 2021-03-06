﻿using UnityEngine;

public class BurstTowardsPlayer : MonoBehaviour
{
		public GameObject player;
		public GameObject projectile;
		public float firingDelay;
		public float projectileSpeed;
		private float firingTimer = 0;
		public int burstAmount = 1;
		private int shotsFired = 0;
		public float timeBetweenBursts = 0;
		private float burstTimer = 0;

		void Update ()
		{
				if (burstTimer >= timeBetweenBursts) {
						if (firingTimer >= firingDelay) {
								Shoot ();		
								shotsFired++;
								if (shotsFired >= burstAmount) {
										shotsFired = 0;
										burstTimer = 0;
								}
								firingTimer = 0;
						}
						firingTimer += Time.deltaTime;
				}
				burstTimer += Time.deltaTime;
		}
	
		void Shoot ()
		{
				Fire.at.Player (transform.position, projectileSpeed);
		}
}
