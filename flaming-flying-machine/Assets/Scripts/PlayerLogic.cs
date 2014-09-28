using UnityEngine;
using System.Collections;

public class PlayerLogic : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnCollisionEnter2D (Collision2D coll)
		{
				GameObject collidedWith = coll.gameObject;
				if (collidedWith.tag == "Enemy" || collidedWith.tag == "EnemyBullet") {
						Destroy (gameObject);		
				}
		}
}
