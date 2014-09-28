using UnityEngine;
using System.Collections;

public class TimerText : MonoBehaviour {


	private float timer;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		guiText.text = timer.ToString();
	}
}
