using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterNutrientMinigame : MonoBehaviour
{
    // add UI CONNECTION //public GameObject uiManager;

    // GLOBAL UI SCRIPT CONNECTION

    public string minigameObjectiveHeader;
    public string minigameObjectiveBodyLine1;
    public string minigameObjectiveBodyLine2;
    public string minigameObjectiveBodyLine3;

    // WATER TANK GLOBAL VARIABLES

    public int watertankLevel = 0;
    public int watertankCapacity = 0;
    public bool nutrientsOptimised = false;
    public bool allowInput = false;

    // WATER TANK DROP VARIABLES

    private string watertankDrop1 = "Empty";
    private string watertankDrop2 = "Empty";

    // WATER TANK DROP GOALS

    // public gameObject OrangeGoalUI;
    // public gameObject GreenGoalUI;
    // public gameObject PurpleGoalUI;

    private string watertankNutrientGoal = "Completed";

    void Start()
    {
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
        minigameObjectiveHeader = "Add drops of Nutrients to make a mix of what is missing from the water tank.";
        minigameObjectiveBodyLine1 = "PRESS 1 to add a drop of Cyan coloured nutrients.";
        minigameObjectiveBodyLine2 = "PRESS 2 to add a drop of Magenta coloured nutrients.";
        minigameObjectiveBodyLine3 = "PRESS 3 to add a drop of Yellow coloured nutrients.";
        // SendUIObjectives();

        allowInput = true;
    }

    void Update()
    {
        // ADD CYAN DROP BY PRESSING 1
        if (Input.GetKey("1"))
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

        // ADD MAGENTA BY WITH PRESSING 2
        if (Input.GetKey("2"))
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

        // ADD YELLOW DROP BY PRESSING 3
        if (Input.GetKey("3"))
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

    }

    // private void SendUIObjectives()
    // {
    //     uiManager.GetComponent<SCRIPTNAME>().RecieveObjective(minigameObjectiveHeader,  minigameObjectiveBodyLine1, //minigameObjectiveBodyLine2, minigameObjectiveBodyLine3);
    // }

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
                break;
        }
    }
}
