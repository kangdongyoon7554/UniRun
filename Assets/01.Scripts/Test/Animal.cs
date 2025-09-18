using UnityEngine;

public class Animal : MonoBehaviour
{
    void Start()
    {
        Dog wawa = new Dog();
        wawa.name = "客客";
        wawa.Bark();
        Debug.Log("Count : " + (++Dog.count));

        Dog kang = new Dog();
        kang.name = "碍悼辣";
        kang.Bark();
        Debug.Log("Count : " + (++Dog.count));

        Dog ju = new Dog();
        ju.name = "林柳快";
        ju.Bark();
        Debug.Log("Count : " + (++Dog.count));
    }
}
