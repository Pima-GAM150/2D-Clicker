using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoMineOre;
    public GameObject AutoSell;

    public void StartAutoOre()
    {
        AutoMineOre.SetActive(true);
        GlobalCash.CashCount -= GlobalMiner.minerValue;
        GlobalMiner.minerValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalMiner.turnOffButton = true;
        GlobalMiner.minedPerSec += 1;
        GlobalMiner.numberOfMiners += 1;
    }

    public void StartAutoSell()
    {
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalMiner.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
}
