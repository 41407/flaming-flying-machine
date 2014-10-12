using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class LevelScript : MonoBehaviour
{
		public MonoBehaviour[] enemies;
		public GameObject player;
		public Camera levelCamera;
		private const float tick = 2 * 117.1875f;
		private Queue spawnSequence;
		private float timer;

		void Start ()
		{
				Screen.showCursor = false;
				timer = 0.0f;
		}

		// Update is called once per frame
		void Update ()
		{
				timer += Time.deltaTime;
				if (!player) {
						Application.LoadLevel (0);		
				}
		}	
	
}
