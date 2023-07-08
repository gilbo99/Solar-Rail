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
    private bool toggle = false;
    private int screenMode;
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


    public void NewSceneData(int val)
    {
        levelCount = val;
        print(val);
    }

    public void StartNewScene()
    {
        SceneManager.LoadSceneAsync(levelCount);
       

    }

    public void FullScreenToggle(bool Tick)
    {
        Screen.fullScreenMode = (FullScreenMode)screenMode;
        Screen.fullScreen = Tick;
    }
    public void Screenset()
    {

            Screen.fullScreenMode = (FullScreenMode)screenMode;
      
        
    }


    public void ScreenData(int val)
    {

        screenMode = val;

    }






}
