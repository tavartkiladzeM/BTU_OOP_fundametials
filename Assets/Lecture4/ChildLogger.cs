
using UnityEngine;

public class ChildLogger : BaseLogger
{
    public override void Log ()
        {
       Debug.LogWarning (message);
    }

	
}
