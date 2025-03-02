using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FrmSnakeGame: Form
    {
        private const int CELL_SIZE_PIXELS = 30;                    // Размер клетки игрового поля, в пикселях
        private const int ROWS_NUMBER = 15;                         // Количество рядов в игровом поле
        private const int COLS_NUMBER = 15;                         // Количество столбцов в игровом поле
        private const int FIELD_LEFT_OFFSET_PIXELS = 40;            // Отступ в пикселях от левого края формы
        private const int FIELD_TOP_OFFSET_PIXELS = 15;             // Отступ в пикселях от правого края формы
        private const int INITIAL_SNAKE_SPEED_INTERVAL = 300;       // Задержка (свойство "Interval") для основного игрового таймера TimerGameLoop
        private const int SPEED_INCREMENT_BY = 5;                   // На сколько миллисекунд увеличить скорость "Змейки" при очередном поглощении змейкой "Еды"        
        private const bool ENABLE_KEYDOWN_DELAY = true;             // Разрешить функцию задержки при нажатии клавиш?
        private const int KEYDOWN_DELAY_MILLIS = 120;               // Минимальное количество миллисекунд, которое должно пройти между последовательными нажатиями клавиш
        private enum SnakeDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        private SnakeDirection snakeDirection = SnakeDirection.Up;      // Текущее направление движения "Змейки"
        private LinkedList<Point> snake = new LinkedList<Point>();      // Список точек, содержащих координаты всего "тела Змейки"
        private Point food;                                             // Точка, содержащая координаты "Еды" для "Змейки"
        private Random rand = new Random();                             // Генератор псевдослучайных чисел. нужен для генерации очередной "Еды" в произвольном месте игрового поля
        private bool isGameEnded;                                       // Признак: игра завершена?

        private int foodAlpha = 255;                                    // Значение для Альфа-канала для цвета "Еды". Необходимо для эффекта "мерцания" еды на игровом поле
        private int foodAlphaInc = -25;                                 // Текущее значение, которое будет по таймеру прибавляться к значению foodAlpha
        private bool isGamePaused;                                      // Признак: поставлена ли игра на паузу?
        private Stopwatch keyPressSensivityStopwatch = new Stopwatch(); // Объект Stopwatch для подсчёта количества миллисекунд между нажатиями клавиш игроком
        private int points = 0;                                         // Статистика: количество очков, набранных игроком в игре
        private int foodEaten = 0;                                      // Статистика: количество "Еды", поглощённой "Змейкой"

        public FrmSnakeGame()
        {
            InitializeComponent();
        }

        private void InitializeSnake()
        {
            snakeDirection = SnakeDirection.Up;
            snake.Clear();
            snake.AddFirst(new Point(ROWS_NUMBER - 1, COLS_NUMBER / 2 - 1));
        }

        private void FrmSnakeGame_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            BackColor = Color.Black;
            StartGame();
        }

        private void StartGame() //Запуск игры
        {
            GenerateFood();
            InitializeSnake();
            isGameEnded = false;
            isGamePaused = false;
            foodAlpha = 255;
            foodAlphaInc = -25;
            points = 0; //
            foodEaten = 0;
            TimerGameLoop.Start();
            TimerFoodBlink.Start();
            TimerGameLoop.Interval = INITIAL_SNAKE_SPEED_INTERVAL;
        }

        private void GenerateFood() //Генерация еды для змейки
        {
            bool isFoodClashWithSnake;
            do
            {
                food = new Point(rand.Next(0, ROWS_NUMBER), rand.Next(0, COLS_NUMBER));
                isFoodClashWithSnake = false;
                foreach (Point p in snake)
                {
                    if (p.X == food.X && p.Y == food.Y)
                    {
                        isFoodClashWithSnake = true;
                        break;
                    }
                }
            } while (isFoodClashWithSnake);

            TimerGameLoop.Interval -= SPEED_INCREMENT_BY;
        }

        private void FrmSnakeGame_Paint(object sender, PaintEventArgs e) //Событие отрисовки при запуске формы
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            DrawGrid(g);
            DrawFood(g);
            DrawSnake(g);
        }

        private void DrawGrid(Graphics g)
        {
            for (int row = 0; row <= ROWS_NUMBER; row++)
            {
                g.DrawLine(Pens.Cyan,
                    new Point(FIELD_LEFT_OFFSET_PIXELS, FIELD_TOP_OFFSET_PIXELS + row * CELL_SIZE_PIXELS),
                    new Point(FIELD_LEFT_OFFSET_PIXELS + CELL_SIZE_PIXELS * ROWS_NUMBER, FIELD_TOP_OFFSET_PIXELS + row * CELL_SIZE_PIXELS)
                );

                for (int col = 0; col <= COLS_NUMBER; col++)
                {
                    g.DrawLine(Pens.Cyan,
                        new Point(FIELD_LEFT_OFFSET_PIXELS + col * CELL_SIZE_PIXELS, FIELD_TOP_OFFSET_PIXELS),
                        new Point(FIELD_LEFT_OFFSET_PIXELS + col * CELL_SIZE_PIXELS, FIELD_TOP_OFFSET_PIXELS + CELL_SIZE_PIXELS * COLS_NUMBER)
                    );
                }
            }
        }

        private void DrawSnake(Graphics g)
        {
            int snakePoint = 0;
            foreach (Point p in snake)
            {
                Rectangle snakeBodyRectangle = new Rectangle(
                    FIELD_LEFT_OFFSET_PIXELS + p.Y * CELL_SIZE_PIXELS + 1,
                    FIELD_TOP_OFFSET_PIXELS + p.X * CELL_SIZE_PIXELS + 1,
                    CELL_SIZE_PIXELS - 1,
                    CELL_SIZE_PIXELS - 1);
                Brush brushSnakeBodyGradient = new LinearGradientBrush(snakeBodyRectangle, snakePoint == 0 ? Color.Black : Color.DarkGreen, snakePoint == 0 ? Color.DarkGreen : Color.Lime, 100, true);

                g.FillRectangle(brushSnakeBodyGradient, snakeBodyRectangle);
                brushSnakeBodyGradient.Dispose();

                if (snakePoint == 0)
                {
                    // snakePoint == 0 - это голова. Нарисуем глаза "Змейки"
                    int offsetLeftEyeX = 0, offsetLeftEyeCircleX = 0;
                    int offsetLeftEyeY = 0, offsetLeftEyeCircleY = 0;
                    int offsetRightEyeX = 0, offsetRightEyeCircleX = 0;
                    int offsetRightEyeY = 0, offsetRightEyeCircleY = 0;
                    int eyeWidth = 0;
                    int eyeHeight = 0;
                    switch (snakeDirection)
                    {
                        case SnakeDirection.Left:
                            eyeWidth = 10; eyeHeight = 3; offsetLeftEyeX = 5; offsetLeftEyeY = 22; offsetRightEyeX = 5; offsetRightEyeY = 5;
                            offsetLeftEyeCircleX = 7; offsetRightEyeCircleX = 7; offsetLeftEyeCircleY = 22; offsetRightEyeCircleY = 5;
                            break;
                        case SnakeDirection.Right:
                            eyeWidth = 10; eyeHeight = 3; offsetLeftEyeX = CELL_SIZE_PIXELS - eyeWidth - 5; offsetLeftEyeY = 5; offsetRightEyeX = CELL_SIZE_PIXELS - eyeWidth - 5; offsetRightEyeY = 22;
                            offsetLeftEyeCircleX = CELL_SIZE_PIXELS - eyeWidth - 5 + 5;
                            offsetRightEyeCircleX = CELL_SIZE_PIXELS - eyeWidth - 5 + 5;
                            offsetLeftEyeCircleY = 5; offsetRightEyeCircleY = 22;
                            break;
                        case SnakeDirection.Up:
                            eyeWidth = 3; eyeHeight = 10; offsetLeftEyeX = 5; offsetLeftEyeY = 5; offsetRightEyeX = 22; offsetRightEyeY = 5;
                            offsetLeftEyeCircleX = offsetLeftEyeX;
                            offsetRightEyeCircleX = offsetRightEyeX;
                            offsetLeftEyeCircleY = offsetLeftEyeY + 2; offsetRightEyeCircleY = offsetRightEyeY + 2;
                            break;
                        case SnakeDirection.Down:
                            eyeWidth = 3; eyeHeight = 10; offsetLeftEyeX = 22; offsetLeftEyeY = CELL_SIZE_PIXELS - eyeHeight - 5; offsetRightEyeX = 5; offsetRightEyeY = CELL_SIZE_PIXELS - eyeHeight - 5;
                            offsetLeftEyeCircleX = offsetLeftEyeX;
                            offsetRightEyeCircleX = offsetRightEyeX;
                            offsetLeftEyeCircleY = CELL_SIZE_PIXELS - eyeHeight - 5 + 5; offsetRightEyeCircleY = CELL_SIZE_PIXELS - eyeHeight - 5 + 5;
                            break;
                    }
                    // Рисуем правый глаз "Змейки"
                    g.FillEllipse(Brushes.Yellow, new Rectangle(
                        FIELD_LEFT_OFFSET_PIXELS + p.Y * CELL_SIZE_PIXELS + 1 + offsetRightEyeX,
                        FIELD_TOP_OFFSET_PIXELS + p.X * CELL_SIZE_PIXELS + 1 + offsetRightEyeY,
                        eyeWidth,
                        eyeHeight));

                    // Рисуем зрачок для правого глаза "Змейки"
                    g.FillEllipse(Brushes.Black, new Rectangle(
                        FIELD_LEFT_OFFSET_PIXELS + p.Y * CELL_SIZE_PIXELS + 1 + offsetRightEyeCircleX,
                        FIELD_TOP_OFFSET_PIXELS + p.X * CELL_SIZE_PIXELS + 1 + offsetRightEyeCircleY,
                        3,
                        3));

                    // Рисуем левый глаз "Змейки"
                    g.FillEllipse(Brushes.Yellow, new Rectangle(
                        FIELD_LEFT_OFFSET_PIXELS + p.Y * CELL_SIZE_PIXELS + 1 + offsetLeftEyeX,
                        FIELD_TOP_OFFSET_PIXELS + p.X * CELL_SIZE_PIXELS + 1 + offsetLeftEyeY,
                        eyeWidth,
                        eyeHeight));

                    // Рисуем зрачок для левого глаза "Змейки"
                    g.FillEllipse(Brushes.Black, new Rectangle(
                        FIELD_LEFT_OFFSET_PIXELS + p.Y * CELL_SIZE_PIXELS + 1 + offsetLeftEyeCircleX,
                        FIELD_TOP_OFFSET_PIXELS + p.X * CELL_SIZE_PIXELS + 1 + offsetLeftEyeCircleY,
                        3,
                        3));
                }
                snakePoint++;
            }
        }

        private void DrawFood(Graphics g)
        {
            Rectangle foodRectangle = new Rectangle(
                 FIELD_LEFT_OFFSET_PIXELS + food.Y * CELL_SIZE_PIXELS + 1,
                 FIELD_TOP_OFFSET_PIXELS + food.X * CELL_SIZE_PIXELS + 1,
                 CELL_SIZE_PIXELS - 1,
                 CELL_SIZE_PIXELS - 1);
            Brush brushFood = new LinearGradientBrush(foodRectangle,
                Color.FromArgb(foodAlpha, Color.Crimson.R, Color.Crimson.G, Color.Crimson.B),
                Color.FromArgb(foodAlpha, Color.RosyBrown.R, Color.RosyBrown.G, Color.RosyBrown.B),
                100, true);
            g.FillEllipse(brushFood, foodRectangle);
            Brush brushFoodBorder = new SolidBrush(Color.FromArgb(foodAlpha, Color.Red.R, Color.Red.G, Color.Red.B));
            Pen penFoodBorder = new Pen(brushFoodBorder);
            g.DrawEllipse(penFoodBorder, foodRectangle);
            brushFood.Dispose();
            penFoodBorder.Dispose();
            brushFoodBorder.Dispose();

            foodAlpha = 255;
            foodAlphaInc = -25;
        }

        private void GameOver()
        {
            isGameEnded = true;
            TimerGameLoop.Stop();
            TimerFoodBlink.Stop();  // Останавливаем таймер мерцания для "Еды"
            if (MessageBox.Show("Конец игры! Начать заново?", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartGame();
            }
        }

        private void MoveSnake()
        {
            LinkedListNode<Point> head = snake.First;
            Point newHead = new Point(0, 0);
            switch (snakeDirection)
            {
                case SnakeDirection.Left:
                    newHead = new Point(head.Value.X, head.Value.Y - 1);
                    break;
                case SnakeDirection.Right:
                    newHead = new Point(head.Value.X, head.Value.Y + 1);
                    break;
                case SnakeDirection.Down:
                    newHead = new Point(head.Value.X + 1, head.Value.Y);
                    break;
                case SnakeDirection.Up:
                    newHead = new Point(head.Value.X - 1, head.Value.Y);
                    break;
            }

            foreach (Point p in snake)
            {
                if (p.X == newHead.X && p.Y == newHead.Y)
                {
                    // змейка съела сама себя! конец игры!
                    Invalidate();
                    GameOver();
                    return;
                }
            }

            snake.AddFirst(newHead);

        }

        private bool IsGameOver()
        {
            LinkedListNode<Point> head = snake.First;
            switch (snakeDirection)
            {
                case SnakeDirection.Left:
                    return head.Value.Y - 1 < 0;
                case SnakeDirection.Right:
                    return head.Value.Y + 1 >= COLS_NUMBER;
                case SnakeDirection.Down:
                    return head.Value.X + 1 >= ROWS_NUMBER;
                case SnakeDirection.Up:
                    return head.Value.X - 1 < 0;
            }
            return false;
        }

        private void TimerGameLoop_Tick(object sender, EventArgs e)
        {
            if (IsGameOver())
            {
                GameOver();
            }
            else
            {
                MoveSnake();
                Invalidate();
            }
        }

        private void ChangeSnakeDirection(SnakeDirection restrictedDirection, SnakeDirection newDirection)
        {
            if (snakeDirection != restrictedDirection)
            {
                snakeDirection = newDirection;
            }
        }





        private void AddPlayerPoints() //Начисляемые очки
        {
            if (food.X == 0 && food.Y == 0 || food.X == ROWS_NUMBER - 1 && food.Y == 0 || food.X == ROWS_NUMBER - 1 && food.Y == COLS_NUMBER - 1 || food.X == 0 && food.Y == COLS_NUMBER - 1)
            {
                points += 1000;
            }
            else if (food.X == 0 || food.X == ROWS_NUMBER - 1 || food.Y == 0 || food.Y == COLS_NUMBER - 1)
            {
                points += 500;
            }
            else
            {
                points += 250;
            }
        }

        private void TimerFoodBlink_Tick(object sender, EventArgs e)
        {
            if (foodAlpha + 25 > 255)
            {
                foodAlphaInc = -25;
            }
            else if (foodAlpha - 25 < 0)
            {
                foodAlphaInc = 25;
            }
            foodAlpha += foodAlphaInc;
            Invalidate();
        }



        private void FrmSnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (ENABLE_KEYDOWN_DELAY)
            {
                if (!keyPressSensivityStopwatch.IsRunning)
                {
                    keyPressSensivityStopwatch.Start();
                }
                else
                {
                    if (keyPressSensivityStopwatch.ElapsedMilliseconds < KEYDOWN_DELAY_MILLIS)
                    {
                        return;
                    }
                    else
                    {
                        keyPressSensivityStopwatch.Restart();
                    }
                }
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    ChangeSnakeDirection(SnakeDirection.Right, SnakeDirection.Left);
                    break;
                case Keys.Right:
                case Keys.D:
                    ChangeSnakeDirection(SnakeDirection.Left, SnakeDirection.Right);
                    break;
                case Keys.Down:
                case Keys.S:
                    ChangeSnakeDirection(SnakeDirection.Up, SnakeDirection.Down);
                    break;
                case Keys.Up:
                case Keys.W:
                    ChangeSnakeDirection(SnakeDirection.Down, SnakeDirection.Up);
                    break;                
            }
        }
    }
}
