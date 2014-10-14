using UnityEngine;
using System.Collections;

public class EliteMovement : MonoBehaviour
{

		public float targetY;
		private Vector2 targetPosition;

		// Use this for initialization
		void Start ()
		{
				targetPosition = new Vector2 (transform.position.x, targetY);
		}
	
		// Update is called once per frame
		void Update ()
		{
				gameObject.transform.position = Vector2.Lerp (transform.position, targetPosition, 0.025f);

		}
}
