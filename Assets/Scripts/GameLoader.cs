using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int savedOres;
    public int savedCash;
    public int savedMiners;
    public int savedShops;
    public int savedValue;

	void Start ()
    {
		if (MainMenu.isLoading == true)
        {
            savedOres = PlayerPrefs.GetInt("SavedOres");
            GlobalOre.OreCount = savedOres;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedMiners = PlayerPrefs.GetInt("SavedMiners");
            GlobalMiner.minedPerSec = savedMiners;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            savedValue = PlayerPrefs.GetInt("SavedValue");
            SaveGame.saveValue = savedValue;








           
        }
	}
	
	
}
