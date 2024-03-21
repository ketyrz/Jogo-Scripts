using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basuca : MonoBehaviour

{
    public GameObject orangeModel;
    public Transform spawPoint;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.F))
        if (Input.GetMouseButtonDown(0))
            {
            var orangeObject = Instantiate(orangeModel, spawPoint.position, Quaternion.identity);
            Rigidbody orangeRB = orangeObject.GetComponent<Rigidbody>();

            orangeRB.AddForce(spawPoint.forward * force);
        }
        
    }
}