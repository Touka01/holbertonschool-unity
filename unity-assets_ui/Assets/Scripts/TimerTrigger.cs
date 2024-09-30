using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().gameObject;
    }
    void OnTriggerExit(Collider other)
    {
        Player.GetComponent<Timer>().enabled = true;
    }
}
