using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static ScoreScript instance;
    public TextMeshProUGUI myScore;
    public GameObject scoreUI;
    // public Text finalScore;
    public int score = 0;
    
    private void Awake()
    {
        instance = this;
        
    }
    void Start(){
        scoreUI.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {   
        if(score < 0){
            myScore.text = "GO";
        }
        else {
            myScore.text = score.ToString();
        }        
    }
}
