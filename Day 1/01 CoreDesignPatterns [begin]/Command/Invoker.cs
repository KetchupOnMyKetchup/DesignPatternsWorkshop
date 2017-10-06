﻿namespace Command
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}