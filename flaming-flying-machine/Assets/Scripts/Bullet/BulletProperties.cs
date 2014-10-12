using UnityEngine;
using System.Collections;

public class BulletProperties : MonoBehaviour
{
		public int damage;
		public float speed;
		public Vector3 direction;

		void Start ()
		{
				direction = Vector3.down;
				print ("Bullet's speed: " + speed);
		}

		// Update is called once per frame
		void Update ()
		{
				
				transform.Translate (direction * speed * Time.deltaTime);
		}
}
