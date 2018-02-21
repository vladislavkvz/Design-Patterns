﻿namespace Strategy.Entities
{
    using Interfaces;

    public class Context
    {
        private IStrategy strategy;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }
}