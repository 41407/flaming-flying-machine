using UnityEngine;
using System.Collections;

public class Level1BossMovement : MonoBehaviour
{

		public Vector2[] positions;
		private int currentPositionIndex = 0;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				gameObject.transform.position = Vector2.Lerp (gameObject.transform.position, positions [currentPositionIndex], 0.5f * Time.deltaTime);
				if (Vector2.Distance (gameObject.transform.position, positions [currentPositionIndex]) < 1.0f) {
						currentPositionIndex++;
				}
				if (currentPositionIndex >= positions.Length) {
						currentPositionIndex = 0;
				}
		}
}
