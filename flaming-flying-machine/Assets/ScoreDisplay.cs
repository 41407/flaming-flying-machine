﻿using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				GetComponent<TextMesh> ().text = "" + GameStats.getScore ();
		}
}
