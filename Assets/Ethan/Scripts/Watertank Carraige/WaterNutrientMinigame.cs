using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterNutrientMinigame : MonoBehaviour
{
    // MANAGER CONNECTIONS

    public GameObject UIManager;
    private UIManager uiUpdate;
    

    // GLOBAL UI SCRIPT VARIABLES

    public string minigameObjectiveHeader;
    public string minigameObjectiveBodyLine1;
    public string minigameObjectiveBodyLine2;
    public string minigameObjectiveBodyLine3;

    public string controls1;
    public string controls2;
    public string controls3;

    public Color32 colour;

    // NUTRIENT MONITOR DISPLAY

    public GameObject nutrientsMonitorScreen;

    // WATER TANK GLOBAL VARIABLES

    public int watertankLevel = 0;
    public int watertankCapacity = 0;
    public bool nutrientsOptimised = false;
    public bool allowInput = false;
    public bool gameActive = false;

    // WATER TANK DROP VARIABLES

    private string watertankDrop1 = "Empty";
    private string watertankDrop2 = "Empty";

    // WATER TANK DROP GOALS

    // public gameObject OrangeGoalUI;
    // public gameObject GreenGoalUI;
    // public gameObject PurpleGoalUI;

    private string watertankNutrientGoal = "Completed";

    void OnEnable()
    {
        gameActive = true;
        
        uiUpdate = UIManager.GetComponent<UIManager>();
        
        switch (UnityEngine.Random.Range(0,2))
        {
            case 0:
                watertankNutrientGoal = "Orange";
                //OrangeGoalUI.SetActive(true);
                break;
            case 1:
                watertankNutrientGoal = "Green";
                //GreenGoalUI.SetActive(true);
                break;
            case 2:
                watertankNutrientGoal = "Purple";
                //PurpleGoalUI.SetActive(true);
                break;
        }

        // UPDATE UI
        
        minigameObjectiveHeader = "ADD CHEMICALS TO CORRECT THE NUTRIENTS IMBALANCE IN THE WATER TANK";
        minigameObjectiveBodyLine1 = "• Correct the balance of nutrients with the dispenser.";
        minigameObjectiveBodyLine2 = "• The display indicates you're missing the " + watertankNutrientGoal + " compound.";
        minigameObjectiveBodyLine3 = null;

        controls1 = null;
        controls2 = "Click the buttons below to add nutrients.";
        controls3 = null;

        // SEND OBJECTIVES TO MANAGERS

        
    }

    void Update()
    {
        
        // ADD CYAN DROP BY PRESSING 1
        if (Input.GetKey("1"))
        {  
            AddCyanDrop();
        }

        // ADD MAGENTA BY WITH PRESSING 2
        if (Input.GetKey("2"))
        {
            
            AddMagentaDrop();
        }

        // ADD YELLOW DROP BY PRESSING 3
        if (Input.GetKey("3"))
        {
            AddYellowDrop();
        }

    }

    public void AddCyanDrop()
    {
        if (watertankDrop1 == "Empty")
            {
                watertankDrop1 = "Cyan";
                print("You add a drop of Cyan coloured nutrients.");
            }
            else
            {
                watertankDrop2 = "Cyan";
                print("You add a drop of Cyan coloured nutrients.");
                allowInput = false;
                SolveNutrients();
            }
    }

    public void AddMagentaDrop()
    {
        if (watertankDrop1 == "Empty")
            {
                watertankDrop1 = "Magenta";
                print("You add a drop of Magenta coloured nutrients.");
            }
            else
            {
                watertankDrop2 = "Magenta";
                print("You add a drop of Magenta coloured nutrients.");
                allowInput = false;
                SolveNutrients();
            }
    }

    public void AddYellowDrop()
    {
        if (watertankDrop1 == "Empty")
            {
                watertankDrop1 = "Yellow";
                print("You add a drop of Yellow coloured nutrients.");
            }
            else
            {
                watertankDrop2 = "Yellow";
                print("You add a drop of Yellow coloured nutrients.");
                allowInput = false;
                SolveNutrients();
            }
    }

    public void SolveNutrients()
    {
        switch (watertankNutrientGoal)
        {
            case "Orange":
                if (watertankDrop1 == "Magenta" || watertankDrop2 == "Magenta" && watertankDrop1 == "Magenta" || watertankDrop2 == "Yellow")
                {
                    // PASS
                    nutrientsOptimised = true;
                    print("The nutrients in the water has been optimised and now can be used to water plants.");
                }
                else
                {
                    // FAIL
                    watertankLevel = 0;
                    nutrientsOptimised = false;
                    print("Water has been contaminated and subsequently drained.");
                }
                // OrangeGoalUI.SetActive(false);
                gameActive = false;
                break;

            case "Green":
                if (watertankDrop1 == "Cyan" || watertankDrop2 == "Cyan" && watertankDrop1 == "Yellow" || watertankDrop2 == "Yellow")
                {
                    // PASS
                    nutrientsOptimised = true;
                    print("The nutrients in the water has been optimised and now can be used to water plants.");
                }
                else
                {
                    // FAIL
                    watertankLevel = 0;
                    nutrientsOptimised = false;
                    print("Water has been contaminated and subsequently drained.");
                }
                // GreenGoalUI.SetActive(false);
                gameActive = false;
                break;

            case "Purple":
                if (watertankDrop1 == "Magenta" || watertankDrop2 == "Magenta" && watertankDrop1 == "Magenta" || watertankDrop2 == "Cyan")
                {
                    // PASS
                    nutrientsOptimised = true;
                    print("The nutrients in the water has been optimised and now can be used to water plants.");
                }
                else
                {
                    // FAIL
                    watertankLevel = 0;
                    nutrientsOptimised = false;
                    print("Water has been contaminated and subsequently drained.");
                }
                // PurpleGoalUI.SetActive(false);
                gameActive = false;
                break;
        }
    }

    void UpdateUI()
    {
        if(gameActive)
        {
            uiUpdate.ObjectiveUpdate(minigameObjectiveHeader, minigameObjectiveBodyLine1, minigameObjectiveBodyLine2, minigameObjectiveBodyLine3);
            uiUpdate.ButtonUpdate(controls1, controls2, controls3);
            uiUpdate.borderChange(colour);
            allowInput = true;
        } else {
            Color32 color2 = new Color32(225, 255, 0, 0);
            uiUpdate.ObjectiveUpdate("", "", "", "");
            uiUpdate.ButtonUpdate("","","");
            uiUpdate.borderChange(color2);
        }
    } 
}
