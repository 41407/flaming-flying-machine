using UnityEngine;
using System.Collections;

public class BasicEnemyMovement : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
}
