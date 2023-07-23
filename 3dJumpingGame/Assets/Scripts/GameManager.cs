using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent onGameOver;
    private int coins;


    public void GameOver()
    {
        onGameOver.Invoke();
    }

    public void CoinsCollected(int amount)
    {
        coins += 1;
        Debug.Log(coins + " Coins collected");
    }
}
