using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPaused;
    public Crosshair crosshair;
    [SerializeField] KeyCode KeyMenuPaused;
    bool isMenuPaused = false;
    private void Start()
    {
        menuPaused.SetActive(false);
    }

    void Update()
    {
        ActiveMenu();
    }



    void ActiveMenu()
    {
        if (Input.GetKeyDown(KeyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }
        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            crosshair.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false);
            crosshair.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }

    }

    public void MenuPausedContinue()
    {
        isMenuPaused = false;
    }
    public void MenuPausedMainMenu()
    {
        Application.LoadLevel(0);
    }
    public void MenuPausedSettings()
    {
        Application.LoadLevel(2);
    }

}