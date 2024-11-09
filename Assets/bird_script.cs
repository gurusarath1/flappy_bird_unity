using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;

    private bool bird_is_alive = true;

    private logic_game exe_logic;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "super bird";

        exe_logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_game>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 61 || transform.position.y < -61 ) {
            exe_logic.gameOver();
            bird_is_alive = false;
            transform.rotation = new Quaternion(-180,0,0,0);
        }

        if(Input.GetKeyDown(KeyCode.Space) == true && bird_is_alive) {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        exe_logic.gameOver();
        bird_is_alive = false;
        transform.rotation = new Quaternion(-180,0,0,0);
    }
}
