using UnityEngine;

public class Move : MonoBehaviour
{
    Component c;
    public Texture t;

    void Start()
    {
        //Определяет местоположение объекта в пространстве
        c = transform;
        //Определяет форму объекта
        c = GetComponent<MeshFilter>();
        //Отрисовывает объект на сцене
        c = GetComponent<MeshRenderer>();
        //Отвечает за столкновения
        c = GetComponent<Collider>();

        //Придает объекту физические свойства
        var rb = GetComponent<Rigidbody>();
        var rbd = rb.drag;          //сопротивление воздуха при движении
        var rbad = rb.angularDrag;  //сопротивление воздуха при вращении
        var rbk = rb.isKinematic;   //не действуют столкновения

        //Определяет, как объект должен отображаться (свет, поверхность, отражение и т.д.)
        var m = GetComponent<Renderer>().material;
        var mc = m.color;                                   //albedo
        m.SetTexture("_MainTex", t);                        //albedo
        m.SetFloat("_Metallic", 1f);
        m.SetFloat("_Smoothness", 1f);                      //степень отражения
        m.SetTextureScale("_MainTex", new Vector2(1, 1));   //tiling
        m.SetTextureOffset("_MainTex", new Vector2(1, 1));  //offset
        m.EnableKeyword("_EMISSION");                       //свечение
        m.SetColor("_EmissionColor", Color.blue);           //цвет свечения
        m.SetOverrideTag("RenderType", "Transparent");      //Rendering Mode
    }
}
