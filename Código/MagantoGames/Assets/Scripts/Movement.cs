using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector2 izquierda;
    public Vector2 derecha;
    public Vector2 arriba;
    public Vector2 abajo;
    // Use this for initialization

    public int cont = 0;
    


	void Start () {
        izquierda = new Vector2(-0.3f, 0.15f);
        derecha = new Vector2(0.3f, -0.15f);
        arriba = new Vector2(0.3f, 0.15f);
        abajo = new Vector2(-0.3f, -0.15f);
	}

    private void Update()
    {
        /*cont++;
        if(cont >= 60)
        {
            cont = 0;
            this.transform.position = new Vector2(this.transform.position.x + abajo.x, this.transform.position.y + abajo.y);
        }*/
    }


}
