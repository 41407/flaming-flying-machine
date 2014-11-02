using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

		public GameObject pawn;
		public GameObject elite;
		public GameObject tank;

		//Here is a private reference only this class can access
		private static Spawn _instance;
	
		//This is the public reference that other classes will use
		public static Spawn the {
				get {
						//If _instance hasn't been set yet, we grab it from the scene!
						//This will only happen the first time this reference is used.
						if (_instance == null)
								_instance = GameObject.FindObjectOfType<Spawn> ();
						return _instance;
				}
		}

		public void StraightMovingPawn (Vector2 startPosition, Vector2 direction, float speed)
		{
				GameObject mob = (GameObject)Instantiate (pawn, startPosition, Quaternion.identity);
				mob.AddComponent<MovementTowardsPoint> ();
				mob.GetComponent<MovementTowardsPoint> ().movement = (direction - startPosition).normalized;
				mob.GetComponent<MovementTowardsPoint> ().speed = speed;
				mob.AddComponent<ShootTowardsPlayer> ();
				mob.GetComponent<ShootTowardsPlayer> ().speed = 10;
				mob.GetComponent<ShootTowardsPlayer> ().fps = 1;
				mob.GetComponent<ShootTowardsPlayer> ().accuracy = 10;
		}

		public void AnchoringPawn (Vector2 startPosition, Vector2 anchorPosition, float speed)
		{
				GameObject mob = (GameObject)Instantiate (pawn, startPosition, Quaternion.identity);
				mob.AddComponent<AnchorToPosition> ();
				mob.GetComponent<AnchorToPosition> ().anchorPosition = anchorPosition;
				mob.GetComponent<AnchorToPosition> ().lerpSpeed = 0.025f;
				mob.AddComponent<ShootTowardsPlayer> ();
				mob.GetComponent<ShootTowardsPlayer> ().speed = 10;
				mob.GetComponent<ShootTowardsPlayer> ().fps = 1;
				mob.GetComponent<ShootTowardsPlayer> ().accuracy = 10;
		}

		public void AnchoringTank (Vector2 startPosition, Vector2 anchorPosition)
		{
				GameObject mob = (GameObject)Instantiate (tank, startPosition, Quaternion.identity);
				mob.AddComponent<AnchorToPosition> ();
				mob.GetComponent<AnchorToPosition> ().anchorPosition = anchorPosition;
				mob.GetComponent<AnchorToPosition> ().lerpSpeed = 0.01f;
				mob.AddComponent<TankShotPattern> ();
		}

		public void Elite (Vector2 startPosition, Vector2 anchorPosition)
		{
				GameObject mob = (GameObject)Instantiate (elite, startPosition, Quaternion.identity);
				mob.AddComponent<AnchorToPosition> ();
				mob.GetComponent<AnchorToPosition> ().anchorPosition = anchorPosition;
				mob.GetComponent<AnchorToPosition> ().lerpSpeed = 0.01f;
		}
}
