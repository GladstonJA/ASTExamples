namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public class OnboardingWorkflow : Workflow
    {
        protected override void ExecuteStep(WorkflowRequest request)
        {
            // Executa os passos necessários
        }

        protected override void ValidateRequest(WorkflowRequest request)
        {
            // Validação conforme necessidade do onboarding
        }
    }
}
