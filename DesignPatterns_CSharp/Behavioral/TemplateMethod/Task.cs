namespace DesignPatterns_CSharp.Behavioral.TemplateMethod
{
    internal abstract class Task
    {
        private AuditTrail auditTrail;

        public Task()
        {
            auditTrail = new AuditTrail();

        }

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }


        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
