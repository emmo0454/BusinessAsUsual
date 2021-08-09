using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Conv3 : MonoBehaviour
{
    public Text convText;
    public string[] arr = {"omg lou did this","jamie is gay"};

    void OnTriggerEnter(){
      int l = arr.Length;
      System.Random rand = new System.Random();
      int randomIndex = rand.Next(l);
      convText.text = arr[randomIndex];
    }
}
