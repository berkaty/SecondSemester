using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReversePuzzle
{
    public partial class Form1 : Form
    {
        GameModel game;
        TableLayoutPanel table;

        public Form1(GameModel game) //создание интерфейса
        {
            InitializeComponent();
            this.game = game;
            table = new TableLayoutPanel();

            toolStripMenuItem1.Click += Reverse_Click;

            toolStripMenuItem2.Click += Close_Click;

            for (int i = 0; i < game.SizeOfTheGame; i++) 
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / game.SizeOfTheGame));
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / game.SizeOfTheGame));
            }

            for (int column = 0; column < game.SizeOfTheGame; column++)
                for (int row = 0; row < game.SizeOfTheGame; row++)
                {
                    var iRow = row; //чтобы программа не замкнуласб, объявить переменные
                    var iColumn = column;
                    var button = new Button();
                    button.Dock = DockStyle.Fill;
                    button.Click += (sender, args) => game.Flip(iRow, iColumn); //действие при нажатии кнопки 
                    table.Controls.Add(button, iColumn, iRow);
                }

            table.Dock = DockStyle.Fill;
            Controls.Add(table);
            game.StateChanged += (row, column, state) => 
                ((Button)table.GetControlFromPosition(column, row)).BackColor = state ? Color.Black : Color.White;
            game.Start();
        }

        public void Reverse_Click(object sender, EventArgs e) //кнопка Сброс
        {
            game.Start();
        }

        public void Close_Click(object sender, EventArgs e) //кнопка Выход
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e) //Происходит до первоначального отображения формы
        {

        }
    }
    public class GameModel
    {
        bool[,] game; //массив состояний
        public readonly int SizeOfTheGame; //размер игры

        public GameModel(int size) //конструктор, в котором инициализируются поля
        {
            SizeOfTheGame = size;
            game = new bool[size, size]; // состояния будут меняться, при изменении состояния меняется рисунок (идет перерисовка события)
        }

        public void Start() // инициализирует игру
        {
            for (int row = 0; row < SizeOfTheGame; row++)
                for (int column = 0; column < SizeOfTheGame; column++)
                    SetState(row, column, 0 == 1);
        }

        public event Action<int, int, bool> StateChanged;

        void SetState(int row, int column, bool state) //меняет состояние в какой-то строке или столбце
        {
            game[row, column] = state;
            if (StateChanged != null) 
                StateChanged(row, column, game[row, column]);
        }

        void FlipState(int row, int column) // меняет состояние на противоположное
        {
            SetState(row, column, !game[row, column]);
        }

        public void Flip(int row, int column) //отвечает за смену цвета клеток
        {
            for (int iRow = 0; iRow < SizeOfTheGame; iRow++)
                if (iRow != row) 
                    FlipState(iRow, column);
            for (int iColumn = 0; iColumn < SizeOfTheGame; iColumn++)
                if (iColumn != column) 
                    FlipState(row, iColumn);
            FlipState(row, column);
        }   
    }
}
