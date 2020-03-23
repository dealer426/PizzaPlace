using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public interface INotifyDataErrorInfo
    {
        bool HasErrors { get; }
        event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        IEnumerable GetErrors(string propertyName);
    }
}
