using UnityEngine;
using System.Collections;

public class Decay : MonoBehaviour
{

		void OnBecameInvisible ()
		{
				Destroy (gameObject);
		}
}
