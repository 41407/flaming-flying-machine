using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour {
	
	public float x;
	public float y;
	public float z;

	void Update () {
		gameObject.transform.Rotate(new Vector3(x * Time.deltaTime, y* Time.deltaTime, z* Time.deltaTime));
	}
}
