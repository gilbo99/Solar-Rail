using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerHead : MonoBehaviour
{
    public GameObject showerHead;
    public GameObject waterStream;
    public GameObject UIManager;

    private bool ableToMove = false;

    public float xSpeed = 0;
    public float zSpeed = 0;

    private bool waterStatus;

    public Transform cube;
    public float speed;

    private UIManager uiUpdate;

    // UI ELEMENTS

    public string minigameObjectiveHeader;
    public string minigameObjectiveBodyLine1;
    public string minigameObjectiveBodyLine2;
    public string minigameObjectiveBodyLine3;

    public string controls1;
    public string controls2;
    public string controls3;
    
    public Color32 colour;

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.GreenHouseMinigame += ToggleWater;
        waterStream.SetActive(false);
        uiUpdate = UIManager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(ableToMove)
        {

      
        if (Input.GetKey("d"))
        {
            cube.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            cube.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            cube.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            cube.Translate(Vector3.down * speed * Time.deltaTime);
        }
        }
    
    }

    public void ToggleWater()
    {
        ableToMove =!ableToMove;
        waterStream.SetActive(ableToMove);
        UpdateUI();
    }
    
    void UpdateUI()
    {
        if(ableToMove)
        {
            uiUpdate.ObjectiveUpdate(minigameObjectiveHeader, minigameObjectiveBodyLine1, minigameObjectiveBodyLine2, minigameObjectiveBodyLine3);
            uiUpdate.ButtonUpdate(controls1, controls2, controls3);
            uiUpdate.borderChange(colour);
        } else {
            Color32 color2 = new Color32(225, 255, 0, 0);
            uiUpdate.ObjectiveUpdate("", "", "", "");
            uiUpdate.ButtonUpdate("","","");
            uiUpdate.borderChange(color2);
        }
    }

    public void OnDestroy()
    {
        EventBus.Current.GreenHouseMinigame -= ToggleWater;
    }
}
