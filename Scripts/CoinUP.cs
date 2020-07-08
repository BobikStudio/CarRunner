using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUP : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EconomyManager.collectedCoin += 1;
            Debug.Log("+1 coin");
            Destroy(gameObject);
        }
    }
}
