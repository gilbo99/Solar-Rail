using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OLD_Intractable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    public string Texttest;
    //public TagField interactTag;
    // Start is called before the first frame update
    private void OnTriggerEnter (Collider other)
    {
        //print("hii");
        if (other.gameObject.CompareTag("Player"))
        {
            promptText.text = Texttest;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //print("hii");
        if (other.gameObject.CompareTag("Player"))
        {
            promptText.text = "";
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
