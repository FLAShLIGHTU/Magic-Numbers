using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumber : MonoBehaviour
{
    
    [SerializeField] private int _lastNumber;
    private int _sumNumber;
    private int _number;
    private int _counterSteps;
    
    void Start()
    {
        _sumNumber = 0;
        print("Введите число от 1 до 9");
        _counterSteps = 0;

    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _sumNumber = 0;
            _counterSteps = 0;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _number = 1;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _number = 2;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _number = 3;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _number = 4;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _number = 5;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            _number = 6;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            _number = 7;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            _number = 8;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }
        
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            _number = 9;
            _sumNumber = _sumNumber + _number;
            print($"Вы ввели {_number}. Ваша сумма {_sumNumber}");
            winCheker();
            

        }

    }

    private bool _boolSumNumber(int _sumNumber)
    {
        return (_sumNumber == 1);
    }
    private void winCheker()
    {
        _counterSteps += 1;
        if(_sumNumber == _lastNumber)
        {
            print($"Игра окончена! Колличество ходов:{_counterSteps} Нажмите пробел, что бы начать заново.");

           
        }
    }
}
