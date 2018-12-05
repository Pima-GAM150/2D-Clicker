using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMiner : MonoBehaviour {

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int minerValue = 10;
    public static bool turnOffButton = false;
    public GameObject minerStats;
    public static int numberOfMiners;
    public static int minedPerSec;
	
	void Update ()
    {
        currentCash = GlobalCash.CashCount;
        minerStats.GetComponent<Text>().text = "Miners: " + numberOfMiners + " @ " + minedPerSec + " Per Second";
        fakeText.GetComponent<Text>().text = "Buy Miner - $" + minerValue;
        realText.GetComponent<Text>().text = "Buy Miner - $" + minerValue;
        if (currentCash >= minerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
	}
}
