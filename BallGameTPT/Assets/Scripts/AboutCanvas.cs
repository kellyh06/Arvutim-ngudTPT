using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutCanvas : MonoBehaviour

{
    public GameObject MainMenuCanvas;
    public GameObject AboutCanvasScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        MainMenuCanvas.SetActive(true);
        AboutCanvasScreen.SetActive(false);
    }
}
