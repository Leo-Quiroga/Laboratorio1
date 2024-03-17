using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
  

    public int valueCoin;

  
   
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.instance.AddCoins(valueCoin);
            
        }
    }
}
