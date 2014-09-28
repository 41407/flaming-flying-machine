using UnityEngine;
using System.Collections;

public class LookAtObject : MonoBehaviour
{
		public GameObject objectToLookAt;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 moveDirection = objectToLookAt.transform.position;
				if (moveDirection != Vector3.zero) {
						float angle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg - 90;
						transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
				}
	
		}
}
