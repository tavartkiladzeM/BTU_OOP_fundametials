using UnityEngine;

public class Parent : MonoBehaviour
{

        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoAction();
        }
    }


    public virtual void DoAction()
    {
        Debug.Log("error");
    }
}

