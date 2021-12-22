using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelloWorld : MonoBehaviour
{
 [SerializeField] private int _min;
 [SerializeField] private int _max;
 private int _guess;
 private int _counterSteps;
 
 private void Start()
 {
  Debug.Log($"Загадай число от {_min} до {_max} и нажми любую кнопку");
  _counterSteps = 0;

 }

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.DownArrow))
  {  
   _max = _guess;
   
   CalculateGuess();
   CheckWin();
  }
  if (Input.GetKeyDown(KeyCode.UpArrow))
  {
   _min = _guess;
   
   CalculateGuess();
   CheckWin();
   
  }
  if (Input.GetKeyDown(KeyCode.Space))
  {
   
  }
  
  
 }
 private void CalculateGuess()
 {
  _guess = (_min + _max) / 2;
  Debug.Log($"Твое число {_guess} ?");
  _counterSteps += 1;

 }

 private void CheckWin()
 
 {
  Debug.Log("Это твое число? Y - да, N - нет.");
  
  if (Input.GetKeyDown(KeyCode.Y))
  {
   Debug.Log($"Ура! Колличество шагов {_counterSteps}");
   
  }

  if (Input.GetKeyDown(KeyCode.N))
  {
   Update();
  }

 }
}
