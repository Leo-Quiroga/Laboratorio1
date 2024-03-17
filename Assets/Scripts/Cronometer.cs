using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometer : MonoBehaviour
{
    public static Cronometer instance;

    public float timer;
    public Text cronometerText;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        cronometerText.text = "" + timer.ToString("f0");
    }
}
