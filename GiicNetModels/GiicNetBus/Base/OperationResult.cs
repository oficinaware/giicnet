using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace GiicNetBus.Base
{

    public enum ResultType
    {
        // it has errors
        Error = -1,

        //not initialized/verified
        Undefined = 0,

        // all goes well
        OK = 1,

        // it has some warning but passed over
        Warning = 2,

        // information on result, perhaps user feedback(???)
        Information = 3,

        //Information for validaton of model data
        Validation = 4
    }
    public class ResultList
    {
        public Boolean Status { get; set; }
        public IList Lista { get; set; }
        public String Erros { get; set; }

    }
    public class ResultList_BL
    {
        public Boolean Status { get; set; }
        public IBindingList Lista { get; set; }
        public String Erros { get; set; }

    }
    public class OperationResult<T>
    {
        public ResultType Type { get; set; }
        public T Value { get; set; }

        public Dictionary<ResultType, List<string>> Messages { get; set; }
        public Dictionary<string, List<string>> Validations { get; set; }

        public OperationResult()
        {
            Messages = new Dictionary<ResultType, List<string>>();
            Validations = new Dictionary<string, List<string>>();
            Messages.Add(ResultType.Error, new List<string>());
            Messages.Add(ResultType.Warning, new List<string>());
            Messages.Add(ResultType.Information, new List<string>());
        }

        public void AddResult(T result)
        {
            this.Value = result;
        }

        public void AddMessage(ResultType type, string message)
        {
            var currentMessages = new List<string>();
            this.Messages.TryGetValue(type, out currentMessages);

            currentMessages.Add(message);
            this.Messages[type] = currentMessages;
        }

        public void AddValidation(string property, string message)
        {
            var currentValidations = new List<string>();
            Validations.TryGetValue(property, out currentValidations);

            currentValidations.Add(message);
            Validations[property] = currentValidations;
        }
    }
}
