﻿using UnityEngine;
using System.Collections;

public class RandomizePitch : MonoBehaviour
{

		public float amount = 0;

		// Use this for initialization
		void Start ()
		{
				if (gameObject.audio) {
						audio.pitch = Mathf.Min (1 + Random.Range (-amount, amount));
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
