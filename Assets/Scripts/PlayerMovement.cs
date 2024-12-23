using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapRange;
    public LogicManager logic;
    public bool birdIsAlive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdIsAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) { 
            myRigidBody.linearVelocity = Vector2.up * flapRange;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
