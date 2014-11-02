using UnityEngine;
using System.Collections;

public class MovementTowardsPoint : MonoBehaviour
{

		public Vector2 movement;
		public float speed;

		void Update ()
		{
				transform.Translate (movement * speed * Time.deltaTime);
		}
}
