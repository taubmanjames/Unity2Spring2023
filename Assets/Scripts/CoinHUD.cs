using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinHUD : MonoBehaviour
{
    public int coinsCollected;
    public int coinsInScene;
    public TMP_Text coinDisplay;


    // Start is called before the first frame update
    void Start()
    {
        coinDisplay.text = $"Coins {coinsCollected}/{coinsInScene}";
    }

    public void CoinCollected()
    {
        coinsCollected++;
        coinDisplay.text = $"Coins {coinsCollected}/{coinsInScene}";
    }

}
