using UnityEngine;

public class Attributes : MonoBehaviour
{
    //Появится в инспекторе
    [SerializeField]
    string SerializeField;
    
    //Не появится в инспекторе
    [HideInInspector]
    string HideInInspector;
    
    //Выводит указанную надпись над полем в инспекторе
    [Header("Spaceship Info")]
    string ssInfo;
    
    //Добавляет пустое пространство над полем
    [Space]
    string Space;
}

//Требует предварительного подключения компонента
[RequireComponent(typeof(Animator))]
public class RequireComponent : MonoBehaviour { }

//Выполняет код в обоих режимах - проигрывания и редактирования
[ExecuteInEditMode]
public class ExecuteInEditMode : MonoBehaviour { }
