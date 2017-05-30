using UnityEngine;

public class SwordsMan : Soldier
{

    public int armor=100;

    public override void GetDamage(int dmg)
    {
        if (armor > 0)
        {
            armor -= dmg;
        }
        else
        {
            health -= dmg;
        }
    }
            
}

    