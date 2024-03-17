using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            WinScene();
        }
    }

    public void WinScene()
    {
        Time.timeScale = 0f;
        UIManager.instance.winScene.SetActive(true);
        UIManager.instance.maskText.text = "" + GameManager.instance.currentCoins;
        UIManager.instance.levelText.text = "Level " + GameManager.instance.level;

        GameManager.instance.canPause = false;

    }
}
