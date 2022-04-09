namespace jobsearch.Core.Models.EF
{
    public class CompanyEntity : BaseModel<int>
    {
        private ILazyLoader _loader;

        public CompanyEntity()
        {

        }

        private CompanyEntity(ILazyLoader loader)
        {
            this._loader = loader;
        }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string? ProfileHeadline { get; set; }

        public string? ProfileHtmlBody { get; set; }

        public string? ProfilePlainBody { get; set; }

        public string? Address { get; set; }

        #region FK Instance
        public int InstanceId { get; set; }

        public InstanceEntity Instance { get; set; }
        #endregion

        #region FK Agents
        private List<CompanyAgentEntity> _companyAgents;

        public List<CompanyAgentEntity> CompanyAgents => this._loader.Load(this, ref this._companyAgents);
        #endregion

    }
}
