﻿using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour
{

		public GameObject bullet;
		public float firingDelay;
		public float speed;
		private bool firing = false;
		private float firingCooldown = 0;
		// Use this for initialization
		void Start ()
		{
				firingDelay /= 1000;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetMouseButtonDown (0)) {
						firing = true;
				} 
				if (Input.GetMouseButtonUp (0)) {
						firing = false;
				}
				if (firing && firingCooldown >= firingDelay) {
						firingCooldown = 0;
						GameObject newBullet = (GameObject)Instantiate (bullet, this.gameObject.transform.position, Quaternion.identity);
						Physics2D.IgnoreCollision (newBullet.collider2D, gameObject.collider2D);
						newBullet.GetComponent<BulletProperties> ().speed = speed;
						newBullet.GetComponent<BulletProperties> ().direction = Vector3.up;
						Destroy (newBullet, 1.0f);
				}
				firingCooldown += Time.deltaTime;
		}
}