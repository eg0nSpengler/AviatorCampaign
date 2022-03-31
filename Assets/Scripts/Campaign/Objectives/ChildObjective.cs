using Assets.Scripts.Enumerations;
using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Campaign.Objectives
{
    public class ChildObjective : MonoBehaviour, IObjectiveChild, IDestructible
    {
        public uint Health { get => this._health; set => this._health = value; }
        public string ObjectiveName { get => this._objectiveName; set => this._objectiveName = value; }
        public EObjectiveValue ObjectiveValue { get => this._objectiveValue; set => this._objectiveValue = value; }

        [Header("Objective Fields")]
        [SerializeField]
        private string _objectiveName;
        [SerializeField]
        private uint _health;
        [SerializeField]
        private EObjectiveValue _objectiveValue;
    }
}
