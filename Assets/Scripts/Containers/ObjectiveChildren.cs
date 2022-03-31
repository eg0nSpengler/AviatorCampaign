using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Containers
{
    [System.Serializable]
    public class ObjectiveChildren
    {
        [SerializeField]
        private ParentObjective[] _objectives;
    }
}
