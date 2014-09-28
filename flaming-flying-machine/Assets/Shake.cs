using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour
{
		public float shakeFactor;
		public float shake;

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
				Vector3 shaky = new Vector3 (Random.value * shake, Random.value * shake, gameObject.transform.position.z);
				gameObject.transform.position = shaky;
		}
}
