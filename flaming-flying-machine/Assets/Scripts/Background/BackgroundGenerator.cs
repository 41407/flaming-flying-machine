using UnityEngine;
using System.Collections;

public class BackgroundGenerator : MonoBehaviour
{
		public Color color;
		public float speed;
		public GameObject[] backgrounds;

		// Use this for initialization
		void Start ()
		{
//				Camera.current.backgroundColor = color;
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Time.frameCount % 20 == 0) {
						int random = (int)Mathf.Pow (-1, Random.Range (0, 2));
						random *= 30;
						random += Random.Range (-5, 5);
						Vector3 pos = new Vector3 (random, 40, 2);
						Instantiate (backgrounds [Random.Range (0, backgrounds.Length - 1)], pos, Quaternion.identity);
				}
		}
}