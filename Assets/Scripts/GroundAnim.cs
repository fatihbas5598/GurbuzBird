using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnim : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Vector2 offsetChangePerSecond;


    void Update()
    {
        // Mevcut offset de�erini al
        Vector2 currentOffset = spriteRenderer.material.GetTextureOffset("_MainTex");

        // Delta time ile �arparak frame rate ba��ms�z hale getir
        currentOffset += offsetChangePerSecond * Time.deltaTime;

        // Yeni offset de�erini atar
        spriteRenderer.material.SetTextureOffset("_MainTex", currentOffset);
    }

}
