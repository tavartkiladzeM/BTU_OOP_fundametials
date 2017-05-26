using UnityEngine;

public class Lecture2Example : MonoBehaviour
{
    soldier mysoldier;
	void Start ()
    {
        mysoldier = new archer();
        mysoldier.attack();
	}
}

public class soldier
{
    public int health;
    public int damage;
    public virtual void attack()
    {
        Debug.Log("soldier is attacking!!!");
    }
}
public class archer : soldier
{
   public override void attack()
    {
        //base.attack();
        Debug.Log("archer is shooting!");
    }
}
public class swordsman : soldier
{

}