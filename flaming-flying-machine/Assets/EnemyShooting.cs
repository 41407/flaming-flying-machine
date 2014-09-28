using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour
{
	
		public GameObject bullet;
		public GameObject player;
		public float firingDelay;
		private float firingCooldown = 0;
		// Use this for initialization
		void Start ()
		{
				firingDelay /= 1000;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (firingCooldown >= firingDelay) {
						firingCooldown = 0;
						GameObject newBullet = (GameObject)Instantiate (bullet, this.gameObject.transform.position, new Quaternion ());
						Angle a = (Angle)newBullet.GetComponent ("Angle");
						a.setAngle (gameObject.transform.position - player.transform.position);
						print (player.transform.position);
				}
				firingCooldown += Time.deltaTime;
		}
}
