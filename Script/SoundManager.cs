using UnityEngine;


public class SoundManager  : MonoBehaviour
{
    public static SoundManager instance;
    public GameObject gameOverSound;
    
    private void Awake(){
        instance = this;
    }
    
    public void Update(){

    }
}
