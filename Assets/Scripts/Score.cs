using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    private static int count = 0;
    
    public static int Get () { return count; }

    public static int Set (int value){
        return count = count + value;
    }
}
