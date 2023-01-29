using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{

    public float diceResult;

    public GameObject blueFish;
    public Vector3 blueFishPosition;

    public GameObject pinkFish;
    public Vector3 pinkFishPosition;

    public GameObject orangeFish;
    public Vector3 orangeFishPosition;

    public GameObject yellowFish;
    public Vector3 yellowFishPosition;

    public GameObject boot;
    public Vector3 bootPosition;


    private Sprite[] diceSides;

    
    private SpriteRenderer rend;

    public GameObject dice;

    public Text FishWin;
    public Text FischerWin;
    public Text Unentschieden;

    
    private void Start()
    {
        blueFishPosition = blueFish.transform.position;
        pinkFishPosition = pinkFish.transform.position;
        orangeFishPosition = orangeFish.transform.position;
        yellowFishPosition = yellowFish.transform.position;
        bootPosition = boot.transform.position;



        rend = GetComponent<SpriteRenderer>();

        diceSides = Resources.LoadAll<Sprite>("DiceSides/");

        FishWin.enabled = false;
        FischerWin.enabled = false;
        Unentschieden.enabled = false;
    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        int finalSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);

            rend.sprite = diceSides[randomDiceSide];

            yield return new WaitForSeconds(0.1f);
        }

        finalSide = randomDiceSide + 1;

        Debug.Log(finalSide);

        diceResult = finalSide;

        MoveFish();
    }

    private void Update()
    {
        if (blueFish.transform.position.x >= 6 && orangeFish.transform.position.x >= 6 && pinkFish.transform.position.x >= 6 && yellowFish.transform.position.x >= 6)
        {
            Debug.Log("Die Fische Gewinnen");
            FishWin.enabled = true;
            dice.SetActive(false);

        }

        if (boot.transform.position.x == 5)
        {
            dice.SetActive(false);
            Unentschieden.enabled = true;
            Debug.Log("Boot hat Meer erreicht");
        }

        if ((blueFish.active == false) && (orangeFish.active == false) && (pinkFish.active == false) && (yellowFish.active == false))
        {
            Debug.Log("Die Fischer haben gewonnen");
            FischerWin.enabled = true;
        }

        if (boot.transform.position.x == blueFish.transform.position.x)
        {
            blueFish.SetActive(false);
        }

        if (boot.transform.position.x == orangeFish.transform.position.x)
        {
            orangeFish.SetActive(false);
        }

        if (boot.transform.position.x == pinkFish.transform.position.x)
        {
            pinkFish.SetActive(false);
        }

        if (boot.transform.position.x == yellowFish.transform.position.x)
        {
            yellowFish.SetActive(false);
        }
    }


    public void MoveFish()
    {

        switch (diceResult)
        {
            case 1:
                if (blueFish.active == true && blueFish.transform.position.x < 6)
                {
                    blueFishPosition = new Vector3(blueFish.transform.position.x + 1, blueFish.transform.position.y, 0);
                    blueFish.transform.position = blueFishPosition;
                }
                else if (blueFish.active == false)
                {
                    bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                    boot.transform.position = bootPosition;
                }


                else if (blueFish.transform.position.x >= 6 && orangeFish.active == true)
                {
                    orangeFishPosition = new Vector3(orangeFish.transform.position.x + 1, orangeFish.transform.position.y, 0);
                    orangeFish.transform.position = orangeFishPosition;
                }
                else if (blueFish.transform.position.x >= 6 && pinkFish.active == true)
                {
                    pinkFishPosition = new Vector3(pinkFish.transform.position.x + 1, pinkFish.transform.position.y, 0);
                    pinkFish.transform.position = pinkFishPosition;
                }
                else if (blueFish.transform.position.x >= 6 && yellowFish.active == true)
                {
                    yellowFishPosition = new Vector3(yellowFish.transform.position.x + 1, yellowFish.transform.position.y, 0);
                    yellowFish.transform.position = yellowFishPosition;
                }
                break;


            case 2:
                bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                boot.transform.position = bootPosition;
                break;


            case 3:
                if (orangeFish.active == true && orangeFish.transform.position.x < 6)
                {
                    orangeFishPosition = new Vector3(orangeFish.transform.position.x + 1, orangeFish.transform.position.y, 0);
                    orangeFish.transform.position = orangeFishPosition;
                }
                else if (orangeFish.active == false)
                {
                    bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                    boot.transform.position = bootPosition;
                }


                else if (orangeFish.transform.position.x >= 6 && blueFish.active == true)
                {
                    blueFishPosition = new Vector3(blueFish.transform.position.x + 1, blueFish.transform.position.y, 0);
                    blueFish.transform.position = blueFishPosition;
                }
                else if (orangeFish.transform.position.x >= 6 && pinkFish.active == true)
                {
                    pinkFishPosition = new Vector3(pinkFish.transform.position.x + 1, pinkFish.transform.position.y, 0);
                    pinkFish.transform.position = pinkFishPosition;
                }
                else if (orangeFish.transform.position.x >= 6 && yellowFish.active == true)
                {
                    yellowFishPosition = new Vector3(yellowFish.transform.position.x + 1, yellowFish.transform.position.y, 0);
                    yellowFish.transform.position = yellowFishPosition;
                }
                break;


            case 4:
                if (pinkFish.active == true && pinkFish.transform.position.x < 6)
                {
                    pinkFishPosition = new Vector3(pinkFish.transform.position.x + 1, pinkFish.transform.position.y, 0);
                    pinkFish.transform.position = pinkFishPosition;
                }
                else if (pinkFish.active == false)
                {
                    bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                    boot.transform.position = bootPosition;
                }


                else if (pinkFish.transform.position.x >= 6 && blueFish.active == true)
                {
                    blueFishPosition = new Vector3(blueFish.transform.position.x + 1, blueFish.transform.position.y, 0);
                    blueFish.transform.position = blueFishPosition;
                }
                else if (pinkFish.transform.position.x >= 6 && orangeFish.active == true)
                {
                    orangeFishPosition = new Vector3(orangeFish.transform.position.x + 1, orangeFish.transform.position.y, 0);
                    orangeFish.transform.position = orangeFishPosition;
                }
                else if (pinkFish.transform.position.x >= 6 && yellowFish.active == true)
                {
                    yellowFishPosition = new Vector3(yellowFish.transform.position.x + 1, yellowFish.transform.position.y, 0);
                    yellowFish.transform.position = yellowFishPosition;
                }
                break;


            case 5:
                bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                boot.transform.position = bootPosition;
                break;


            case 6:
                if (yellowFish.active == true && yellowFish.transform.position.x < 6)
                {
                    yellowFishPosition = new Vector3(yellowFish.transform.position.x + 1, yellowFish.transform.position.y, 0);
                    yellowFish.transform.position = yellowFishPosition;
                }
                else if (yellowFish.active == false)
                {
                    bootPosition = new Vector3(boot.transform.position.x + 1, boot.transform.position.y, 0);
                    boot.transform.position = bootPosition;
                }


                else if (yellowFish.transform.position.x >= 6 && blueFish.active == true)
                {
                    blueFishPosition = new Vector3(blueFish.transform.position.x + 1, blueFish.transform.position.y, 0);
                    blueFish.transform.position = blueFishPosition;
                }
                else if (yellowFish.transform.position.x >= 6 && orangeFish.active == true)
                {
                    orangeFishPosition = new Vector3(orangeFish.transform.position.x + 1, orangeFish.transform.position.y, 0);
                    orangeFish.transform.position = orangeFishPosition;
                }
                else if (yellowFish.transform.position.x >= 6 && pinkFish.active == true)
                {
                    pinkFishPosition = new Vector3(pinkFish.transform.position.x + 1, pinkFish.transform.position.y, 0);
                    pinkFish.transform.position = pinkFishPosition;
                }
                break;
        }
      
    }
}
