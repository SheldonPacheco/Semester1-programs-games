using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
//Sheldon Pacheco
public class LabEx4 : MonoBehaviour
{
    [SerializeField] TMP_InputField guess;
    [SerializeField] TMP_Text status;
    [SerializeField] TMP_Text gameScore;
    int playerguess = 0;
    int randomNumber = 0;
    int playerScore = 0;
    int computerScore = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Guess()
    {
        
        randomNumber = Random.Range(1, 11);
        
        if (int.TryParse(guess.text, out playerguess)) //converts text input to int
        {
                if (playerguess == randomNumber) {
                    playerScore++;
                    status.text = "Player wins! "+"Number was "+randomNumber+" |";
                    gameScore.text = "Player Score: "+ playerScore + " Computer Score: " + computerScore;
                }
                else
                {
                    computerScore++;
                    status.text = "Computer wins! " + "Number was " + randomNumber+" |";
                    gameScore.text = "Player Score: " + playerScore + " Computer Score: " + computerScore;
                }
            
        }
        else
        {
            status.text = "Invaild input, try again";
        }
           
    }
}
