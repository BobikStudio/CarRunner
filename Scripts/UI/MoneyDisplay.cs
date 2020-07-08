using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private Text moneyDisplay;

    public void Show_Money_Display ()
    {
        moneyDisplay.text = "Money: " + EconomyManager.collectedCoin;
    }

}
