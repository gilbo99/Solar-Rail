using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUIInteract : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    
    // Start is called before the first frame update


    public void UpdateUIText(string setWord)
    {
        interactText.text = setWord;
      


    }
}
