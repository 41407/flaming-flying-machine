using UnityEngine;
using System.Collections;

public class TankShotPattern : MonoBehaviour
{
		public float shootingInterval = 0.3f;
		private float shootingTimer = 3f;
		public float angle = 0;
		public float angleIteration = 5;

		void Update ()
		{
				shootingTimer -= Time.deltaTime;
				if (shootingTimer <= 0) {
						Fire.at.Angle (transform.position, angle, 3.5f);
						Fire.at.Angle (transform.position, angle + 90, 3.5f);
						Fire.at.Angle (transform.position, angle + 180, 3.5f);
						Fire.at.Angle (transform.position, angle + 270, 3.5f);
						shootingTimer = shootingInterval;
						angle += angleIteration;
				}
		}
}
