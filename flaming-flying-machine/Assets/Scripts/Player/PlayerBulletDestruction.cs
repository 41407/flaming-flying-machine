using UnityEngine;
using System.Collections;

public class PlayerBulletDestruction : MonoBehaviour
{

		public GameObject explosion;

		void OnDestroy ()
		{
				Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.0f);
		}
}
