using System;
using System.Collections.Generic;
using LogicList.BackLogic;
using LogicList.BackLogic.Exceptions;
using UniversalLogic.Results;

namespace LogicList
{
    public class LogicHandler : ILogicImplementation
    {
        public List<Logic> Logics { get; set; }
        //Add Logic
        public OperationResult AddLogic(Logic logic)
        {
            try
            {

            }
            catch (AlreadyExistingLogic e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            catch (AlreadyGeneratedUuid e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            return new OperationResult(true, "Successfully added logic.");
        }
        

        public OperationResult AddLogics(List<Logic> logic)
        {
            try
            {

            }
            catch (AlreadyExistingLogic e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            catch (AlreadyGeneratedUuid e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new OperationResult(false, e.Message);
            }
            return new OperationResult(true, "Successfully added logic.");
        }
        //Gyatt Rizz
        // Remove Logic Method
        

        public OperationResult RemoveLogic(string logic)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult RemoveLogic(Logic logic)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult RemoveLogics(List<string> logics)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult RemoveLogics(List<Logic> logics)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult PlayAllLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}