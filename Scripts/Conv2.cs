using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Conv2 : MonoBehaviour
{
    public Text convText;
    public string[] arr = {"andre eats celery","lou has problems"};

    void OnTriggerEnter(){
      int l = arr.Length;
      System.Random rand = new System.Random();
      int randomIndex = rand.Next(l);
      convText.text = arr[randomIndex];
    }
}
