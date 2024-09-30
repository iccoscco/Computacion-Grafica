using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Cuando algo lo colisione el ladrillo se va destruir
        Destroy(gameObject);
    }
}
