using UnityEngine;
using System.Collections;

public class MenuLogic : MonoBehaviour
{

		public GameObject cam;
		public GameObject mouse;
		private Vector3 mousePosition;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				mousePosition = GetWorldPositionOnPlane (Input.mousePosition, 0.0f);
				mouse.transform.position = mousePosition;
		}

		private Vector3 GetWorldPositionOnPlane (Vector3 screenPosition, float z)
		{
				Ray ray = Camera.main.ScreenPointToRay (screenPosition);
				Plane xy = new Plane (Vector3.forward, new Vector3 (0, 0, z));
				float distance;
				xy.Raycast (ray, out distance);
				return ray.GetPoint (distance);
		}
}
