using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;

    [SerializeField] private Tile tilePrefab;

    private Camera myCam;

    private Dictionary<Vector2, Tile> tiles;

    [SerializeField] private Vector2 debugTryPos;
    private void Start()
    {
        myCam = Camera.main;
        tiles = new Dictionary<Vector2, Tile>();
        GenerateGrid();

        var tile = GetTileAtPosition(debugTryPos); /* ---> */ Debug.Log(tile.name);
    }
    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);

                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }
        SetCamera();
    }

    void SetCamera()
    {
        myCam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10f);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        //If tile is available
        if (tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }

        return null;
    }
}
