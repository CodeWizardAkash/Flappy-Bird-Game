using System.Collections;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{   
    public static moveObstacle instance;
    public float speed = 2f;
    public float updownSpeed = 1f;
    public int up = 0;
    bool down = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(RepeateCall());
    }
    void Awake()
    {
        instance = this;
    }


    // Update is called once per frame
    void Update()
    {  
        if(GameMagager.Instance.isGameOver== false){
            transform.Translate(Vector2.left *Time.deltaTime * speed);
        }
        // if(transform.position.y >=2f) up = false;
        // if(transform.position.y <=-2f) down= true;
        if(up <5){
            transform.Translate(Vector2.up * Time.deltaTime * updownSpeed);
        }
        else {
            transform.Translate(Vector2.down * Time.deltaTime * updownSpeed);
        }
    }   
    
}
