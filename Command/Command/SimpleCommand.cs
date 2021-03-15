using System;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }
        
        //// Some commands can implement simple operations on their own.
        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
        }
    }
}