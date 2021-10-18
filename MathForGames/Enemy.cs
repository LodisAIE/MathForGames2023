using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Enemy : Actor
    {
        private float _speed;
        private Vector2 _velocity;
        private Actor _target;
        public UIText _speechText;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Enemy(char icon, float x, float y, float speed, Color color, Actor target, string name = "Actor")
            : base(icon, x, y, color, name)
        {
            _speed = speed;
            _target = target;
        }


        public override void Start()
        {
            base.Start();
        }

        public override void Update(float deltaTime)
        {
            _speechText.Text = "Pls get away";
            _speechText.Position = Position + new Vector2(0, -5);
            //Create a vector that stores the move input
            Vector2 moveDirection = (Position - _target.Position  ).Normalized;

            Velocity = moveDirection * Speed * deltaTime;

            Position += Velocity;

            base.Update(deltaTime);
        }

        public override void OnCollision(Actor actor)
        {
            Console.WriteLine("Collision occured");
        }
    }
}
