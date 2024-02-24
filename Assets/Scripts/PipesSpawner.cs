using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // Boru örneði
    public float minHeight = -0.7f; // Minimum yükseklik
    public float maxHeight = 2.5f; // Maksimum yükseklik
    public float spawnRate = 2f; // Borularýn spawn hýzý (saniyede kaç boru olacak)

    private float nextSpawnTime = 0f; // Sonraki spawn zamaný

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPipe(); // Boru spawn fonksiyonunu çaðýr
            nextSpawnTime = Time.time + 1f / spawnRate; // Sonraki spawn zamanýný güncelle
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.Range(minHeight, maxHeight); // Rastgele yükseklik belirle
        Vector2 spawnPosition = new Vector2(transform.position.x, randomHeight); // Spawn pozisyonu

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity); // Boru örneðini spawn et
    }
}