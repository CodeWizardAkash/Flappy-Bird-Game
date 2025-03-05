using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EasyLevel(){
        SceneManager.LoadScene("Easy");         
        
    }
    public void MediumLevel()
    {   
        SceneManager.LoadScene("Medium");
    }
    public void HardLevel()
    {   
        SceneManager.LoadScene("Hard");
    }
}
