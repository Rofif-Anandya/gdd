using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public Button button2, button3;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        button2.interactable = false;
        button3.interactable = false;
    
        switch(levelPassed)
        {
            case 1:
            button2.interactable = true;
            break;

            case 2:
            button2.interactable = true;
            button3.interactable = true;
            break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
