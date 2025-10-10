using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int coinsCollected = 0;

    public void CollectCoin()
    {
        coinsCollected++;
    }

    public int GetCoinsCollected()
    {
        return coinsCollected;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
