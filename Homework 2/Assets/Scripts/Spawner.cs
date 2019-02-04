using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("Spawn", 1, 1); //Call Spawn after 1 second and then every 1 second
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn()
	{
		if (gameObject.GetComponent<GameRunner>().GameRunning) //if the game is still running
		{
		    GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));
		    newPrize.transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));			
		}

	}
}
