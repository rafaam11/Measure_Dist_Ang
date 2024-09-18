using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(-10, 0, 0);
        // transform.Translate(new Vector3(2.0f, 0.0f, 2.0f));

        
    }

    float speed = 10.0f;



    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Rotate(Vector3.up * h);
        transform.Rotate(-1 * Vector3.right * v);

        /*
        
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");

        transform.Translate(mouseMoveValueX, 0, mouseMoveValueY);

        */





    }
}
