using UnityEngine;
using System.Collections;

public class EnemyDestruction : MonoBehaviour
{
		public int health;

		void Update ()
		{
				if (health <= 0) {	
						Destroy (gameObject);
				}
		}
	
		void OnCollisionEnter2D (Collision2D coll)
		{
				if (coll.gameObject.tag == "PlayerBullet") {
						print ("Muhun oisui!!!!!!");
						BulletProperties p = (BulletProperties)coll.gameObject.GetComponent ("BulletProperties");
			health -= p.damage;

				}
		}
}