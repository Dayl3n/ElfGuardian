﻿using Projekt_J.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Projekt_J
{
    internal class LevelClass
    {
        private int level;
        private EnemyFabric monsterINC;
        public bool isFinished=false;

        public PictureBox button;
        public Label label;

        public int Level
        {
            get { return level; }
        }
        public EnemyFabric MonsterINC
        {
            get { return monsterINC; }
        }

        public LevelClass(Form parrentForm, PlayerCastle playerCastle,int level,int BasicEnemiesCount, int RangeEnemiesCount, int FlyingEnemiesCount, int HugeEnemies)
        {
            this.level = level;
            label = new Label();
            label.Text = $"Level {level}";
            label.Font = new Font("Calibri", 12,FontStyle.Bold);
            label.BackColor = Color.Transparent;
            label.Size = new Size(width: 62, height: 19);

            monsterINC = new EnemyFabric(parrentForm,playerCastle,level,BasicEnemiesCount,RangeEnemiesCount,FlyingEnemiesCount,HugeEnemies);

            button = new PictureBox();
            button.Size = new Size(width: Properties.Resources.Green_Button.Width, height: Properties.Resources.Green_Button.Height);
            button.BackColor = Color.Transparent;
           
        }

    }
}
