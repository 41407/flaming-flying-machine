using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour
{
	
		public GameObject bullet;
		public GameObject player;
		public float firingDelay;
		private float firingCooldown = 0;
		public float burstAmount;
		private float shotsFired;
		public float timeBetweenBursts;
		private float timeSinceLastBurst;
		public float accuracy;
		// Use this for initialization
		void Start ()
		{
				firingDelay /= 1000;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (player) {
						if (firingCooldown >= firingDelay && shotsFired < burstAmount) {
								GameObject newBullet = (GameObject)Instantiate (bullet, this.gameObject.transform.position, new Quaternion ());
								newBullet.GetComponent<Angle> ().setAngle (gameObject.transform.position - player.transform.position, accuracy);
								shotsFired++;
								firingCooldown = 0;
								timeSinceLastBurst = 0;
						}
						if (timeSinceLastBurst > timeBetweenBursts) {
								shotsFired = 0;
						}
						timeSinceLastBurst += Time.deltaTime;
						firingCooldown += Time.deltaTime;
				}
		}
}
