using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Метод, вызванный сценарием стрельбы
    public void Damage()
    {
        StartCoroutine(Die());
    }

    //Опрокидываем врага, ждем 1,5 секунды и уничтожаем его
    private IEnumerator Die()
    {
        this.transform.Rotate(0, 0, -75);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
