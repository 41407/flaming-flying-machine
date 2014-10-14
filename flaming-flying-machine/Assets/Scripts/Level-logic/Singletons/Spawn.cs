using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

		public GameObject pawn;
		public GameObject elite;

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
				GameObject newPawn = (GameObject)Instantiate (pawn, startPosition, Quaternion.identity);
				newPawn.AddComponent<MovementTowardsPoint> ();
				newPawn.GetComponent<MovementTowardsPoint> ().movement = (direction - startPosition).normalized;
				newPawn.GetComponent<MovementTowardsPoint> ().speed = speed;
				newPawn.AddComponent<ShootTowardsPlayer> ();
				newPawn.GetComponent<ShootTowardsPlayer> ().speed = 10;
				newPawn.GetComponent<ShootTowardsPlayer> ().fps = 1;
				newPawn.GetComponent<ShootTowardsPlayer> ().accuracy = 10;
		}

		public void AnchoringPawn (Vector2 startPosition, Vector2 anchorPosition, float speed)
		{
				GameObject newPawn = (GameObject)Instantiate (pawn, startPosition, Quaternion.identity);
				newPawn.AddComponent<AnchorToPosition> ();
				newPawn.GetComponent<AnchorToPosition> ().anchorPosition = anchorPosition;
				newPawn.GetComponent<AnchorToPosition> ().lerpSpeed = 0.025f;
				newPawn.AddComponent<ShootTowardsPlayer> ();
				newPawn.GetComponent<ShootTowardsPlayer> ().speed = 10;
				newPawn.GetComponent<ShootTowardsPlayer> ().fps = 1;
				newPawn.GetComponent<ShootTowardsPlayer> ().accuracy = 10;
		}
}
