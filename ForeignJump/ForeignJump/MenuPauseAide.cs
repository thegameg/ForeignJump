﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ForeignJump
{
    class MenuPauseAide
    {
        private Texture2D menuPauseAidebg; //image
        
        public MenuPauseAide()
        { }

        public void Initialize()
        {

        }

        public void LoadContent(ContentManager Content)
        {
            menuPauseAidebg = Content.Load<Texture2D>("Menu/MenuPauseAide");
        }

        public void Update(GameTime gameTime, int vitesse)
        {
            if (KB.New.IsKeyDown(Keys.Escape) && !KB.Old.IsKeyDown(Keys.Escape))
                GameState.State = "menuPause"; //retour au menu
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(menuPauseAidebg, new Rectangle(440, 185, 400, 431), Color.White);
        }
    }
}