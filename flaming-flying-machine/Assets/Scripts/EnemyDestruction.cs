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
	
		void OnCollisionEnter2D (Collision2D coll)
		{
				if (coll.gameObject.tag == "PlayerBullet") {
						BulletProperties p = (BulletProperties)coll.gameObject.GetComponent ("BulletProperties");
						health -= p.damage;
						if (destroysBulletsOnImpact) { 
								Destroy (coll.gameObject);
						}
				}
		}
}