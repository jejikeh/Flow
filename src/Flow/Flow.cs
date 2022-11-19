using Engine;
using Engine.Types;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Flow.GameObjects;
using SFML.Graphics;
using SFML.System;
using TinyLog;

namespace Flow
{
    public class Flow : Game
    {
        // private Player _player = new Player(new Vector2f(50,50));
        // public static CellGrid World = new CellGrid(35, 31, 8);

        private FlowWorld? _mainWorld;

        private string _levelMap = @"
*******************************
*******************************
********E**********E***********
*******************************
*******************************
*************B*****************
*******************************
*****************X*************
*****************XXXX**********
***********X*****X**X**********
***********X********X**********
***********X*******************
*******E***********************
*************B*****************
*******************************
*******************B***********
*******************************
*******************************
*******************************
*******************************
*******S***********************
*******************************
*******************************
*******************************
*******************************
*******************************
*******************************
*******************************
*******************************
*******************************

";
        
        protected override void OnAwake()
        {
            Config = new Config();   
            base.OnAwake();

            _mainWorld = new FlowWorld(_levelMap.Split("\n")[2].Length, Render, _levelMap);
            _mainWorld.ChangeTileType(34,3,TileType.Player);
        }

        public override void Load()
        {
           // World.PlaceObjectToGrid(_player, 8,8);
        }

        public override async Task Update()
        {
            await base.Update();
            VoidColor = Color.Black;

            // await _player.Update(this);
        }

        public override void Draw()
        {
            
            Render.Draw(_mainWorld!);
            // Render.Draw(_player);
        }
    }
}