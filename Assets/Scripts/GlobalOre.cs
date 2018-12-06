using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalOre : MonoBehaviour {

    public static int OreCount;
    public GameObject OreDisplay;
    public int InternalOre;
	
	// Update is called once per frame
	void Update ()
    {
        InternalOre = OreCount;
        OreDisplay.GetComponent<Text>().text = "Ore Mined: " + InternalOre;
	}
}
