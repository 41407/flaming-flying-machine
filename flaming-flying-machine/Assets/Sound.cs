﻿using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnDestroy ()
		{
				audio.Play ();
		}
}
