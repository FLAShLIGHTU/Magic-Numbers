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
  
   
    
    void Start()
    {
      
      _gameText.text = (@$"I need to choose number from {_min}  to {_max}.");
      Debug.Log($"{_min}, {_max}");
      CalculateGuess();
      Debug.Log($"{_min}, {_max}");
      _anotherText.text = ($@"Your number is {_guess}? ");
      Debug.Log($"{_min}, {_max}");
      
    }

    void Update()
    {
      

    }

    public void Less()
    {
      _guess = _min;
      CalculateGuess();
    }

    public void More()
    {
      _guess = _max;
      CalculateGuess();
    }

    public void Win()
    {
      
    }

    private void CalculateGuess()
    {
      
      _guess = (_max - _min) / 2;

    }
}
