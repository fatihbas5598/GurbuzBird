using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnim : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Vector2 offsetChangePerSecond;


    void Update()
    {
        // Mevcut offset deðerini al
        Vector2 currentOffset = spriteRenderer.material.GetTextureOffset("_MainTex");

        // Delta time ile çarparak frame rate baðýmsýz hale getir
        currentOffset += offsetChangePerSecond * Time.deltaTime;

        // Yeni offset deðerini atar
        spriteRenderer.material.SetTextureOffset("_MainTex", currentOffset);
    }

}
