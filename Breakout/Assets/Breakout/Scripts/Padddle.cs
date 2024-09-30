using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padddle : MonoBehaviour
{
    // SerializeField nos deja ver el valor de floatSpeed en el inspecto
    [SerializeField] float paddleSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * paddleSpeed; //new Vector3(1, 0, 0);               
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * paddleSpeed; //new Vector3(-1, 0, 0);               
        }
    }
}

