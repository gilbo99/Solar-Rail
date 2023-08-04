using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving_System : MonoBehaviour
{
    [SerializeField]
    private bool _isencrypted;
    
    public string _path;

    private IDataService DataService = new JsonDataService();

    private Player_Save player_Save = new Player_Save();
    [SerializeField]
    private LevelSystem levelSystem;
    



    public void SerializeJson()
    {
        
        if (DataService.SaveData(_path, player_Save, _isencrypted))
        {
            try
            {
                Player_Save data = DataService.LoadData<Player_Save>(_path, _isencrypted);

            }
            catch (Exception e)
            {
                Debug.LogError($"Could not read file! Show something on the UI here!" + e);
            }
        }
        else
        {
            Debug.LogError("Could not save file! Show something on the UI about it!");
        }
    }


    public void SavePlayer_LevelSystem(int lvl, int rank, int xp, int xpneed)
    {
        player_Save.playerLevel = lvl;
        player_Save.rankingLevel = rank;
        player_Save.playerXP = xp;
        player_Save.XPneeded = xpneed;
        
        SerializeJson();

    }


    public void LoadPlayer_LevelSystem()
    {
        Player_Save data = DataService.LoadData<Player_Save>(_path, _isencrypted);
        levelSystem.LoadPlayer(data.playerLevel, data.rankingLevel, data.playerXP, data.XPneeded);
    }




}

