using UnityEngine;
using System.Collections;

public class ParitcleLookAt : MonoBehaviour {

	public GameObject objectToLookAt;
	// Use this for initialization
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (objectToLookAt.transform.position);
	}
}
