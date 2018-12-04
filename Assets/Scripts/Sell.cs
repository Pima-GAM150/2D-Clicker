using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalMoney.MoneyCount += 1;
    }	
	
}
