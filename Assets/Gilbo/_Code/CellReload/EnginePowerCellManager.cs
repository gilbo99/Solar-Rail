using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePowerCellManager : MonoBehaviour
{

    public List<string> objective;
    public List<string> key;
    public Color32 color;

    [SerializeField] private UIManager uiUpdate;

    void Start()
    {
        void Start()
        {

            
            EventBus.Current.PowerCellsToggle += ToggleEngine;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void ToggleEngine()
    {

    }






    void OnDestroy()
    {
        EventBus.Current.PowerCellsToggle -= ToggleEngine;
    }
}
