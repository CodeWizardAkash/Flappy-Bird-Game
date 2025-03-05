using UnityEngine;
using UnityEngine.UI;

public class Player_script : MonoBehaviour
{   
    private Rigidbody2D rb;
    public float force = 10f;
    public Text finalScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            rb.linearVelocity = Vector2.up * force;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        // if(collision.gameObject.tag == "Gap"){
        //     ScoreScript.instance.score +=1;
        // }
        if(collision.gameObject.tag == "Obstacle"){
            Debug.Log("Game is Over");
            GameMagager.Instance.isGameOver = true;
            finalScore.text = "Score: " + ScoreScript.instance.score.ToString();
            GameMagager.Instance.GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            ScoreScript.instance.scoreUI.SetActive(false);
            GameObject sound = Instantiate(SoundManager.instance.gameOverSound);
            Destroy(sound, 1f);
        }        
    }
}
