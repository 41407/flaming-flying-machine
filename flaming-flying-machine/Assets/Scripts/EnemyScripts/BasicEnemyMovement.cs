using UnityEngine;
using System.Collections;

public class BasicEnemyMovement : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}
}
