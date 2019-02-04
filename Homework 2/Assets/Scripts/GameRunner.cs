using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameRunner : MonoBehaviour
{

	public KeyCode StartKey;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Timer;
	public Text StartText;
	public Text EndText;
	public Text WinnerText;
	public bool GameRunning;
	public bool GameEnds;

	public int score1;
	public int score2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			score1 = Player1.GetComponent<PlayerController>().score; //Get player1's score
			score2 = Player2.GetComponent<PlayerController>().score; //Get player2's score
		
		if (GameEnds == false && GameRunning == false && Input.GetKey(StartKey)) //When the StartKey is Pressed
		{
			GameRunning = true;
			Player1.GetComponent<PlayerController>().enabled = true; //Enable Player1's control
			Player2.GetComponent<PlayerController>().enabled = true; //Enable Player2's control
			gameObject.GetComponent<Spawner>().enabled = true; //Enable prizes to spawn
			Timer.GetComponent<Timer>().enabled = true; //Start the timer
			Destroy(StartText); //Hide the Start text
		}

		if (GameEnds == false && GameRunning && Timer.GetComponent<Timer>().counting == false) //When time's up
		{
			GameEnds = true;
			GameRunning = false;
			Player1.GetComponent<PlayerController>().enabled = false; //Disable Player1's control
			Player2.GetComponent<PlayerController>().enabled = false; //Disable Player2's control
			gameObject.GetComponent<Spawner>().enabled = false; //Disable prizes to spawn
			Timer.GetComponent<Timer>().enabled = false; //Disable the timer
			EndText.text = "Time's Up!"; //Show EndText
            print("Time's up!");
			


			if (score1 == score2) //Compare scores
			{
				WinnerText.text = "Tie!";
			}
			else if (score1 > score2)
			{
				WinnerText.text = "The winner is: Player 1!";
			}
			else
			{
				WinnerText.text = "The winner is: Player 2!";
			}
		}
		
	}
}
