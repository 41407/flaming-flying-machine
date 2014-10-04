﻿using UnityEngine;
using System.Collections;

public class Metronome : MonoBehaviour
{

		public int bar;
		public float beat;
		public float tempo;
		private float tick;
		private float time;

		// Use this for initialization
		void Start ()
		{
				tick = 60f /( tempo);
				bar = 1;
				beat = 1;
		}
	
		// Update is called once per frame
		void Update ()
		{
				time += Time.deltaTime;
		print ("time: " + time + " beat duration: " + tick);
				if (time >= tick) {
						time -= tick;	
						beat++;
						gameObject.audio.Play ();
				}
				
				if (beat == 5) {
						beat = 1;
						bar++;
				}
		}
}
