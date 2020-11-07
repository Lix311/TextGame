using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorrorGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    string[] days = {"Mon","Tues","Weds","Thurs","Fri"};

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text =  state.GetStateStory();
        Debug.Log(days[1]);
        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState(){
        var nextStates = state.GetNextStates();
        for(int i = 0;i < nextStates.Length;i++){
           
            if(Input.GetKeyDown(KeyCode.Alpha1 + i)){
                state = nextStates[i];
            }
        }
        
        // if(Input.GetKeyDown(KeyCode.Alpha1)){
        //     state = nextStates[0];
        // } else if(Input.GetKeyDown(KeyCode.Alpha2)){
        //     state = nextStates[1];
        // } else if(Input.GetKeyDown(KeyCode.Alpha3)){
        //     state = nextStates[2];
        // } else if(Input.GetKeyDown(KeyCode.Q)){
        //     Application.Quit();
        // }
        
        
        textComponent.text = state.GetStateStory();
    }




}
