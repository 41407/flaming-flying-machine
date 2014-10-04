using UnityEngine;
using System.Collections;

public class OrbitAroundParent : MonoBehaviour
{

		public GameObject parent;
		public float speed;
		public float radius;
		public int index;
		private float position;

		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				float xPos = parent.transform.position.x + (Mathf.Sin (position + (2 * (float)index / 3.0f) * Mathf.PI) * radius);
				float yPos = parent.transform.position.y + (Mathf.Cos (position + (2 * (float)index / 3.0f) * Mathf.PI) * radius);
				gameObject.transform.position = new Vector3 (xPos, yPos, 0);
				position += speed;
		}
}
