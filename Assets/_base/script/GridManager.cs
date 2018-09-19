using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RegionType
{
    Unknown,
    Fire,
    Water,
    Earth,
    Air
}

public class TileInfo
{
    public int posX;
    public int posY;
    public RegionType element;
    public GameObject inhabitant;
}

public class GridManager : MonoBehaviour {

    public int sizeX = 20;
    public int sizeY = 20;

    public float tileSize = 1;

    private TileInfo[,] grid;

	// Use this for initialization
	void Awake () {
        grid = new TileInfo[sizeX, sizeY];
	}

    public bool RegisterGameObject(GameObject target, Vector2Int gridPos)
    {
        TileInfo currentGrid = grid[gridPos.x, gridPos.y];
        if (currentGrid.inhabitant != null)
            return false;

        currentGrid.inhabitant = target;
        return true;
    }

    public bool UnregisterGameObject(GameObject target, Vector2Int gridPos)
    {
        TileInfo currentGrid = grid[gridPos.x, gridPos.y];
        if (currentGrid.inhabitant != target)
            return false;

        currentGrid.inhabitant = null;
        return true;
    }
	
	
}
