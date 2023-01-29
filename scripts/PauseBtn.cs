using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pausebtn;
    public GameObject start;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pausebtn.SetActive(false);
        start.gameObject.SetActive(false);

    }

    void OnApplicationPause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pausebtn.SetActive(false);
    }
}
