using UnityEngine;
using System.Collections;

public class BulletProperties : MonoBehaviour
{
		public int damage;
		public float speed;
		public Vector3 direction;

		void Update ()
		{
				transform.Translate (direction * speed * Time.deltaTime);
		}
}
