using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disaster : MonoBehaviour {

    public GameObject statusBox;
    public float oreCheck;
    public int genChance;
    public bool disasterActive = false;
    public int oreLoss;

    // Update is called once per frame
    void Update()
    {
        oreCheck = GlobalOre.OreCount / 100;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }

    }

        IEnumerator StartDisaster() 
        {
            disasterActive = true;
            genChance = Random.Range(1, 20);
            if (oreCheck > genChance)
            {
                oreLoss = Mathf.RoundToInt(GlobalOre.OreCount * 0.25f);
                statusBox.GetComponent<Text>().text = "You lost " + oreLoss + "ores in a mining explosion";
                GlobalOre.OreCount -= oreLoss;
                yield return new WaitForSeconds(3);
                statusBox.GetComponent<Animation>().Play("statusAnim");
                yield return new WaitForSeconds(1);
                statusBox.SetActive(false);
                statusBox.SetActive(true);
        }
            yield return new WaitForSeconds(10);
            disasterActive = false;
        }
	
}
