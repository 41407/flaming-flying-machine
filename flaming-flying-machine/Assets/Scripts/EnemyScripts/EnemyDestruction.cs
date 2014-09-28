using UnityEngine;
using System.Collections;

public class EnemyDestruction : MonoBehaviour
{
		public int health;
		public bool destroysBulletsOnImpact;

		void Update ()
		{
				if (health <= 0) {	
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