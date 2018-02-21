namespace Interpreter.Interfaces
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}