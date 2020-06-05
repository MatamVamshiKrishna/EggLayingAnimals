using UnityEngine;

// This script opens a popup and display the content
// When click/tap on the game object
public class Popup : MonoBehaviour
{
    private string Tag = "Selectable";
    private Transform selected;

    private void Update()
    {
        if (selected != null)
        {
            selected.GetChild(0).transform.gameObject.SetActive(false);
            selected = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            
            var _selected = hit.transform;
            if(_selected.CompareTag(Tag))
            {
                _selected.GetChild(0).transform.gameObject.SetActive(true);
                selected = _selected;
                
            }
        }
    }
}
