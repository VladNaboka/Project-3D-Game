using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int NumberCoin = 0;
    [SerializeField] TextMeshProUGUI _textMP;

    private void Start()
    {
        NumberCoin = Progres.Instance.Coins;
        _textMP.text = NumberCoin.ToString();
    }
    public void AddCoinToCollect()
    {
        NumberCoin++;
        _textMP.text = NumberCoin.ToString();
    }
    public void SaveProgress()
    {
        Progres.Instance.Coins = NumberCoin;
    }
    public void SpendMoney(int value)
    {
        NumberCoin -= value;
        _textMP.text = NumberCoin.ToString();
    }
}
