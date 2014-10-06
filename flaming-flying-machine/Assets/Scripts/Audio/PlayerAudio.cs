using UnityEngine;
using System.Collections;

public class PlayerAudio : MonoBehaviour
{

		public bool firing = false;
		public AudioSource moving;
		public AudioSource still;
		public float firingMasterVolume = 1;
		public float speed;
		public float speedThreshold = 1.0f;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (firing) {
						if (speed > speedThreshold) {
								AddVolume (moving);
								ReduceVolume (still);
						} else {
								AddVolume (still);
								ReduceVolume (moving);
						}
						
						
				} else {
						moving.volume = 0;
						still.volume = 0;
				}
		}
	
		void AddVolume (AudioSource source)
		{
				source.volume = Mathf.Min (firingMasterVolume, source.volume + 0.05f);
		}
	
		void ReduceVolume (AudioSource source)
		{
				source.volume = Mathf.Max (0, source.volume - 0.05f);
		}
}
