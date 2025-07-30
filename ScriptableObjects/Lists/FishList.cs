using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Lists
{
    public class FishList : MonoBehaviour
    {
        public List<Fishes> fishSO = new List<Fishes>();
        
        public Fishes FishSelect(int fishID)
        {
            return fishSO[fishID];
        }
        
    }
}