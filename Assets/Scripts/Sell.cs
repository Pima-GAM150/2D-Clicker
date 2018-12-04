using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sell : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton()
    {
        if (GlobalOre.OreCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough ores to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalOre.OreCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }	
	
}
