using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.EventSystems;
using ExampleGame.Module.SaveData;

namespace ExampleGame.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            return null;
        }

        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}
