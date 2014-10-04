using UnityEngine;
using System.Collections;

public class Level1BossMovement : MonoBehaviour {

	public Vector2 goToPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, goToPosition, 0.2f * Time.deltaTime);
	}
}
