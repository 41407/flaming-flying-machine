using UnityEngine;
using System.Collections;

public class AnchorToPosition : MonoBehaviour
{
		public Vector2 anchorPosition;
		public float lerpSpeed;

		void Update ()
		{
				gameObject.transform.position = Vector2.Lerp (transform.position, anchorPosition, lerpSpeed);
		}
}
