using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{

    public static Meta instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] public Animator padrePuerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("Abrir puerta");
            padrePuerta.Play("Door");
        }
    }
}
