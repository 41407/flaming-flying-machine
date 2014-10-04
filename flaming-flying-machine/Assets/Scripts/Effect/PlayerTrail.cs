using UnityEngine;
using System.Collections;

public class PlayerTrail : MonoBehaviour {

	public GameObject sprite;
	public float lifetime;
	public int density;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.frameCount % density == 0) {
			Destroy(Instantiate(sprite, gameObject.transform.position, Quaternion.identity), lifetime);
		}
	}
}
