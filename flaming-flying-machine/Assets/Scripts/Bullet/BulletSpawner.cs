using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{

		public Vector2 startPosition;
		public Vector2 endPosition;
		public float noteDuration = 0;
		public int shots = 1;
		public float startAngle = 0;
		public float endAngle = 0;
		private float angleModifier = 0;
		private int fired = 0;
		public float speed = 5;
		public GameObject bullet;
		private Vector2 positionStep;
		private Quaternion angle;

		void Start ()
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
				if (fired >= shots) {
						Destroy (gameObject);		
				}
				if (Metronome.beat % noteDuration == 0) {
						Shoot ();
						MoveSpawnpoint ();
						ApplyRotation ();
				}
		}

		void Shoot ()
		{
				GameObject createdBullet = (GameObject)Instantiate (bullet, gameObject.transform.position, angle);
				createdBullet.GetComponent<BulletProperties> ().direction = Vector3.down;
				createdBullet.GetComponent<BulletProperties> ().speed = speed;
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
