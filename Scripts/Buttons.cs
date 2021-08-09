using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  public void OnBeginPush(){
    SceneManager.LoadScene("MainScene");
  }


  public void OnExitPush(){
    Debug.Log("Loading QuitScreen");
    SceneManager.LoadScene("QuitScreen");
  }

  public void OnMenuPush(){
    SceneManager.LoadScene("Menu");
  }

  public void OnAppointPush(){
    SceneManager.LoadScene("Reflection");
  }
}
