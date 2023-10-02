using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_List : MonoBehaviour
{
    private MyList<string> stringMyList;
    [SerializeField] private int testCount;
    [SerializeField] private string word;
    [SerializeField] private int index;

    void Start()
    {
        stringMyList = new MyList<string>(7);
        CheckListCapacity(stringMyList);
        AddItems(stringMyList, testCount);
        DisplayItems(stringMyList);
        CheckListCapacity(stringMyList);
        IndexSearch(stringMyList, word);
        RemoveElement(stringMyList, word);
        RemoveElementAtIndex(stringMyList, index);
        InsertIntoTheList(stringMyList, index, word);
        ClearList(stringMyList);
        CheckItem(stringMyList, word);
    }

    void Update()
    {

    }

    private void CheckListCapacity(MyList<string> list)
    {
        Debug.Log($"The capacity of the {nameof(list)} is equal to {list.Capacity}");
    }

    private void AddItems(MyList<string> list, int count)
    {
        for (int i = 0; i < count; i++)
        {
            list.Add($"{i}");
        }
    }

    private void DisplayItems(MyList<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"The name of the element with index {i} is {list[i]}");
        }
    }

    private void IndexSearch(MyList<string> list, string word)
    {
        Debug.Log($"The index of the element with name {word} is {list.IndexOf(word)}");
    }

    private void RemoveElement(MyList<string> list, string word)
    {
        Debug.Log(list.Remove(word));
        DisplayItems(list);
    }

    private void RemoveElementAtIndex(MyList<string> list, int index)
    {
        list.RemoveAt(index);
        DisplayItems(list);
    }

    private void InsertIntoTheList(MyList<string> list, int index, string word)
    {
        list.Insert(index, word);
        DisplayItems(list);
    }

    private void ClearList(MyList<string> list)
    {
        list.Clear();
        DisplayItems(list);
    }

    private void CheckItem(MyList<string> list, string word)
    {
        Debug.Log(list.Contains(word));
    }
}