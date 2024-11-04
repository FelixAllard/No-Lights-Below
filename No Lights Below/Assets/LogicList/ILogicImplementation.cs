using System.Collections.Generic;
using UniversalLogic.Results;

namespace LogicList
{
    public interface ILogicImplementation
    {
        List<Logic> Logics { get; set; }
        //Add Logic
        public OperationResult AddLogic(Logic logic);
        public OperationResult AddLogics(List<Logic> logic);
        //Remove Logic
        public OperationResult RemoveLogic(string logic);
        public OperationResult RemoveLogic(Logic logic);
        public OperationResult RemoveLogics(List<string> logics);
        public OperationResult RemoveLogics(List<Logic> logics);
        
        //Play Logic
        public OperationResult PlayAllLogic();
        
        
    }
}