using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public AudioClip[] sounds;

	void Start () {
		audio.clip = ((AudioClip)sounds[0]);
		audio.Play();
	}
}
