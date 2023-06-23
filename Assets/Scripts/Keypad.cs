using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keypad : MonoBehaviour
{

    public string password = "1234";
    private string userInput = "";

    public AudioClip clickSound;
    public AudioClip correctSound;
    public AudioClip wrongSound;
    AudioSource audioSource;
    
    private void Start() {
        userInput = "";
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClicked(string number)
    {
        audioSource.PlayOneShot(clickSound);
        userInput += number;

        if(userInput.Length >= 4) {
            if (userInput == password) {
                Debug.Log("correct");
                audioSource.PlayOneShot(correctSound);
                System.Threading.Thread.Sleep(1500);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }else{
                Debug.Log("try again");
                userInput = "";
                audioSource.PlayOneShot(wrongSound);      
            }
        }
        
    } 
}
