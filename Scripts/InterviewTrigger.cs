using UnityEngine;
using UnityEngine.SceneManagement;

public class InterviewTrigger : MonoBehaviour
{
    void OnTriggerEnter(){
      SceneManager.LoadScene("OfficeInterview");
    }
}
