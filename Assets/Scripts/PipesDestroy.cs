using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesDestroy : MonoBehaviour
{
    public float destroyPoint = -4f;  // Borunun yok olacaðý x konumu

    void Update()
    {
        Destroy();
    }

    void Destroy()
    {
        // Belirli konuma ulaþýldýðýnda boruyu yok etme
        if (transform.position.x < destroyPoint)
        {
            Destroy(gameObject); // Bu scriptin baðlý olduðu objeyi yok et
        }
    }
}