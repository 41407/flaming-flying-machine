using UnityEngine;
using System.Collections;

public class PlayerBulletDestruction : MonoBehaviour
{

		public GameObject explosion;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnDestroy ()
		{
				Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.0f);
		}
}
