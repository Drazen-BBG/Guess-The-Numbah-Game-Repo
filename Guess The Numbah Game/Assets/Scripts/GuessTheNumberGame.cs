using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour
{
    public InputField input;
    public Text infoText;

    private int GuessNumber;
    private int userGuess;

    // Start is called before the first frame update
    void Start()
    {
        GuessNumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        userGuess = int.Parse(input.text);

        if (userGuess == GuessNumber)
        {
            infoText.text = "You guessed the number, it is " + userGuess;
        }
        else if (userGuess > GuessNumber)
        {
            infoText.text = "You guess is "+ userGuess + " and it is grater than the guessed number";
        }
        else if (userGuess < GuessNumber)
        {
            infoText.text = "You guess is " + userGuess + " and it is lower than the guessed number";
        }

        input.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
