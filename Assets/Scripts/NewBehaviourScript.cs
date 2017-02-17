﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

	// Use this for initialization
	int min;
	int max;
	int guess;
	
	void Start ()
	{
		StartGame ();
	}
	
	void StartGame ()
	{
		max = 1000;
		min = 1;
		guess = 500;
				
		print ("==================================");
		print ("Welcome to Number Wizard");
		print ("Pick a number, but DON'T tell me.");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal.");
		
		max = max + 1; // fixes rounding issue where stuck at 999
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
		
	}
	
	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up arrow for higher, down for lower, return for equal.");	
	}
	
	
}