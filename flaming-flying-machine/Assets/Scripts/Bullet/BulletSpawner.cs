using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{

		public Vector2 start;
		public Vector2 end;
		public float note;
		public int shots;
		public float angleModifier;
		private int fired = 0;
		public float speed;
		public GameObject bullet;
		private Vector2 iteration;

		// Use this for initialization
		void Start ()
		{

				gameObject.transform.position = start;
				iteration = end - start;
				iteration = new Vector2 (iteration.x / (float)shots, iteration.y / (float)shots);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (fired >= shots) {
						Destroy (gameObject);		
				}
				if (Metronome.beat % note == 0) {
						Shoot ();
						Move ();
				}
		}

		void Shoot ()
		{
				GameObject b = (GameObject)Instantiate (bullet, gameObject.transform.position, Quaternion.AngleAxis ((float)fired * angleModifier, Vector3.forward));
				b.GetComponent<BulletProperties> ().direction = Vector3.down;
				b.GetComponent<BulletProperties> ().speed = speed;
				fired++;
		}

		void Move ()
		{
				gameObject.transform.Translate (iteration);
		}
}
