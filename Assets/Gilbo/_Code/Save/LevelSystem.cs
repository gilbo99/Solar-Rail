using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityEditor;
using System;
using Newtonsoft.Json;
using UnityEngine.UI;
using System.IO;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private int playerLevel;
    [SerializeField] private int rankingLevel;


    //Players Current XP
    [SerializeField] private int playerXP;


    //XP to Level up
    [SerializeField] private int XPneeded;
    [SerializeField] private int leftOverXP;

   
    [SerializeField] private int constant = 50;

    [SerializeField] private List<string> rankingName;

    [SerializeField]
    private Saving_System savingSystem;





    private void Awake()
    {
        if(File.Exists(Application.persistentDataPath + savingSystem._path))
        {
            savingSystem.LoadPlayer_LevelSystem();
        }


    }

    

   


    //Levels player up and runs SetXPNeeded()
    private void LevelUp()
    {
        playerLevel++;
        if (playerLevel >= 25 && rankingLevel >= 10)
        {
            rankingLevel = 10;
            playerLevel = 25;
        }
        else if (playerLevel >= 25)
        {
            rankingLevel++;
            playerLevel = 0;
            XPneeded = 0;
        }

        if (playerLevel < 25 && rankingLevel < 10)
        {
            XPneeded = SetXPNeeded(constant);  
            playerXP = leftOverXP;
            leftOverXP = 0;
            
        }
    }

    // Sets Needed XP for next level
    private int SetXPNeeded(int addedXP)
    {
        XPneeded += addedXP;
        return XPneeded;
    }

    //Use Give XP to sent XP from any script with Level System
    public void GiveXP(int xp)
    {
        playerXP += xp;
        if (XPneeded <= playerXP)
        {
            leftOverXP = LeftOver(playerXP, XPneeded);
            LevelUp();
        }
    }

    public int GetCurrentLevel()
    {
        return playerLevel;
    }

    public string GetCurrentID()
    {
        return rankingName[rankingLevel];
    }


    private int LeftOver(int a, int b)
    {
        int c = (a -= b);
        if (c <= 0)
        {
            c = 0;
        }
        return c;
    }


    public void SavePlayer()
    {
        savingSystem.SavePlayer_LevelSystem(playerLevel, rankingLevel, playerXP, XPneeded);
    }

    

    public void ResetPlayerLevel()
    {
        playerLevel = 0;
        rankingLevel = 0;
        playerXP = 0;
        XPneeded = constant;
        leftOverXP = 0;
    }

    public void LoadPlayer(int lvl, int rank, int xp, int xpneed)
    {
        playerLevel = lvl;
        rankingLevel = rank;
        playerXP = xp;
        XPneeded = xpneed;
        
    }


}
