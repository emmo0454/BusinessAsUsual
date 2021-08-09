using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Set_Interviewee set;
    public static int Index = 0;

    // public float timeSinceLoad;
    public float timer;
    public float[] times;
    int counter;


    // public string[] namesAppointed = {"none", "none","none","none","none","none","none","none","none"};
    // public string[] positionsApppointed = {"none", "none","none","none","none","none","none","none","none"};
    // string currName;
    // string currPosition;

    public Text character;
    public Text years;
    public Text productivity;
    public Text Info1;
    public Text Info2;
    public Text Info3;
    public Text position;

    public string[] names = {"Lou Scott", "Zackary Wortham", "Tanya Adekunle", "Jamie Chen", "Andre Perez"};
    public string[] yearNum = {"3 years with our company", "7 years with our company", "1 year with our company", "5 years with our company", "10 years with our company"};
    public string[] produRate = {"86% Productivity", "91% Productivity", "88% Productivity", "93% Productivity", "87% Productivity"};
    public string[] info1 = {"3 years away from retirement", "Requested to work from home", "Always uses all vacation days", "Sometimes hard to hear in meetings", "No personal pictures on desk"};
    public string[] info2 = {"Bachelor's degree from CU", "Bachelor's from Community College", "Master's degree from School of Mines", "Unrelated Bachelor's from Northern Colorado", "Bachelor's from Arizona"};
    public string[] info3 = {"Displays excellent leadership", "Good decision maker", "Well-liked by the staff", "Excellent client interactions", "Very self-motivated"};
    public string[] positions = {"Group Leader", "Take out trash", "Arrange Happy Hour", "Sales", "Reception", "Human Resources", "Meeting Notetaker", "Traveling Sales", "Tech Help"};

    void Start(){
      int l = positions.Length;
      System.Random rand = new System.Random();
      int randomIndex = rand.Next(l);
      position.text = positions[randomIndex];
      // currPosition = positions[randomIndex];
    }
    void Update()
    {
      character.text = names[Index];
      years.text = yearNum[Index];
      productivity.text = produRate[Index];
      Info1.text = info1[Index];
      Info2.text = info2[Index];
      Info3.text = info3[Index];

      set.onCharChange();
      timer = Time.timeSinceLevelLoad;
      Debug.Log(timer);

    }

    // public void time(){
    //   if(timer == 30){
    //   Info1.gameObject.SetActive(true);
    // }
    // else if(timer == 60){
    //
    // }


    public void next(){
      if(Index == 5){
        SceneManager.LoadScene("MainScene");
      }else{
      Index++;
      // timer = timer - Time.timeSinceLevelLoad;

    }
    }
    public void previous(){
      Index--;
    }
    public void appoint(){
      // times[counter] = timer;
      // counter++;
      // setIndexName();
      // positionsApppointed[counter] = currPosition;
      // namesAppointed[counter] = currName;

      // SceneManager.LoadScene("Reflection");
    }

    // public void setIndexName(){
    //   if(Index == 0){
    //     currName = "Lou Scott";
    //   }
    //   if(Index == 1){
    //     currName = "Zackary Wortham";
    //   }
    //   if(Index == 2){
    //     currName = "Tanya Adekunle";
    //   }
    //   if(Index == 3){
    //     currName = "Jamie Chen";
    //   }
    //   if(Index == 4){
    //     currName = "Andre Perez";
    //   }
    // }

//Time.timeSinceLevelLoad
}
