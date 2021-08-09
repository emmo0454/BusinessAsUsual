using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitFunctions : MonoBehaviour
{
  //public PlayerTextInput playerInput;
  // public GameManager manager;
  // public string[] responses;
  // public string currResponse;
  // public float[] times;
  // public float currTime;
  // public string[] names;
  // public string currName;
  // public string[] positions;
  // public string currPosition;


  public void Exit(){
    Debug.Log("QuitFunctions.Exit executing");
    //printReflections();
    Application.Quit();
  }

  // void printReflections(){
  //   responses = playerInput.reflections;
  //   Debug.Log(playerInput.reflections[0]);
  //   // times = manager.times;
  //   // names = manager.namesAppointed;
  //   // positions = manager.positionsApppointed;
  //   string path = "PlayerResponses.txt";
  //   if (!File.Exists(path)) {
  //     using (StreamWriter sw = File.CreateText(path)){
  //       for(int i=0; i<9; i++){
  //         // currPosition = positions[i];
  //         // sw.WriteLine("Position: " + currPosition);
  //         // currName = names[i];
  //         // sw.WriteLine("Employee Name: " + currName);
  //         // currTime = times[i];
  //         // sw.WriteLine("Time: " + currTime + " seconds");
  //         currResponse = responses[i];
  //         sw.WriteLine("Reflection: " + currResponse);
  //       }
  //     }
  //   } else {
  //     Debug.Log("File already exists in downloads folder, cannot write to file.");
  //   }
  // }
}
