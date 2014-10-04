using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour
{

		public float rotationSpeed;
		public float ySpeed;
		public float scale;

		void Start ()
		{
				rotationSpeed *= Random.value;
				scale *= Random.value;
				gameObject.transform.localScale = new Vector3 (scale, scale, 0);
				gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + scale * 10, 0);
		}

		void Update ()
		{
				gameObject.transform.Translate (Vector3.down * ySpeed * Time.deltaTime);
				gameObject.transform.Rotate (0, 0, rotationSpeed);
		}
}
