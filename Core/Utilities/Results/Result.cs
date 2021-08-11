using System;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Get ler readonly dir lakin sadece constructor ile Set edilebilirler
        // this => bu class'in (success) tek paremetreli constructor'ni calistir
        public Result(bool success, string message) : this(success) 
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}