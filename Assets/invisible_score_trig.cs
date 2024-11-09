using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_score_trig : MonoBehaviour
{

    private logic_game exe_logic;

    // Start is called before the first frame update
    void Start()
    {
        exe_logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        exe_logic.addScore();
    }
}
