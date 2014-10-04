using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public Component[] stages;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.frameCount % 120 == 0) {
			MonoBehaviour curr = (MonoBehaviour)stages[0];
			curr.enabled = true;
		}
		if(Time.frameCount % 240 == 0) {
			MonoBehaviour curr = (MonoBehaviour)stages[0];
			curr.enabled = false;
			curr = (MonoBehaviour)stages[1];
			curr.enabled = true;
		}
	}
}
