using UnityEngine;

public class Prefabs : MonoBehaviour
{
    //В эту переменную нужно перетаскивать префаб
    [SerializeField] GameObject enemyPrefab;
    GameObject _enemy;

    void Update()
    {
        //Создание объекта из префаба
        if (_enemy == null) _enemy = Instantiate(enemyPrefab);
    }
}
