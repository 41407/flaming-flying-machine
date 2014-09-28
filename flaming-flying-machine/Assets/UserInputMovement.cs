using UnityEngine;
using System.Collections;

public class UserInputMovement : MonoBehaviour
{

		public GameObject objectToControl;
		public bool keyboardInput;
		public float speed;
		private float xMovement;
		private float yMovement;

		void Update ()
		{
				if (keyboardInput) {
						xMovement = Input.GetAxisRaw ("Horizontal");
						yMovement = Input.GetAxisRaw ("Vertical");
		
						Vector2 movementVector = new Vector2 (xMovement, yMovement);
		
						objectToControl.transform.Translate (movementVector * speed * Time.deltaTime * Time.timeScale);
				}
		}
}
