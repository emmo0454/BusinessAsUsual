using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Interviewee : MonoBehaviour
{
    public RawImage DisplayLou;
    public RawImage DisplayZack;
    public RawImage DisplayTanya;
    public RawImage DisplayJamie;
    public RawImage DisplayAndre;

    

    static int currIndex;

    public void onCharChange()
    {

      currIndex = GameManager.Index;

      if(currIndex == 0){
        this.DisplayLou.enabled = true;
        this.DisplayZack.enabled = false;
        this.DisplayTanya.enabled = false;
        this.DisplayJamie.enabled = false;
        this.DisplayAndre.enabled = false;
      }
      else if(currIndex == 1){
        this.DisplayZack.enabled = true;
        this.DisplayLou.enabled = false;
        this.DisplayTanya.enabled = false;
        this.DisplayJamie.enabled = false;
        this.DisplayAndre.enabled = false;
      }
      else if(currIndex == 2){
        this.DisplayTanya.enabled = true;
        this.DisplayZack.enabled = false;
        this.DisplayLou.enabled = false;
        this.DisplayJamie.enabled = false;
        this.DisplayAndre.enabled = false;
      }
      else if(currIndex == 3){
        this.DisplayJamie.enabled = true;
        this.DisplayZack.enabled = false;
        this.DisplayTanya.enabled = false;
        this.DisplayLou.enabled = false;
        this.DisplayAndre.enabled = false;
      }
      else if(currIndex == 4){
        this.DisplayAndre.enabled = true;
        this.DisplayZack.enabled = false;
        this.DisplayTanya.enabled = false;
        this.DisplayJamie.enabled = false;
        this.DisplayLou.enabled = false;
      }

    }
}
