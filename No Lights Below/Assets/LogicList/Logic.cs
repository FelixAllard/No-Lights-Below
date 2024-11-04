using System;

namespace LogicList
{
    public abstract class Logic 
    { 
        protected Logic(LogicHandler logicHandler)
        {
            this.LogicHandler = logicHandler;
            _uuid = Guid.NewGuid().ToString();
        }

        public LogicHandler LogicHandler;
        public abstract string Name { get; }
        private string _uuid;
        public abstract string Description { get; }
        public abstract void PreLogic();
        public abstract void LogicToRun();
        public abstract void PostLogic();
        
        public void RemoveLogicFromHandler()
        {
            LogicHandler.RemoveLogic(this);
        }

        public string GetUniqueUuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}