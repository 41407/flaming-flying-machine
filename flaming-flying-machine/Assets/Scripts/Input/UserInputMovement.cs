using UnityEngine;
using System.Collections;

public class UserInputMovement : MonoBehaviour
{
		// Object that will be moved by this script
		public GameObject objectToFollow;
		public bool keyboardInput;
		
		// In units/s
		public float speed;

		// Range: [-1.0, 1.0] 
		private float xMovement;
		private float yMovement;

		void Start ()
		{
				Screen.showCursor = false;
		}

		void Update ()
		{
				Vector2 movementVector;
				if (keyboardInput) {
						movementVector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
				} else {
						Vector2 distanceBetween = objectToFollow.transform.position - transform.position;
						gameObject.GetComponent<PlayerAudio> ().speed = distanceBetween.magnitude;
						if (distanceBetween.magnitude > 1) {				
								movementVector = distanceBetween.normalized;
						} else {
								movementVector = distanceBetween;
						}
				}
				
				transform.Translate (movementVector * speed * Time.deltaTime * Time.timeScale);
		}
}
