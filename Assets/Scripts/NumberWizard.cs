using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int maxGuess;
    [SerializeField] int minGuess;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void TooHigh()
    {
        maxGuess = guess - 1;
        NextGuess();
    }

    public void TooLow()
    {
        minGuess = guess + 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(minGuess, maxGuess + 1);
        guessText.text = guess.ToString();
    }
}

