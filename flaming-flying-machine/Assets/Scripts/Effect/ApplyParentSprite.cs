using UnityEngine;
using System.Collections;

public class ApplyParentSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject parent = transform.parent.gameObject;
		renderer.material.mainTexture = parent.GetComponent<SpriteRenderer> ().sprite.texture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
