using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void TryAgainButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }


}
