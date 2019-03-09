using Game_With_Number.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Game
{
    class GameScreen
    {
        private int _width;
        private int _height;
        private Hero _hero;
        private List<Enemy> _enemy = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            _width = width;
            _height = height;
         
        }


        public void SetHero(Hero hero)
        {
            _hero = hero;
        }

        public void MoveHeroRight()
        {   
            _hero.MoveRight();
        }

        public void MoveHeroLeft()
        {
            _hero.MoveLeft();
        }

        public void AddEnemy(Enemy enemy)
        {
            _enemy.Add(enemy);
        }

        public void MoveAllEnemiesDown ()
        {
            foreach (Enemy enemy in _enemy)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in _enemy)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }


        public void render()
        {
            _hero.PrintInfo();
            foreach(Enemy enemy in _enemy)
            {
                enemy.PrintInfo();
            }
        }
    }
}
