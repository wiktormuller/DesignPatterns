using System;

namespace Memento
{
    //The Concrete memento contains the infrastructure for storing the Originator's state
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        public string GetState()
        {
            return _state;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}