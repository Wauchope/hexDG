using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileGrid : MonoBehaviour
{
    [SerializeField]
    Transform mapObject;

    [SerializeField]
    GameObject[] gameObjects;

    void Start()
    {
        CreateMap(50, 30);
    }

    void Update()
    {
        
    }

    private HexTile CreateTile(int tileID, Point pos)
    {
        HexTile newTile = Instantiate(gameObjects[tileID], new Vector3(pos.GetX(), pos.GetY(), pos.GetZ()), Quaternion.identity).GetComponent<HexTile>();

        return newTile;
    }

    private HexTile[] CreateRow(int width, float y, bool offset)
    {
        HexTile[] row = new HexTile[width];


        for (int x = 0; x < width; x++)
        {
            //Define the variable tile
            HexTile tile;
            //Can't have decimals when using int - workaround
            float tempX = x;

            if (offset)
            {
                tile = CreateTile(0, new Point(1.5f * tempX, y, 0));
            }
            else
            {
                tile = CreateTile(0, new Point(1.5f * tempX + 0.75f, y, 0));
            }

            row[x] = tile;
        }

        return row;
    }

    private List<HexTile[]> CreateMap(int width, int height)
    {
        bool offset = false;
        List<HexTile[]> map = new List<HexTile[]>();
        for (float y = 0; y < height; y++)
        {
            CreateRow(width, y / 2, offset);

            offset = !offset;
        }

        return map;
    }
}
