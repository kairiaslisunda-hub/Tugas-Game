using UnityEngine;

public class FlagZombie : enemy
{
    public bool flag = true;

    public override void Serang()
    {
        Debug.Log("FlagZombie gigit");
    }
}
