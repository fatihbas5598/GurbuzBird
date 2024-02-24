using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // Boru �rne�i
    public float minHeight = -0.7f; // Minimum y�kseklik
    public float maxHeight = 2.5f; // Maksimum y�kseklik
    public float spawnRate = 2f; // Borular�n spawn h�z� (saniyede ka� boru olacak)

    private float nextSpawnTime = 0f; // Sonraki spawn zaman�

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPipe(); // Boru spawn fonksiyonunu �a��r
            nextSpawnTime = Time.time + 1f / spawnRate; // Sonraki spawn zaman�n� g�ncelle
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.Range(minHeight, maxHeight); // Rastgele y�kseklik belirle
        Vector2 spawnPosition = new Vector2(transform.position.x, randomHeight); // Spawn pozisyonu

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity); // Boru �rne�ini spawn et
    }
}