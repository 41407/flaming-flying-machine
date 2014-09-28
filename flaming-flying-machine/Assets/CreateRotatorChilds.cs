using UnityEngine;
using System.Collections;

public class CreateRotatorChilds : MonoBehaviour {

	public GameObject rotatorChild;

	// Use this for initialization
	void Start () {
		for (int i = 1; i < 4; i++) {
			GameObject child = (GameObject) Instantiate(rotatorChild, gameObject.transform.position, Quaternion.identity);
			child.GetComponent<OrbitAroundParent>().index = i;
			child.GetComponent<OrbitAroundParent>().speed = 0.05f;
			child.GetComponent<OrbitAroundParent>().radius = 0.5f;
			child.GetComponent<OrbitAroundParent>().parent = gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
