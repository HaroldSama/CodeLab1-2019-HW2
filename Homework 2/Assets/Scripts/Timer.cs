using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	public int minite = 3;
	public int second;
	public Text MiniteText;
	public Text SecondText;
	public bool counting = true;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating("CountDown", 1, 1); //Start the timer

	}
	
	// Update is called once per frame
	void Update ()
	{

		MiniteText.text = "" + minite; //convey minite to text
		SecondText.text = "0" + second; //convey second to text
		SecondText.text = SecondText.text.Substring(SecondText.text.Length - 2, 2); //turncate the second for the last 2 digits

	}

	void CountDown() //The timer
	{
		print("Counting!");
		if (counting)
		{
			if (second == 0)
            		{
            			if (minite == 0)
            			{
            				counting = false;
            			}
            			else
            			{
            				second = 59;
            				minite--;
            			}
            		}
            		else
            		{
            			second--;
            		}
		}
	}
}
