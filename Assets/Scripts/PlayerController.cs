using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f; // units / second

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W)) // moving forward
       {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
       } 
       if (Input.GetKey(KeyCode.S)) // moving backward
       {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
       }
       if (Input.GetKey(KeyCode.D)) // moving right
       {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
       }
       if (Input.GetKey(KeyCode.A)) // moving left
       {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
       }
    }
}
