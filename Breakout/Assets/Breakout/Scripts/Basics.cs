using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        // Este fragemento hace que el Vector se mueva a la siguiente posici�n
        //transform.position += new Vector3(3, 0, 0);
    }

    private void Update()
    {
        // Leemos que tecla se est� presionando y en base a eso realizamos una acci�n
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right; //new Vector3(1, 0, 0);               
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left; //new Vector3(-1, 0, 0);               
        }
    }
}
