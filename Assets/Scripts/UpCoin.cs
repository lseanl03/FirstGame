using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpCoin : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    public int coin;
    private void Start()
    {
        this.coin = 0;
    }
    private void Update()
    {
        this.coinText.text = this.coin.ToString();
    }

}
