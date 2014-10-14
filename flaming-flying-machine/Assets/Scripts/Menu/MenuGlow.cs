using UnityEngine;
using System.Collections;

public class MenuGlow : MonoBehaviour
{

		public static Vector3 position;

		// Use this for initialization
		void Start ()
		{
				position = new Vector3 (0, 0, -100);
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.position = position;
		}
}
