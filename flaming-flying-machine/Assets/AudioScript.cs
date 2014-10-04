using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public AudioClip[] sounds;

	// Use this for initialization
	void Start () {
		audio.clip = ((AudioClip)sounds[0]);
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
