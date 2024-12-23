using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public LogicManager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer);
        if (collision.gameObject.layer == 0)
        {
            logic.addScore(1);
        }
    }
}
