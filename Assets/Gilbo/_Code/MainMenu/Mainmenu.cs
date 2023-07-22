using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Drawing;

public class Mainmenu : MonoBehaviour
{
    
    public GameObject levelSelect;
    public GameObject credits;
    private int levelCount;
    private bool toggle = false;
    private bool toggleCredits = false;
    private int screenMode;
    public string newSelectedValue = "Solar Panel Rotation";


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


    public void NewSceneData(TMP_Dropdown dropdown)
    {
        int newSelectedIndex = dropdown.value;
        newSelectedValue = dropdown.options[newSelectedIndex].text;
    }

    public void StartNewScene()
    {
        SceneManager.LoadSceneAsync(newSelectedValue);
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


    
    public void togglecredits()
    {

        toggleCredits =! toggleCredits;
        credits.SetActive(toggleCredits);
    }











}
