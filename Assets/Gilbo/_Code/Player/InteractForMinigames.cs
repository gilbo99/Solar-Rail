using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractForMinigames : MonoBehaviour
{
    public string MiniGame;
    public GameObject mainCam;
    public GameObject minigameCam;
    public GameObject player;
    public bool cam1stats = true;
    public bool minigamecamstats = false;
    public bool inputbool = false;
    public GameObject UIUpdater;

    

    //Add GameObject that is gamemanager when setup
    // make sure it triggers OnTriggerExit once minigame is done

    public void Start()
    {
        
    }
    void Update()
    {

        var updateText = UIUpdater.GetComponent<UpdateUIInteract>();



        if (Input.GetKeyDown(KeyCode.F) & inputbool)
        {
            SwitchCam();
            updateText.UpdateUIText("");
        }

    }
    // Sets text when player enters
    void OnTriggerEnter(Collider other)
    {
        var updateText = UIUpdater.GetComponent<UpdateUIInteract>();
        inputbool = true;
        if (other.CompareTag("Player"))
        {
            updateText.UpdateUIText("Press F To Start " + MiniGame);
        }
           

    }
    // Sets text to nothing when player leaves
    void OnTriggerExit(Collider other)
    {
        var updateText = UIUpdater.GetComponent<UpdateUIInteract>();
        inputbool = false;
        if (other.CompareTag("Player"))
        {
            updateText.UpdateUIText("");
        }

            
    }

    
    // Changes too diffrent camera depending on what you set minigameCam // allways set mainCam too player cam
    void SwitchCam()
    {
        EventBus.Current.SolarPanelToggleTrigger();
        cam1stats = !cam1stats;
        minigamecamstats = !minigamecamstats;
        mainCam.SetActive(cam1stats);
        minigameCam.SetActive(minigamecamstats);
        player.GetComponent<PlayerMovement>().enabled = cam1stats;
    }
}
