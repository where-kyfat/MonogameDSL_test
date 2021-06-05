﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogameLib.Classes
{
    public static class Conditions
    {
        static float timerSec = 0;
        static float timerMil = 0;

        public static bool EveryTick()
        {
            return true;
        }

        public static bool EveryXSeconds(GameTime gameTime, float x)
        {
            timerSec += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timerSec > x)
            {
                timerSec = 0f;
                return true;
            }
            return false;
        }

        //public static bool ForEach(List<Sprite> sprites, )

        public static bool IsOutsideLayout(Sprite target, int layoutSizeX, int layoutSizeY)
        {
            var Left = target.Rectangle.Left;
            var Right = target.Rectangle.Right;
            var Bottom = target.Rectangle.Bottom;
            var Top = target.Rectangle.Top;
            if (layoutSizeX <= Right || layoutSizeY <=  Bottom ||
                Left <= 0 || Top < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InCollisionWith(Sprite target1, Sprite target2)
        {
            return IsTouchingLeft(target1, target2) || IsTouchingRight(target1, target2) 
                || IsTouchingTop(target1, target2) || IsTouchingBottom(target1, target2);

        }

        public static bool IsTouchingLeft(Sprite target1, Sprite target2)
        {
            return target1.Rectangle.Right > target2.Rectangle.Left &&
              target1.Rectangle.Left < target2.Rectangle.Left &&
              target1.Rectangle.Bottom > target2.Rectangle.Top &&
              target1.Rectangle.Top < target2.Rectangle.Bottom;
        }

        public static bool IsTouchingRight(Sprite target1, Sprite target2)
        {
            return target1.Rectangle.Left < target2.Rectangle.Right &&
              target1.Rectangle.Right > target2.Rectangle.Right &&
              target1.Rectangle.Bottom > target2.Rectangle.Top &&
              target1.Rectangle.Top < target2.Rectangle.Bottom;
        }

        public static bool IsTouchingTop(Sprite target1, Sprite target2)
        {
            return target1.Rectangle.Bottom > target2.Rectangle.Top &&
              target1.Rectangle.Top < target2.Rectangle.Top &&
              target1.Rectangle.Right > target2.Rectangle.Left &&
              target1.Rectangle.Left < target2.Rectangle.Right;
        }

        public static bool IsTouchingBottom(Sprite target1, Sprite target2)
        {
            return target1.Rectangle.Top < target2.Rectangle.Bottom &&
              target1.Rectangle.Bottom > target2.Rectangle.Bottom &&
              target1.Rectangle.Right > target2.Rectangle.Left &&
              target1.Rectangle.Left < target2.Rectangle.Right;
        }


        public enum MouseButton
        {
            Left,
            Right,
            Middle
        }

        public static bool OnMouseXButtonClicked(MouseButton NameButton, GameTime gameTime)
        {
            timerMil += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timerMil > 250f)
            {
                var mouseState = Mouse.GetState();
                if (NameButton == MouseButton.Left)
                {
                    if (mouseState.LeftButton == ButtonState.Pressed)
                    {
                        timerMil = 0f;
                        return true;
                    }
                }
                else if (NameButton == MouseButton.Right)
                {
                    if (mouseState.RightButton == ButtonState.Pressed)
                    {
                        timerMil = 0f;
                        return true;
                    }
                }
                else if (NameButton == MouseButton.Middle)
                {
                    if (mouseState.MiddleButton == ButtonState.Pressed)
                    {
                        timerMil = 0f;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool OnXButtonClicked(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key);
        }
    }
}
