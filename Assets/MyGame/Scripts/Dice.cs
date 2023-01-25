using System.Collections;
using UnityEngine;

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

    public GameObject Boot;


    private Sprite[] diceSides;

    
    private SpriteRenderer rend;

    
    private void Start()
    {
        blueFishPosition = blueFish.transform.position;
        pinkFishPosition = pinkFish.transform.position;
        orangeFishPosition = orangeFish.transform.position;
        yellowFishPosition = yellowFish.transform.position;



        rend = GetComponent<SpriteRenderer>();

        diceSides = Resources.LoadAll<Sprite>("DiceSides/");


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
        
    }


    public void MoveFish()
    {

        switch (diceResult)
        {
            case 1:
                blueFishPosition = new Vector3(blueFish.transform.position.x + 1, blueFish.transform.position.y, 0);
                blueFish.transform.position = blueFishPosition;
                break;
            case 2:
                
                break;
            case 3:
                orangeFishPosition = new Vector3(orangeFish.transform.position.x + 1, orangeFish.transform.position.y, 0);
                orangeFish.transform.position = orangeFishPosition;
                break;
            case 4:
                pinkFishPosition = new Vector3(pinkFish.transform.position.x + 1, pinkFish.transform.position.y, 0);
                pinkFish.transform.position = pinkFishPosition;
                break;
            case 5:
                
                break;
            case 6:
                yellowFishPosition = new Vector3(yellowFish.transform.position.x + 1, yellowFish.transform.position.y, 0);
                yellowFish.transform.position = yellowFishPosition;
                break;
        }
      
    }
}
