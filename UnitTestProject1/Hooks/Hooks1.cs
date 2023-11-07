using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;
using Test.Feature;
using TestStack.White;

namespace Test.Hooks
{
    [Binding]
    public class Hooks1
    {
        public Application _calculatorApplication;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("close plese");
            CloseMultipleCalculatorInstances();
        }


        private void CloseMultipleCalculatorInstances()
        {
            var calculatorProcesses = System.Diagnostics.Process.GetProcesses()
                .Where(p => p.ProcessName.Contains("Calculator"));
            if (calculatorProcesses.Count() > 1)
            {
                foreach (var process in calculatorProcesses)
                {
                    try
                    {
                        _calculatorApplication = Application.Attach(process);
                        if (_calculatorApplication != null)
                        {
                            _calculatorApplication.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception or logging
                        Console.WriteLine($"Error while closing Calculator process: {ex.Message}");
                    }
                }
            }
        }




        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()

        {
            CloseMultipleCalculatorInstances();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}