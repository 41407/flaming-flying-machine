using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{

		public GameObject bullet;
		public GameObject player;


		//Here is a private reference only this class can access
		private static Fire _instance;
	
		//This is the public reference that other classes will use
		public static Fire at {
				get {
						//If _instance hasn't been set yet, we grab it from the scene!
						//This will only happen the first time this reference is used.
						if (_instance == null)
								_instance = GameObject.FindObjectOfType<Fire> ();
						return _instance;
				}
		}

		public void Angle (Vector2 position, float angle, float speed)
		{
				Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
				Vector3 direction = rotation * Vector3.down;
				Shoot (position, direction, speed);
		}

		public void Angle (Vector2 position, Quaternion direction, float speed)
		{
				Shoot (position, direction, speed);
		}
	
		public void Player (Vector2 position, float speed)
		{
				Shoot (position, (Vector2)player.transform.position - position, speed);
		}

		public void Player (Vector2 position, float speed, float accuracy)
		{
				Vector2 direction = (Vector2)player.transform.position - position;
				direction = Quaternion.AngleAxis (Random.Range (-accuracy, accuracy), Vector3.forward) * direction;
				Shoot (position, (Vector2)player.transform.position - position, speed);
		}
	
		private void Shoot (Vector2 position, Quaternion direction, float speed)
		{
				GameObject createdBullet = (GameObject)Instantiate (bullet, position, direction);
				createdBullet.GetComponent<BulletProperties> ().speed = speed;
		}
	
		private void Shoot (Vector2 position, Vector3 deltaPosition, float speed)
		{
				GameObject createdBullet = (GameObject)Instantiate (bullet, position, Quaternion.identity);
				createdBullet.GetComponent<BulletProperties> ().speed = speed;
				createdBullet.GetComponent<BulletProperties> ().direction = deltaPosition.normalized;
				Destroy (createdBullet, 5.0f);
		}
}
