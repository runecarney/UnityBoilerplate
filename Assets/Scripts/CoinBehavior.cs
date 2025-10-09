using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<LevelManager>().CollectCoin();
        Destroy(this.gameObject);
    }
}
