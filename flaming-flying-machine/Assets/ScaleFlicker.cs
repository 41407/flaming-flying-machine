using UnityEngine;
using System.Collections;

public class ScaleFlicker : MonoBehaviour
{

		public float minimum;
		public float variance;
	
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				float randomRange = Random.value * (variance) + minimum;
				this.transform.localScale = new Vector2(randomRange, randomRange);
		}
}
