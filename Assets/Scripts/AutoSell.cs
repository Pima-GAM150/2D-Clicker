using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour {

    public bool SellingOre = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

	
	void Update ()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingOre == false)
        {
            SellingOre = true;
            StartCoroutine(SellOre());
        }

	}
    IEnumerator SellOre()
    {
        if (GlobalOre.OreCount < InternalIncrease)
        {
            // we can't do shit
        }
        else
        {

            GlobalCash.CashCount += InternalIncrease;
            GlobalOre.OreCount -= 1;
            yield return new WaitForSeconds(1);
            SellingOre = false;
        }
        
    }
}
