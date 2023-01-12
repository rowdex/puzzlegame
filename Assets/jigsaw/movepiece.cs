using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movepiece : MonoBehaviour
{
    public string obje = "";
    public string pieceStatus = "idle";
    public Transform edgeParticles;
    public KeyCode placePiece;
    public KeyCode returntoinv;
    public string checkPlacement = "";
    public float yDiff;
    public Vector2 invPos;
    public static int puan;
    public static float zamanBonusu = 150;
    public Sprite stage2Image;
    public Sprite stage3Image;
    public Sprite stage4Image;
    public Sprite stage5Image;
    public Sprite stage6Image;
    public Sprite stage7Image;
    public Sprite stage8Image;
    public Sprite stage9Image;
    public Sprite stage10Image;
    public Sprite stage11Image;
    public Sprite stage12Image;
    public Sprite stage13Image;
    public Sprite stage14Image;
    public Sprite stage15Image;
    public Sprite stage16Image;
    public Sprite stage17Image;
    public Sprite stage18Image;
    public Sprite stage19Image;
    public Sprite stage20Image;



    // Start is called before the first frame update

    void Start()
    {

        if (levelselect.lvlsec == 2)
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        if (levelselect.lvlsec == 3)
            GetComponent<SpriteRenderer>().sprite = stage3Image;
        if (levelselect.lvlsec == 4)
            GetComponent<SpriteRenderer>().sprite = stage4Image;
        if (levelselect.lvlsec == 5)
            GetComponent<SpriteRenderer>().sprite = stage5Image;
        if (levelselect.lvlsec == 6)
            GetComponent<SpriteRenderer>().sprite = stage6Image;
        if (levelselect.lvlsec == 7)
            GetComponent<SpriteRenderer>().sprite = stage7Image;
        if (levelselect.lvlsec == 8)
            GetComponent<SpriteRenderer>().sprite = stage8Image;
        if (levelselect.lvlsec == 9)
            GetComponent<SpriteRenderer>().sprite = stage9Image;
        if (levelselect.lvlsec == 10)
            GetComponent<SpriteRenderer>().sprite = stage10Image;
        if (levelselect.lvlsec == 11)
            GetComponent<SpriteRenderer>().sprite = stage11Image;
        if (levelselect.lvlsec == 12)
            GetComponent<SpriteRenderer>().sprite = stage12Image;
        if (levelselect.lvlsec == 13)
            GetComponent<SpriteRenderer>().sprite = stage13Image;
        if (levelselect.lvlsec == 14)
            GetComponent<SpriteRenderer>().sprite = stage14Image;
        if (levelselect.lvlsec == 15)
            GetComponent<SpriteRenderer>().sprite = stage15Image;
        if (levelselect.lvlsec == 16)
            GetComponent<SpriteRenderer>().sprite = stage16Image;
        if (levelselect.lvlsec == 17)
            GetComponent<SpriteRenderer>().sprite = stage17Image;
        if (levelselect.lvlsec == 18)
            GetComponent<SpriteRenderer>().sprite = stage18Image;
        if (levelselect.lvlsec == 19)
            GetComponent<SpriteRenderer>().sprite = stage19Image;
        if (levelselect.lvlsec == 20)
            GetComponent<SpriteRenderer>().sprite = stage20Image;

    }

    // Update is called once per frame
    void Update()
    {

        invControl();

        if (pieceStatus == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        if ((Input.GetKeyDown(placePiece)) && (pieceStatus == "pickedup"))
        {
            checkPlacement = "y";
        }
    }


    void OnTriggerStay2D(Collider2D other)
    {

        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y"))
        {
          
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;

            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
            checkPlacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            puan += 5;
            parcayonetim.kalanparca -= 1;
        }

        if ((other.gameObject.name != gameObject.name) && (checkPlacement == "y"))
        {
            obje = "hata";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .6f);
            parcayonetim.hataparca+=1;
            checkPlacement = "n";
            puan -= 2;

        }
    }

    void OnMouseDown()
    {
        pieceStatus = "pickedup";
        checkPlacement = "n";
        GetComponent<Renderer>().sortingOrder = 10;
        invPos = transform.position;
        if(obje=="hata")
            transform.position = new Vector2(-6.71f, invPos.y + yDiff);
    }

    void invControl()
    {
        if ((Input.GetAxis("Mouse ScrollWheel") > 0)&&(pieceStatus!="locked"))
        {
            transform.position = new Vector2(-6.71f, transform.position.y - 2.36f);
            yDiff -= 2.36f;
        }
        if ((Input.GetAxis("Mouse ScrollWheel") < 0)&& (pieceStatus != "locked"))
        {
            transform.position = new Vector2(-6.71f, transform.position.y + 2.36f);
            yDiff -= 2.36f;
        }
        if ((Input.GetKeyDown(returntoinv)) && (pieceStatus == "pickedup"))
        {
            transform.position = new Vector2(-6.71f, invPos.y + yDiff);
            pieceStatus = "";
        }
    }
}
