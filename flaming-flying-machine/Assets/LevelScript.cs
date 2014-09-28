using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour
{
		public GameObject player;
		public GameObject mouse;
		public GameObject levelCamera;

		// Use this for initialization
		void Start ()
		{
				Instantiate (levelCamera, new Vector3 (0, 0, -20), new Quaternion ());
				Instantiate (player, new Vector3 (0, 0, 0), new Quaternion ());
				Instantiate (mouse, new Vector3 (0, 0, 0), new Quaternion ());

		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
