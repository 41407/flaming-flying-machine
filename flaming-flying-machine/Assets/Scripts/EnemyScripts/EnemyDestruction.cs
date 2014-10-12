using UnityEngine;
using System.Collections;

public class EnemyDestruction : MonoBehaviour
{
		public GameObject hitEffect;
		public GameObject explosion;
		public int health;
		private int maxHealth;
		public bool destroysBulletsOnImpact;

		void Start ()
		{
				maxHealth = health;
		}

		void Update ()
		{
				if (health <= 0) {	
						PlayerFiring.xpUp (maxHealth);
						Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.0f);
						Destroy (gameObject);
				}
		}
	
		void OnTriggerEnter2D (Collider2D coll)
		{
				if (coll.gameObject.tag == "PlayerBullet") {
						health -= coll.gameObject.GetComponent<BulletProperties> ().damage;
						if (destroysBulletsOnImpact) {
								Destroy (Instantiate (hitEffect, coll.gameObject.transform.position, Quaternion.identity), 3.0f);

								Destroy (coll.gameObject);
						}
				}
		}
}