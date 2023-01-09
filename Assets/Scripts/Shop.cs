using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    PlayerModification playerModification;
    private void Start()
    {
        playerModification = FindObjectOfType<PlayerModification>();
    }

    public void BuyWidth() 
    { 
        if (coinManager.NumberCoin >= 20)
        {
            coinManager.SpendMoney(20);
            Progres.Instance.Coins = coinManager.NumberCoin;
            Progres.Instance.Wight += 25;
            playerModification.WeightUp(Progres.Instance.Wight);
        }
    }
    public void BuyHeight()
    {
        if (coinManager.NumberCoin >= 20)
        {
            coinManager.SpendMoney(20);
            Progres.Instance.Coins = coinManager.NumberCoin;
            Progres.Instance.Height += 25;
            playerModification.HeightUp(Progres.Instance.Height);
        }
    }
}
