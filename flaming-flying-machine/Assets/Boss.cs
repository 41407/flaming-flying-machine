using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour
{

		public Component[] stages;
		public int loopLengthInBar;
		private int currentStage = 0;
		private bool switchStage = true;

		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (switchStage) {	
						DisableAll ();
						((MonoBehaviour)stages [currentStage]).enabled = true;
						currentStage++;
						if (currentStage > stages.Length) {
								currentStage = 0;
						}
						switchStage = false;
				}

		}

		void DisableAll ()
		{
				for (int i = 0; i < stages.Length; i++) {
						((MonoBehaviour)stages [i]).enabled = false;
				}
		}
}