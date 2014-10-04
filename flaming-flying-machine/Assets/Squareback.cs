using UnityEngine;
using System.Collections;

public class Squareback : MonoBehaviour
{

		public float minSpeed;
		public float randomization;
		private float speed;

		// Use this for initialization
		void Start ()
		{
				speed = minSpeed + Random.Range (0, randomization);
		}
	
		// Update is called once per frame
		void Update ()
		{
				gameObject.transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
}
