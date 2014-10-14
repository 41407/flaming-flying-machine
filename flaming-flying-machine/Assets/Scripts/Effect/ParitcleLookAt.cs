using UnityEngine;
using System.Collections;

public class ParitcleLookAt : MonoBehaviour
{
		public GameObject objectToLookAt;

		void Update ()
		{
				transform.LookAt (objectToLookAt.transform.position);
		}
}
