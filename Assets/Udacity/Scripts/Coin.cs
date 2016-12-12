using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject poof;
    public GameObject coin;

    public void OnCoinClicked() {
        // Instatiate the CoinPoof Prefab where this item is located
        // The poof animates vertically
        Instantiate(poof, coin.transform.position, Quaternion.identity);

        // Destroy the coin.
        Destroy(coin);
    }

}
