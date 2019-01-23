using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    void GameStart()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess++;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess--;
        NextGuess();
    }
    // Update is called once per frame
    
    void NextGuess()
    {
        guess = Random.Range(min, max++);
        guessText.text = guess.ToString();
    }
}
