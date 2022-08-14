using Agate.MVC.Base;
using ExampleGame.Message;
using ExampleGame.Module.SaveData;
using ExampleGame.Module.Soundfx;
using System.Collections;
using UnityEngine;

namespace ExampleGame.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveDataController _saveData;
        private SoundfxController _soundfx;

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }
        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
        }
    }
}
