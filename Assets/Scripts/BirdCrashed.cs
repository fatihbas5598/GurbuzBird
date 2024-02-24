using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCrashed : MonoBehaviour
{
    public GameObject GameOverMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipes")
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
    }
}
