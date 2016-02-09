using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	
	int max;
	int min;
	int guess;

	void Start () {
		 
		StartGame ();
 
	}

	void StartGame()	{

		int max = 1000;
		int min = 1;
		int guess =500;

		max = max + 1;
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		
		print ("The max number you can pick is  " + max);
		print ("The min number you can pick is  " + min);
		
		print ("Is the number higher or lower than  " + guess  );
		print ("Type up arrow for higher, down for lower, return for equal.  " );
		
		
		
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {

			min = guess;
			NextGuess();
		}

		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			
			max = guess;
			NextGuess();
			
		}		else if(Input.GetKeyDown(KeyCode.Return))
			print ("The number you prechoosed is:"  +guess );
	}

	void NextGuess(){
		guess =(min+max)/2;
		print ("Is the number higher or lower than  " + guess  );
		print ("Type up arrow for higher, down for lower, return for equal.  " );

	}
}
