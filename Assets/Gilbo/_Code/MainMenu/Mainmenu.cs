using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Mainmenu : MonoBehaviour
{
    
    public GameObject levelSelect;
    private int levelCount;
    public bool toggle = false;
    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void LevelSelect()
    {
        
        toggle = !toggle;
        levelSelect.SetActive(toggle);
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void HandleInputData(int val)
    {
        levelCount = val;
    }

    public void StartNewScene()
    {
        SceneManager.LoadSceneAsync(levelCount);
       

    }
}
