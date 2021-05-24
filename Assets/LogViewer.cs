using UnityEngine;
using UnityEngine.UI;

namespace EcsGenerator
{
    public class LogViewer : MonoBehaviour
    {
        public Text text;

        void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }
        
        void HandleLog(string logString, string stackTrace, LogType type)
        {
            text.text = logString;
        }
    }
}