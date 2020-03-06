using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazMovement : MonoBehaviour {



    Rigidbody rb;
    public Transform Player;
	int MaxDist = 10;
	int MinDist = 0;
    private static int Score;



	void Start()
	{
        rb = GetComponent<Rigidbody>();

    }

	void Update()
	{
        Score = CarrotCount.Carrots;

		




        if (Score <= 10)
        {transform.LookAt(Player);
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    rb.AddForce(transform.forward * 40f);
                }

            }
        }


        if (Score >= 10)
        {
            transform.LookAt(2*transform.position - Player.position);
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {   

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                   rb.AddForce(transform.forward * 60f); 
                }

            }
        }






    }
}