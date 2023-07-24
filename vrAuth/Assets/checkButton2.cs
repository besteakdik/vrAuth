using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkButton2 : MonoBehaviour
{
    public void ChangeScene(){
        Debug.Log("clicked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
