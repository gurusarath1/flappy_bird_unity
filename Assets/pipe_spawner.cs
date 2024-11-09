using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner : MonoBehaviour
{

    public GameObject pipe;
    public int spawn_rate = 10;
    private float timer = 0;
    public float height_offset = 5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        float y_max = transform.position.y + height_offset;
        float y_min = transform.position.y - height_offset;

        if(timer < spawn_rate) {
            timer += Time.deltaTime;
        } else {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(y_max, y_min), 0), transform.rotation);
            timer = 0;
        }
    }
}
