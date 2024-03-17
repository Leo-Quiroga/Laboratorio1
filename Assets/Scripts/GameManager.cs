using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentCoins, level;

    public GameObject mpON, mpOFF, mpWinOn, mpWinOff;

    public bool canPause = true;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; //Implementa el Mouse. En este caso quita el Mouse de la pantalla.
        Cursor.lockState = CursorLockMode.Locked;

        AddCoins(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            PauseUnpause();

        }

        if(Cronometer.instance.timer <= 0)
        {
            GameOver();
        }
       
        //activa el mapPoint de Win
        if (GameManager.instance.currentCoins == 20)
        {

            mpWinOff.SetActive(false);
            mpWinOn.SetActive(true);
        }


        //Activa el mapPoint para pasar a la siguiente escena
        if (GameManager.instance.currentCoins == 10)
        {

            mpOFF.SetActive(false);
            mpON.SetActive(true);
        }

    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        UIManager.instance.gameOver.SetActive(true);

        UIManager.instance.maskTextGO.text = "" + GameManager.instance.currentCoins;
        UIManager.instance.levelTextGO.text = "Level " + GameManager.instance.level;


    }



    public void AddCoins(int coinsToAdd)
    {
        currentCoins += coinsToAdd;
        UIManager.instance.coinText.text = "" + currentCoins;
    }

    public void PauseUnpause()
    {
        if (UIManager.instance.pauseScreen.activeInHierarchy)
        {

            UIManager.instance.pauseScreen.SetActive(false);
            Time.timeScale = 1f;

            Cursor.visible = false; //Implementa el Mouse. En este caso quita el Mouse de la pantalla.
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            UIManager.instance.pauseScreen.SetActive(true);
            UIManager.instance.CloseOptions();
            Time.timeScale = 0f;

            Cursor.visible = true; //Implementa el Mouse. En este caso activa el Mouse de la pantalla.
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
