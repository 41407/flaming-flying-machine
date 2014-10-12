using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour
{

		public GameObject bullet;
		public float firingDelay;
		public float speed;
		static public int level = 1;
		public Sprite[] sprites;
		private bool firing = false;
		private float timeSinceLastShot = 0;
		static public int xp = 0;
		// Use this for initialization
		void Start ()
		{
				xp = 0;
				firingDelay /= 1000;
		}

		public static void xpUp (int xpGain)
		{	
				xp += xpGain;
				level = Mathf.Max (1, xp / 50);
//				print ("Current xp: " + xp + ", level: " + level);
		}

		// Update is called once per frame
		void Update ()
		{		
				CheckXp ();
				CheckInput ();
				if (firing && timeSinceLastShot >= firingDelay) {
						timeSinceLastShot = 0;
						
						if (level > 0) {
								Shoot (0);
						}
			
						if (level > 1) {
								Shoot (-20f);
								Shoot (20f);
						}
				}
				timeSinceLastShot += Time.deltaTime;
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
		}

		void Shoot (float angle)
		{
				GameObject newBullet = (GameObject)Instantiate (bullet, transform.position, Quaternion.AngleAxis (180 + angle, Vector3.back));
				Physics2D.IgnoreCollision (newBullet.collider2D, gameObject.collider2D);
				newBullet.GetComponent<BulletProperties> ().speed = speed;
				newBullet.GetComponent<BulletProperties> ().direction = Vector3.down;
				Destroy (newBullet, 1.0f);
		}

		void CheckXp ()
		{
				gameObject.GetComponent<SpriteRenderer> ().sprite = sprites [level - 1];
		}
}
