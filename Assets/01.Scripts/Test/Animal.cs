using UnityEngine;

public class Animal : MonoBehaviour
{
    void Start()
    {
        Dog wawa = new Dog();
        wawa.name = "�Ϳ�";
        wawa.Bark();
        Debug.Log("Count : " + (++Dog.count));

        Dog kang = new Dog();
        kang.name = "������";
        kang.Bark();
        Debug.Log("Count : " + (++Dog.count));

        Dog ju = new Dog();
        ju.name = "������";
        ju.Bark();
        Debug.Log("Count : " + (++Dog.count));
    }
}
