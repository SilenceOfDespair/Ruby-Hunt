using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public GameObject[] coldSection;
    public GameObject[] fireSection;
    public int zPos = 32;
    public int yRot = 90;
    public bool creatingSection = false;
    public int secNum;
    public int biomeNum;
    public static int levelCheck = 0;

    void BiomeNumberGenerator()
    {
        if (levelCheck == 0)
        {
            biomeNum = Random.Range(0, 1);
        }
    }

    void Update()
    {
        BiomeNumberGenerator();
        if (levelCheck >= 20)
        {
            levelCheck = 0;
        }
        if (creatingSection == false && ObstacleCollision.levelGen == true && levelCheck <= 10)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        if (creatingSection == false && ObstacleCollision.levelGen == true && levelCheck > 10 && biomeNum == 0)
        {
            creatingSection = true;
            StartCoroutine(GenerateColdSection());
        }
        if (creatingSection == false && ObstacleCollision.levelGen == true && levelCheck > 10 && biomeNum == 1)
        {
            creatingSection = true;
            StartCoroutine(GenerateFireSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.Euler(0, yRot, 0));
        zPos += 32;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
    IEnumerator GenerateColdSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(coldSection[secNum], new Vector3(0, 0, zPos), Quaternion.Euler(0, yRot, 0));
        zPos += 32;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
    IEnumerator GenerateFireSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(fireSection[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 32;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
