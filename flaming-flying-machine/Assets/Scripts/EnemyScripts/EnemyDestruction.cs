using UnityEngine;
using System.Collections;

public class EnemyDestruction : MonoBehaviour
{
		public GameObject explosion;
		public int health;
		public bool destroysBulletsOnImpact;

		void Update ()
		{
				if (health <= 0) {	
						Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 0.1f);
						Destroy (gameObject);
				}
		}
	
		void OnTriggerEnter2D (Collider2D coll)
		{
				if (coll.gameObject.tag == "PlayerBullet") {
						health -= coll.gameObject.GetComponent<BulletProperties> ().damage;
						if (destroysBulletsOnImpact) { 
								Destroy (coll.gameObject);
						}
				}
		}
}