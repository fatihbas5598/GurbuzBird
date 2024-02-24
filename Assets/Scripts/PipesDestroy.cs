using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesDestroy : MonoBehaviour
{
    public float destroyPoint = -4f;  // Borunun yok olaca�� x konumu

    void Update()
    {
        Destroy();
    }

    void Destroy()
    {
        // Belirli konuma ula��ld���nda boruyu yok etme
        if (transform.position.x < destroyPoint)
        {
            Destroy(gameObject); // Bu scriptin ba�l� oldu�u objeyi yok et
        }
    }
}