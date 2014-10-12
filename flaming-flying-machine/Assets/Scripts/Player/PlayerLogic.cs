﻿using UnityEngine;
using System.Collections;

public class PlayerLogic : MonoBehaviour
{

		public GameObject bullet;
		public float firingDelay;
		public float speed;
		static public int level = 1;
		public Sprite[] sprites;
		private bool firing = false;
		private float timeSinceLastShot = 0;
		static public int xp = 0;
		public float invulnerabilityPeriod;
		private float invulnerabilityTimer;

		void Start ()
		{
				xp = 0;
				firingDelay /= 1000;
		}

		void Update ()
		{		
				CheckXp ();
				CheckInput ();
				FiringLogic ();
				Invulnerability ();

		}

		void CheckInput ()
		{
				if (Input.GetMouseButtonDown (0)) {
						firing = true;
						gameObject.GetComponent<PlayerAudio> ().firing = true;
				} 
				if (Input.GetMouseButtonUp (0)) {
						firing = false;
						gameObject.GetComponent<PlayerAudio> ().firing = false;
				}

				if (Input.GetMouseButtonDown (1)) {
						invulnerabilityTimer = invulnerabilityPeriod;
				}
		}

	#region xp

		void CheckXp ()
		{
				gameObject.GetComponent<SpriteRenderer> ().sprite = sprites [level - 1];
		}
	
		public static void xpUp (int xpGain)
		{	
				xp += xpGain;
				level = Mathf.Max (1, xp / 50);
				//				print ("Current xp: " + xp + ", level: " + level);
		}

	#endregion

		void FiringLogic ()
		{
				if (firing && timeSinceLastShot >= firingDelay) {
						timeSinceLastShot = 0;
			
						if (level > 0) {
								Shoot (transform.position, 0);
						}
			
						if (level > 0) {
								Shoot (transform.position + (Vector3.left / 2.0f), 0);
								Shoot (transform.position + (Vector3.right / 2.0f), 0);
						}
						if (level > 0) {
								Shoot (transform.position + (Vector3.left / 4.0f), 180);
								Shoot (transform.position + (Vector3.right / 4.0f), 180);
						}
						if (level > 0) {
								Shoot (transform.position + (Vector3.left / 2.0f), -30);
								Shoot (transform.position + (Vector3.right / 2.0f),  30);
								Shoot (transform.position + (Vector3.left / 3.0f), 180 + 30);
								Shoot (transform.position + (Vector3.right / 3.0f), 180 - 30);
						}
				}
				timeSinceLastShot += Time.deltaTime;
		}

		void Invulnerability ()
		{
				invulnerabilityTimer -= Time.deltaTime;
				if (invulnerabilityTimer > 0) {
						if (Time.frameCount % 3 == 0) {
								renderer.enabled = !renderer.enabled;
						}
				} else {
						renderer.enabled = true;
				}
		}

		void OnTriggerEnter2D (Collider2D coll)
		{
				if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "EnemyBullet" && invulnerabilityTimer <= 0) {
						Destroy (gameObject);		
				}
		}

		void Shoot (Vector2 position, float angle)
		{
				GameObject newBullet = (GameObject)Instantiate (bullet, position, Quaternion.AngleAxis (180 + angle, Vector3.back));
				Physics2D.IgnoreCollision (newBullet.collider2D, gameObject.collider2D);
				newBullet.GetComponent<BulletProperties> ().speed = speed;
				newBullet.GetComponent<BulletProperties> ().direction = Vector3.down;
				Destroy (newBullet, 1.0f);
		}

}
