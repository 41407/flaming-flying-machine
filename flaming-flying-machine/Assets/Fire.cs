using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{

		public GameObject bullet;
		public GameObject player;


		//Here is a private reference only this class can access
		private static Fire _instance;
	
		//This is the public reference that other classes will use
		public static Fire instance {
				get {
						//If _instance hasn't been set yet, we grab it from the scene!
						//This will only happen the first time this reference is used.
						if (_instance == null)
								_instance = GameObject.FindObjectOfType<Fire> ();
						return _instance;
				}
		}
	
		public void AtAngle (Vector2 position, float angle, float speed)
		{
				FireAtAngle (position, angle, speed);
		}
	
		public void FireAtAngle (Vector2 position, float angle, float speed)
		{
				Quaternion direction = Quaternion.AngleAxis (angle, Vector3.forward);
				Shoot (position, direction, speed);
		}
	
		public void FireAtPlayer (Vector2 position, float speed)
		{
		
		}
	
		private void Shoot (Vector2 position, Quaternion direction, float speed)
		{
				print ("Speed: " + speed);
				GameObject createdBullet = (GameObject)Instantiate (bullet, position, direction);
				createdBullet.GetComponent<BulletProperties> ().speed = speed;
		}
}
