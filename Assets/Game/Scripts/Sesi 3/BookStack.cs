using System.Collections.Generic;
using UnityEngine;

public class BookStack : MonoBehaviour
{
    [SerializeField]
    private string text;
    [SerializeField]
    private List<string> _bookTitles;
    private Stack<string> _bookStack = new Stack<string>();

    private void Start()
    {
        foreach (string title in _bookTitles)
        {
            _bookStack.Push(title);
        }
    }

    private void Update()
    {
        bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
        if (isSpaceDetected)
        {
            string book = _bookStack.Pop();
            Debug.Log(book);
        }
    }
}
