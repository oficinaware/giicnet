using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GiicNetBus.Base 
{
    public enum ResultType
    {
        Undefined = 0,
        OK = 1,
        Error = -1,
        Warning = 2,
        Information = 3,
        Validation = 4
     }
    public class ResultList
    {
        public Boolean Status { get; set; }
        public IList Lista { get; set; }
        public String Erros { get; set; }
        
    }

    public class OperationResult<T>
    {
        public ResultType Info { get; set; }
        public T Result { get; set; }
        public Dictionary<ResultType, List<string>> Messages { get; set; }



        public OperationResult()
        {
            Messages = new Dictionary<ResultType, List<string>>();
            Messages.Add(ResultType.Error,new List<string>());
            Messages.Add(ResultType.Warning, new List<string>());
            Messages.Add(ResultType.Information, new List<string>());
           
        }
    }

}
