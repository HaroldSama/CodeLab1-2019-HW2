using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBelongs : MonoBehaviour
{

    public int Belong;

    public Material[] Matt;

    private Renderer rend;
    
    public GameObject player1;
    public GameObject player2;

    public int Score1;
    public int Score2;
    
    //Belong: 0:none 1:Player1 2:player2
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
        //Score1 = player1.GetComponent<PlayerController>().score;
        //Score2 = player2.GetComponent<PlayerController>().score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Belong = 1;
            rend.sharedMaterial = Matt[1];
        }

        else if (other.gameObject.CompareTag("Player2"))
        {
            Belong = 2;
            rend.sharedMaterial = Matt[2];
        }

        else if (other.gameObject.CompareTag("Wall"))
        {
            Belong = 0;
            rend.sharedMaterial = Matt[0];
        }

/*        else if (other.gameObject.CompareTag("Prize"))
        {
            print("Score!");
            if (Belong == 1)
            {
                Score1++;
            }

            if (Belong == 2)
            {
                Score2++;
            }
        }*/
    }
}
