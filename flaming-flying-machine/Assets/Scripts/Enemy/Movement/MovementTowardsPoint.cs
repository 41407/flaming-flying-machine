using UnityEngine;
using System.Collections;

public class MovementTowardsPoint : MonoBehaviour
{

		public Vector2 movement;
		public float speed;

		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.Translate (movement * speed * Time.deltaTime);
		}
}
