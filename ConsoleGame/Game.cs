using System;
using System.Collections.Generic;
using System.Text;

namespace code_cademy
{
    class Game
    {

        // move cursor 
        public static void UpdatePosition(string keyPressed, out int xCoordinate, out int yCoordinate)
        {
            yCoordinate = 0;
            xCoordinate = 0;
            switch (keyPressed)
            {
                case "DownArrow":
                    yCoordinate++;
                    break;
                case "UpArrow":
                    yCoordinate--;
                    break;
                case "LeftArrow":
                    xCoordinate--;
                    break;
                case "RightArrow":
                    xCoordinate++;
                    break;
                default:
                    break;
            }
        }

        // change cursor method. for example, if you move left cursor is "<". 
        // ">" for right and etc
        // this method returns char

        /*public static char UpdateCursor(string keyPressed)
        {
            char cursor = ' ';
            switch(keyPressed)
            {
                case "DownArrow":
                    cursor = 'V';
                    break;
                case "UpArrow":
                    cursor = '^';
                    break;
                case "LeftArrow":
                    cursor = '<';
                    break;
                case "RightArrow":
                    cursor = '>';
                    break;
                default:
                    break;
            }
            return cursor;
        }*/

        // change cursor method. for example, if you move left cursor is "<". 
        // ">" for right and etc
        //thid method returns string

        public static string UpdateCursor(string keyPressed)
        {
            string cursor = " ";
            switch (keyPressed)
            {
                case "DownArrow":
                    cursor = "V";
                    break;
                case "UpArrow":
                    cursor = "^";
                    break;
                case "LeftArrow":
                    cursor = "<:";
                    break;
                case "RightArrow":
                    cursor = ":>";
                    break;
                default:
                    break;
            }
            return cursor;
        }

        // set borders for console window

        public static int KeepInBounds(int xyCoordinate, int maxCoordinate)
        {
            /*if (xyCoordinate == 1) xyCoordinate++;
            if (xyCoordinate == maxCoordinate) xyCoordinate--;
            return xyCoordinate;*/

            if (xyCoordinate == 1) xyCoordinate = maxCoordinate - 2;
            if (xyCoordinate == maxCoordinate) xyCoordinate = 2;
            return xyCoordinate;
        }

        // if cursor reached "@fruit" return true
        public static bool DidScore(int cursorXCoordinates, int cursorYCoordinates, int fruitXCoordinates, int fruitYCoordinates)
        {
            bool scored = (cursorXCoordinates == fruitXCoordinates && cursorYCoordinates == fruitYCoordinates) ? true : false;
            return scored;
        }
    }
}
