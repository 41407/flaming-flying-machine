using UnityEngine;
using System.Collections;

public class MenuLogic : MonoBehaviour
{

		public static string clickedButton;
		public GameObject cam;
		public GameObject mouse;
		private Vector3 mousePosition;

		void Update ()
		{

				if (mouse) {
						mousePosition = GetWorldPositionOnPlane (Input.mousePosition, 0.0f);
						mouse.transform.position = mousePosition;
				}
		}

		private Vector3 GetWorldPositionOnPlane (Vector3 screenPosition, float z)
		{
				Ray ray = Camera.main.ScreenPointToRay (screenPosition);
				Plane xy = new Plane (Vector3.forward, new Vector3 (0, 0, z));
				float distance;
				xy.Raycast (ray, out distance);
				return ray.GetPoint (distance);
		}
		
		public static void LoadLevel ()
		{
				if (clickedButton.Equals ("Button.Level1")) {
						GameStats.setGameLevel (1);
						Application.LoadLevel (GameStats.getGameLevel ());
				} else if (clickedButton.Equals ("Button.MainMenu")) {
						GameStats.setGameLevel (0);
						Application.LoadLevel ("Main Menu");
				} else if (clickedButton.Equals ("Button.Retry")) {
						Application.LoadLevel (GameStats.getGameLevel ());
				} else {
						GameStats.setGameLevel (0);
						Application.LoadLevel (GameStats.getGameLevel ());
				}
		}
}