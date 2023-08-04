using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{

    [SerializeField] private LevelSystem levelSystem;
    [SerializeField] private Saving_System savingSystem;


    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            levelSystem.GiveXP(25);
        }
        if (Input.GetKeyDown("2"))
        {
            levelSystem.SavePlayer();
        }
        if (Input.GetKeyDown("3"))
        {

            savingSystem.LoadPlayer_LevelSystem();
        }
       

    }

    
}
