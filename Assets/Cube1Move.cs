using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Move : MonoBehaviour
{
    [SerializeField] float speed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0f, speed * Time.deltaTime, 0f);

    }
}
