using UnityEngine;
using System.Collections;

public class MenuCursor : MonoBehaviour
{

		public string currentButton = "none";
		public GameObject cam;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetMouseButtonDown (0) && currentButton.Equals ("Button.Start")) {
						cam.GetComponent<MenuCamera> ().state = 1;		
				}
				if (Input.GetMouseButtonDown (0) && currentButton.Equals ("Button.Quit")) {
						Application.Quit ();	
				}
				if (Input.GetMouseButtonDown (0) && currentButton.Equals ("Button.Level1")) {
						Application.LoadLevel (1);	
				}
		}
	
		void OnTriggerEnter2D (Collider2D col)
		{
				currentButton = col.gameObject.tag;
		}

		void OnTriggerExit2D (Collider2D col)
		{
				currentButton = "none";
		}
}
