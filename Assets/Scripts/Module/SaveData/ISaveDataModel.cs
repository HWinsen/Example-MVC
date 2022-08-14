using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Coin { get; }
    }
}
