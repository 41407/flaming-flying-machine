using UnityEngine;
using System.Collections;

public class TimerText : MonoBehaviour {

	private const float tick = 117.1875f;
	private float timeBetweenTicks;
	private float timer;
	private float beatTimer;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		beatTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timeBetweenTicks += Time.deltaTime*1000;
		if (timeBetweenTicks >= tick) {
			beatTimer += 0.0625f;		
			timeBetweenTicks -= tick;
		}

		guiText.text = ("Sec: " + timer.ToString() + "\nBeat: " + beatTimer.ToString());
	}
}
