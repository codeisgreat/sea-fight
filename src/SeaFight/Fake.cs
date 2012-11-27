using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeaFight
{
    public static class Fake
    {
    public static Cell[][] GetModel()
    {
        Cell[][] fakeModel = new Cell[10][];
        for (int i = 0; i < fakeModel.Length; i++)
        {
            fakeModel[i] = new Cell[10];
        }
        fakeModel[0][0] = Cell.Life;
        fakeModel[0][1] = Cell.Life;
        fakeModel[0][1] = Cell.Life;
        fakeModel[0][2] = Cell.Life;
        fakeModel[0][3] = Cell.Life;

        fakeModel[2][0] = Cell.Life;
        fakeModel[2][1] = Cell.Life;
        fakeModel[2][2] = Cell.Life;

        fakeModel[4][0] = Cell.Life;
        fakeModel[4][1] = Cell.Life;
        fakeModel[4][2] = Cell.Life;

        fakeModel[6][0] = Cell.Life;
        fakeModel[6][1] = Cell.Life;

        fakeModel[8][0] = Cell.Life;
        fakeModel[8][1] = Cell.Life;

        fakeModel[6][3] = Cell.Life;
        fakeModel[6][4] = Cell.Life;

        fakeModel[8][3] = Cell.Life;

        fakeModel[8][5] = Cell.Life;

        fakeModel[8][7] = Cell.Life;
        
        fakeModel[8][9] = Cell.Life;

        return fakeModel;
    }
    }
}
