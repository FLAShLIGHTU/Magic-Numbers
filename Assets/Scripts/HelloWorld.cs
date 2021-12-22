using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
 [SerializeField] private int min;
 [SerializeField] private int max;
 private int guess;

 private void Start()
 {
  Debug.Log($"Загадай число от {min} до {max}");
 }

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.DownArrow))
  {  
   max = guess;
   this.CalculateGuess();
  }
  if (Input.GetKeyDown(KeyCode.UpArrow))
  {
   min = guess;
   this.CalculateGuess();
  }
  if (Input.GetKeyDown(KeyCode.Space))
  {
   
  }

 }
 private void CalculateGuess()
 {
  guess = (min + max) / 2;
  Debug.Log($"Твое число {guess} ?");
 }
}
