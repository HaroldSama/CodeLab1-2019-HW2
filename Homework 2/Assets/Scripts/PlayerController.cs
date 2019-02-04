using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	
	public float forceAmouint = 1;
	
	private Rigidbody2D rb;

	public int score = 0;
	public Text ScoreText;
	
	// Use this for initialization
	void Start ()
	{

		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 newForce = new Vector2(0, 0);  //the force we will add to our player

		if (Input.GetKey(upKey))  //When someone presses "W"
		{
			Debug.Log("Pressed W");
			newForce.y += forceAmouint;
		}
		
		if (Input.GetKey(downKey))  //When someone presses "S"
		{
			Debug.Log("Pressed S");
			newForce.y -= forceAmouint;
		}
		
		if (Input.GetKey(leftKey))  //When someone presses "A"
		{
			Debug.Log("Pressed A");
			newForce.x -= forceAmouint;
		}
		
		if (Input.GetKey(rightKey))  //When someone presses "D"
		{
			Debug.Log("Pressed D");
			newForce.x += forceAmouint;
		}
		
		rb.AddForce(newForce);
		
		ScoreText.text =  "" + score;
		
	}
}
