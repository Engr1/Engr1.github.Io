using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazMovement : MonoBehaviour
{
    // Start is called before the first frame update
   
   public GameObject Haz;
   public float X;
   public float Z;
    void Start()
    {
        X = 6;
        Z = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
     Haz.transform.position = new Vector3(X, 1, Z);
    
    if (Haz.transform.position == new Vector3(6, 1, 1)){
            X = X - .1f;
           }













    }
}
