using UnityEngine;

public abstract class BaseLogger : MonoBehaviour
{
    public string message;
    public abstract void Log();



    public void LogError()
    {
        Debug.LogError(message);
            }
    
}



