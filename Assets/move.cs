using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float move_speed = 100;
    private float dead_x = -200;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * move_speed) * Time.deltaTime;

        if(transform.position.x <= dead_x) {
            Destroy(gameObject);
        }
    }
}
