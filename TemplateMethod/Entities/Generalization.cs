namespace TemplateMethod.Entities
{
    using System;

    public abstract class Generalization
    {
        // 1. Standardize the skeleton of an algorithm in a "template" method
        public void FindSolution()
        {
            StepOne();
            StepTwo();
            StepThree();
            StepFour();
        }
        // 2. Common implementations of individual steps are defined in base class
        private void StepOne()
        {
            Console.WriteLine("Generalization.stepOne");
        }
        // 3. Steps requiring peculiar implementations are "placeholders" in the base class
        public abstract void StepTwo();
        public abstract void StepThree();

        public void StepFour()
        {
           Console.WriteLine("Generalization.stepFor");
        }
    }
}