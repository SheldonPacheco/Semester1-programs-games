using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;
//Sheldon Pacheco
public class Assignment1 : MonoBehaviour
{
    [SerializeField] TMP_InputField playernameinput;
    [SerializeField] TMP_Text gamestate;
    [SerializeField] Button rock;
    [SerializeField] Button paper;
    [SerializeField] Button scissors;
    [SerializeField] Button resetNewPlayer;
    [SerializeField] Button resetCurrentPlayer;
    [SerializeField] Button submitPlayerName;
    [SerializeField] TMP_Text gamescore;

    string playername = "";
    int playersore;
    int cpuscore;
    int tiesTotal;
    // Start is called before the first frame update
    void Start()
    {
        rock.gameObject.SetActive(false);
        paper.gameObject.SetActive(false);
        scissors.gameObject.SetActive(false);
        resetCurrentPlayer.gameObject.SetActive(false);
        resetNewPlayer.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (playername!="")//makes sure user enters text
        {
            gamescore.text = playername + " Score: " + playersore + " Computer Score: " + cpuscore + " Ties: " + tiesTotal; //keeps scores updated
        }
    }
    public void SubmitName()
    {
        playername = playernameinput.text;
        if (playername != "") //makes sure user enters text
        { 



        submitPlayerName.gameObject.SetActive(false);
        playernameinput.gameObject.SetActive(false);

        rock.gameObject.SetActive(true);
        paper.gameObject.SetActive(true);
        scissors.gameObject.SetActive(true);
        }
    }
    public void ResetCurrentPlayer()
    {
        gamestate.text = "";

        resetCurrentPlayer.gameObject.SetActive(false);
        resetNewPlayer.gameObject.SetActive(false);

        rock.gameObject.SetActive(true);
        paper.gameObject.SetActive(true);
        scissors.gameObject.SetActive(true);


    }
    public void ResetNewPlayer()
    {
        playername = "";
        playernameinput.text = "";
        gamestate.text = "";
        gamescore.text = "";

        playersore = 0;
        cpuscore = 0;
        tiesTotal = 0;

        submitPlayerName.gameObject.SetActive(true);
        playernameinput.gameObject.SetActive(true);

        resetCurrentPlayer.gameObject.SetActive(false);
        resetNewPlayer.gameObject.SetActive(false);


        rock.gameObject.SetActive(false);
        paper.gameObject.SetActive(false);
        scissors.gameObject.SetActive(false);

    }
    public void PlayerChoseRock()
    {
        int cpuchoice = Random.Range(0, 3); //rock=0, paper=1, scissors=2
        int playerchoice = 0;//rock=0
        if (cpuchoice == 0 && playerchoice == 0) //rock ties rock
        {
            gamestate.text = playername+" chose rock "+", computer chose rock! no winner!";
            tiesTotal++;
        } 
        else if (cpuchoice == 1 && playerchoice == 0)//rock losses to paper
        {
            gamestate.text = playername + " chose rock " + ", computer chose paper! computer wins!";
            cpuscore++;
        } else { //rock beats scissors
            gamestate.text = playername + " chose rock " + ", computer chose scissors! player wins!";
            playersore++;
        }


        resetCurrentPlayer.gameObject.SetActive(true);
        resetNewPlayer.gameObject.SetActive(true);

        rock.gameObject.SetActive(false);
        paper.gameObject.SetActive(false);
        scissors.gameObject.SetActive(false);
    }
    public void PlayerChosePaper()
    {
        int cpuchoice = Random.Range(0, 3); //rock=0, paper=1, scissors=2
        int playerchoice = 1;//paper=1
        if (cpuchoice == 0 && playerchoice == 1) //paper beats rock
        {
            gamestate.text = playername + " chose paper " + ", computer chose rock! player wins!";
            playersore++;
        }
        else if (cpuchoice == 1 && playerchoice == 1) //paper ties paper
        {
            gamestate.text = playername + " chose paper " + ", computer chose paper! no winner!";
            tiesTotal++;
        }
        else //paper losses to scissors
        {
            gamestate.text = playername + " chose paper " + ", computer chose scissors! computer wins!";
            cpuscore++;
        }

        resetCurrentPlayer.gameObject.SetActive(true);
        resetNewPlayer.gameObject.SetActive(true);


        rock.gameObject.SetActive(false);
        paper.gameObject.SetActive(false);
        scissors.gameObject.SetActive(false);
    }
    public void PlayerChoseScissors()
    {
        int cpuchoice = Random.Range(0, 3); //rock=0, paper=1, scissors=2
        int playerchoice = 2;//scissors=2
        if (cpuchoice == 0 && playerchoice == 2) //scissors losses to rock
        {
            gamestate.text = playername + " chose scissors " + ", computer chose rock! computer wins!";
            cpuscore++;
        }
        else if (cpuchoice == 1 && playerchoice == 2) //scissors beats paper
        {
            gamestate.text = playername + " chose scissors " + ", computer chose paper! player wins!";
            playersore++;
        }
        else //scissors ties with scissors
        {
            gamestate.text = playername + " chose scissors " + ", computer chose scissors! no winner!";
            tiesTotal++;
        }

        resetCurrentPlayer.gameObject.SetActive(true);
        resetNewPlayer.gameObject.SetActive(true);


        rock.gameObject.SetActive(false);
        paper.gameObject.SetActive(false);
        scissors.gameObject.SetActive(false);
    }
}



