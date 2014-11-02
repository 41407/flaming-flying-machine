using UnityEngine;
using System.Collections;

public class Decay : MonoBehaviour
{

		void OnBecameInvisible ()
		{
				Destroy (gameObject);
		}

		void Update ()
		{
				if (transform.position.x < -16 || transform.position.x > 16) {
						Destroy (gameObject);
				}
		}
}
