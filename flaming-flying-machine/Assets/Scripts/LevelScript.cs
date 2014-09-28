using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour
{
		public GameObject enemy;
		public GameObject player;

		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
			//	if (Time.frameCount % 10 == 0) {
			//			GameObject e = (GameObject)Instantiate (enemy, new Vector3 (Random.Range (-40, 40), 10, 0), new Quaternion ());
		//				EnemyShooting es = e.GetComponent<EnemyShooting> ();
		///				es.player = player;
		//		}
		}
}
