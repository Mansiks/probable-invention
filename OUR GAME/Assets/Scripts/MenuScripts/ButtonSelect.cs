using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSelect : MonoBehaviour
{

    void Start()
    {

    }
    void Update()
    {

    }
    public void GoToGame()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Gotoclicker()
    {
        SceneManager.LoadScene(5);
    }
    public void ModeSelection()
    {
        SceneManager.LoadScene(4);
    }
    

    
}






