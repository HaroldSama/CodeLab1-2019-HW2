using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{

	public Vector2 Pos;
	public GameObject Spawner;

	// Use this for initialization
	void Start () {
		
		Spawner = GameObject.FindGameObjectWithTag("GameManager");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		print("I GOT HIT");

		if (other.CompareTag("Ball"))
		{
			//other.GetComponent<PlayerController>().score++;
		}
		
		Destroy(gameObject);
		Spawner.GetComponent<Spawner>().SpawnPosList.Add(Pos);//put the position of this prize back to the list
	}
}
