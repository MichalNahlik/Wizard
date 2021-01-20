using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {

        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Hello adventurer. Me, the Wizard man, will guess any number you can possible think about... in few guesses");
        Debug.Log("Pick a random number");
        Debug.Log("Highest number can be: " + max);
        Debug.Log("Lowest number can be: " + min);
        Debug.Log("Tell me if your number is lower or higher than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();
          
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Told ya!");
            StartGame();
        }   

    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower mate?" + guess);

    }
}
