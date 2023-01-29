using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeBtn : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pausebtn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pausebtn.SetActive(true);
    }
}
