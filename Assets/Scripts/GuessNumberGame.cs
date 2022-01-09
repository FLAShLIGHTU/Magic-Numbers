using UnityEngine;
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
        _gameText.text = (@$"Cheating! your number is {_guess} ");

      }
      else
      {
        _anotherText.text = ($@"Your number is {_guess}?");
        _step++;
        _gameOver = false;
      }
      

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
    
    public void onClickWin()
    {
      _gameOver = true;
      _gameText.text = ("You are genius! Wanna play again?");
      
    }

    public void onClickQuit()
    {
      Application.Quit();
    }
    
}
