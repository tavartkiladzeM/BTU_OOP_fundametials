
using UnityEngine;

public class Child2 : Parent
{
    public Material mat;

	
	public override void DoAction()
    {
        mat.color = Random.ColorHSV();
    }
}
