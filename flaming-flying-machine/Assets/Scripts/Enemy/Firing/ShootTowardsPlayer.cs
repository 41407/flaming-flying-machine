using UnityEngine;
using System.Collections;

public class ShootTowardsPlayer : MonoBehaviour
{

		public float speed;
		public float fps;
		public float accuracy;
		private float cooldown;

		void Start ()
		{
				cooldown = fps;
		}

		void Update ()
		{
				if (cooldown >= fps) {
						Fire.at.Player (transform.position, speed, accuracy);	
						cooldown = 0;
				}
				cooldown += Time.deltaTime;
		}
}
