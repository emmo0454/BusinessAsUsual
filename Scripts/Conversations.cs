using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Conversations : MonoBehaviour
{
    public Text convText;
    public string[] arr = {"hello","goodbye"};

    void OnTriggerEnter(){
      int l = arr.Length;
      System.Random rand = new System.Random();
      int randomIndex = rand.Next(l);
      convText.text = arr[randomIndex];
    }
}
