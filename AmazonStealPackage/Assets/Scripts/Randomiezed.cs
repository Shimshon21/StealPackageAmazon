using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class myTuple : IComparable<myTuple>
{

    public int index;
    public int second;
    public char located;

    public myTuple(int new_index, int new_second, char new_located) // ctor
    {
        index = new_index;//index for the home
        second = new_second;//in what second will be played
        located = new_located;//depends on the seconds
    }
    
    public int CompareTo(myTuple t)
    {
        return this.second.CompareTo(t.second);
    }
    
}
public class Randomiezed : MonoBehaviour
{
    [SerializeField] GameObject[] housesExisted;
    // Start is called before the first frame update
    int randNumber()
    {
        int rand = UnityEngine.Random.Range(0, 60);
        return rand;
    }
    void Start()
    {
        List<myTuple> houses = new List<myTuple> () { 
            new myTuple(0, 0, 'Z'),
            new myTuple(1, 0, 'Z'),
            new myTuple(2, 0, 'Z'),
            new myTuple(3, 0, 'Z'), 
            new myTuple(4, 0, 'Z'), 
            new myTuple(5, 0, 'Z'), 
            new myTuple(6, 0, 'Z'), 
            new myTuple(7, 0, 'Z'),
            new myTuple(8, 0, 'Z'), 
            new myTuple(9, 0, 'Z') };
        char idn = 'A';//for the sorted houses

        foreach (myTuple tup in houses)
        {
            tup.second = randNumber();//randomized seconds into the houses
        }
        houses.Sort();

        foreach (myTuple tup in houses)
        {
            tup.located = idn;
            idn++;//"A"++ -> "B"
        }

        foreach (myTuple tup in houses)
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }


}

