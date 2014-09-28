using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour
{

		public GameObject bullet;
		public int rateOfFire;
		private bool firing = false;
		private int firingCooldown;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetMouseButtonDown (0)) {
						print ("FIREIN'G");
						firing = true;
				} 
				if (Input.GetMouseButtonUp (0)) {
						firing = false;
				}
				if (firing && firingCooldown >= rateOfFire) {
						firingCooldown = 0;
						Instantiate (bullet, this.gameObject.transform.position, new Quaternion ());
				}
		}
}
