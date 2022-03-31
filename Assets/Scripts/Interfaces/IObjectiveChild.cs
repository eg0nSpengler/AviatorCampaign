using Assets.Scripts.Enumerations;

namespace Assets.Scripts.Interfaces
{
    public interface IObjectiveChild
    {
        public string ObjectiveName { get; set; }   
        public EObjectiveValue ObjectiveValue { get; set; }
    }
}
