﻿namespace Interpreter.Entities
{
    using Interfaces;
    
    public class OrExpression : IExpression
    {
        private IExpression expr1 = null;
        private IExpression expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        
        public bool Interpret(string context)
        {
            return expr1.Interpret(context) || expr2.Interpret(context);
        }
    }
}