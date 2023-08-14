using System;
using UnityEngine;

namespace EcsGenerator
{

    public interface IEcsRunner
    {
        void Init();
        void GenStartEntities();
        void Run();
        void GenInfo();
        void CopyWorld(int i);
    }
    
    public class UnityEcsRunner : MonoBehaviour
    {
        private IEcsRunner _runner;
        
        public void SelectRunnerFromObject(GameObject g)
        {
            var c = g.GetComponent<IEcsRunner>();
            if (c == null)
            {
                Debug.LogError("Runner not found");
                return;
            }

            _runner = c;
            Debug.Log("runner selected "+g.gameObject.name);
        }

        public void Init()
        {
            StartTimer();
            _runner.Init();
            EndTimer("Init time: ");
        }
        
        public void GenStartEntities()
        {
            StartTimer();
            _runner.GenStartEntities();
            EndTimer("Creation entities time: ");
        }
        
        public void Run(int r)
        {
            StartTimer();
            for (int i = 0; i < r; i++)
            {
                _runner.Run();    
            }
            EndTimer($"Run on {r} iterations time: ");
        }

        private float _t;
        void StartTimer()
        {
            _t = Time.realtimeSinceStartup;
        }

        void EndTimer(string desc)
        {
            var dt = Time.realtimeSinceStartup-_t;
            Debug.Log(desc + (dt*1000)+"ms");
        }
        
        public void GetInfo()
        {
            _runner.GenInfo();
        }      
        
        public void CopyWorld(int i)
        {
            StartTimer();
            _runner.CopyWorld(i);
            EndTimer($"CopyWorld {i} time: ");
        }
    }
}