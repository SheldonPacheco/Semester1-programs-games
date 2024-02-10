using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Color[] colors = new Color[6];
    [SerializeField] SpriteRenderer Shape1;
    [SerializeField] SpriteRenderer Shape2;
    [SerializeField] SpriteRenderer Shape3;
    [SerializeField] TMP_Text statusText1;
    [SerializeField] TMP_Text statusText2;
    [SerializeField] TMP_Text statusText3;
    [SerializeField] TMP_Text mainStatusGuesses;
    [SerializeField] UnityEngine.UI.Button resetButton;
    [SerializeField] public Sprite[] Sprites = new Sprite[3]; //shapes are intialized in the inspector for the array, 3 shapes circle, square, triangle
    private Color[] colorsSolution = new Color[3];
    private Sprite[] shapesSolution = new Sprite[3];
    private int guesses;
    private int colorIndex1=0;
    private int colorIndex2 = 0;
    private int colorIndex3 = 0;
    private int spriteIndex1 = 0;
    private int spriteIndex2 = 0;
    private int spriteIndex3 = 0;
    void Start()
    {
        Sprites = new Sprite[3] { Shape1.sprite,Shape2.sprite,Shape3.sprite};//intialize the shapes for the array for randomization
        colors = new Color[6] { Color.blue, Color.red, Color.green, Color.red, Color.yellow, Color.magenta }; //intialize the colours for the array for randomization

         //generate random solution for user to slove for colors and sprites 
         for (int i = 0; i < colorsSolution.Length; i++)
        {
            colorsSolution[i] = colors[Random.Range(0,colors.Length)];
            shapesSolution[i] = Sprites[Random.Range(0, Sprites.Length)];
        }

        //Cheat code for the user 
        Debug.Log("First colour is: "+ colorsSolution[0] + " shape is: " + shapesSolution[0]);
        Debug.Log("Second answer, colour is: " + colorsSolution[1] + " shape is: " + shapesSolution[1]);
        Debug.Log("Third answer, colour is: " + colorsSolution[2] + " shape is: " + shapesSolution[2]);

        //randomize shapes & colours 
        Shape1.color = colors[colorIndex1=Random.Range(0, colors.Length)];
        Shape2.color = colors[colorIndex2=Random.Range(0, colors.Length)];
        Shape3.color = colors[colorIndex3=Random.Range(0, colors.Length)];
        Shape1.sprite = Sprites[spriteIndex1=Random.Range(0, Sprites.Length)];
        Shape2.sprite = Sprites[spriteIndex2=Random.Range(0, Sprites.Length)];
        Shape3.sprite = Sprites[spriteIndex3=Random.Range(0, Sprites.Length)];

        resetButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //randomize shapes & colours on click with raycast
        if (Input.GetMouseButtonDown(0)) // 0 represents the left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject shape = hit.collider.gameObject;
               
                if (shape == Shape1.gameObject)
                {
                    if (colorIndex1 == colors.Length)
                    {
                        colorIndex1 = 0;
                    }
                    Shape1.color = colors[colorIndex1++];
                } else if (shape == Shape2.gameObject)
                {
                    if (colorIndex2 == colors.Length)
                    {
                        colorIndex2 = 0;
                    }
                    Shape2.color = colors[colorIndex2++];
                } else if (shape == Shape3.gameObject)
                {
                    if (colorIndex3 == colors.Length)
                    {
                        colorIndex3 = 0;
                    }
                    Shape3.color = colors[colorIndex3++];
                }
            }
            
        }
        if (Input.GetMouseButtonDown(1)) // 1 represents the right mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject shape = hit.collider.gameObject;

                if (shape == Shape1.gameObject)
                {
                    if (spriteIndex1 == Sprites.Length)
                    {
                        spriteIndex1 = 0;
                    }
                    Shape1.sprite = Sprites[spriteIndex1++];
                }
                else if (shape == Shape2.gameObject)
                {
                    if (spriteIndex2 == Sprites.Length)
                    {
                        spriteIndex2 = 0;
                    }
                    Shape2.sprite = Sprites[spriteIndex2++];
                }
                else if (shape == Shape3.gameObject)
                {
                    if (spriteIndex3 == Sprites.Length)
                    {
                        spriteIndex3 = 0;
                    }
                    Shape3.sprite = Sprites[spriteIndex3++];
                }
            }

        }
       
    }
    public void check()
    {
        //when user guesses all three shapes right & hints 
        mainStatusGuesses.text = "Gusses: " + ++guesses;
        if (Shape1.sprite == shapesSolution[0] && Shape1.color == colorsSolution[0] && Shape2.sprite == shapesSolution[1] && Shape2.color == colorsSolution[1] && Shape3.sprite == shapesSolution[2] && Shape3.color == colorsSolution[2])
        {
            mainStatusGuesses.text = "Good job! you won with "+ --guesses +" guesses"; //minus a guess cause user guessed right
            statusText1.text = "Right shape\n Right Colour";
            statusText2.text = "Right shape\n Right Colour";
            statusText3.text = "Right shape\n Right Colour";
            resetButton.gameObject.SetActive(true);
        }

        //checking win condition for shape1
        if (Shape1.sprite == shapesSolution[0] && Shape1.color == colorsSolution[0])
        {
            statusText1.text = "Right shape\n Right Colour";
        } 
        else if (Shape1.sprite != shapesSolution[0] && Shape1.color == colorsSolution[0])
        {
            statusText1.text = "Wrong shape\n Right Colour";
        }
        else if (Shape1.sprite == shapesSolution[0] && Shape1.color != colorsSolution[0])
        {
            statusText1.text = "Right shape\n Wrong Colour";
        }
        else if (Shape1.sprite != shapesSolution[0] && Shape1.color != colorsSolution[0])
        {
            statusText1.text = "Wrong shape\n Wrong Colour";
        }

        //checking win condition for shape2
        if (Shape2.sprite == shapesSolution[1] && Shape2.color == colorsSolution[1])
        {
            statusText2.text = "Right shape\n Right Colour";
        }
        else if (Shape2.sprite != shapesSolution[1] && Shape2.color == colorsSolution[1])
        {
            statusText2.text = "Wrong shape\n Right Colour";
        }
        else if (Shape2.sprite == shapesSolution[1] && Shape2.color != colorsSolution[1])
        {
            statusText2.text = "Right shape\n Wrong Colour";
        }
        else if (Shape2.sprite != shapesSolution[1] && Shape2.color != colorsSolution[1])
        {
            statusText2.text = "Wrong shape\n Wrong Colour";
        }

        //checking win condition for shape3
        if (Shape3.sprite == shapesSolution[2] && Shape3.color == colorsSolution[2])
        {
            statusText3.text = "Right shape\n Right Colour";
        }
        else if (Shape3.sprite != shapesSolution[2] && Shape3.color == colorsSolution[2])
        {
            statusText3.text = "Wrong shape\n Right Colour";
        }
        else if (Shape3.sprite == shapesSolution[2] && Shape3.color != colorsSolution[2])
        {
            statusText3.text = "Right shape\n Wrong Colour";
        }
        else if (Shape3.sprite != shapesSolution[2] && Shape3.color != colorsSolution[2])
        {
            statusText3.text = "Wrong shape\n Wrong Colour";
        }
    }
    public void reset()
    {
        resetButton.gameObject.SetActive(false);
        statusText1.text = "";
        statusText2.text = "";
        statusText3.text = "";
        mainStatusGuesses.text = "";
        guesses = 0;
        //generate new random solution for user to slove for colors and sprites 
        for (int i = 0; i < colorsSolution.Length; i++)
        {
            colorsSolution[i] = colors[Random.Range(0, colors.Length)];
            shapesSolution[i] = Sprites[Random.Range(0, Sprites.Length)];
        }
        //Cheat code for the user 
        Debug.Log("---------------------------------New Round--------------------------------");
        Debug.Log("First colour is: " + colorsSolution[0] + " shape is: " + shapesSolution[0]);
        Debug.Log("Second answer, colour is: " + colorsSolution[1] + " shape is: " + shapesSolution[1]);
        Debug.Log("Third answer, colour is: " + colorsSolution[2] + " shape is: " + shapesSolution[2]);
    }
}
