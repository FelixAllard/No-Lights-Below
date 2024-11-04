using System;

namespace LogicList
{
    public abstract class Logic 
    { 
        protected Logic(LogicHandler logicHandler)
        {
            this._logicHandler = logicHandler;
            _uuid = Guid.NewGuid().ToString();
        }

        private readonly LogicHandler _logicHandler;
        public abstract string Name { get; }
        private string _uuid;
        public abstract string Description { get; }
        public abstract void PreLogic();
        public abstract void LogicToRun();
        public abstract void PostLogic();
        
        public void RemoveLogicFromHandler()
        {
            _logicHandler.RemoveLogic(this);
        }

        public string GetUniqueUuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}