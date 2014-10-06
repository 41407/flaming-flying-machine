using UnityEngine;
using System.Collections;

public class AlphaRamp : MonoBehaviour
{

		public float startingAlpha;
		public float alphaDecayRate;
		private float currentAlpha;
		public float endingAlpha;
		public bool destroyWhenAtTarget = false;

		// Use this for initialization
		void Start ()
		{
				currentAlpha = startingAlpha;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (currentAlpha >= endingAlpha) {
						currentAlpha -= alphaDecayRate;
						Color c = new Color (renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, currentAlpha);
						renderer.material.color = c;
						
				} else if (destroyWhenAtTarget) {
						Destroy (gameObject);
				}
		}
}
