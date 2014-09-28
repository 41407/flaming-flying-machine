using UnityEngine;
using System.Collections;

public class PendulumMovement : MonoBehaviour {

	public bool horizontalMovement = true;
	public bool verticalMovement = false;
	public float radius = 10f;
	public float speed = 0.5f;

	private float position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		position += speed;

		Vector2 movementVector;

		if (horizontalMovement) {

						if (verticalMovement) {
								movementVector = new Vector2 (Mathf.Sin (position) * radius, Mathf.Cos (position) * radius);
						} else {
								movementVector = new Vector2 (Mathf.Sin (position) * radius, 0);
						}

				} else if (verticalMovement) {
			movementVector = new Vector2 (0, Mathf.Cos (position) * radius);
				} else {
			movementVector = new Vector2 (0,0);
		}

		this.gameObject.transform.Translate (movementVector * Time.deltaTime * Time.timeScale);
	}
}
