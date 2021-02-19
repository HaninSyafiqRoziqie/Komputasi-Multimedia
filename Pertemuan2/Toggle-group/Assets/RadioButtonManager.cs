using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonManager : MonoBehaviour
{
    private string currentDificulty = "Easy";
    private Toggle toggleEasy;
    private Toggle toggleMedium;
    private Toggle toggleHard;
    // Start is called before the first frame update
    private void Start()
    {
        toggleEasy = transform.Find("Toggle-easy").GetComponent<Toggle>();
        toggleMedium = transform.Find("Toggle-medium").GetComponent<Toggle>();
        toggleHard = transform.Find("Toggle-hard").GetComponent<Toggle>();
    }

    // Update is called once per frame
    if(sender.ison)
    {
        currentDifficulty = sender.tag;
        print("option changed to = " + currentDifficulty);
    if(sender.tag== "Easy"){
        toggleMedium.ison = false;
        toggleHard.ison = false;
    }
    else if(sender.tag== "Medium"){
        toggleEasy.ison = false;
        toggleHard.ison = false;
    }
    else if(sender.tag== "Hard"){
        toggleEasy.ison = false;
        toggleMedium.ison = false;
    }
    }
}
}
