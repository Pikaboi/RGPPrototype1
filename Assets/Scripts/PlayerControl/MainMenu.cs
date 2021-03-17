using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void backToMain()
    {
        SceneManager.LoadScene(0);
    }
}
