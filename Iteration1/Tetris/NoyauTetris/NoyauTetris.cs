using InterfaceTetris;
namespace NoyauTetris;

public class JeuTetris
{
    public int LargeurGrille;
    public int HauteurGrille;

    public JeuTetris()
    {
        LargeurGrille = 12;
        HauteurGrille = 15;
    }

    public void DessinerCadre()
    {
        DessinerRectangle(10,0,180,390,Avalonia.Media.Brushes.White);
    }
    
}
