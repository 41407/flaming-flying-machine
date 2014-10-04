using UnityEngine;
using System.Collections;

public class BackgroundGenerator : MonoBehaviour
{
		public float speed;
		public GameObject[] backgrounds;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Time.frameCount % 60 == 0) {
						Vector3 pos = new Vector3 (Random.Range (-16, 16), 0, 2);
						GameObject backdrop = (GameObject)Instantiate (backgrounds [Random.Range (0, backgrounds.Length - 1)], pos, Quaternion.identity);
						backdrop.GetComponent<BackgroundMovement> ().ySpeed = Random.value * speed;
				}
		}
}