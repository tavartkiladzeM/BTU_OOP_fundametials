using UnityEngine;

public class Archer : Soldier
{

    
    public int arrowCount=100;

    public override void Attack()
    {
        if (arrowCount>0)
        {
            arrowCount--;
            target.GetDamage(damage);
        }
    }


    }