using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoMineOre;

    public void StartAutoOre()
    {
        AutoMineOre.SetActive(true);
        GlobalCash.CashCount -= GlobalMiner.minerValue;
        GlobalMiner.minerValue *= 2;
        GlobalMiner.turnOffButton = true;
    }
}
