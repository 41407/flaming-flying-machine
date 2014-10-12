using UnityEngine;
using System.Collections;

public class ApplyParentSprite : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				GameObject parent = transform.parent.gameObject;
				renderer.material.mainTexture = parent.GetComponent<SpriteRenderer> ().sprite.texture;
	
		}
}
