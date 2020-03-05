using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StG : MonoBehaviour
{

    public void Play(){SceneManager.LoadScene("SampleScene");} 

    public void Back(){SceneManager.LoadScene("Menue");} 

    public void Restart(){ SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);} 
    
    public void Exit(){ Application.Quit();}
}
