namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public abstract class Workflow
    {
        public void Run(WorkflowRequest request)
        {
            LoadConfig(request);

            ValidateRequest(request);

            ExecuteStep(request);

            PersistState(request);
        }

        private void LoadConfig(WorkflowRequest request)
        {
        }

        private void PersistState(WorkflowRequest request)
        {
        }

        protected abstract void ExecuteStep(WorkflowRequest request);

        protected abstract void ValidateRequest(WorkflowRequest request);
    }
}
