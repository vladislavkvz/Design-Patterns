namespace TemplateMethod.Entities
{
    using System;

    public abstract class Specialization : Generalization
    {
        // 4. Derived classes can override placeholder methods
        // 1. Standardize the skeleton of an algorithm in a "template" method
        public override void StepThree()
        {
            Step3_1();
            Step3_2();
            Step3_3();
        }
        // 2. Common implementations of individual steps are defined in base class
        private void Step3_1()
        {
            Console.WriteLine("Specialization.step3_1");
        }
        // 3. Steps requiring peculiar implementations are "placeholders" in the base class
        abstract protected void Step3_2();

        private void Step3_3()
        {
            Console.WriteLine("Specialization.step3_3");
        }
    }
}