using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class PlayerHud : Actor
    {
        private Player _player;
        private UIText _health;
        private UIText _lives;

        public PlayerHud(Player player, UIText health, UIText lives)
        {
            _player = player;
            _health = health;
            _lives = lives;
        }

        public override void Update()
        {
            _health.Text = "Health: " + _player.Health.ToString();
            _lives.Text = "Lives: " + _player.Lives.ToString();
        }
    }
}
