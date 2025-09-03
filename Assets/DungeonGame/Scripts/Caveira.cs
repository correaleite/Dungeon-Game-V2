using UnityEngine;

public class Caveira:Enemy
{
    protected override void Introduction()
    {
        base.Introduction();
        Debug.Log("Outra frase");
    }
}
