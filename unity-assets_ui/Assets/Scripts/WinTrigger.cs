using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    // public Text timerText;
    public GameObject winCanvas;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
        // timerText = GameObject.Find("TimerCanvas").transform.Find("TimerText").GetComponent<Text>();
    }

    void OnTriggerEnter(Collider other)
    {
        winCanvas.SetActive(true);
        player.GetComponent<Timer>().enabled = false;
        // timerText.enabled = false;
        player.GetComponent<PauseMenu>().enabled = false;
        player.GetComponent<Timer>().Win();
    }
}
