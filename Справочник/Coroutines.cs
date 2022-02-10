using UnityEngine;

//Сопрограммы - это функции, которые выполняются на протяжении нескольких кадров. Например, перемещение обекта вперед на определенное расстояние в каждом кадре
public class Prefabs : MonoBehaviour
{
    void Start()
    {
        //Вызов сопрограммы
        var myCoroutine = StartCoroutine(MoveSmoothly());
    }
    
    //Правильный пример сопрограммы с учетом разной частоты кадров
    IEnumerator MoveSmoothly()
    {
        while (true)
        {
            //перемещать на 1 единицу в секунду
            var movement = 1.0f * Time.deltaTime;
            transform.Translate(0, movement, 0);
            yield return null;
        }
    }
    
    IEnumerator Coroutine1()
    {
        //Приостановит выполнение до следующего кадра
        yield return null;
    }
    
    IEnumerator Coroutine2()
    {
        //Приостановит выполнение на 3 сек
        yield return new WaitForSeconds(3);
    }
    
    IEnumerator Coroutine3()
    {
        //Приостановит выполнение до момента, когда переменная someVariable получит значение true
        yield return  new WaitUntil(() => this.someVariable == true);
    }
    
    IEnumerator Coroutine4()
    {
        //Остановит сопрограмму
        yield break;
    }
}
