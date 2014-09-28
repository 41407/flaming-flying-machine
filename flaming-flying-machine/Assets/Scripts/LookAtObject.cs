using UnityEngine;
using System.Collections;

public class LookAtObject : MonoBehaviour
{
		public GameObject objectToLookAt;
	
		void Update ()
		{
				Vector3 relativeLookDirection = gameObject.transform.position - objectToLookAt.transform.position;
				float angle = Mathf.Atan2 (relativeLookDirection.y, relativeLookDirection.x) * Mathf.Rad2Deg + 90;
				transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		}
}
