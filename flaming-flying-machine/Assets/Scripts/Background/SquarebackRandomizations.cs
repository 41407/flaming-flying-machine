using UnityEngine;
using System.Collections;

public class SquarebackRandomizations : MonoBehaviour
{

		public float rotationRandomization;
		public float scaleRandomization;
		private float rotation;
		private float scale;

		// Use this for initialization
		void Start ()
		{
				rotation = Random.Range (-rotationRandomization, rotationRandomization);
				scale = Random.Range (1.0f, scaleRandomization);
				float z = Random.Range (1f, 2f);
				transform.Translate (new Vector3 (0, 0, z + 6));
				transform.localScale = new Vector3 (scale, scale, 0);
				Color c = gameObject.renderer.material.color;
				renderer.material.color = new Color (c.r / z, c.g / z, c.b / z);
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.Rotate (new Vector3 (0, 0, rotation));
		}
}
