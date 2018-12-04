using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOre : MonoBehaviour {

    public bool CreatingOre = false;
    public static int OreIncrease = 1;
    public int InternalIncrease;

	
	void Update ()
    {
        InternalIncrease = OreIncrease;
        if (CreatingOre == false)
        {
            CreatingOre = true;
            StartCoroutine(CreateOre());
        }

	}
    IEnumerator CreateOre()
    {
        GlobalOre.OreCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingOre = false;
    }
}
