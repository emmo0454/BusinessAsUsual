using UnityEngine;

public class background_music : MonoBehaviour
{
    // private AudioSource audioSource;
    private static background_music musicManagerInstance;

    private void Awake(){
      DontDestroyOnLoad(this);

      if(musicManagerInstance == null){
        musicManagerInstance = this;
      }else{
        Destroy(gameObject);
      }
    }

    public void PlayMusic(){
      // if(audioSource.isPlaying) return;
      // audioSource.Play();
    }




}
