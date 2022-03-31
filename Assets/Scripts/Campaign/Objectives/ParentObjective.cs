using Assets.Scripts.Campaign.Objectives;
using Assets.Scripts.Enumerations;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using UnityEngine;


public class ParentObjective : MonoBehaviour, IObjectiveParent
{
    public string ObjectiveName { get => this._objectiveName; set => this._objectiveName = value; }
    public EObjectiveType ObjectiveType { get => this._objectiveType; set => this._objectiveType = value; }
    public List<ChildObjective> ObjectiveChildren { get => this._objectiveChildren; set => this._objectiveChildren = value; }
    public EFaction OriginalOwner { get => this._originalOwner; set => this._originalOwner = value; }
    public EFaction CurrentOwner { get => this._currentOwner; set => this._currentOwner = value; }    
    public bool RequiresPower { get => this._requiresPower; set => this._requiresPower = value; }
    public bool IsPowered { get => this._isPowered; set => this._isPowered = value; }

    [Header("Objective Fields")]
    [SerializeField]
    private string _objectiveName;
    [Header("Objective Flags")]
    [SerializeField]
    [Tooltip("Does this objective depend on power? (Power plant)")]
    private bool _requiresPower;
    [SerializeField]
    [Tooltip("Is this objective powered by a power plant?")]
    private bool _isPowered;
    [Header("Objective Settings")]
    [SerializeField]
    private EObjectiveType _objectiveType;
    [SerializeField]
    private EFaction _originalOwner;
    [SerializeField]
    private EFaction _currentOwner;
    [SerializeField]
    private List<ChildObjective> _objectiveChildren;

    public void Awake()
    {
        if(!RequiresPower)
        {
            _isPowered = false;
        }
    }
}
