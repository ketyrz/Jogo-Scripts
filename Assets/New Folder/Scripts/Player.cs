using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float speed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.position += transform.forward * vertical * speed * Time.deltaTime;

        transform.Rotate(new Vector3(0, horizontal * turnSpeed * Time.deltaTime, 0));
    }
}
