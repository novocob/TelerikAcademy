using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;
        const int sleepTime = 200;  // sleep time added - Homework Task 02

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            /*for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }*/

            //Test  class GiftBlock and Gift - Homework Task 12  and  ExplodingBlock - HomeWork Task 10
            for (int i = startCol; i < endCol; i++)
            {
                if (i == 7)
                {
                    ExplodingBlock expBlock = new ExplodingBlock(new MatrixCoords(3, 7));
                    engine.AddObject(expBlock);
                    continue;
                }
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }
                
            

            //Ceiling wall - Homework Task 01
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock currentBlock = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(currentBlock);
            }

            //Side walls - Homework Task 01
            for (int i = 1; i <= WorldRows; i++)
            {
                IndestructibleBlock currentBlockLeft = new IndestructibleBlock(new MatrixCoords(i, 0));
                IndestructibleBlock currentBlockRight = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(currentBlockLeft);
                engine.AddObject(currentBlockRight);
            }

            /*Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));*/

            // test Meteorite Ball - Homework Task 07
            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            /*  //test TrailObject - Homework Task 05
            TrailObject testObject = new TrailObject(new MatrixCoords(10, 10), new char[,] { { '@' } }, 5);
            engine.AddObject(testObject);*/

            /* //test Gift
            Gift testGift = new Gift(new MatrixCoords(WorldRows / 5, WorldCols / 5));
            engine.AddObject(testGift);*/
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, sleepTime);  // sleep time added - Homework Task 02
       

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
