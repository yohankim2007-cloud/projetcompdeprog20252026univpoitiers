namespace NoyauTetris;

public enum TetrinoCouleur
{
    Bleu,
    Rose,
    Violet,
    Blanc,
    Noir
    
}
public class JeuTetris
{
    public int LargeurGrille;
    public int HauteurGrille;

    public JeuTetris()
    {
        LargeurGrille = 12;
        HauteurGrille = 15;
    }

};

public class Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

};

public class Tetrino
{
public static Position[][] TetrinosTab = new Position[][]
{
// carre
new Position[] { new Position(0, 0), new Position(1, 0),
new Position(0, -1), new Position(1, -1) },
// barre horizontale
new Position[] { new Position(0, 0), new Position(1, 0),
new Position(2, 0), new Position(3, 0) },
// barre verticale
new Position[] { new Position(0, 0), new Position(0, -1),
new Position(0, -2), new Position(0, -3) }
};
public int Indice;
public Position PositionOrigine = new Position(0, 0);
public static TetrinoCouleur[] TetrinosCouleurs = new TetrinoCouleur[]
{
    TetrinoCouleur.Bleu,
    TetrinoCouleur.Rose,
    TetrinoCouleur.Violet
};

public Tetrino(int indice, Position positionOrigine, int indiceCouleur)
    {
        Indice = indice;
        TetrinosTab[indice] = TetrinosTab[indice];
        PositionOrigine = positionOrigine;
        TetrinosCouleurs[indiceCouleur] = TetrinosCouleurs[indiceCouleur];
    }

public Position[] Positions()
    {
        return TetrinosTab[Indice];
    }

};