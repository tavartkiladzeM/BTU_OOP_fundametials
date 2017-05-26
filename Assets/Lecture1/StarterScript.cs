using UnityEngine;

namespace Lecture1
{
    public class StarterScript : MonoBehaviour
    {
        // Polimorphism - methods with same name but different arguments:
        void LogWriter()
        {
            Debug.Log("this is a log");
        }

        void LogWriter(string message)
        {
            Debug.Log(message);
        }

        void LogWriter(int intArgument)
        {
            Debug.Log(intArgument);
        }
    }
}

