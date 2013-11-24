﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JamGame.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace JamGame.Gamestate
{
    public class MenuState : GameState
    {
        private GuiManager gui;
        public MenuState()
        {
            gui = new GuiManager(Game.Instance.Content.Load<SpriteFont>("default"));
            LinkLabel start = new LinkLabel();
            start.Text = "Start game";
            start.Position = new Vector2(Game.Instance.ScreenWidth / 2, 300);
            start.Color = Color.Black;
            start.OnSelected += start_OnSelected;
            gui.AddControl(start);
        }

        void start_OnSelected(object sender, ControlEventArgs e)
        {
            Game.Instance.GameStateManager.ChangeState(new HowManyPlayersState());
        }

        public override void Update(GameTime gameTime)
        {
         gui.Update(gameTime);   
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.GraphicsDevice.Clear(Color.RosyBrown);
            gui.Draw(spriteBatch);
            spriteBatch.End();
        }
    }
}