using UnityEngine;
using System.Collections;

public class MenuMouseOver : MonoBehaviour
{
	
		void OnTriggerEnter2D (Collider2D coll)
		{
				MenuGlow.position = transform.position;
		}
	
		void OnTriggerExit2D (Collider2D coll)
		{
				MenuGlow.position = new Vector3 (-100, 100, -100);
		}
}
