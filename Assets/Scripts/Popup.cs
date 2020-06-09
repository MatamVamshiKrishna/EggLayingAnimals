using UnityEngine;

// This script opens a popup and display the content
// When click/tap on the game object
public class Popup : MonoBehaviour
{
    private string Tag = "Selectable";
    private Transform selected;

    private void Update()
    {
#if UNITY_EDITOR
        if (selected != null)
        {
            selected.GetChild(0).transform.gameObject.SetActive(false);
            selected = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            var _selected = hit.transform;
            if (_selected.CompareTag(Tag))
            {
                _selected.GetChild(0).transform.gameObject.SetActive(true);
                selected = _selected;

            }
        }

#elif UNITY_ANDROID
        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {

            if (selected != null)
            {
                selected.GetChild(0).transform.gameObject.SetActive(false);
                selected = null;
            }

            var ray1 = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit1;
            if (Physics.Raycast(ray1, out hit1))
            {

                var _selected = hit1.transform;
                if (_selected.CompareTag(Tag))
                {
                    _selected.GetChild(0).transform.gameObject.SetActive(true);
                    selected = _selected;

                }
            }
        }
#endif
    }
}

