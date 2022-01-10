using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// The code of a grid in the grid
/// </summary>
public class GridSquare : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
    public const int BLANK = 0, COLORED = 1, EXCLUDED = 2, QUESTIONABLE = 3;
    public int state = BLANK;

    public int x, y;
    public Vector2Int pos;

    public Image image;
    public Text text;

    void Awake()
    {
        image = GetComponent<Image>();
        text = GetComponentInChildren<Text>();

        if(image == null || text == null)
        {
            Debug.LogError("Square component lost!");
        }
    }

    public void SetState(int s)
    {
        this.state = s;
        switch (s)
        {
            case BLANK:
                image.color = Color.white;
                text.text = "";
                break;
            case COLORED:
                image.color = Color.black;
                text.text = "";
                break;
            case EXCLUDED:
                Debug.Log("Excluded");
                image.color = Color.white;
                text.text = "X";
                break;
            case QUESTIONABLE:
                image.color = Color.white;
                text.text = "?";
                break;
            default:
                break;
        }
    }

    public void SetPosition(int x,int y)
    {
        this.x = x;
        this.y = y;
        this.pos = new Vector2Int(x, y);
    }

    public void SetPosition(Vector2Int p)
    {
        SetPosition(p.x, p.y);
    }

    public void SetSize(int size)
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(size*0.9f, size*0.9f);
        text.fontSize = size /2;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Grid.currentSquare = this;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Grid.currentSquare = null;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }
}
