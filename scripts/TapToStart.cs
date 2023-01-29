using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
{
    public GameObject start;
    public GameObject pausePanel;
    public GameObject pausebtn;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        start.gameObject.SetActive(true);
        pausePanel.SetActive(false);
        pausebtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
    }

    public void gameStart()
    {
        Time.timeScale = 1;
        start.gameObject.SetActive(false);
    }
}
