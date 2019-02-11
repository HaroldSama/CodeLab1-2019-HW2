using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{

	[FormerlySerializedAs("SpawnPos")] public List<Vector2> SpawnPosList;
	public Vector2 PossibleSpawnPos;
	public Vector2 ActualSpawnPos;
	    
	// Use this for initialization
	void Start ()
	
	{
		//create a list for all possible positions to spawn
		for (int i = 0; i < 6; i++)
		{
			for (int j = 0; j < 6; j++)
			{
				PossibleSpawnPos = new Vector2(j * 4 - 10, i * 2 - 5);
				SpawnPosList.Add(PossibleSpawnPos);
			}
		}
		InvokeRepeating("Spawn", 1, 1); //Call Spawn after 1 second and then every 1 second
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn()
	{
		if (gameObject.GetComponent<GameRunner>().GameRunning && SpawnPosList.Count > 0) //if the game is still running and there's still a position available for spawn
		{
		    GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));//spawn a prize
		    ActualSpawnPos = SpawnPosList[Random.Range(0, SpawnPosList.Count)];//chose a random position from the list
		    SpawnPosList.Remove(ActualSpawnPos);//remove that position from the list
		    newPrize.transform.position = ActualSpawnPos;//move the prize to the chosen position
		    newPrize.GetComponent<PrizeScript>().Pos = ActualSpawnPos;//record the position in the prize
		}

	}
}
