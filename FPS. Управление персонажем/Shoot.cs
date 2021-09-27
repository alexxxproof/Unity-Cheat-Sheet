using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Camera _camera;
    
    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        //Нажатие левой кнопки мыши
        if (Input.GetMouseButtonDown(0))
        {
            //Точка в центре экрана
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            //Создает луч, начинающийся с камеры, и проецирует его по линии, проходящей через указанные экранные координаты.
            Ray ray = _camera.ScreenPointToRay(point);
            //Проверяет место пересечения луча, собирает информацию об этом пересечении и возвращает true в случае столкновения луча с препятствием.
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //Запуск сопрограммы в ответ на попадание.
                StartCoroutine(SphereIndicator(hit.point));
            }
        }
    }

    //Создает сферу, помещает ее в указанной точке, ждет 1 секунду, после чего удаляет сферу
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        yield return new WaitForSeconds(1);
        Destroy(sphere);
    }

    //OnGUI вызывается в каждом кадре после визуализации в трехмерной сцене. В данном случае создается точка в центре экрана
    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
