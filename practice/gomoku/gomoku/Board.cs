using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gomoku
{
    class Board
    {
        private static readonly int NODE_COUNT = 9;
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTRAMCE = 75;

        private Piece[,] pieces = new Piece[NODE_COUNT, NODE_COUNT];

        public bool CanBePlaced(int x, int y)
        {
            //TODO:找出最近的節點
            Point nodeId = findTheClosetNode(x, y);

            //TODO:如果沒有的話，回傳false

            if (nodeId == NO_MATCH_NODE)
                return false;

            //TODO:如果有的話，檢查是否已經存在旗子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;

            return true;
        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            //TODO:找出最近的節點
            Point nodeId = findTheClosetNode(x, y);

            //TODO:如果沒有的話，回傳false

            if (nodeId == NO_MATCH_NODE)
                return null;

            //TODO:如果有的話，檢查是否已經存在旗子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;

            //根據type產生對應的棋子
            Point formPos = converToFormPosition(nodeId);
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X, formPos.Y);
            else if(type == PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);

            return pieces[nodeId.X, nodeId.Y];

        }
        private Point converToFormPosition(Point nodeId)
        {
            Point formPoisition = new Point();
            formPoisition.X = nodeId.X * NODE_DISTRAMCE + OFFSET;
            formPoisition.Y = nodeId.Y * NODE_DISTRAMCE + OFFSET;
            return formPoisition;
        }
        private Point findTheClosetNode(int x, int y)
        {
            int nodeXId = findTheClosetNode(x);
            if (nodeXId == -1 || nodeXId >= NODE_COUNT)
                return NO_MATCH_NODE;

            int nodeYId = findTheClosetNode(y);
            if (nodeYId == -1 || nodeYId >= NODE_COUNT)
                return NO_MATCH_NODE;

            return new Point(nodeXId, nodeYId);
        }
        private int findTheClosetNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;

            pos -= OFFSET;

            int quotient = pos / NODE_DISTRAMCE;
            int remainder = pos % NODE_DISTRAMCE;

            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_DISTRAMCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}
