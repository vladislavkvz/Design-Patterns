namespace TemplateMethod.Entities
{
    using System;

    public class Realization : Specialization
    {
        // 4. Derived classes can override placeholder methods
        public override void StepTwo()
        {
            Console.WriteLine("Realization.stepTwo");
        }

        protected override void Step3_2()
        {
            Console.WriteLine("Realization.step3_2");
        }

        // 5. Derived classes can override implemented methods
        // 6. Derived classes can override and "call back to" base class methods
        protected void StepFor()
        {
            Console.WriteLine("Realization.stepFor");
            base.StepFour();
        }
    }
}