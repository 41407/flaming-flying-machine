using UnityEngine;
using System.Collections;

public class ObjectFollowsMouse : MonoBehaviour {

	public Camera cameraToUse;

	void Update () {
		Vector3 mouseScreenPosition = Input.mousePosition;
		Vector3 mouseWorldPosition = cameraToUse.ScreenToWorldPoint (mouseScreenPosition);	
		mouseWorldPosition.z = 0;
		gameObject.transform.position = mouseWorldPosition;
	}
}
