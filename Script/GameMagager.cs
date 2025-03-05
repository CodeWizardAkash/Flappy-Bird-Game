using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMagager : MonoBehaviour
{
    public static GameMagager Instance;
    public GameObject obstacleprefab;
    // public speed = 5f;
    private float timer = 1f;
    public bool isGameOver = false;
    public GameObject GameOverPanel;
    public float upDownRange = 1.5f;
    // public GameObject LevelPanel;

    private void Awake(){
        Instance = this;
    }
    private void Start(){
        isGameOver = false;
        GameOverPanel.SetActive(false);        
        Time.timeScale = 1f;
    }
    private void Update()
    {   
        // Debug.Log("timer", timer);
        
        if(timer <= 0f){
            if(isGameOver==false){
                GameObject gm = Instantiate(obstacleprefab, new Vector3(2f, Random.Range(-upDownRange,upDownRange), 0f), Quaternion.identity);
                moveObstacle.instance.up = Random.Range(0, 10);
                Destroy(gm, 5f);
                timer += 2f;
                ScoreScript.instance.score +=1;
            }
        }
        else{
            timer -= Time.deltaTime;
        }
    }
    
    public void RetryButton(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("ScenesManager");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
