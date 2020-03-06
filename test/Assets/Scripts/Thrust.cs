using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Thrust : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    public float x = 1.0f;
    float mouseX;
    float mouseY;
    public GameObject eyes;
    public float sensitivity;
    public AudioClip Bear;
    AudioSource audioSource;
    private static int Score;
    private int Nom;  

    void Start()
    {
        Nom = 0;
        
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Score = CarrotCount.Carrots;
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        eyes.transform.Rotate(-mouseY*sensitivity,0,0);
        transform.Rotate(0, mouseX*sensitivity, 0);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 40f);
        }
        else { rb.AddForce(transform.right * 0); }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * 40f);
        }
        else { rb.AddForce(transform.right * 0); }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -40f);
        }
        else { rb.AddForce(transform.right * 0); }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -40f);
        }

        else { rb.AddForce(transform.right * 0); }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 400f);
        }

        else { rb.AddForce(transform.up * 0); }


        if(Nom >= 3)
        {
            SceneManager.LoadScene("Win");
        }





    }


    private void OnCollisionEnter(Collision Col)
    {

        
        if (Col.gameObject.tag == "BadThing")
        {
            if (Score <= 9)
            {

                audioSource.PlayOneShot(Bear);

                StartCoroutine(Example());
                IEnumerator Example()
                {
                    yield return new WaitForSecondsRealtime(1f);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
       else if(Score >= 10)
        {
            Destroy(Col.gameObject);
            Nom++;
        }

        }







    }

}
