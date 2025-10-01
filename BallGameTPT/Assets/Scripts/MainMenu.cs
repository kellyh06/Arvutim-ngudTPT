using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject MainMenuCanvas;
    public GameObject AboutCanvas;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level");

    }
    public void AboutButton()
    {
        MainMenuCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
