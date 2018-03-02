using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {

    public GameObject PaperPrefab;
    public GameObject ToiletPrefab;
    public GameObject PoopPrefab;

    public string levelFile = "pooplevel.txt";

    public float tileHeight = 2f;
    public float tileWidth = 2f;

	// Use this for initialization
	void Start () {
		
        string levelString = File.ReadAllText(Application.dataPath + Path.DirectorySeparatorChar + levelFile);

       
        string[] levelLines = levelString.Split('\n');
        int width = 0;
        
        for (int row = 0; row < levelLines.Length; row++)
        {
            string currentLine = levelLines[row];
            width = currentLine.Length;
            
            for (int col = 0; col < currentLine.Length; col++)
            {
                char currentChar = currentLine[col];
                if (currentChar == 'x')
                {
                  
                    GameObject wallObj = Instantiate(PaperPrefab);
                    wallObj.transform.parent = transform;
                    wallObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'p')
                {
               
                    GameObject playerObj = Instantiate(PoopPrefab);
                    playerObj.transform.parent = transform;
                    playerObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'e')
                {
                   
                        GameObject enemyObj = Instantiate(ToiletPrefab);
                        enemyObj.transform.parent = transform;
                        enemyObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                    }
                }
            }
        }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
