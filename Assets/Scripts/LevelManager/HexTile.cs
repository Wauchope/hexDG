using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTile : MonoBehaviour
{
    [SerializeField]
    public Point gridPos { get; private set; }
    private SpriteRenderer renderer;

    void Start()
    {

    }

    void Update()
    {
        
    }
 
    private void SetupTile(float x, float y, float z)
    {
        SetPos(x, y, z);
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void SetPos(float x, float y, float z)
    {
        gridPos = new Point(x, y, z);
    }

    public Point GetPos()
    {
        return gridPos;
    }
}
