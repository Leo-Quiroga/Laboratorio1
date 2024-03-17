using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text coinText, maskText, levelText, maskTextGO, levelTextGO;
 
    public GameObject pauseScreen, optionScreen, gameOver, winScene, extraSeconds;

   
    private void Awake()
    {
        instance = this;
    }
  

    public void Resume()
    {
        GameManager.instance.PauseUnpause();
        
    }
    public void OpenOptions()
    {
        optionScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionScreen.SetActive(false);
    }


 
}
