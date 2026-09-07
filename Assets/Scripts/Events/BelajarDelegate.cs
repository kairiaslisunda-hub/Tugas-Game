using UnityEngine;
using System;

public class BelajarDelegate : MonoBehaviour
{

    delegate void delegateContoh();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UjiDeleagte1();
        UjiDelegate2();
        UjiDelegate3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PanggilNama()
    {
        Debug.Log("Halo Nama Saya Kairi");
    }

    void PanggilHello()
    {
        Debug.Log("Hello");
    }

    void UjiDeleagte1()
    {
        delegateContoh Panggil = PanggilHello;
        PanggilHello();
    }

    void UjiDelegate2()
    {
        delegateContoh Panggil = PanggilHello;
        Panggil += PanggilNama;
        Panggil();
    }

    void UjiDelegate3()
    {
        Action panggil = PanggilHello;
        panggil += PanggilNama;
        panggil();
    }
}
