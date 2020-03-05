using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public GameObject board;
    public GameObject player;
    public AudioClip Splash;
    AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision Col)
    {

        Debug.Log("collision name = " + Col.gameObject.name);
        if (Col.gameObject.name == "Player")
        {
            
            audioSource.PlayOneShot(Splash);

            var Mat = board.GetComponent<Renderer>();

            Mat.material.SetColor("_Color", Color.blue);
        }


    }
}
