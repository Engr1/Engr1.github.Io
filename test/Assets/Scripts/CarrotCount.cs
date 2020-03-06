using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarrotCount : MonoBehaviour
{

    
    public AudioClip Chewing, Yay;
    AudioSource audioSource;
    public static int Carrots;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Carrots = 0;
        SetScoreText();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Carrots >= 10)
        {
            var Mat = GetComponent<Renderer>();

            Mat.material.SetColor("_Color", Color.red);
        } 
    }

    private void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "Carrot")
        {


            Carrots++;
            
            Destroy(col.gameObject);

            SetScoreText();

            audioSource.PlayOneShot(Chewing);
        }


    }


    void SetScoreText(){

        ScoreText.text = "Carrots:" + Carrots.ToString();

    }



}
