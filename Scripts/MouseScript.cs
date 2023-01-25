using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{

    public GameObject IceSword;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;
        mousePos.x = mousePos.x - IceSword.transform.position.x;
        mousePos.y = mousePos.y - IceSword.transform.position.y;


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(IceSword, mouseCursorPos, Quaternion.identity);
            IceSword.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 1f);
            float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
            IceSword.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
        if (Input.GetMouseButtonUp(0))
        {
            IceSword.transform.position = IceSword.transform.position;
        }

    }

}
