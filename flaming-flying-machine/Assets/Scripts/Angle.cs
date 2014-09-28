using UnityEngine;
using System.Collections;

public class Angle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setAngle(Vector3 deltaPosition) {
		Vector3 relativeLookDirection = deltaPosition;
		float angle = Mathf.Atan2 (relativeLookDirection.y, relativeLookDirection.x) * Mathf.Rad2Deg + 90;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
	}
}
