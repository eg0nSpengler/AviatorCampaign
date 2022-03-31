using Assets.Scripts.Campaign.Objectives;
using Assets.Scripts.Enumerations;
using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    public interface IObjectiveParent
    {
        public bool RequiresPower { get;set; }
        public bool IsPowered { get; set; }
        public string ObjectiveName { get; set; }
        public EObjectiveType ObjectiveType { get; set; }
        public EFaction OriginalOwner { get; set; }
        public EFaction CurrentOwner { get; set; }
        public List<ChildObjective> ObjectiveChildren { get; set; }
    }
}
