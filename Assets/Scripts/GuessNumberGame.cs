using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GuessNumberGame : MonoBehaviour
{ 
    [SerializeField] Text _gameText;
    [SerializeField] private Text _anotherText;
    private int _min = NumberMinMax.MinNum;
    private int _max = NumberMinMax.MaxNum;
    
    private int _guess;
    private int _step = 0;

    private bool _gameOver;
    


    void Start()
    {
      
      _gameText.text = (@$"I need to choose number from {_min}  to {_max}.");
      CalculateGuess();
      _anotherText.text = ($@"Your number is {_guess}? ");

    }

    void Update()
    {
      

    }


    public void CalculateGuess()
    {
      int guess = _guess;
      _guess = (_min + _max) / 2;
      if (guess == _guess)
      {
        _gameOver = true;
        _gameText.text = (@$"LMAO, you forget your number? :) ");
        Invoke(nameof(LoadRestart), 2f);
        

      }
      else
      {
        _anotherText.text = ($@"Your number is {_guess}?");
        _step++;
        _gameOver = false;
      }
      

    }

    public void LoadRestart()
    {
      SceneManager.LoadScene("GuessNumber");
    }
    public void onClickMin()
    {
      if (_gameOver == false)
      {
        _max = _guess;
        CalculateGuess();
      }
    
    }
    
    public void onClickMax()
    {
      if (_gameOver == false)
      {
        _min = _guess;
        CalculateGuess();
      }
     
    }

    public void MenuBooton()
    {
      SceneManager.LoadScene("StartScene");
    }
    
    public void LoadGuessNumber()
    {
      SceneManager.LoadScene("GuessNumber");
    }

    public void onClickQuit()
    {
      Application.Quit();
      Debug.Log("Quit");
    }
    
    public void WinScene()
    {

      SceneManager.LoadScene(("WinScene"));
    }
    
}
