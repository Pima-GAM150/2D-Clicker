using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoMineOre;

    public void StartAutoOre()
    {
        AutoMineOre.SetActive(true);
    }
}
