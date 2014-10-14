using UnityEngine;
using System.Collections;

public class ApplyParentSprite : MonoBehaviour
{
		void Update ()
		{
				renderer.material.mainTexture = transform.parent.gameObject.GetComponent<SpriteRenderer> ().sprite.texture;
		}
}
