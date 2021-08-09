using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitButton : MonoBehaviour
{

  // public GameManager manager;

    void OnPush(){
      // manager.appoint();
      SceneManager.LoadScene("MainScene");
    }

}
