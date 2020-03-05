using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class W2Board : MonoBehaviour
{
    

    public GameObject player;
    public GameObject Haz;
    public AudioClip Thump,Tap;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, 1);
            audioSource.PlayOneShot(Tap);
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += new Vector3(-1, 0, 0);
            audioSource.PlayOneShot(Tap);
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position += new Vector3(0, 0, -1);
            audioSource.PlayOneShot(Tap);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(1, 0, 0);
            audioSource.PlayOneShot(Tap);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += new Vector3(0, 1, 0);
            audioSource.PlayOneShot(Tap);
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            player.transform.position += new Vector3(0, -1, 0);
            audioSource.PlayOneShot(Tap);
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            player.transform.position = new Vector3(2, 1, 0);

            var Mat = player.GetComponent<Renderer>();

            Mat.material.SetColor("_Color", Color.blue);
        }



    }

        private void OnCollisionEnter( Collision Col)
    {

        Debug.Log("collision name = " + Col.gameObject.name);
        if (Col.gameObject.name == "Haz")
        {
            audioSource.PlayOneShot(Thump);

            var Mat = player.GetComponent<Renderer>();

            Mat.material.SetColor("_Color", Color.red);


            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

        }




    }



}