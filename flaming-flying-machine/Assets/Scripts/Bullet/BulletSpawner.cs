using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{

		public Vector2 startPosition;
		public Vector2 endPosition;
		public float rateOfFire = 0.10f;
		private float timeSinceLastShot = 0;
		public int shots = 1;
		public float startAngle = 0;
		public float endAngle = 0;
		private float angleModifier = 0;
		private int fired = 0;
		public float speed = 5;
		public GameObject bullet;
		private Vector2 positionStep;
		private Quaternion angle;
		private bool initialized = false;
		private int lifetime = 0;

		void Initialize ()
		{

				ValidateValues ();
				angle = Quaternion.AngleAxis (startAngle, Vector3.forward);
				angleModifier = (Mathf.Abs (startAngle) + Mathf.Abs (endAngle)) / shots;
				if (startAngle > endAngle) {
						angleModifier *= -1;
				}
				transform.position = startPosition;
				positionStep = endPosition - startPosition;
				positionStep = new Vector2 (positionStep.x / (float)shots, positionStep.y / (float)shots);
				initialized = true;

		}

		void ValidateValues ()
		{		
				if (shots < 1) {
						Debug.Log ("Number of shots initialized at " + shots, gameObject);
						shots = 1;
				}
		}

		void Update ()
		{
				if (!initialized && lifetime > 0) {
						Initialize ();
				}
				if (initialized) {
						if (fired >= shots) {
								Destroy (gameObject);		
						}
						timeSinceLastShot += Time.deltaTime;
						if (timeSinceLastShot >= rateOfFire) {
								Shoot ();
								MoveSpawnpoint ();
								ApplyRotation ();
								timeSinceLastShot = 0;
						}
				}
				lifetime++;
		}

		void Shoot ()
		{
				Fire.at.Angle (transform.position, angle, speed);
				fired++;
		}

		void MoveSpawnpoint ()
		{
				transform.Translate (positionStep);
		}

		void ApplyRotation ()
		{
				angle = Quaternion.AngleAxis (startAngle + fired * angleModifier, Vector3.forward);
		}
}
