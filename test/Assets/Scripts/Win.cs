using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Win : MonoBehaviour
{

  public AudioClip Yay;

public GameObject Player;
AudioSource audioSource;
void Start(){

    audioSource = GetComponent<AudioSource>();
}

private void OnCollisionEnter( Collision Col)
    {

        Debug.Log("collision name = " + Col.gameObject.name);
        if (Col.gameObject.name == "Player")
        {
            StartCoroutine(Example());
            IEnumerator Example()
        {

                yield return new WaitForSecondsRealtime(1.5f);
            SceneManager.LoadScene("Win");
            
        }

            audioSource.PlayOneShot(Yay);



        }

}
}