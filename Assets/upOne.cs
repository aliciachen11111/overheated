using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upOne : MonoBehaviour
{

public Rigidbody2D polarBear;
private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(0.0f, 1.0f);
        polarBear = gameObject.GetComponent<Rigidbody2D>();

 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up")){
            polarBear.MovePosition(polarBear.position + velocity);
        }
        if (Input.GetKeyDown("left")){
            polarBear.MovePosition(polarBear.position + new Vector2(-1.0f, 0.0f));
        }
        if (Input.GetKeyDown("right")){
            polarBear.MovePosition(polarBear.position + new Vector2(1.0f, 0.0f));
        }
    }
}
