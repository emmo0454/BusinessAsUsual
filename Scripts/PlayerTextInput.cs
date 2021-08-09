using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTextInput : MonoBehaviour
{
    // public GameManager manager;

    private string reflect;
    public string[] reflections = {"none", "none","none","none","none","none","none","none","none"};
    int counter = 0;

    public string[] responses;
    public string currResponse;
    public float currTime;

    public void ReadStringInput(string input){
      reflect = input;
      reflections[counter] = reflect;
      Debug.Log("Input: " + reflections[counter]);

      //Debug.Log(input);
    }

    public void OnSubmitPush(){
      Debug.Log("PlayerTextInput.OnSubmitPush executing");
      printReflections();
      SceneManager.LoadScene("MainScene");
      Debug.Log(reflections[0]);
    }

    void printReflections(){
      currResponse = reflections[counter];
      // currTime = this.manager.timer;
      // names = manager.namesAppointed;
      // positions = manager.positionsApppointed;
      string path = counter.ToString() + " PlayerResponses.txt";
      if (!File.Exists(path)) {
        using (StreamWriter sw = File.CreateText(path)){
        //  for(int i=0; i<9; i++){
            // currPosition = positions[i];
            // sw.WriteLine("Position: " + currPosition);
            // currName = names[i];
            // sw.WriteLine("Employee Name: " + currName);
            // currTime = times[i];
            // sw.WriteLine("Time: " + currTime + " seconds");
            // currResponse = responses;
            sw.WriteLine("Reflection: " + currResponse);
          //}
        }
      } else {
        Debug.Log("File already exists in downloads folder, cannot write to file.");
      }counter++;
    }
}
