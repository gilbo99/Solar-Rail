using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interact : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    public string MiniGame;
    public GameObject mainCam;
    public GameObject minigameCam;
    public GameObject player;
    public bool cam1stats = true;
    public bool minigamecamstats = false;
    public bool inputbool = false;


    //Add GameObject that is gamemanager when setup
    // make sure it triggers OnTriggerExit once minigame is done


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) & inputbool)
        {
            SwitchCam();
            UpdateUIText("");
        }

    }
    // Sets text when player enters
    void OnTriggerEnter(Collider other)
    {
        inputbool = true;
        if (other.CompareTag("Player"))
            UpdateUIText("Press F To Start " + MiniGame);

    }
    // Sets text to nothing when player leaves
    void OnTriggerExit(Collider other)
    {
        inputbool = false;
        if (other.CompareTag("Player"))
            UpdateUIText("");
    }

    void UpdateUIText(string setWord)
    {
        interactText.text = setWord;
    }
    // Changes too diffrent camera depending on what you set minigameCam // allways set mainCam too player cam
    void SwitchCam()
    {
        cam1stats = !cam1stats;
        minigamecamstats = !minigamecamstats;
        mainCam.SetActive(cam1stats);
        minigameCam.SetActive(minigamecamstats);
        player.GetComponent<PlayerMovement>().enabled = cam1stats;
    }
}
