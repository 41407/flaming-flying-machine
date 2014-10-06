using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour
{
		public float shakeFactor;
		public float shake;
		public float x;
		public float y;

		// Use this for initialization
		void Start ()
		{
				shake = 10f;
		}

		public void set (float shake)
		{
				this.shake += shake;
		}

		// Update is called once per frame
		void Update ()
		{
				this.shake *= shakeFactor;
				Vector3 shaky = new Vector3 (x + Random.value * shake, y + Random.value * shake, gameObject.transform.position.z);
				transform.position = shaky;
		}
}
