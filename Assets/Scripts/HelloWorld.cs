using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class HelloWorld : MonoBehaviour
{
 [SerializeField] private int _min;
 [SerializeField] private int _max;
 private int _minRange;
 private int _maxRange;
 private int _restartGuess;
 private int _guess;
 private int _counterSteps;
 


 private void Start()
 {
  Debug.Log($"Загадай число от {_min} до {_max} и нажми кнопку Вверх");
 //_counterSteps = 0;

 }

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.DownArrow))
  {
   _max = _guess;
   CalculateGuess();

  }

  if (Input.GetKeyDown(KeyCode.UpArrow))
  {
   _min = _restartGuess;
   CalculateGuess();


  }

  if (Input.GetKeyDown(KeyCode.Space))
  {
   Default();
  }

 }



 private void Default()
 {
  Debug.Log($"Ура!Твое числов {_guess} Колличество шагов {_counterSteps}");
  
  _minRange = _min;
  _maxRange = _max;
  _guess = _restartGuess;
  _counterSteps = 0;
  
  
  Debug.Log($"Давай заново!");


 }

 private void CalculateGuess()
 {
  _guess = (_min + _max) / 2;
  Debug.Log($"Твое число {_guess} ? Нажми пробел, если я угадал, или играем дальше!");
  _counterSteps += 1;

 }
}
