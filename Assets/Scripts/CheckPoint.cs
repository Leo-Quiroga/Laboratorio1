using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            StartCoroutine(Seconds());

        }
    }


    public IEnumerator Seconds()
    {
        GameManager.instance.level += 1;
        Meta.instance.padrePuerta.Play("CloseDoor");
        Cronometer.instance.timer += 20;
        UIManager.instance.extraSeconds.SetActive(true);
        yield return new WaitForSeconds(2f);
        UIManager.instance.extraSeconds.SetActive(false);
    }
}
